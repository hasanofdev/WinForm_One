namespace Baku_London
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Baku = new System.Windows.Forms.Button();
            this.London = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Baku
            // 
            this.Baku.BackColor = System.Drawing.SystemColors.Highlight;
            this.Baku.Location = new System.Drawing.Point(191, 248);
            this.Baku.Name = "Baku";
            this.Baku.Size = new System.Drawing.Size(170, 70);
            this.Baku.TabIndex = 0;
            this.Baku.Text = "Baku";
            this.Baku.UseVisualStyleBackColor = false;
            this.Baku.Click += new System.EventHandler(this.Baku_Click);
            // 
            // London
            // 
            this.London.BackColor = System.Drawing.SystemColors.Highlight;
            this.London.Location = new System.Drawing.Point(367, 248);
            this.London.Name = "London";
            this.London.Size = new System.Drawing.Size(170, 70);
            this.London.TabIndex = 0;
            this.London.Text = "London";
            this.London.UseVisualStyleBackColor = false;
            this.London.Click += new System.EventHandler(this.London_Click);
            // 
            // Time
            // 
            this.Time.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Time.Location = new System.Drawing.Point(191, 106);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(346, 49);
            this.Time.TabIndex = 1;
            this.Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.baku;
            BackgroundImageLayout = ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(732, 435);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.London);
            this.Controls.Add(this.Baku);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Baku;
        private Button London;
        private Label Time;
    }
}