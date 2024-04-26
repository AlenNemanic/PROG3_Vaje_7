namespace Semafor
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Rdeca = new System.Windows.Forms.Button();
            this.Rumena = new System.Windows.Forms.Button();
            this.Zelena = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(250, 50);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(220, 220);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // Rdeca
            // 
            this.Rdeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rdeca.Location = new System.Drawing.Point(50, 50);
            this.Rdeca.Name = "Rdeca";
            this.Rdeca.Size = new System.Drawing.Size(160, 60);
            this.Rdeca.TabIndex = 1;
            this.Rdeca.Text = "Rdeča";
            this.Rdeca.UseVisualStyleBackColor = true;
            this.Rdeca.Click += new System.EventHandler(this.Rdeca_Click);
            // 
            // Rumena
            // 
            this.Rumena.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rumena.Location = new System.Drawing.Point(50, 130);
            this.Rumena.Name = "Rumena";
            this.Rumena.Size = new System.Drawing.Size(160, 60);
            this.Rumena.TabIndex = 2;
            this.Rumena.Text = "Rumena";
            this.Rumena.UseVisualStyleBackColor = true;
            this.Rumena.Click += new System.EventHandler(this.Rumena_Click);
            // 
            // Zelena
            // 
            this.Zelena.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zelena.Location = new System.Drawing.Point(50, 210);
            this.Zelena.Name = "Zelena";
            this.Zelena.Size = new System.Drawing.Size(160, 60);
            this.Zelena.TabIndex = 3;
            this.Zelena.Text = "Zelena";
            this.Zelena.UseVisualStyleBackColor = true;
            this.Zelena.Click += new System.EventHandler(this.Zelena_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 301);
            this.Controls.Add(this.Zelena);
            this.Controls.Add(this.Rumena);
            this.Controls.Add(this.Rdeca);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button Rdeca;
        private System.Windows.Forms.Button Rumena;
        private System.Windows.Forms.Button Zelena;
    }
}

