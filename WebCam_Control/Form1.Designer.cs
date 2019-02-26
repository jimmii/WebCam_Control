namespace WebCam_Control
{
    partial class WebCam_Control
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
            this.Start_Btn = new System.Windows.Forms.Button();
            this.Stop_Btn = new System.Windows.Forms.Button();
            this.SelectCamera_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Display_pictureBox = new System.Windows.Forms.PictureBox();
            this.TakePhoto_Btn = new System.Windows.Forms.Button();
            this.CaptureVideo_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Display_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_Btn
            // 
            this.Start_Btn.BackColor = System.Drawing.Color.Lime;
            this.Start_Btn.Location = new System.Drawing.Point(39, 32);
            this.Start_Btn.Name = "Start_Btn";
            this.Start_Btn.Size = new System.Drawing.Size(131, 50);
            this.Start_Btn.TabIndex = 0;
            this.Start_Btn.Text = "Start";
            this.Start_Btn.UseVisualStyleBackColor = false;
            this.Start_Btn.Click += new System.EventHandler(this.Start_Btn_Click);
            // 
            // Stop_Btn
            // 
            this.Stop_Btn.BackColor = System.Drawing.Color.Crimson;
            this.Stop_Btn.Location = new System.Drawing.Point(1014, 32);
            this.Stop_Btn.Name = "Stop_Btn";
            this.Stop_Btn.Size = new System.Drawing.Size(131, 50);
            this.Stop_Btn.TabIndex = 1;
            this.Stop_Btn.Text = "Stop";
            this.Stop_Btn.UseVisualStyleBackColor = false;
            this.Stop_Btn.Click += new System.EventHandler(this.Stop_Btn_Click);
            // 
            // SelectCamera_comboBox
            // 
            this.SelectCamera_comboBox.FormattingEnabled = true;
            this.SelectCamera_comboBox.Location = new System.Drawing.Point(513, 46);
            this.SelectCamera_comboBox.Name = "SelectCamera_comboBox";
            this.SelectCamera_comboBox.Size = new System.Drawing.Size(168, 24);
            this.SelectCamera_comboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(553, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Camera";
            // 
            // Display_pictureBox
            // 
            this.Display_pictureBox.Location = new System.Drawing.Point(220, 112);
            this.Display_pictureBox.Name = "Display_pictureBox";
            this.Display_pictureBox.Size = new System.Drawing.Size(730, 571);
            this.Display_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Display_pictureBox.TabIndex = 4;
            this.Display_pictureBox.TabStop = false;
            // 
            // TakePhoto_Btn
            // 
            this.TakePhoto_Btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.TakePhoto_Btn.Location = new System.Drawing.Point(235, 703);
            this.TakePhoto_Btn.Name = "TakePhoto_Btn";
            this.TakePhoto_Btn.Size = new System.Drawing.Size(213, 38);
            this.TakePhoto_Btn.TabIndex = 5;
            this.TakePhoto_Btn.Text = "Take Photo";
            this.TakePhoto_Btn.UseVisualStyleBackColor = false;
            // 
            // CaptureVideo_Btn
            // 
            this.CaptureVideo_Btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.CaptureVideo_Btn.Location = new System.Drawing.Point(716, 703);
            this.CaptureVideo_Btn.Name = "CaptureVideo_Btn";
            this.CaptureVideo_Btn.Size = new System.Drawing.Size(213, 38);
            this.CaptureVideo_Btn.TabIndex = 6;
            this.CaptureVideo_Btn.Text = "Capture Video";
            this.CaptureVideo_Btn.UseVisualStyleBackColor = false;
            // 
            // WebCam_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.CaptureVideo_Btn);
            this.Controls.Add(this.TakePhoto_Btn);
            this.Controls.Add(this.Display_pictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectCamera_comboBox);
            this.Controls.Add(this.Stop_Btn);
            this.Controls.Add(this.Start_Btn);
            this.Name = "WebCam_Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebCam Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WebCam_Control_FormClosing);
            this.Load += new System.EventHandler(this.WebCam_Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Display_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_Btn;
        private System.Windows.Forms.Button Stop_Btn;
        private System.Windows.Forms.ComboBox SelectCamera_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Display_pictureBox;
        private System.Windows.Forms.Button TakePhoto_Btn;
        private System.Windows.Forms.Button CaptureVideo_Btn;
    }
}

