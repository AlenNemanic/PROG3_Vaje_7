namespace Odstevalnik
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
            this.stevilo = new System.Windows.Forms.Label();
            this.Gumb_ponastavi = new System.Windows.Forms.Button();
            this.Gumb_ustavi = new System.Windows.Forms.Button();
            this.Gumb_zacni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // stevilo
            // 
            this.stevilo.AutoSize = true;
            this.stevilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stevilo.Location = new System.Drawing.Point(241, 34);
            this.stevilo.Name = "stevilo";
            this.stevilo.Size = new System.Drawing.Size(70, 76);
            this.stevilo.TabIndex = 0;
            this.stevilo.Text = "9";
            // 
            // Gumb_ponastavi
            // 
            this.Gumb_ponastavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gumb_ponastavi.Location = new System.Drawing.Point(22, 140);
            this.Gumb_ponastavi.Name = "Gumb_ponastavi";
            this.Gumb_ponastavi.Size = new System.Drawing.Size(156, 54);
            this.Gumb_ponastavi.TabIndex = 1;
            this.Gumb_ponastavi.Text = "Ponastavi";
            this.Gumb_ponastavi.UseVisualStyleBackColor = true;
            this.Gumb_ponastavi.Click += new System.EventHandler(this.Gumb_ponastavi_Click);
            // 
            // Gumb_ustavi
            // 
            this.Gumb_ustavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gumb_ustavi.Location = new System.Drawing.Point(201, 140);
            this.Gumb_ustavi.Name = "Gumb_ustavi";
            this.Gumb_ustavi.Size = new System.Drawing.Size(156, 54);
            this.Gumb_ustavi.TabIndex = 2;
            this.Gumb_ustavi.Text = "Ustavi";
            this.Gumb_ustavi.UseVisualStyleBackColor = true;
            this.Gumb_ustavi.Click += new System.EventHandler(this.Gumb_ustavi_Click);
            // 
            // Gumb_zacni
            // 
            this.Gumb_zacni.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gumb_zacni.Location = new System.Drawing.Point(380, 140);
            this.Gumb_zacni.Name = "Gumb_zacni";
            this.Gumb_zacni.Size = new System.Drawing.Size(156, 54);
            this.Gumb_zacni.TabIndex = 3;
            this.Gumb_zacni.Text = "Začni";
            this.Gumb_zacni.UseVisualStyleBackColor = true;
            this.Gumb_zacni.Click += new System.EventHandler(this.Gumb_zacni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 215);
            this.Controls.Add(this.Gumb_zacni);
            this.Controls.Add(this.Gumb_ustavi);
            this.Controls.Add(this.Gumb_ponastavi);
            this.Controls.Add(this.stevilo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label stevilo;
        private System.Windows.Forms.Button Gumb_ponastavi;
        private System.Windows.Forms.Button Gumb_ustavi;
        private System.Windows.Forms.Button Gumb_zacni;
    }
}

