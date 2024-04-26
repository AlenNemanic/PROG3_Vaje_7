namespace Levi_in_desni
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
            this.Levi = new System.Windows.Forms.Button();
            this.Desno = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Levi
            // 
            this.Levi.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Levi.Location = new System.Drawing.Point(25, 41);
            this.Levi.Name = "Levi";
            this.Levi.Size = new System.Drawing.Size(127, 73);
            this.Levi.TabIndex = 0;
            this.Levi.Text = "Levi";
            this.Levi.UseVisualStyleBackColor = true;
            this.Levi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Levi_MouseDown);
            this.Levi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Levi_MouseUp);
            // 
            // Desno
            // 
            this.Desno.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Desno.Location = new System.Drawing.Point(390, 41);
            this.Desno.Name = "Desno";
            this.Desno.Size = new System.Drawing.Size(127, 73);
            this.Desno.TabIndex = 1;
            this.Desno.Text = "Desno";
            this.Desno.UseVisualStyleBackColor = true;
            this.Desno.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Desno_MouseDown);
            this.Desno.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Desno_MouseUp);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.Location = new System.Drawing.Point(178, 58);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 39);
            this.label.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 143);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Desno);
            this.Controls.Add(this.Levi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Levi;
        private System.Windows.Forms.Button Desno;
        private System.Windows.Forms.Label label;
    }
}

