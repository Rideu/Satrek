namespace Satrek
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
            this.winHeader1 = new GrayLib.WinHeader();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelKeys = new System.Windows.Forms.Label();
            this.labelBestSpeed = new System.Windows.Forms.Label();
            this.labelJumps = new System.Windows.Forms.Label();
            this.labelLMC = new System.Windows.Forms.Label();
            this.labelRMC = new System.Windows.Forms.Label();
            this.labelDist = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // winHeader1
            // 
            this.winHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.winHeader1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.winHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.winHeader1.Location = new System.Drawing.Point(0, 0);
            this.winHeader1.Name = "winHeader1";
            this.winHeader1.Size = new System.Drawing.Size(292, 22);
            this.winHeader1.TabIndex = 0;
            // 
            // labelSpeed
            // 
            this.labelSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(30)))));
            this.labelSpeed.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.labelSpeed.ForeColor = System.Drawing.SystemColors.Window;
            this.labelSpeed.Location = new System.Drawing.Point(12, 177);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.labelSpeed.Size = new System.Drawing.Size(172, 18);
            this.labelSpeed.TabIndex = 30;
            this.labelSpeed.Text = "228 c.u.";
            this.labelSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKeys
            // 
            this.labelKeys.BackColor = System.Drawing.SystemColors.WindowText;
            this.labelKeys.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKeys.ForeColor = System.Drawing.SystemColors.Window;
            this.labelKeys.Location = new System.Drawing.Point(12, 25);
            this.labelKeys.Name = "labelKeys";
            this.labelKeys.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.labelKeys.Size = new System.Drawing.Size(266, 53);
            this.labelKeys.TabIndex = 25;
            this.labelKeys.Text = "Keys";
            // 
            // labelBestSpeed
            // 
            this.labelBestSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(30)))));
            this.labelBestSpeed.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.labelBestSpeed.ForeColor = System.Drawing.SystemColors.Window;
            this.labelBestSpeed.Location = new System.Drawing.Point(12, 177);
            this.labelBestSpeed.Name = "labelBestSpeed";
            this.labelBestSpeed.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.labelBestSpeed.Size = new System.Drawing.Size(266, 18);
            this.labelBestSpeed.TabIndex = 31;
            this.labelBestSpeed.Text = "[Module not found]";
            this.labelBestSpeed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelJumps
            // 
            this.labelJumps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.labelJumps.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelJumps.ForeColor = System.Drawing.SystemColors.Window;
            this.labelJumps.Location = new System.Drawing.Point(151, 132);
            this.labelJumps.Name = "labelJumps";
            this.labelJumps.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.labelJumps.Size = new System.Drawing.Size(127, 43);
            this.labelJumps.TabIndex = 29;
            this.labelJumps.Text = "Jumps";
            this.labelJumps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLMC
            // 
            this.labelLMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.labelLMC.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLMC.ForeColor = System.Drawing.SystemColors.Window;
            this.labelLMC.Location = new System.Drawing.Point(12, 78);
            this.labelLMC.Name = "labelLMC";
            this.labelLMC.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.labelLMC.Size = new System.Drawing.Size(133, 51);
            this.labelLMC.TabIndex = 26;
            this.labelLMC.Text = "Mouse";
            this.labelLMC.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelRMC
            // 
            this.labelRMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.labelRMC.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRMC.ForeColor = System.Drawing.SystemColors.Window;
            this.labelRMC.Location = new System.Drawing.Point(151, 78);
            this.labelRMC.Name = "labelRMC";
            this.labelRMC.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.labelRMC.Size = new System.Drawing.Size(127, 51);
            this.labelRMC.TabIndex = 27;
            this.labelRMC.Text = "Mouse";
            this.labelRMC.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelDist
            // 
            this.labelDist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.labelDist.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDist.ForeColor = System.Drawing.SystemColors.Window;
            this.labelDist.Location = new System.Drawing.Point(12, 132);
            this.labelDist.Name = "labelDist";
            this.labelDist.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.labelDist.Size = new System.Drawing.Size(133, 43);
            this.labelDist.TabIndex = 28;
            this.labelDist.Text = "Distance";
            this.labelDist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(292, 208);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelKeys);
            this.Controls.Add(this.labelBestSpeed);
            this.Controls.Add(this.labelJumps);
            this.Controls.Add(this.labelLMC);
            this.Controls.Add(this.labelRMC);
            this.Controls.Add(this.labelDist);
            this.Controls.Add(this.winHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Satrek";
            this.ResumeLayout(false);

        }

        #endregion

        private GrayLib.WinHeader winHeader1;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelKeys;
        private System.Windows.Forms.Label labelBestSpeed;
        private System.Windows.Forms.Label labelJumps;
        private System.Windows.Forms.Label labelLMC;
        private System.Windows.Forms.Label labelRMC;
        private System.Windows.Forms.Label labelDist;
    }
}

