namespace Hitrost_reakcij
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
            this.Gumb_se_ujemata = new System.Windows.Forms.Button();
            this.vprasanje = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Gumb_se_ne_ujemata = new System.Windows.Forms.Button();
            this.zapis = new System.Windows.Forms.Label();
            this.odstotek = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Gumb_se_ujemata
            // 
            this.Gumb_se_ujemata.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gumb_se_ujemata.Location = new System.Drawing.Point(115, 194);
            this.Gumb_se_ujemata.Name = "Gumb_se_ujemata";
            this.Gumb_se_ujemata.Size = new System.Drawing.Size(165, 100);
            this.Gumb_se_ujemata.TabIndex = 0;
            this.Gumb_se_ujemata.Text = "Barvi se ujemata";
            this.Gumb_se_ujemata.UseVisualStyleBackColor = true;
            this.Gumb_se_ujemata.Click += new System.EventHandler(this.Gumb_se_ujemata_Click);
            // 
            // vprasanje
            // 
            this.vprasanje.AutoSize = true;
            this.vprasanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vprasanje.Location = new System.Drawing.Point(12, 25);
            this.vprasanje.Name = "vprasanje";
            this.vprasanje.Size = new System.Drawing.Size(687, 39);
            this.vprasanje.TabIndex = 1;
            this.vprasanje.Text = "Ali se ime barve in barva zapisa ujemata?";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Gumb_se_ne_ujemata
            // 
            this.Gumb_se_ne_ujemata.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gumb_se_ne_ujemata.Location = new System.Drawing.Point(408, 194);
            this.Gumb_se_ne_ujemata.Name = "Gumb_se_ne_ujemata";
            this.Gumb_se_ne_ujemata.Size = new System.Drawing.Size(165, 100);
            this.Gumb_se_ne_ujemata.TabIndex = 2;
            this.Gumb_se_ne_ujemata.Text = "Barvi se ne ujemata";
            this.Gumb_se_ne_ujemata.UseVisualStyleBackColor = true;
            this.Gumb_se_ne_ujemata.Click += new System.EventHandler(this.Gumb_se_ne_ujemata_Click);
            // 
            // zapis
            // 
            this.zapis.AutoSize = true;
            this.zapis.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zapis.Location = new System.Drawing.Point(288, 115);
            this.zapis.Name = "zapis";
            this.zapis.Size = new System.Drawing.Size(107, 39);
            this.zapis.TabIndex = 3;
            this.zapis.Text = "barva";
            // 
            // odstotek
            // 
            this.odstotek.AutoSize = true;
            this.odstotek.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odstotek.Location = new System.Drawing.Point(160, 335);
            this.odstotek.Name = "odstotek";
            this.odstotek.Size = new System.Drawing.Size(378, 39);
            this.odstotek.TabIndex = 4;
            this.odstotek.Text = "Odstotek pravilnih: 0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 442);
            this.Controls.Add(this.odstotek);
            this.Controls.Add(this.zapis);
            this.Controls.Add(this.Gumb_se_ne_ujemata);
            this.Controls.Add(this.vprasanje);
            this.Controls.Add(this.Gumb_se_ujemata);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Gumb_se_ujemata;
        private System.Windows.Forms.Label vprasanje;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button Gumb_se_ne_ujemata;
        private System.Windows.Forms.Label zapis;
        private System.Windows.Forms.Label odstotek;
    }
}

