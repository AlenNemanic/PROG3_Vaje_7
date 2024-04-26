namespace Izmenjava_barv
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.stevec_oranzna = new System.Windows.Forms.Label();
            this.Gumb = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.stevec_vijolicna = new System.Windows.Forms.Label();
            this.stevec_zelena = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(223, 33);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 200);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // stevec_oranzna
            // 
            this.stevec_oranzna.AutoSize = true;
            this.stevec_oranzna.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stevec_oranzna.Location = new System.Drawing.Point(31, 108);
            this.stevec_oranzna.Name = "stevec_oranzna";
            this.stevec_oranzna.Size = new System.Drawing.Size(158, 31);
            this.stevec_oranzna.TabIndex = 1;
            this.stevec_oranzna.Text = "Oranžna: 0";
            // 
            // Gumb
            // 
            this.Gumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Gumb.Location = new System.Drawing.Point(37, 33);
            this.Gumb.Name = "Gumb";
            this.Gumb.Size = new System.Drawing.Size(130, 52);
            this.Gumb.TabIndex = 2;
            this.Gumb.Text = "Ustavi";
            this.Gumb.UseVisualStyleBackColor = true;
            this.Gumb.Click += new System.EventHandler(this.Gumb_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // stevec_vijolicna
            // 
            this.stevec_vijolicna.AutoSize = true;
            this.stevec_vijolicna.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stevec_vijolicna.Location = new System.Drawing.Point(31, 158);
            this.stevec_vijolicna.Name = "stevec_vijolicna";
            this.stevec_vijolicna.Size = new System.Drawing.Size(157, 31);
            this.stevec_vijolicna.TabIndex = 3;
            this.stevec_vijolicna.Text = "Vijolična: 0";
            // 
            // stevec_zelena
            // 
            this.stevec_zelena.AutoSize = true;
            this.stevec_zelena.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stevec_zelena.Location = new System.Drawing.Point(31, 202);
            this.stevec_zelena.Name = "stevec_zelena";
            this.stevec_zelena.Size = new System.Drawing.Size(136, 31);
            this.stevec_zelena.TabIndex = 4;
            this.stevec_zelena.Text = "Zelena: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 268);
            this.Controls.Add(this.stevec_zelena);
            this.Controls.Add(this.stevec_vijolicna);
            this.Controls.Add(this.Gumb);
            this.Controls.Add(this.stevec_oranzna);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label stevec_oranzna;
        private System.Windows.Forms.Button Gumb;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label stevec_vijolicna;
        private System.Windows.Forms.Label stevec_zelena;
    }
}

