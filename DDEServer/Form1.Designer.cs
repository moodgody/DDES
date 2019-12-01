namespace DDEServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_CoileOn = new System.Windows.Forms.Button();
            this.BTN_CoileOff = new System.Windows.Forms.Button();
            this.TXT_CoileReference = new System.Windows.Forms.MaskedTextBox();
            this.CHB_Coile0 = new System.Windows.Forms.CheckBox();
            this.CHB_Coile1 = new System.Windows.Forms.CheckBox();
            this.CHB_Coile2 = new System.Windows.Forms.CheckBox();
            this.CHB_Coile3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coile";
            // 
            // BTN_CoileOn
            // 
            this.BTN_CoileOn.Location = new System.Drawing.Point(247, 38);
            this.BTN_CoileOn.Name = "BTN_CoileOn";
            this.BTN_CoileOn.Size = new System.Drawing.Size(75, 23);
            this.BTN_CoileOn.TabIndex = 2;
            this.BTN_CoileOn.Text = "On";
            this.BTN_CoileOn.UseVisualStyleBackColor = true;
            this.BTN_CoileOn.Click += new System.EventHandler(this.BTN_CoileOn_Click);
            // 
            // BTN_CoileOff
            // 
            this.BTN_CoileOff.Location = new System.Drawing.Point(338, 38);
            this.BTN_CoileOff.Name = "BTN_CoileOff";
            this.BTN_CoileOff.Size = new System.Drawing.Size(75, 23);
            this.BTN_CoileOff.TabIndex = 3;
            this.BTN_CoileOff.Text = "Off";
            this.BTN_CoileOff.UseVisualStyleBackColor = true;
            this.BTN_CoileOff.Click += new System.EventHandler(this.BTN_CoileOff_Click);
            // 
            // TXT_CoileReference
            // 
            this.TXT_CoileReference.Location = new System.Drawing.Point(123, 41);
            this.TXT_CoileReference.Mask = "00000";
            this.TXT_CoileReference.Name = "TXT_CoileReference";
            this.TXT_CoileReference.Size = new System.Drawing.Size(83, 20);
            this.TXT_CoileReference.TabIndex = 4;
            this.TXT_CoileReference.Text = "00000";
            this.TXT_CoileReference.ValidatingType = typeof(int);
            // 
            // CHB_Coile0
            // 
            this.CHB_Coile0.AutoSize = true;
            this.CHB_Coile0.Location = new System.Drawing.Point(524, 54);
            this.CHB_Coile0.Name = "CHB_Coile0";
            this.CHB_Coile0.Size = new System.Drawing.Size(58, 17);
            this.CHB_Coile0.TabIndex = 5;
            this.CHB_Coile0.Text = "Coile 0";
            this.CHB_Coile0.UseVisualStyleBackColor = true;
            this.CHB_Coile0.CheckedChanged += new System.EventHandler(this.CHB_Coile0_CheckedChanged);
            // 
            // CHB_Coile1
            // 
            this.CHB_Coile1.AutoSize = true;
            this.CHB_Coile1.Location = new System.Drawing.Point(524, 77);
            this.CHB_Coile1.Name = "CHB_Coile1";
            this.CHB_Coile1.Size = new System.Drawing.Size(58, 17);
            this.CHB_Coile1.TabIndex = 6;
            this.CHB_Coile1.Text = "Coile 1";
            this.CHB_Coile1.UseVisualStyleBackColor = true;
            this.CHB_Coile1.CheckedChanged += new System.EventHandler(this.CHB_Coile1_CheckedChanged);
            // 
            // CHB_Coile2
            // 
            this.CHB_Coile2.AutoSize = true;
            this.CHB_Coile2.Location = new System.Drawing.Point(524, 100);
            this.CHB_Coile2.Name = "CHB_Coile2";
            this.CHB_Coile2.Size = new System.Drawing.Size(58, 17);
            this.CHB_Coile2.TabIndex = 7;
            this.CHB_Coile2.Text = "Coile 2";
            this.CHB_Coile2.UseVisualStyleBackColor = true;
            this.CHB_Coile2.CheckedChanged += new System.EventHandler(this.CHB_Coile2_CheckedChanged);
            // 
            // CHB_Coile3
            // 
            this.CHB_Coile3.AutoSize = true;
            this.CHB_Coile3.Location = new System.Drawing.Point(524, 123);
            this.CHB_Coile3.Name = "CHB_Coile3";
            this.CHB_Coile3.Size = new System.Drawing.Size(58, 17);
            this.CHB_Coile3.TabIndex = 8;
            this.CHB_Coile3.Text = "Coile 3";
            this.CHB_Coile3.UseVisualStyleBackColor = true;
            this.CHB_Coile3.CheckedChanged += new System.EventHandler(this.CHB_Coile3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CHB_Coile3);
            this.Controls.Add(this.CHB_Coile2);
            this.Controls.Add(this.CHB_Coile1);
            this.Controls.Add(this.CHB_Coile0);
            this.Controls.Add(this.TXT_CoileReference);
            this.Controls.Add(this.BTN_CoileOff);
            this.Controls.Add(this.BTN_CoileOn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_CoileOn;
        private System.Windows.Forms.Button BTN_CoileOff;
        private System.Windows.Forms.MaskedTextBox TXT_CoileReference;
        private System.Windows.Forms.CheckBox CHB_Coile0;
        private System.Windows.Forms.CheckBox CHB_Coile1;
        private System.Windows.Forms.CheckBox CHB_Coile2;
        private System.Windows.Forms.CheckBox CHB_Coile3;
    }
}

