using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX.DirectInput;

namespace HID_DirectInput_joy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DirectInput directInput = new DirectInput();
        Guid joystickGuid;
        Joystick joystick;
        JoystickStatus joyStatus;

        int joyResolution = 65535;
        int joyOffset = 5000;

        private void buttonDetectJoy_Click(object sender, EventArgs e)
        {
            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Gamepad,
                DeviceEnumerationFlags.AllDevices))
                joystickGuid = deviceInstance.InstanceGuid;

            // If Gamepad not found, look for a Joystick
            if (joystickGuid == Guid.Empty)
                foreach (var deviceInstance in directInput.GetDevices(DeviceType.Joystick,
                        DeviceEnumerationFlags.AllDevices))
                    joystickGuid = deviceInstance.InstanceGuid;

            if (joystickGuid == Guid.Empty)
            {
                listBoxLog.Items.Insert(0, "nie znaleziono joya");
            }

            else
            {
                joystick = new Joystick(directInput, joystickGuid);
                listBoxLog.Items.Insert(0, "znalazłem joya, GUID: " + joystickGuid);

                //forcefeedback check
                var allEffects = joystick.GetEffects();
                if (allEffects.Count == 0)
                    listBoxLog.Items.Insert(0, "brak ForceFeedbacka");
                else
                {
                    foreach (var effectInfo in allEffects)
                        listBoxLog.Items.Insert(0, "Effect available " + effectInfo.Name);
                }

                //Set BufferSize in order to use buffered data.
                joystick.Properties.BufferSize = 128;


                // Acquire the joystick
                joystick.Acquire();
                joyStatus = new JoystickStatus();
                timerJoyPolling.Enabled = true;
            }
        }



        private void timerJoyPolling_Tick(object sender, EventArgs e)
        {
            joystick.Poll();
            var datas = joystick.GetBufferedData();
            foreach (var state in datas)
            {
                switch (state.Offset)
                {
                    case JoystickOffset.Y:
                        trackBarY.Value = state.Value;

                        //rescaling to bytes
                        if (state.Value > (joyResolution / 2 + joyOffset))
                            joyStatus.backward = (byte)(state.Value / (128));
                        else joyStatus.backward = 0;
                        
                        if (state.Value < (joyResolution / 2 - joyOffset))
                            joyStatus.forward = (byte)(255 - (state.Value / (128)));
                        else joyStatus.forward = 0;
                        
                        break;

                    case JoystickOffset.X:
                        trackBarX.Value = state.Value;

                        //rescaling to bytes
                        if (state.Value < (joyResolution / 2 - joyOffset))
                            joyStatus.left = (byte)(255 - (state.Value / (128)));
                        else joyStatus.left = 0;
                        
                        if (state.Value > (joyResolution / 2 + joyOffset))
                            joyStatus.right = (byte)(state.Value / (128));
                        else joyStatus.right = 0;

                        break;

                    case JoystickOffset.Z:
                        trackBarZ.Value = state.Value;
                        break;

                    case JoystickOffset.Buttons0:
                        if (state.Value == 0)
                        {
                            labelButton0.ForeColor = Color.Red;
                            joyStatus.button0 = 0;
                        }
                        else 
                        {
                            labelButton0.ForeColor = Color.Green;
                            joyStatus.button0 = (byte)state.Value;
                        }
                        break;

                    case JoystickOffset.Buttons1:
                        if (state.Value == 0)
                        {
                            labelButton1.ForeColor = Color.Red;
                            joyStatus.button1 = 0;
                        }
                        else 
                        {
                            labelButton1.ForeColor = Color.Green;
                            joyStatus.button1 = (byte)state.Value;
                        }
                        break;

                    case JoystickOffset.Buttons2:
                        if (state.Value == 0)
                        {
                            labelButton2.ForeColor = Color.Red;
                            joyStatus.button2 = 0;
                        }
                        else 
                        {
                            labelButton2.ForeColor = Color.Green;
                            joyStatus.button2 = (byte)state.Value;
                        }
                        break;

                    default:
                        break;
                }

                textBoxStatusBut0.Text = joyStatus.button0.ToString();
                textBoxStatusBut1.Text = joyStatus.button1.ToString();
                textBoxStatusBut2.Text = joyStatus.button2.ToString();
                textBoxLeft.Text = joyStatus.left.ToString();
                textBoxRight.Text = joyStatus.right.ToString();
                textBoxForward.Text = joyStatus.forward.ToString();
                textBoxBackward.Text = joyStatus.backward.ToString();

                if (checkBoxCOMSendData.Checked) SendDataToCom();


            }
        }

        private void buttonCOMConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd " + ex);
                return;
            }
            finally
            {
                listBoxLog.Items.Insert(0, "Połączyłem z portem szeregowym "+serialPort1.PortName);
            }
        }

        private void buttonCOMClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd " + ex);
                    return;
                }
                finally
                {
                    listBoxLog.Items.Insert(0, "Rozłączyłem port szeregowy " + serialPort1.PortName);
                }
            }
            else listBoxLog.Items.Insert(0, "Brak połączenia z portem szeregowym " + serialPort1.PortName);
        }

        public void SendDataToCom()
        {
            string temp = string.Format("{0:x2}{1:x2}{2:x2}{3:x2}{4:x2}{5:x2}{6:x2}",
                joyStatus.forward, joyStatus.backward, joyStatus.left, joyStatus.right, joyStatus.button0, joyStatus.button1, joyStatus.button2);
            //serialPort1.WriteLine(temp+"/n");
            serialPort1.Write(temp + '0' + '0');
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //listBoxLog.Items.Insert(0, serialPort1.ReadExisting());
            //MessageBox.Show(serialPort1.ReadExisting());
        }
    }

    

    class JoystickStatus
    {
        public JoystickStatus()
        {
            this.forward = 0;
            this.backward =0;
            this.right =0;
            this.left =0;
            this.button0 =0;
            this.button1 =0;
            this.button2 =0;
        }
        public void Update(byte _forward, byte _backward, byte _right, byte _left, byte _button0, byte _button1, byte _button2)
        {
            forward = _forward;
            backward = _backward;
            right = _right;
            left = _left;
            button0 = _button0;
            button1 = _button1;
            button2 = _button2;
        }

        public byte forward;
        public byte backward;
        public byte right;
        public byte left;
        public byte button0;
        public byte button1;
        public byte button2;
    }
    }

