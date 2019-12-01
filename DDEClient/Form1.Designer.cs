namespace DDEClient
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
            this.BTN_ReadCoiles = new System.Windows.Forms.Button();
            this.CHB_Coile3 = new System.Windows.Forms.CheckBox();
            this.CHB_Coile2 = new System.Windows.Forms.CheckBox();
            this.CHB_Coile1 = new System.Windows.Forms.CheckBox();
            this.CHB_Coile0 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BTN_ReadCoiles
            // 
            this.BTN_ReadCoiles.Location = new System.Drawing.Point(165, 68);
            this.BTN_ReadCoiles.Name = "BTN_ReadCoiles";
            this.BTN_ReadCoiles.Size = new System.Drawing.Size(113, 23);
            this.BTN_ReadCoiles.TabIndex = 0;
            this.BTN_ReadCoiles.Text = "Read coiles";
            this.BTN_ReadCoiles.UseVisualStyleBackColor = true;
            this.BTN_ReadCoiles.Click += new System.EventHandler(this.BTN_ReadCoiles_Click);
            // 
            // CHB_Coile3
            // 
            this.CHB_Coile3.AutoSize = true;
            this.CHB_Coile3.Location = new System.Drawing.Point(512, 128);
            this.CHB_Coile3.Name = "CHB_Coile3";
            this.CHB_Coile3.Size = new System.Drawing.Size(58, 17);
            this.CHB_Coile3.TabIndex = 12;
            this.CHB_Coile3.Text = "Coile 3";
            this.CHB_Coile3.UseVisualStyleBackColor = true;
            // 
            // CHB_Coile2
            // 
            this.CHB_Coile2.AutoSize = true;
            this.CHB_Coile2.Location = new System.Drawing.Point(512, 105);
            this.CHB_Coile2.Name = "CHB_Coile2";
            this.CHB_Coile2.Size = new System.Drawing.Size(58, 17);
            this.CHB_Coile2.TabIndex = 11;
            this.CHB_Coile2.Text = "Coile 2";
            this.CHB_Coile2.UseVisualStyleBackColor = true;
            // 
            // CHB_Coile1
            // 
            this.CHB_Coile1.AutoSize = true;
            this.CHB_Coile1.Location = new System.Drawing.Point(512, 82);
            this.CHB_Coile1.Name = "CHB_Coile1";
            this.CHB_Coile1.Size = new System.Drawing.Size(58, 17);
            this.CHB_Coile1.TabIndex = 10;
            this.CHB_Coile1.Text = "Coile 1";
            this.CHB_Coile1.UseVisualStyleBackColor = true;
            // 
            // CHB_Coile0
            // 
            this.CHB_Coile0.AutoSize = true;
            this.CHB_Coile0.Location = new System.Drawing.Point(512, 59);
            this.CHB_Coile0.Name = "CHB_Coile0";
            this.CHB_Coile0.Size = new System.Drawing.Size(58, 17);
            this.CHB_Coile0.TabIndex = 9;
            this.CHB_Coile0.Text = "Coile 0";
            this.CHB_Coile0.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.BTN_ReadCoiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_ReadCoiles;
        private System.Windows.Forms.CheckBox CHB_Coile3;
        private System.Windows.Forms.CheckBox CHB_Coile2;
        private System.Windows.Forms.CheckBox CHB_Coile1;
        private System.Windows.Forms.CheckBox CHB_Coile0;
    }
}

