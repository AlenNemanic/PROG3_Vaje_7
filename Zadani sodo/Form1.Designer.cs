namespace Zadani_sodo
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
            this.st_tock = new System.Windows.Forms.Label();
            this.Gumb = new System.Windows.Forms.Button();
            this.st_klikov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 250;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // st_tock
            // 
            this.st_tock.AutoSize = true;
            this.st_tock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.st_tock.Location = new System.Drawing.Point(40, 159);
            this.st_tock.Name = "st_tock";
            this.st_tock.Size = new System.Drawing.Size(199, 31);
            this.st_tock.TabIndex = 0;
            this.st_tock.Text = "Število točk: 0";
            // 
            // Gumb
            // 
            this.Gumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gumb.Location = new System.Drawing.Point(86, 57);
            this.Gumb.Name = "Gumb";
            this.Gumb.Size = new System.Drawing.Size(124, 80);
            this.Gumb.TabIndex = 1;
            this.Gumb.Text = "0";
            this.Gumb.UseVisualStyleBackColor = true;
            this.Gumb.Click += new System.EventHandler(this.button1_Click);
            // 
            // st_klikov
            // 
            this.st_klikov.AutoSize = true;
            this.st_klikov.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.st_klikov.Location = new System.Drawing.Point(40, 217);
            this.st_klikov.Name = "st_klikov";
            this.st_klikov.Size = new System.Drawing.Size(219, 31);
            this.st_klikov.TabIndex = 2;
            this.st_klikov.Text = "Število klikov: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 279);
            this.Controls.Add(this.st_klikov);
            this.Controls.Add(this.Gumb);
            this.Controls.Add(this.st_tock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label st_tock;
        private System.Windows.Forms.Button Gumb;
        private System.Windows.Forms.Label st_klikov;
    }
}

