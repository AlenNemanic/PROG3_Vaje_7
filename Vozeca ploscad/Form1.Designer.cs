﻿namespace Vozeca_ploscad
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
            this.ploscad = new System.Windows.Forms.PictureBox();
            this.Gumb = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ploscad)).BeginInit();
            this.SuspendLayout();
            // 
            // ploscad
            // 
            this.ploscad.BackColor = System.Drawing.Color.Black;
            this.ploscad.Location = new System.Drawing.Point(10, 10);
            this.ploscad.Name = "ploscad";
            this.ploscad.Size = new System.Drawing.Size(100, 5);
            this.ploscad.TabIndex = 0;
            this.ploscad.TabStop = false;
            // 
            // Gumb
            // 
            this.Gumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gumb.Location = new System.Drawing.Point(70, 60);
            this.Gumb.Name = "Gumb";
            this.Gumb.Size = new System.Drawing.Size(150, 80);
            this.Gumb.TabIndex = 1;
            this.Gumb.Text = "Začni";
            this.Gumb.UseVisualStyleBackColor = true;
            this.Gumb.Click += new System.EventHandler(this.Gumb_Click);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 161);
            this.Controls.Add(this.Gumb);
            this.Controls.Add(this.ploscad);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ploscad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ploscad;
        private System.Windows.Forms.Button Gumb;
        private System.Windows.Forms.Timer timer;
    }
}

