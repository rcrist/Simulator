
namespace Simulator
{
    partial class MainForm1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBusBar = new System.Windows.Forms.Label();
            this.BtnBusClear = new System.Windows.Forms.Button();
            this.BtnLoadBus = new System.Windows.Forms.Button();
            this.busLedBar = new ctlDigitalLib.CtlLedBar8Bit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAregBar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AOled = new ctlDigitalLib.CtlRoundLed();
            this.label2 = new System.Windows.Forms.Label();
            this.AIled = new ctlDigitalLib.CtlRoundLed();
            this.AregLedBar = new ctlDigitalLib.CtlLedBar8Bit();
            this.BtnTestPanel = new System.Windows.Forms.Button();
            this.BtnBus2Areg = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pcuAOLed = new ctlDigitalLib.CtlRoundLed();
            this.label6 = new System.Windows.Forms.Label();
            this.pcuAILed = new ctlDigitalLib.CtlRoundLed();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pcuEOled = new ctlDigitalLib.CtlRoundLed();
            this.label11 = new System.Windows.Forms.Label();
            this.pcuSUBled = new ctlDigitalLib.CtlRoundLed();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pcuBIled = new ctlDigitalLib.CtlRoundLed();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblBregBar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BIled = new ctlDigitalLib.CtlRoundLed();
            this.BregLedBar = new ctlDigitalLib.CtlLedBar8Bit();
            this.BtnBus2Breg = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EOled = new ctlDigitalLib.CtlRoundLed();
            this.lblALUBar = new System.Windows.Forms.Label();
            this.SUBlbl = new System.Windows.Forms.Label();
            this.SUBled = new ctlDigitalLib.CtlRoundLed();
            this.ALULedBar = new ctlDigitalLib.CtlLedBar8Bit();
            this.BtnBus2ALU = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(559, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "8-Bit Breadboard Simulator";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBusBar);
            this.groupBox1.Controls.Add(this.BtnBusClear);
            this.groupBox1.Controls.Add(this.BtnLoadBus);
            this.groupBox1.Controls.Add(this.busLedBar);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 134);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Bus (8-Bit)";
            // 
            // lblBusBar
            // 
            this.lblBusBar.AutoSize = true;
            this.lblBusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusBar.Location = new System.Drawing.Point(189, 33);
            this.lblBusBar.Name = "lblBusBar";
            this.lblBusBar.Size = new System.Drawing.Size(100, 25);
            this.lblBusBar.TabIndex = 7;
            this.lblBusBar.Text = "00000000";
            // 
            // BtnBusClear
            // 
            this.BtnBusClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBusClear.ForeColor = System.Drawing.Color.Black;
            this.BtnBusClear.Location = new System.Drawing.Point(9, 73);
            this.BtnBusClear.Name = "BtnBusClear";
            this.BtnBusClear.Size = new System.Drawing.Size(87, 30);
            this.BtnBusClear.TabIndex = 6;
            this.BtnBusClear.Text = "Clear";
            this.BtnBusClear.UseVisualStyleBackColor = true;
            this.BtnBusClear.Click += new System.EventHandler(this.BtnBusClear_Click);
            // 
            // BtnLoadBus
            // 
            this.BtnLoadBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadBus.ForeColor = System.Drawing.Color.Black;
            this.BtnLoadBus.Location = new System.Drawing.Point(9, 34);
            this.BtnLoadBus.Name = "BtnLoadBus";
            this.BtnLoadBus.Size = new System.Drawing.Size(87, 30);
            this.BtnLoadBus.TabIndex = 5;
            this.BtnLoadBus.Text = "Bus<-5";
            this.BtnLoadBus.UseVisualStyleBackColor = true;
            this.BtnLoadBus.Click += new System.EventHandler(this.BtnLoadBus_Click);
            // 
            // busLedBar
            // 
            this.busLedBar.BackColor = System.Drawing.Color.Black;
            this.busLedBar.barValue = "00000000";
            this.busLedBar.Location = new System.Drawing.Point(117, 61);
            this.busLedBar.Name = "busLedBar";
            this.busLedBar.OffCol = System.Drawing.Color.Maroon;
            this.busLedBar.OnCol = System.Drawing.Color.Red;
            this.busLedBar.Size = new System.Drawing.Size(188, 52);
            this.busLedBar.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAregBar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.AOled);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.AIled);
            this.groupBox2.Controls.Add(this.AregLedBar);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(329, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 134);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "A-Register";
            // 
            // lblAregBar
            // 
            this.lblAregBar.AutoSize = true;
            this.lblAregBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAregBar.Location = new System.Drawing.Point(192, 33);
            this.lblAregBar.Name = "lblAregBar";
            this.lblAregBar.Size = new System.Drawing.Size(100, 25);
            this.lblAregBar.TabIndex = 8;
            this.lblAregBar.Text = "00000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "AO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AOled
            // 
            this.AOled.BackColor = System.Drawing.Color.Maroon;
            this.AOled.Location = new System.Drawing.Point(71, 73);
            this.AOled.Margin = new System.Windows.Forms.Padding(0);
            this.AOled.Name = "AOled";
            this.AOled.OffCol = System.Drawing.Color.Maroon;
            this.AOled.OnCol = System.Drawing.Color.Red;
            this.AOled.Size = new System.Drawing.Size(30, 30);
            this.AOled.State = false;
            this.AOled.TabIndex = 5;
            this.AOled.Click += new System.EventHandler(this.AOled_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "AI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AIled
            // 
            this.AIled.BackColor = System.Drawing.Color.Maroon;
            this.AIled.Location = new System.Drawing.Point(71, 34);
            this.AIled.Margin = new System.Windows.Forms.Padding(0);
            this.AIled.Name = "AIled";
            this.AIled.OffCol = System.Drawing.Color.Maroon;
            this.AIled.OnCol = System.Drawing.Color.Red;
            this.AIled.Size = new System.Drawing.Size(30, 30);
            this.AIled.State = false;
            this.AIled.TabIndex = 2;
            this.AIled.Click += new System.EventHandler(this.AIled_Click);
            // 
            // AregLedBar
            // 
            this.AregLedBar.BackColor = System.Drawing.Color.Black;
            this.AregLedBar.barValue = "00000000";
            this.AregLedBar.Location = new System.Drawing.Point(117, 61);
            this.AregLedBar.Name = "AregLedBar";
            this.AregLedBar.OffCol = System.Drawing.Color.Maroon;
            this.AregLedBar.OnCol = System.Drawing.Color.Red;
            this.AregLedBar.Size = new System.Drawing.Size(188, 52);
            this.AregLedBar.TabIndex = 1;
            // 
            // BtnTestPanel
            // 
            this.BtnTestPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTestPanel.Location = new System.Drawing.Point(21, 22);
            this.BtnTestPanel.Name = "BtnTestPanel";
            this.BtnTestPanel.Size = new System.Drawing.Size(113, 30);
            this.BtnTestPanel.TabIndex = 4;
            this.BtnTestPanel.Text = "Test Panel";
            this.BtnTestPanel.UseVisualStyleBackColor = true;
            this.BtnTestPanel.Click += new System.EventHandler(this.BtnTestPanel_Click);
            // 
            // BtnBus2Areg
            // 
            this.BtnBus2Areg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBus2Areg.Location = new System.Drawing.Point(21, 232);
            this.BtnBus2Areg.Name = "BtnBus2Areg";
            this.BtnBus2Areg.Size = new System.Drawing.Size(113, 30);
            this.BtnBus2Areg.TabIndex = 5;
            this.BtnBus2Areg.Text = "Bus->Areg";
            this.BtnBus2Areg.UseVisualStyleBackColor = true;
            this.BtnBus2Areg.Click += new System.EventHandler(this.BtnBus2Areg_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.pcuAOLed);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.pcuAILed);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(27, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 172);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "A-Register";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "AO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pcuAOLed
            // 
            this.pcuAOLed.BackColor = System.Drawing.Color.Navy;
            this.pcuAOLed.Location = new System.Drawing.Point(71, 73);
            this.pcuAOLed.Margin = new System.Windows.Forms.Padding(0);
            this.pcuAOLed.Name = "pcuAOLed";
            this.pcuAOLed.OffCol = System.Drawing.Color.Navy;
            this.pcuAOLed.OnCol = System.Drawing.Color.Blue;
            this.pcuAOLed.Size = new System.Drawing.Size(30, 30);
            this.pcuAOLed.State = false;
            this.pcuAOLed.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "AI";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pcuAILed
            // 
            this.pcuAILed.BackColor = System.Drawing.Color.Navy;
            this.pcuAILed.Location = new System.Drawing.Point(71, 34);
            this.pcuAILed.Margin = new System.Windows.Forms.Padding(0);
            this.pcuAILed.Name = "pcuAILed";
            this.pcuAILed.OffCol = System.Drawing.Color.Navy;
            this.pcuAILed.OnCol = System.Drawing.Color.Blue;
            this.pcuAILed.Size = new System.Drawing.Size(30, 30);
            this.pcuAILed.State = false;
            this.pcuAILed.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(33, 580);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1545, 245);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Program Control Unit (PCU)";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.pcuEOled);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.pcuSUBled);
            this.groupBox8.ForeColor = System.Drawing.Color.White;
            this.groupBox8.Location = new System.Drawing.Point(296, 34);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(117, 172);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "ALU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "EO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pcuEOled
            // 
            this.pcuEOled.BackColor = System.Drawing.Color.Navy;
            this.pcuEOled.Location = new System.Drawing.Point(69, 77);
            this.pcuEOled.Margin = new System.Windows.Forms.Padding(0);
            this.pcuEOled.Name = "pcuEOled";
            this.pcuEOled.OffCol = System.Drawing.Color.Navy;
            this.pcuEOled.OnCol = System.Drawing.Color.Blue;
            this.pcuEOled.Size = new System.Drawing.Size(30, 30);
            this.pcuEOled.State = false;
            this.pcuEOled.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "SUB";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pcuSUBled
            // 
            this.pcuSUBled.BackColor = System.Drawing.Color.Navy;
            this.pcuSUBled.Location = new System.Drawing.Point(69, 33);
            this.pcuSUBled.Margin = new System.Windows.Forms.Padding(0);
            this.pcuSUBled.Name = "pcuSUBled";
            this.pcuSUBled.OffCol = System.Drawing.Color.Navy;
            this.pcuSUBled.OnCol = System.Drawing.Color.Blue;
            this.pcuSUBled.Size = new System.Drawing.Size(30, 30);
            this.pcuSUBled.State = false;
            this.pcuSUBled.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.pcuBIled);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(166, 34);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(124, 172);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "B-Register";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "BI";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pcuBIled
            // 
            this.pcuBIled.BackColor = System.Drawing.Color.Navy;
            this.pcuBIled.Location = new System.Drawing.Point(71, 34);
            this.pcuBIled.Margin = new System.Windows.Forms.Padding(0);
            this.pcuBIled.Name = "pcuBIled";
            this.pcuBIled.OffCol = System.Drawing.Color.Navy;
            this.pcuBIled.OnCol = System.Drawing.Color.Blue;
            this.pcuBIled.Size = new System.Drawing.Size(30, 30);
            this.pcuBIled.State = false;
            this.pcuBIled.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblBregBar);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.BIled);
            this.groupBox5.Controls.Add(this.BregLedBar);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(646, 82);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(311, 134);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "B-Register";
            // 
            // lblBregBar
            // 
            this.lblBregBar.AutoSize = true;
            this.lblBregBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBregBar.Location = new System.Drawing.Point(192, 33);
            this.lblBregBar.Name = "lblBregBar";
            this.lblBregBar.Size = new System.Drawing.Size(100, 25);
            this.lblBregBar.TabIndex = 8;
            this.lblBregBar.Text = "00000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "BI";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BIled
            // 
            this.BIled.BackColor = System.Drawing.Color.Maroon;
            this.BIled.Location = new System.Drawing.Point(71, 34);
            this.BIled.Margin = new System.Windows.Forms.Padding(0);
            this.BIled.Name = "BIled";
            this.BIled.OffCol = System.Drawing.Color.Maroon;
            this.BIled.OnCol = System.Drawing.Color.Red;
            this.BIled.Size = new System.Drawing.Size(30, 30);
            this.BIled.State = false;
            this.BIled.TabIndex = 2;
            // 
            // BregLedBar
            // 
            this.BregLedBar.BackColor = System.Drawing.Color.Black;
            this.BregLedBar.barValue = "00000000";
            this.BregLedBar.Location = new System.Drawing.Point(117, 61);
            this.BregLedBar.Name = "BregLedBar";
            this.BregLedBar.OffCol = System.Drawing.Color.Maroon;
            this.BregLedBar.OnCol = System.Drawing.Color.Red;
            this.BregLedBar.Size = new System.Drawing.Size(188, 52);
            this.BregLedBar.TabIndex = 1;
            // 
            // BtnBus2Breg
            // 
            this.BtnBus2Breg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBus2Breg.Location = new System.Drawing.Point(21, 268);
            this.BtnBus2Breg.Name = "BtnBus2Breg";
            this.BtnBus2Breg.Size = new System.Drawing.Size(113, 30);
            this.BtnBus2Breg.TabIndex = 10;
            this.BtnBus2Breg.Text = "Bus->Breg";
            this.BtnBus2Breg.UseVisualStyleBackColor = true;
            this.BtnBus2Breg.Click += new System.EventHandler(this.BtnBus2Breg_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.EOled);
            this.groupBox7.Controls.Add(this.lblALUBar);
            this.groupBox7.Controls.Add(this.SUBlbl);
            this.groupBox7.Controls.Add(this.SUBled);
            this.groupBox7.Controls.Add(this.ALULedBar);
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(963, 82);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(311, 134);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Arithmetic Logic Unit (ALU)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "EO";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EOled
            // 
            this.EOled.BackColor = System.Drawing.Color.Maroon;
            this.EOled.Location = new System.Drawing.Point(84, 77);
            this.EOled.Margin = new System.Windows.Forms.Padding(0);
            this.EOled.Name = "EOled";
            this.EOled.OffCol = System.Drawing.Color.Maroon;
            this.EOled.OnCol = System.Drawing.Color.Red;
            this.EOled.Size = new System.Drawing.Size(30, 30);
            this.EOled.State = false;
            this.EOled.TabIndex = 9;
            // 
            // lblALUBar
            // 
            this.lblALUBar.AutoSize = true;
            this.lblALUBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblALUBar.Location = new System.Drawing.Point(192, 33);
            this.lblALUBar.Name = "lblALUBar";
            this.lblALUBar.Size = new System.Drawing.Size(100, 25);
            this.lblALUBar.TabIndex = 8;
            this.lblALUBar.Text = "00000000";
            // 
            // SUBlbl
            // 
            this.SUBlbl.AutoSize = true;
            this.SUBlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBlbl.Location = new System.Drawing.Point(27, 34);
            this.SUBlbl.Name = "SUBlbl";
            this.SUBlbl.Size = new System.Drawing.Size(53, 25);
            this.SUBlbl.TabIndex = 4;
            this.SUBlbl.Text = "SUB";
            this.SUBlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SUBled
            // 
            this.SUBled.BackColor = System.Drawing.Color.Maroon;
            this.SUBled.Location = new System.Drawing.Point(84, 33);
            this.SUBled.Margin = new System.Windows.Forms.Padding(0);
            this.SUBled.Name = "SUBled";
            this.SUBled.OffCol = System.Drawing.Color.Maroon;
            this.SUBled.OnCol = System.Drawing.Color.Red;
            this.SUBled.Size = new System.Drawing.Size(30, 30);
            this.SUBled.State = false;
            this.SUBled.TabIndex = 2;
            // 
            // ALULedBar
            // 
            this.ALULedBar.BackColor = System.Drawing.Color.Black;
            this.ALULedBar.barValue = "00000000";
            this.ALULedBar.Location = new System.Drawing.Point(117, 61);
            this.ALULedBar.Name = "ALULedBar";
            this.ALULedBar.OffCol = System.Drawing.Color.Maroon;
            this.ALULedBar.OnCol = System.Drawing.Color.Red;
            this.ALULedBar.Size = new System.Drawing.Size(188, 52);
            this.ALULedBar.TabIndex = 1;
            // 
            // BtnBus2ALU
            // 
            this.BtnBus2ALU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBus2ALU.Location = new System.Drawing.Point(21, 304);
            this.BtnBus2ALU.Name = "BtnBus2ALU";
            this.BtnBus2ALU.Size = new System.Drawing.Size(113, 30);
            this.BtnBus2ALU.TabIndex = 11;
            this.BtnBus2ALU.Text = "Bus->ALU";
            this.BtnBus2ALU.UseVisualStyleBackColor = true;
            this.BtnBus2ALU.Click += new System.EventHandler(this.BtnBus2ALU_Click);
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1613, 869);
            this.Controls.Add(this.BtnBus2ALU);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.BtnBus2Breg);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.BtnBus2Areg);
            this.Controls.Add(this.BtnTestPanel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "8-Bit Breadboard Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private ctlDigitalLib.CtlRoundLed AIled;
        private System.Windows.Forms.Label label3;
        private ctlDigitalLib.CtlRoundLed AOled;
        private System.Windows.Forms.Button BtnTestPanel;
        public ctlDigitalLib.CtlLedBar8Bit busLedBar;
        private System.Windows.Forms.Button BtnLoadBus;
        private System.Windows.Forms.Button BtnBusClear;
        private System.Windows.Forms.Label lblBusBar;
        private System.Windows.Forms.Label lblAregBar;
        public ctlDigitalLib.CtlLedBar8Bit AregLedBar;
        private System.Windows.Forms.Button BtnBus2Areg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private ctlDigitalLib.CtlRoundLed pcuAOLed;
        private System.Windows.Forms.Label label6;
        private ctlDigitalLib.CtlRoundLed pcuAILed;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblBregBar;
        private System.Windows.Forms.Label label8;
        private ctlDigitalLib.CtlRoundLed BIled;
        public ctlDigitalLib.CtlLedBar8Bit BregLedBar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private ctlDigitalLib.CtlRoundLed pcuBIled;
        private System.Windows.Forms.Button BtnBus2Breg;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label9;
        private ctlDigitalLib.CtlRoundLed EOled;
        private System.Windows.Forms.Label lblALUBar;
        private System.Windows.Forms.Label SUBlbl;
        private ctlDigitalLib.CtlRoundLed SUBled;
        public ctlDigitalLib.CtlLedBar8Bit ALULedBar;
        private System.Windows.Forms.Button BtnBus2ALU;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label4;
        private ctlDigitalLib.CtlRoundLed pcuEOled;
        private System.Windows.Forms.Label label11;
        private ctlDigitalLib.CtlRoundLed pcuSUBled;
    }
}

