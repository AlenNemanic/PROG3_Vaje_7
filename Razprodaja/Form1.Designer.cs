namespace Razprodaja
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
            this.vnesi_ceno = new System.Windows.Forms.Label();
            this.cena = new System.Windows.Forms.TextBox();
            this.euro_simbol = new System.Windows.Forms.Label();
            this.izberi_popust = new System.Windows.Forms.Label();
            this.popust10 = new System.Windows.Forms.Button();
            this.popust100 = new System.Windows.Forms.Button();
            this.popust20 = new System.Windows.Forms.Button();
            this.popust30 = new System.Windows.Forms.Button();
            this.popust50 = new System.Windows.Forms.Button();
            this.nova_cena_tekst = new System.Windows.Forms.Label();
            this.nova_cena = new System.Windows.Forms.Label();
            this.nova_cena_euro_simbol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vnesi_ceno
            // 
            this.vnesi_ceno.AutoSize = true;
            this.vnesi_ceno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vnesi_ceno.Location = new System.Drawing.Point(63, 69);
            this.vnesi_ceno.Name = "vnesi_ceno";
            this.vnesi_ceno.Size = new System.Drawing.Size(163, 31);
            this.vnesi_ceno.TabIndex = 0;
            this.vnesi_ceno.Text = "Vnesi ceno: ";
            // 
            // cena
            // 
            this.cena.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cena.Location = new System.Drawing.Point(232, 66);
            this.cena.Name = "cena";
            this.cena.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cena.Size = new System.Drawing.Size(176, 38);
            this.cena.TabIndex = 1;
            this.cena.Text = "0";
            // 
            // euro_simbol
            // 
            this.euro_simbol.AutoSize = true;
            this.euro_simbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.euro_simbol.Location = new System.Drawing.Point(414, 69);
            this.euro_simbol.Name = "euro_simbol";
            this.euro_simbol.Size = new System.Drawing.Size(29, 31);
            this.euro_simbol.TabIndex = 2;
            this.euro_simbol.Text = "€";
            // 
            // izberi_popust
            // 
            this.izberi_popust.AutoSize = true;
            this.izberi_popust.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izberi_popust.Location = new System.Drawing.Point(163, 141);
            this.izberi_popust.Name = "izberi_popust";
            this.izberi_popust.Size = new System.Drawing.Size(170, 31);
            this.izberi_popust.TabIndex = 3;
            this.izberi_popust.Text = "Izberi popust";
            // 
            // popust10
            // 
            this.popust10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popust10.Location = new System.Drawing.Point(39, 196);
            this.popust10.Name = "popust10";
            this.popust10.Size = new System.Drawing.Size(81, 44);
            this.popust10.TabIndex = 4;
            this.popust10.Text = "10 %";
            this.popust10.UseVisualStyleBackColor = true;
            this.popust10.Click += new System.EventHandler(this.popust10_Click);
            // 
            // popust100
            // 
            this.popust100.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popust100.Location = new System.Drawing.Point(387, 196);
            this.popust100.Name = "popust100";
            this.popust100.Size = new System.Drawing.Size(81, 44);
            this.popust100.TabIndex = 5;
            this.popust100.Text = "100 %";
            this.popust100.UseVisualStyleBackColor = true;
            this.popust100.Click += new System.EventHandler(this.popust100_Click);
            // 
            // popust20
            // 
            this.popust20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popust20.Location = new System.Drawing.Point(126, 196);
            this.popust20.Name = "popust20";
            this.popust20.Size = new System.Drawing.Size(81, 44);
            this.popust20.TabIndex = 6;
            this.popust20.Text = "20 %";
            this.popust20.UseVisualStyleBackColor = true;
            this.popust20.Click += new System.EventHandler(this.popust20_Click);
            // 
            // popust30
            // 
            this.popust30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popust30.Location = new System.Drawing.Point(213, 196);
            this.popust30.Name = "popust30";
            this.popust30.Size = new System.Drawing.Size(81, 44);
            this.popust30.TabIndex = 7;
            this.popust30.Text = "30 %";
            this.popust30.UseVisualStyleBackColor = true;
            this.popust30.Click += new System.EventHandler(this.popust30_Click);
            // 
            // popust50
            // 
            this.popust50.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popust50.Location = new System.Drawing.Point(300, 196);
            this.popust50.Name = "popust50";
            this.popust50.Size = new System.Drawing.Size(81, 44);
            this.popust50.TabIndex = 8;
            this.popust50.Text = "50 %";
            this.popust50.UseVisualStyleBackColor = true;
            this.popust50.Click += new System.EventHandler(this.popust50_Click);
            // 
            // nova_cena_tekst
            // 
            this.nova_cena_tekst.AutoSize = true;
            this.nova_cena_tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nova_cena_tekst.Location = new System.Drawing.Point(76, 301);
            this.nova_cena_tekst.Name = "nova_cena_tekst";
            this.nova_cena_tekst.Size = new System.Drawing.Size(180, 31);
            this.nova_cena_tekst.TabIndex = 9;
            this.nova_cena_tekst.Text = "Nova cena je:";
            // 
            // nova_cena
            // 
            this.nova_cena.AutoSize = true;
            this.nova_cena.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nova_cena.Location = new System.Drawing.Point(262, 301);
            this.nova_cena.Name = "nova_cena";
            this.nova_cena.Size = new System.Drawing.Size(0, 31);
            this.nova_cena.TabIndex = 10;
            // 
            // nova_cena_euro_simbol
            // 
            this.nova_cena_euro_simbol.AutoSize = true;
            this.nova_cena_euro_simbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nova_cena_euro_simbol.Location = new System.Drawing.Point(352, 301);
            this.nova_cena_euro_simbol.Name = "nova_cena_euro_simbol";
            this.nova_cena_euro_simbol.Size = new System.Drawing.Size(29, 31);
            this.nova_cena_euro_simbol.TabIndex = 11;
            this.nova_cena_euro_simbol.Text = "€";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 390);
            this.Controls.Add(this.nova_cena_euro_simbol);
            this.Controls.Add(this.nova_cena);
            this.Controls.Add(this.nova_cena_tekst);
            this.Controls.Add(this.popust50);
            this.Controls.Add(this.popust30);
            this.Controls.Add(this.popust20);
            this.Controls.Add(this.popust100);
            this.Controls.Add(this.popust10);
            this.Controls.Add(this.izberi_popust);
            this.Controls.Add(this.euro_simbol);
            this.Controls.Add(this.cena);
            this.Controls.Add(this.vnesi_ceno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vnesi_ceno;
        private System.Windows.Forms.TextBox cena;
        private System.Windows.Forms.Label euro_simbol;
        private System.Windows.Forms.Label izberi_popust;
        private System.Windows.Forms.Button popust10;
        private System.Windows.Forms.Button popust100;
        private System.Windows.Forms.Button popust20;
        private System.Windows.Forms.Button popust30;
        private System.Windows.Forms.Button popust50;
        private System.Windows.Forms.Label nova_cena_tekst;
        private System.Windows.Forms.Label nova_cena;
        private System.Windows.Forms.Label nova_cena_euro_simbol;
    }
}

