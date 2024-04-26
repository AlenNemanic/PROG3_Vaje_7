namespace Casovnik
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Gumb = new System.Windows.Forms.Button();
            this.cas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Gumb
            // 
            this.Gumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gumb.Location = new System.Drawing.Point(36, 35);
            this.Gumb.Name = "Gumb";
            this.Gumb.Size = new System.Drawing.Size(189, 83);
            this.Gumb.TabIndex = 0;
            this.Gumb.Text = "Ustavi";
            this.Gumb.UseVisualStyleBackColor = true;
            this.Gumb.Click += new System.EventHandler(this.Gumb_Click);
            // 
            // cas
            // 
            this.cas.AutoSize = true;
            this.cas.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cas.Location = new System.Drawing.Point(68, 163);
            this.cas.Name = "cas";
            this.cas.Size = new System.Drawing.Size(76, 46);
            this.cas.TabIndex = 1;
            this.cas.Text = "0 s";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 262);
            this.Controls.Add(this.cas);
            this.Controls.Add(this.Gumb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button Gumb;
        private System.Windows.Forms.Label cas;
    }
}

