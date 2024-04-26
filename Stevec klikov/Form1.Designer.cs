namespace Stevec_klikov
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
            this.stevec_klikov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stevec_klikov
            // 
            this.stevec_klikov.AutoSize = true;
            this.stevec_klikov.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stevec_klikov.Location = new System.Drawing.Point(32, 46);
            this.stevec_klikov.Name = "stevec_klikov";
            this.stevec_klikov.Size = new System.Drawing.Size(418, 63);
            this.stevec_klikov.TabIndex = 0;
            this.stevec_klikov.Text = "Števec klikov: 0";
            this.stevec_klikov.Click += new System.EventHandler(this.stevec_klikov_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 151);
            this.Controls.Add(this.stevec_klikov);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stevec_klikov;
    }
}

