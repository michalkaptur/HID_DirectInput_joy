namespace HID_DirectInput_joy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.buttonDetectJoy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.trackBarY = new System.Windows.Forms.TrackBar();
            this.trackBarZ = new System.Windows.Forms.TrackBar();
            this.timerJoyPolling = new System.Windows.Forms.Timer(this.components);
            this.labelButton0 = new System.Windows.Forms.Label();
            this.labelButton1 = new System.Windows.Forms.Label();
            this.labelButton2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxRight = new System.Windows.Forms.TextBox();
            this.textBoxBackward = new System.Windows.Forms.TextBox();
            this.textBoxStatusBut1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxStatusBut0 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxStatusBut2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLeft = new System.Windows.Forms.TextBox();
            this.textBoxForward = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(19, 209);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(566, 43);
            this.listBoxLog.TabIndex = 0;
            // 
            // buttonDetectJoy
            // 
            this.buttonDetectJoy.Location = new System.Drawing.Point(18, 25);
            this.buttonDetectJoy.Name = "buttonDetectJoy";
            this.buttonDetectJoy.Size = new System.Drawing.Size(88, 24);
            this.buttonDetectJoy.TabIndex = 1;
            this.buttonDetectJoy.Text = "Wyszukaj joya";
            this.buttonDetectJoy.UseVisualStyleBackColor = true;
            this.buttonDetectJoy.Click += new System.EventHandler(this.buttonDetectJoy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Z";
            // 
            // trackBarX
            // 
            this.trackBarX.Location = new System.Drawing.Point(38, 21);
            this.trackBarX.Maximum = 65536;
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Size = new System.Drawing.Size(104, 45);
            this.trackBarX.TabIndex = 11;
            // 
            // trackBarY
            // 
            this.trackBarY.Location = new System.Drawing.Point(38, 59);
            this.trackBarY.Maximum = 65536;
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Size = new System.Drawing.Size(104, 45);
            this.trackBarY.TabIndex = 12;
            // 
            // trackBarZ
            // 
            this.trackBarZ.Location = new System.Drawing.Point(38, 96);
            this.trackBarZ.Maximum = 65536;
            this.trackBarZ.Name = "trackBarZ";
            this.trackBarZ.Size = new System.Drawing.Size(104, 45);
            this.trackBarZ.TabIndex = 13;
            // 
            // timerJoyPolling
            // 
            this.timerJoyPolling.Tick += new System.EventHandler(this.timerJoyPolling_Tick);
            // 
            // labelButton0
            // 
            this.labelButton0.AutoSize = true;
            this.labelButton0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelButton0.ForeColor = System.Drawing.Color.Red;
            this.labelButton0.Location = new System.Drawing.Point(15, 23);
            this.labelButton0.Name = "labelButton0";
            this.labelButton0.Size = new System.Drawing.Size(14, 13);
            this.labelButton0.TabIndex = 14;
            this.labelButton0.Text = "0";
            // 
            // labelButton1
            // 
            this.labelButton1.AutoSize = true;
            this.labelButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelButton1.ForeColor = System.Drawing.Color.Red;
            this.labelButton1.Location = new System.Drawing.Point(35, 23);
            this.labelButton1.Name = "labelButton1";
            this.labelButton1.Size = new System.Drawing.Size(14, 13);
            this.labelButton1.TabIndex = 15;
            this.labelButton1.Text = "1";
            // 
            // labelButton2
            // 
            this.labelButton2.AutoSize = true;
            this.labelButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelButton2.ForeColor = System.Drawing.Color.Red;
            this.labelButton2.Location = new System.Drawing.Point(55, 23);
            this.labelButton2.Name = "labelButton2";
            this.labelButton2.Size = new System.Drawing.Size(14, 13);
            this.labelButton2.TabIndex = 16;
            this.labelButton2.Text = "2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelButton0);
            this.groupBox1.Controls.Add(this.labelButton2);
            this.groupBox1.Controls.Add(this.labelButton1);
            this.groupBox1.Location = new System.Drawing.Point(275, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 58);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Przyciski";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.trackBarZ);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.trackBarY);
            this.groupBox2.Controls.Add(this.trackBarX);
            this.groupBox2.Location = new System.Drawing.Point(112, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 154);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Osie";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxRight);
            this.groupBox3.Controls.Add(this.textBoxBackward);
            this.groupBox3.Controls.Add(this.textBoxStatusBut1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxStatusBut0);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxStatusBut2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxLeft);
            this.groupBox3.Controls.Add(this.textBoxForward);
            this.groupBox3.Location = new System.Drawing.Point(369, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 159);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Joy Status";
            // 
            // textBoxRight
            // 
            this.textBoxRight.Location = new System.Drawing.Point(98, 42);
            this.textBoxRight.Name = "textBoxRight";
            this.textBoxRight.Size = new System.Drawing.Size(46, 20);
            this.textBoxRight.TabIndex = 13;
            // 
            // textBoxBackward
            // 
            this.textBoxBackward.Location = new System.Drawing.Point(66, 68);
            this.textBoxBackward.Name = "textBoxBackward";
            this.textBoxBackward.Size = new System.Drawing.Size(46, 20);
            this.textBoxBackward.TabIndex = 11;
            // 
            // textBoxStatusBut1
            // 
            this.textBoxStatusBut1.Location = new System.Drawing.Point(29, 123);
            this.textBoxStatusBut1.Name = "textBoxStatusBut1";
            this.textBoxStatusBut1.Size = new System.Drawing.Size(46, 20);
            this.textBoxStatusBut1.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "b2";
            // 
            // textBoxStatusBut0
            // 
            this.textBoxStatusBut0.Location = new System.Drawing.Point(29, 101);
            this.textBoxStatusBut0.Name = "textBoxStatusBut0";
            this.textBoxStatusBut0.Size = new System.Drawing.Size(46, 20);
            this.textBoxStatusBut0.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "b1";
            // 
            // textBoxStatusBut2
            // 
            this.textBoxStatusBut2.Location = new System.Drawing.Point(109, 127);
            this.textBoxStatusBut2.Name = "textBoxStatusBut2";
            this.textBoxStatusBut2.Size = new System.Drawing.Size(46, 20);
            this.textBoxStatusBut2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "b0";
            // 
            // textBoxLeft
            // 
            this.textBoxLeft.Location = new System.Drawing.Point(30, 42);
            this.textBoxLeft.Name = "textBoxLeft";
            this.textBoxLeft.Size = new System.Drawing.Size(46, 20);
            this.textBoxLeft.TabIndex = 3;
            // 
            // textBoxForward
            // 
            this.textBoxForward.Location = new System.Drawing.Point(66, 16);
            this.textBoxForward.Name = "textBoxForward";
            this.textBoxForward.Size = new System.Drawing.Size(46, 20);
            this.textBoxForward.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 262);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDetectJoy);
            this.Controls.Add(this.listBoxLog);
            this.Name = "Form1";
            this.Text = "HID Joy Controller";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Button buttonDetectJoy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarX;
        private System.Windows.Forms.TrackBar trackBarY;
        private System.Windows.Forms.TrackBar trackBarZ;
        private System.Windows.Forms.Timer timerJoyPolling;
        private System.Windows.Forms.Label labelButton0;
        private System.Windows.Forms.Label labelButton1;
        private System.Windows.Forms.Label labelButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxRight;
        private System.Windows.Forms.TextBox textBoxBackward;
        private System.Windows.Forms.TextBox textBoxStatusBut1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxStatusBut0;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxStatusBut2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLeft;
        private System.Windows.Forms.TextBox textBoxForward;
    }
}

