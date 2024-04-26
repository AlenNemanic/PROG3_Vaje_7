namespace Vlak_prihaja
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
            this.zacni = new System.Windows.Forms.Button();
            this.leva_luc = new System.Windows.Forms.PictureBox();
            this.ustavi = new System.Windows.Forms.Button();
            this.desna_luc = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.leva_luc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desna_luc)).BeginInit();
            this.SuspendLayout();
            // 
            // zacni
            // 
            this.zacni.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zacni.Location = new System.Drawing.Point(50, 216);
            this.zacni.Name = "zacni";
            this.zacni.Size = new System.Drawing.Size(130, 75);
            this.zacni.TabIndex = 0;
            this.zacni.Text = "Začni";
            this.zacni.UseVisualStyleBackColor = true;
            this.zacni.Click += new System.EventHandler(this.zacni_Click);
            // 
            // leva_luc
            // 
            this.leva_luc.BackColor = System.Drawing.Color.White;
            this.leva_luc.Location = new System.Drawing.Point(39, 37);
            this.leva_luc.Name = "leva_luc";
            this.leva_luc.Size = new System.Drawing.Size(150, 150);
            this.leva_luc.TabIndex = 1;
            this.leva_luc.TabStop = false;
            // 
            // ustavi
            // 
            this.ustavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ustavi.Location = new System.Drawing.Point(262, 216);
            this.ustavi.Name = "ustavi";
            this.ustavi.Size = new System.Drawing.Size(130, 75);
            this.ustavi.TabIndex = 2;
            this.ustavi.Text = "Ustavi";
            this.ustavi.UseVisualStyleBackColor = true;
            this.ustavi.Click += new System.EventHandler(this.ustavi_Click);
            // 
            // desna_luc
            // 
            this.desna_luc.BackColor = System.Drawing.Color.White;
            this.desna_luc.Location = new System.Drawing.Point(253, 37);
            this.desna_luc.Name = "desna_luc";
            this.desna_luc.Size = new System.Drawing.Size(150, 150);
            this.desna_luc.TabIndex = 3;
            this.desna_luc.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 314);
            this.Controls.Add(this.desna_luc);
            this.Controls.Add(this.ustavi);
            this.Controls.Add(this.leva_luc);
            this.Controls.Add(this.zacni);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.leva_luc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desna_luc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button zacni;
        private System.Windows.Forms.PictureBox leva_luc;
        private System.Windows.Forms.Button ustavi;
        private System.Windows.Forms.PictureBox desna_luc;
        private System.Windows.Forms.Timer timer;
    }
}

