
namespace Simulator.UI
{
    partial class TestPanel
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
            this.btnAI = new System.Windows.Forms.Button();
            this.btnAO = new System.Windows.Forms.Button();
            this.btnBI = new System.Windows.Forms.Button();
            this.btnEO = new System.Windows.Forms.Button();
            this.btnSUB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAI
            // 
            this.btnAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAI.Location = new System.Drawing.Point(12, 12);
            this.btnAI.Name = "btnAI";
            this.btnAI.Size = new System.Drawing.Size(248, 33);
            this.btnAI.TabIndex = 0;
            this.btnAI.Text = "AI";
            this.btnAI.UseVisualStyleBackColor = true;
            this.btnAI.Click += new System.EventHandler(this.BtnAI_Click);
            // 
            // btnAO
            // 
            this.btnAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAO.Location = new System.Drawing.Point(12, 51);
            this.btnAO.Name = "btnAO";
            this.btnAO.Size = new System.Drawing.Size(248, 33);
            this.btnAO.TabIndex = 1;
            this.btnAO.Text = "AO";
            this.btnAO.UseVisualStyleBackColor = true;
            this.btnAO.Click += new System.EventHandler(this.BtnAO_Click);
            // 
            // btnBI
            // 
            this.btnBI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBI.Location = new System.Drawing.Point(12, 90);
            this.btnBI.Name = "btnBI";
            this.btnBI.Size = new System.Drawing.Size(248, 33);
            this.btnBI.TabIndex = 2;
            this.btnBI.Text = "BI";
            this.btnBI.UseVisualStyleBackColor = true;
            this.btnBI.Click += new System.EventHandler(this.BtnBI_Click);
            // 
            // btnEO
            // 
            this.btnEO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEO.Location = new System.Drawing.Point(12, 168);
            this.btnEO.Name = "btnEO";
            this.btnEO.Size = new System.Drawing.Size(248, 33);
            this.btnEO.TabIndex = 4;
            this.btnEO.Text = "EO";
            this.btnEO.UseVisualStyleBackColor = true;
            this.btnEO.Click += new System.EventHandler(this.BtnEO_Click);
            // 
            // btnSUB
            // 
            this.btnSUB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSUB.Location = new System.Drawing.Point(12, 129);
            this.btnSUB.Name = "btnSUB";
            this.btnSUB.Size = new System.Drawing.Size(248, 33);
            this.btnSUB.TabIndex = 3;
            this.btnSUB.Text = "SUB";
            this.btnSUB.UseVisualStyleBackColor = true;
            this.btnSUB.Click += new System.EventHandler(this.BtnSUB_Click);
            // 
            // TestPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(272, 889);
            this.Controls.Add(this.btnEO);
            this.Controls.Add(this.btnSUB);
            this.Controls.Add(this.btnBI);
            this.Controls.Add(this.btnAO);
            this.Controls.Add(this.btnAI);
            this.Name = "TestPanel";
            this.Text = "TestPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAI;
        private System.Windows.Forms.Button btnAO;
        private System.Windows.Forms.Button btnBI;
        private System.Windows.Forms.Button btnEO;
        private System.Windows.Forms.Button btnSUB;
    }
}