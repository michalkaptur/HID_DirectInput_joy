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

        // Initialize DirectInput
        DirectInput directInput = new DirectInput();

        // Find a Joystick Guid
        Guid joystickGuid;

        Joystick joystick;

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

                timerJoyPolling.Enabled = true;
            }
        }

            

            private void timerJoyPolling_Tick(object sender, EventArgs e)
            {
                //listBoxLog.Items.Insert(0, "tick");
                joystick.Poll();
                var datas = joystick.GetBufferedData();
                foreach (var state in datas)
                {
                    //listBoxLog.Items.Insert(0, state);
                    switch (state.Offset)
                    {
                        case JoystickOffset.X:
                            //textBoxXvalue.Text = state.Value.ToString();
                            //  progressBarX.Value =  state.Value;
                            trackBarX.Value = state.Value;
                            break;

                        case JoystickOffset.Y:
                            // textBoxYvalue.Text = state.Value.ToString();
                            //  progressBarY.Value =  state.Value;
                            trackBarY.Value = state.Value;
                            break;

                        case JoystickOffset.Z:
                            //textBoxZvalue.Text = state.Value.ToString();
                            // progressBarZ.Value =  state.Value;
                            trackBarZ.Value = state.Value;
                            break;

                        default:
                            break;
                    }
                }
            }
                

        }
    }

