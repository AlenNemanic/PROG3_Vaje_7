namespace Bezeci_gumb
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
            this.stevec_klikov = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // stevec_klikov
            // 
            this.stevec_klikov.AutoSize = true;
            this.stevec_klikov.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stevec_klikov.Location = new System.Drawing.Point(70, 65);
            this.stevec_klikov.Name = "stevec_klikov";
            this.stevec_klikov.Size = new System.Drawing.Size(164, 25);
            this.stevec_klikov.TabIndex = 0;
            this.stevec_klikov.Text = "Število klikov: 0";
            this.stevec_klikov.Click += new System.EventHandler(this.stevec_klikov_Click);
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button.Location = new System.Drawing.Point(143, 221);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(150, 110);
            this.button.TabIndex = 2;
            this.button.Text = "Klikni me!";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // timer
            // 
            this.timer.Interval = 400;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 414);
            this.Controls.Add(this.button);
            this.Controls.Add(this.stevec_klikov);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stevec_klikov;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Timer timer;
    }
}

