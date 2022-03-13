
namespace Inzynierka_ver0
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnWykresy = new System.Windows.Forms.Button();
            this.btnWyjscie = new System.Windows.Forms.Button();
            this.updownIleWykresow = new System.Windows.Forms.NumericUpDown();
            this.lblLiczba = new System.Windows.Forms.Label();
            this.btnLaduj = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVer = new System.Windows.Forms.Label();
            this.btnPomoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updownIleWykresow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(672, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Witaj w programie do analizy danych z badań pirostatycznych.";
            // 
            // btnWykresy
            // 
            this.btnWykresy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWykresy.Location = new System.Drawing.Point(12, 117);
            this.btnWykresy.Name = "btnWykresy";
            this.btnWykresy.Size = new System.Drawing.Size(260, 100);
            this.btnWykresy.TabIndex = 1;
            this.btnWykresy.Text = "Wykresy";
            this.btnWykresy.UseVisualStyleBackColor = true;
            this.btnWykresy.Click += new System.EventHandler(this.btnWykresy_Click);
            // 
            // btnWyjscie
            // 
            this.btnWyjscie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyjscie.Location = new System.Drawing.Point(717, 393);
            this.btnWyjscie.Name = "btnWyjscie";
            this.btnWyjscie.Size = new System.Drawing.Size(193, 81);
            this.btnWyjscie.TabIndex = 2;
            this.btnWyjscie.Text = "Wyjście";
            this.btnWyjscie.UseVisualStyleBackColor = true;
            this.btnWyjscie.Click += new System.EventHandler(this.btnWyjscie_Click);
            // 
            // updownIleWykresow
            // 
            this.updownIleWykresow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updownIleWykresow.Location = new System.Drawing.Point(717, 144);
            this.updownIleWykresow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updownIleWykresow.Name = "updownIleWykresow";
            this.updownIleWykresow.Size = new System.Drawing.Size(120, 26);
            this.updownIleWykresow.TabIndex = 3;
            this.updownIleWykresow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updownIleWykresow.Visible = false;
            this.updownIleWykresow.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblLiczba
            // 
            this.lblLiczba.AutoSize = true;
            this.lblLiczba.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLiczba.Location = new System.Drawing.Point(713, 117);
            this.lblLiczba.Name = "lblLiczba";
            this.lblLiczba.Size = new System.Drawing.Size(136, 24);
            this.lblLiczba.TabIndex = 4;
            this.lblLiczba.Text = "Liczba analiz:";
            this.lblLiczba.Visible = false;
            this.lblLiczba.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLaduj
            // 
            this.btnLaduj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLaduj.Location = new System.Drawing.Point(717, 176);
            this.btnLaduj.Name = "btnLaduj";
            this.btnLaduj.Size = new System.Drawing.Size(120, 41);
            this.btnLaduj.TabIndex = 5;
            this.btnLaduj.Text = "Ładuj";
            this.btnLaduj.UseVisualStyleBackColor = true;
            this.btnLaduj.Visible = false;
            this.btnLaduj.Click += new System.EventHandler(this.btnLaduj_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(310, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 358);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Location = new System.Drawing.Point(12, 464);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(91, 13);
            this.lblVer.TabIndex = 7;
            this.lblVer.Text = "ver. 1.0 MM 2022";
            // 
            // btnPomoc
            // 
            this.btnPomoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPomoc.Location = new System.Drawing.Point(717, 309);
            this.btnPomoc.Name = "btnPomoc";
            this.btnPomoc.Size = new System.Drawing.Size(193, 78);
            this.btnPomoc.TabIndex = 8;
            this.btnPomoc.Text = "Pomoc";
            this.btnPomoc.UseVisualStyleBackColor = true;
            this.btnPomoc.Click += new System.EventHandler(this.btnPomoc_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 486);
            this.Controls.Add(this.btnPomoc);
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLaduj);
            this.Controls.Add(this.lblLiczba);
            this.Controls.Add(this.updownIleWykresow);
            this.Controls.Add(this.btnWyjscie);
            this.Controls.Add(this.btnWykresy);
            this.Controls.Add(this.label1);
            this.Name = "frmMenu";
            this.Text = "Menu Startowe";
            ((System.ComponentModel.ISupportInitialize)(this.updownIleWykresow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWykresy;
        private System.Windows.Forms.Button btnWyjscie;
        private System.Windows.Forms.NumericUpDown updownIleWykresow;
        private System.Windows.Forms.Label lblLiczba;
        private System.Windows.Forms.Button btnLaduj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.Button btnPomoc;
    }
}

