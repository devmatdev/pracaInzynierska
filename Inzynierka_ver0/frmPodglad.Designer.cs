
namespace Inzynierka_ver0
{
    partial class frmPodglad
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
            this.lblPodajSciezke = new System.Windows.Forms.Label();
            this.txtPodgladSciezkaPliku = new System.Windows.Forms.TextBox();
            this.btnWczytajPodglad = new System.Windows.Forms.Button();
            this.txtPodgladPliku = new System.Windows.Forms.TextBox();
            this.txtNumeracja = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnPomoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPodajSciezke
            // 
            this.lblPodajSciezke.AutoSize = true;
            this.lblPodajSciezke.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPodajSciezke.Location = new System.Drawing.Point(23, 13);
            this.lblPodajSciezke.Name = "lblPodajSciezke";
            this.lblPodajSciezke.Size = new System.Drawing.Size(408, 24);
            this.lblPodajSciezke.TabIndex = 0;
            this.lblPodajSciezke.Text = "Podaj ścieżkę pliku z danymi do podglądu:";
            // 
            // txtPodgladSciezkaPliku
            // 
            this.txtPodgladSciezkaPliku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPodgladSciezkaPliku.Location = new System.Drawing.Point(20, 47);
            this.txtPodgladSciezkaPliku.Name = "txtPodgladSciezkaPliku";
            this.txtPodgladSciezkaPliku.Size = new System.Drawing.Size(511, 26);
            this.txtPodgladSciezkaPliku.TabIndex = 1;
            // 
            // btnWczytajPodglad
            // 
            this.btnWczytajPodglad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWczytajPodglad.Location = new System.Drawing.Point(616, 44);
            this.btnWczytajPodglad.Name = "btnWczytajPodglad";
            this.btnWczytajPodglad.Size = new System.Drawing.Size(144, 32);
            this.btnWczytajPodglad.TabIndex = 2;
            this.btnWczytajPodglad.Text = "Wczytaj plik";
            this.btnWczytajPodglad.UseVisualStyleBackColor = true;
            this.btnWczytajPodglad.Click += new System.EventHandler(this.btnWczytajPodglad_Click);
            // 
            // txtPodgladPliku
            // 
            this.txtPodgladPliku.Location = new System.Drawing.Point(49, 93);
            this.txtPodgladPliku.Multiline = true;
            this.txtPodgladPliku.Name = "txtPodgladPliku";
            this.txtPodgladPliku.ReadOnly = true;
            this.txtPodgladPliku.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPodgladPliku.Size = new System.Drawing.Size(711, 315);
            this.txtPodgladPliku.TabIndex = 3;
            // 
            // txtNumeracja
            // 
            this.txtNumeracja.Location = new System.Drawing.Point(20, 93);
            this.txtNumeracja.Multiline = true;
            this.txtNumeracja.Name = "txtNumeracja";
            this.txtNumeracja.ReadOnly = true;
            this.txtNumeracja.Size = new System.Drawing.Size(23, 315);
            this.txtNumeracja.TabIndex = 4;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBrowse.Location = new System.Drawing.Point(537, 44);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(42, 30);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnPomoc
            // 
            this.btnPomoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPomoc.Location = new System.Drawing.Point(616, 11);
            this.btnPomoc.Name = "btnPomoc";
            this.btnPomoc.Size = new System.Drawing.Size(144, 32);
            this.btnPomoc.TabIndex = 6;
            this.btnPomoc.Text = "Pomoc";
            this.btnPomoc.UseVisualStyleBackColor = true;
            this.btnPomoc.Click += new System.EventHandler(this.btnPomoc_Click);
            // 
            // frmPodglad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPomoc);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtNumeracja);
            this.Controls.Add(this.txtPodgladPliku);
            this.Controls.Add(this.btnWczytajPodglad);
            this.Controls.Add(this.txtPodgladSciezkaPliku);
            this.Controls.Add(this.lblPodajSciezke);
            this.Name = "frmPodglad";
            this.Text = "Podgląd pliku z danymi pomiarowymi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPodajSciezke;
        private System.Windows.Forms.TextBox txtPodgladSciezkaPliku;
        private System.Windows.Forms.Button btnWczytajPodglad;
        private System.Windows.Forms.TextBox txtPodgladPliku;
        private System.Windows.Forms.TextBox txtNumeracja;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnPomoc;
    }
}