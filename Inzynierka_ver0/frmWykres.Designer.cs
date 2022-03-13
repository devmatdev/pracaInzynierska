
namespace Inzynierka_ver0
{
    partial class frmWykres
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.crtWykresy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtSciezkaPliku1 = new System.Windows.Forms.TextBox();
            this.lblSciezka1 = new System.Windows.Forms.Label();
            this.btnWczytajDane = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.grbMenu = new System.Windows.Forms.GroupBox();
            this.btnPomoc = new System.Windows.Forms.Button();
            this.chbEksport4 = new System.Windows.Forms.CheckBox();
            this.chbEksport3 = new System.Windows.Forms.CheckBox();
            this.chbEksport2 = new System.Windows.Forms.CheckBox();
            this.chbEksport1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCisnienieZaplonu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGruboscWarstwyPalnej = new System.Windows.Forms.TextBox();
            this.tltKrok = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProbkowanie4 = new System.Windows.Forms.TextBox();
            this.txtDelta4 = new System.Windows.Forms.TextBox();
            this.txtProbkowanie3 = new System.Windows.Forms.TextBox();
            this.txtDelta3 = new System.Windows.Forms.TextBox();
            this.txtProbkowanie2 = new System.Windows.Forms.TextBox();
            this.txtDelta2 = new System.Windows.Forms.TextBox();
            this.txtProbkowanie1 = new System.Windows.Forms.TextBox();
            this.txtDelta = new System.Windows.Forms.TextBox();
            this.numIleKrzywych = new System.Windows.Forms.NumericUpDown();
            this.btnBrowse4 = new System.Windows.Forms.Button();
            this.btnBrowse3 = new System.Windows.Forms.Button();
            this.btnParametry = new System.Windows.Forms.Button();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.lblIleKrzywych = new System.Windows.Forms.Label();
            this.lblNumerWiersza = new System.Windows.Forms.Label();
            this.txtNumerWiersza = new System.Windows.Forms.TextBox();
            this.btnPodglad = new System.Windows.Forms.Button();
            this.btbBrowse = new System.Windows.Forms.Button();
            this.lblSciezka4 = new System.Windows.Forms.Label();
            this.txtSciezkaPliku4 = new System.Windows.Forms.TextBox();
            this.lblSciezka2 = new System.Windows.Forms.Label();
            this.lblSciezka3 = new System.Windows.Forms.Label();
            this.txtSciezkaPliku2 = new System.Windows.Forms.TextBox();
            this.txtSciezkaPliku3 = new System.Windows.Forms.TextBox();
            this.ofdSciezkaPliku1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.crtWykresy)).BeginInit();
            this.grbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIleKrzywych)).BeginInit();
            this.SuspendLayout();
            // 
            // crtWykresy
            // 
            this.crtWykresy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.MinorTickMark.Enabled = true;
            chartArea1.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.crtWykresy.ChartAreas.Add(chartArea1);
            this.crtWykresy.Cursor = System.Windows.Forms.Cursors.Cross;
            legend1.Name = "Legend1";
            this.crtWykresy.Legends.Add(legend1);
            this.crtWykresy.Location = new System.Drawing.Point(10, 12);
            this.crtWykresy.Name = "crtWykresy";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Pomiary";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Pomiary2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Pomiary3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Pomiary4";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "SkorygowanePomiary";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "SkorygowanePomiary2";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "SkorygowanePomiary3";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "SkorygowanePomiary4";
            this.crtWykresy.Series.Add(series1);
            this.crtWykresy.Series.Add(series2);
            this.crtWykresy.Series.Add(series3);
            this.crtWykresy.Series.Add(series4);
            this.crtWykresy.Series.Add(series5);
            this.crtWykresy.Series.Add(series6);
            this.crtWykresy.Series.Add(series7);
            this.crtWykresy.Series.Add(series8);
            this.crtWykresy.Size = new System.Drawing.Size(1157, 565);
            this.crtWykresy.TabIndex = 0;
            this.crtWykresy.TabStop = false;
            this.crtWykresy.Text = "chart1";
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title1.Name = "tltCzasProbkowania";
            title1.Text = "Czas  [ms]";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title2.Name = "tltCisnienie";
            title2.Text = "Cisnienie [MPa]";
            this.crtWykresy.Titles.Add(title1);
            this.crtWykresy.Titles.Add(title2);
            this.crtWykresy.Click += new System.EventHandler(this.chartWykres_Click);
            // 
            // txtSciezkaPliku1
            // 
            this.txtSciezkaPliku1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSciezkaPliku1.Location = new System.Drawing.Point(208, 83);
            this.txtSciezkaPliku1.Name = "txtSciezkaPliku1";
            this.txtSciezkaPliku1.Size = new System.Drawing.Size(215, 26);
            this.txtSciezkaPliku1.TabIndex = 2;
            // 
            // lblSciezka1
            // 
            this.lblSciezka1.AutoSize = true;
            this.lblSciezka1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSciezka1.Location = new System.Drawing.Point(6, 83);
            this.lblSciezka1.Name = "lblSciezka1";
            this.lblSciezka1.Size = new System.Drawing.Size(196, 20);
            this.lblSciezka1.TabIndex = 9;
            this.lblSciezka1.Text = "Scieżka pliku danych 1:";
            this.lblSciezka1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnWczytajDane
            // 
            this.btnWczytajDane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWczytajDane.Location = new System.Drawing.Point(1015, 63);
            this.btnWczytajDane.Name = "btnWczytajDane";
            this.btnWczytajDane.Size = new System.Drawing.Size(146, 29);
            this.btnWczytajDane.TabIndex = 7;
            this.btnWczytajDane.Text = "Wczytaj dane";
            this.btnWczytajDane.UseVisualStyleBackColor = true;
            this.btnWczytajDane.Click += new System.EventHandler(this.btnWczytajDane_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZamknij.Location = new System.Drawing.Point(1015, 165);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(146, 29);
            this.btnZamknij.TabIndex = 8;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // grbMenu
            // 
            this.grbMenu.Controls.Add(this.btnPomoc);
            this.grbMenu.Controls.Add(this.chbEksport4);
            this.grbMenu.Controls.Add(this.chbEksport3);
            this.grbMenu.Controls.Add(this.chbEksport2);
            this.grbMenu.Controls.Add(this.chbEksport1);
            this.grbMenu.Controls.Add(this.label3);
            this.grbMenu.Controls.Add(this.txtCisnienieZaplonu);
            this.grbMenu.Controls.Add(this.label1);
            this.grbMenu.Controls.Add(this.txtGruboscWarstwyPalnej);
            this.grbMenu.Controls.Add(this.tltKrok);
            this.grbMenu.Controls.Add(this.label2);
            this.grbMenu.Controls.Add(this.txtProbkowanie4);
            this.grbMenu.Controls.Add(this.txtDelta4);
            this.grbMenu.Controls.Add(this.txtProbkowanie3);
            this.grbMenu.Controls.Add(this.txtDelta3);
            this.grbMenu.Controls.Add(this.txtProbkowanie2);
            this.grbMenu.Controls.Add(this.txtDelta2);
            this.grbMenu.Controls.Add(this.txtProbkowanie1);
            this.grbMenu.Controls.Add(this.txtDelta);
            this.grbMenu.Controls.Add(this.numIleKrzywych);
            this.grbMenu.Controls.Add(this.btnBrowse4);
            this.grbMenu.Controls.Add(this.btnBrowse3);
            this.grbMenu.Controls.Add(this.btnParametry);
            this.grbMenu.Controls.Add(this.btnBrowse2);
            this.grbMenu.Controls.Add(this.lblIleKrzywych);
            this.grbMenu.Controls.Add(this.lblNumerWiersza);
            this.grbMenu.Controls.Add(this.txtNumerWiersza);
            this.grbMenu.Controls.Add(this.btnPodglad);
            this.grbMenu.Controls.Add(this.btbBrowse);
            this.grbMenu.Controls.Add(this.btnZamknij);
            this.grbMenu.Controls.Add(this.btnWczytajDane);
            this.grbMenu.Controls.Add(this.lblSciezka4);
            this.grbMenu.Controls.Add(this.txtSciezkaPliku4);
            this.grbMenu.Controls.Add(this.lblSciezka2);
            this.grbMenu.Controls.Add(this.lblSciezka3);
            this.grbMenu.Controls.Add(this.txtSciezkaPliku2);
            this.grbMenu.Controls.Add(this.txtSciezkaPliku3);
            this.grbMenu.Controls.Add(this.lblSciezka1);
            this.grbMenu.Controls.Add(this.txtSciezkaPliku1);
            this.grbMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grbMenu.Location = new System.Drawing.Point(0, 583);
            this.grbMenu.Name = "grbMenu";
            this.grbMenu.Size = new System.Drawing.Size(1167, 224);
            this.grbMenu.TabIndex = 0;
            this.grbMenu.TabStop = false;
            this.grbMenu.Text = "Menu";
            // 
            // btnPomoc
            // 
            this.btnPomoc.Location = new System.Drawing.Point(1015, 130);
            this.btnPomoc.Name = "btnPomoc";
            this.btnPomoc.Size = new System.Drawing.Size(146, 29);
            this.btnPomoc.TabIndex = 29;
            this.btnPomoc.Text = "Pomoc";
            this.btnPomoc.UseVisualStyleBackColor = true;
            this.btnPomoc.Click += new System.EventHandler(this.btnPomoc_Click);
            // 
            // chbEksport4
            // 
            this.chbEksport4.AutoSize = true;
            this.chbEksport4.Location = new System.Drawing.Point(648, 179);
            this.chbEksport4.Name = "chbEksport4";
            this.chbEksport4.Size = new System.Drawing.Size(118, 24);
            this.chbEksport4.TabIndex = 28;
            this.chbEksport4.Text = "eksport .txt";
            this.chbEksport4.UseVisualStyleBackColor = true;
            this.chbEksport4.Visible = false;
            // 
            // chbEksport3
            // 
            this.chbEksport3.AutoSize = true;
            this.chbEksport3.Location = new System.Drawing.Point(648, 148);
            this.chbEksport3.Name = "chbEksport3";
            this.chbEksport3.Size = new System.Drawing.Size(118, 24);
            this.chbEksport3.TabIndex = 28;
            this.chbEksport3.Text = "eksport .txt";
            this.chbEksport3.UseVisualStyleBackColor = true;
            this.chbEksport3.Visible = false;
            // 
            // chbEksport2
            // 
            this.chbEksport2.AutoSize = true;
            this.chbEksport2.Location = new System.Drawing.Point(648, 117);
            this.chbEksport2.Name = "chbEksport2";
            this.chbEksport2.Size = new System.Drawing.Size(118, 24);
            this.chbEksport2.TabIndex = 28;
            this.chbEksport2.Text = "eksport .txt";
            this.chbEksport2.UseVisualStyleBackColor = true;
            // 
            // chbEksport1
            // 
            this.chbEksport1.AutoSize = true;
            this.chbEksport1.Location = new System.Drawing.Point(648, 87);
            this.chbEksport1.Name = "chbEksport1";
            this.chbEksport1.Size = new System.Drawing.Size(118, 24);
            this.chbEksport1.TabIndex = 28;
            this.chbEksport1.Text = "eksport .txt";
            this.chbEksport1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cisnienie zapłonu [MPa]:";
            // 
            // txtCisnienieZaplonu
            // 
            this.txtCisnienieZaplonu.Location = new System.Drawing.Point(481, 19);
            this.txtCisnienieZaplonu.Name = "txtCisnienieZaplonu";
            this.txtCisnienieZaplonu.Size = new System.Drawing.Size(41, 26);
            this.txtCisnienieZaplonu.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Grubość warstwy palnej ziarna prochu e1 [m]:";
            // 
            // txtGruboscWarstwyPalnej
            // 
            this.txtGruboscWarstwyPalnej.Location = new System.Drawing.Point(903, 19);
            this.txtGruboscWarstwyPalnej.Name = "txtGruboscWarstwyPalnej";
            this.txtGruboscWarstwyPalnej.Size = new System.Drawing.Size(78, 26);
            this.txtGruboscWarstwyPalnej.TabIndex = 24;
            // 
            // tltKrok
            // 
            this.tltKrok.AutoSize = true;
            this.tltKrok.Location = new System.Drawing.Point(532, 60);
            this.tltKrok.Name = "tltKrok";
            this.tltKrok.Size = new System.Drawing.Size(143, 20);
            this.tltKrok.TabIndex = 23;
            this.tltKrok.Text = "próbkowanie [µs]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "delta";
            // 
            // txtProbkowanie4
            // 
            this.txtProbkowanie4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtProbkowanie4.Location = new System.Drawing.Point(530, 177);
            this.txtProbkowanie4.Name = "txtProbkowanie4";
            this.txtProbkowanie4.Size = new System.Drawing.Size(112, 26);
            this.txtProbkowanie4.TabIndex = 20;
            this.txtProbkowanie4.Visible = false;
            // 
            // txtDelta4
            // 
            this.txtDelta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDelta4.Location = new System.Drawing.Point(481, 177);
            this.txtDelta4.Name = "txtDelta4";
            this.txtDelta4.Size = new System.Drawing.Size(43, 26);
            this.txtDelta4.TabIndex = 20;
            this.txtDelta4.Visible = false;
            // 
            // txtProbkowanie3
            // 
            this.txtProbkowanie3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtProbkowanie3.Location = new System.Drawing.Point(530, 146);
            this.txtProbkowanie3.Name = "txtProbkowanie3";
            this.txtProbkowanie3.Size = new System.Drawing.Size(112, 26);
            this.txtProbkowanie3.TabIndex = 20;
            this.txtProbkowanie3.Visible = false;
            // 
            // txtDelta3
            // 
            this.txtDelta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDelta3.Location = new System.Drawing.Point(481, 146);
            this.txtDelta3.Name = "txtDelta3";
            this.txtDelta3.Size = new System.Drawing.Size(43, 26);
            this.txtDelta3.TabIndex = 20;
            this.txtDelta3.Visible = false;
            // 
            // txtProbkowanie2
            // 
            this.txtProbkowanie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtProbkowanie2.Location = new System.Drawing.Point(530, 115);
            this.txtProbkowanie2.Name = "txtProbkowanie2";
            this.txtProbkowanie2.Size = new System.Drawing.Size(112, 26);
            this.txtProbkowanie2.TabIndex = 20;
            // 
            // txtDelta2
            // 
            this.txtDelta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDelta2.Location = new System.Drawing.Point(481, 115);
            this.txtDelta2.Name = "txtDelta2";
            this.txtDelta2.Size = new System.Drawing.Size(43, 26);
            this.txtDelta2.TabIndex = 20;
            // 
            // txtProbkowanie1
            // 
            this.txtProbkowanie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtProbkowanie1.Location = new System.Drawing.Point(530, 85);
            this.txtProbkowanie1.Name = "txtProbkowanie1";
            this.txtProbkowanie1.Size = new System.Drawing.Size(112, 26);
            this.txtProbkowanie1.TabIndex = 20;
            // 
            // txtDelta
            // 
            this.txtDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDelta.Location = new System.Drawing.Point(481, 85);
            this.txtDelta.Name = "txtDelta";
            this.txtDelta.Size = new System.Drawing.Size(43, 26);
            this.txtDelta.TabIndex = 20;
            // 
            // numIleKrzywych
            // 
            this.numIleKrzywych.Location = new System.Drawing.Point(208, 20);
            this.numIleKrzywych.Name = "numIleKrzywych";
            this.numIleKrzywych.Size = new System.Drawing.Size(58, 26);
            this.numIleKrzywych.TabIndex = 19;
            this.numIleKrzywych.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numIleKrzywych.ValueChanged += new System.EventHandler(this.numIleKrzywych_ValueChanged);
            // 
            // btnBrowse4
            // 
            this.btnBrowse4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBrowse4.Location = new System.Drawing.Point(430, 178);
            this.btnBrowse4.Name = "btnBrowse4";
            this.btnBrowse4.Size = new System.Drawing.Size(45, 28);
            this.btnBrowse4.TabIndex = 18;
            this.btnBrowse4.Text = "...";
            this.btnBrowse4.UseVisualStyleBackColor = true;
            this.btnBrowse4.Visible = false;
            this.btnBrowse4.Click += new System.EventHandler(this.btnBrowse4_Click);
            // 
            // btnBrowse3
            // 
            this.btnBrowse3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBrowse3.Location = new System.Drawing.Point(430, 146);
            this.btnBrowse3.Name = "btnBrowse3";
            this.btnBrowse3.Size = new System.Drawing.Size(45, 29);
            this.btnBrowse3.TabIndex = 17;
            this.btnBrowse3.Text = "...";
            this.btnBrowse3.UseVisualStyleBackColor = true;
            this.btnBrowse3.Visible = false;
            this.btnBrowse3.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnParametry
            // 
            this.btnParametry.Enabled = false;
            this.btnParametry.Location = new System.Drawing.Point(1016, 97);
            this.btnParametry.Margin = new System.Windows.Forms.Padding(2);
            this.btnParametry.Name = "btnParametry";
            this.btnParametry.Size = new System.Drawing.Size(146, 28);
            this.btnParametry.TabIndex = 14;
            this.btnParametry.Text = "Parametry";
            this.btnParametry.UseVisualStyleBackColor = true;
            this.btnParametry.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBrowse2.Location = new System.Drawing.Point(430, 114);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(45, 27);
            this.btnBrowse2.TabIndex = 12;
            this.btnBrowse2.Text = "...";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // lblIleKrzywych
            // 
            this.lblIleKrzywych.AutoSize = true;
            this.lblIleKrzywych.Location = new System.Drawing.Point(6, 22);
            this.lblIleKrzywych.Name = "lblIleKrzywych";
            this.lblIleKrzywych.Size = new System.Drawing.Size(163, 20);
            this.lblIleKrzywych.TabIndex = 9;
            this.lblIleKrzywych.Text = "Ile krzywych? (1-4):";
            // 
            // lblNumerWiersza
            // 
            this.lblNumerWiersza.AutoSize = true;
            this.lblNumerWiersza.Location = new System.Drawing.Point(6, 51);
            this.lblNumerWiersza.Name = "lblNumerWiersza";
            this.lblNumerWiersza.Size = new System.Drawing.Size(255, 20);
            this.lblNumerWiersza.TabIndex = 9;
            this.lblNumerWiersza.Text = "Nr wiersza od którego pomiary:";
            // 
            // txtNumerWiersza
            // 
            this.txtNumerWiersza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNumerWiersza.Location = new System.Drawing.Point(269, 51);
            this.txtNumerWiersza.Name = "txtNumerWiersza";
            this.txtNumerWiersza.Size = new System.Drawing.Size(70, 26);
            this.txtNumerWiersza.TabIndex = 1;
            // 
            // btnPodglad
            // 
            this.btnPodglad.Location = new System.Drawing.Point(1015, 25);
            this.btnPodglad.Name = "btnPodglad";
            this.btnPodglad.Size = new System.Drawing.Size(146, 32);
            this.btnPodglad.TabIndex = 6;
            this.btnPodglad.Text = "Podgląd pliku";
            this.btnPodglad.UseVisualStyleBackColor = true;
            this.btnPodglad.Click += new System.EventHandler(this.btnPodglad_Click);
            // 
            // btbBrowse
            // 
            this.btbBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btbBrowse.Location = new System.Drawing.Point(430, 83);
            this.btbBrowse.Name = "btbBrowse";
            this.btbBrowse.Size = new System.Drawing.Size(45, 28);
            this.btbBrowse.TabIndex = 3;
            this.btbBrowse.Text = "...";
            this.btbBrowse.UseVisualStyleBackColor = true;
            this.btbBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSciezka4
            // 
            this.lblSciezka4.AutoSize = true;
            this.lblSciezka4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSciezka4.Location = new System.Drawing.Point(6, 180);
            this.lblSciezka4.Name = "lblSciezka4";
            this.lblSciezka4.Size = new System.Drawing.Size(196, 20);
            this.lblSciezka4.TabIndex = 9;
            this.lblSciezka4.Text = "Scieżka pliku danych 4:";
            this.lblSciezka4.Visible = false;
            this.lblSciezka4.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSciezkaPliku4
            // 
            this.txtSciezkaPliku4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSciezkaPliku4.Location = new System.Drawing.Point(208, 180);
            this.txtSciezkaPliku4.Name = "txtSciezkaPliku4";
            this.txtSciezkaPliku4.Size = new System.Drawing.Size(215, 26);
            this.txtSciezkaPliku4.TabIndex = 4;
            this.txtSciezkaPliku4.Visible = false;
            // 
            // lblSciezka2
            // 
            this.lblSciezka2.AutoSize = true;
            this.lblSciezka2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSciezka2.Location = new System.Drawing.Point(6, 115);
            this.lblSciezka2.Name = "lblSciezka2";
            this.lblSciezka2.Size = new System.Drawing.Size(196, 20);
            this.lblSciezka2.TabIndex = 9;
            this.lblSciezka2.Text = "Scieżka pliku danych 2:";
            this.lblSciezka2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSciezka3
            // 
            this.lblSciezka3.AutoSize = true;
            this.lblSciezka3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSciezka3.Location = new System.Drawing.Point(6, 148);
            this.lblSciezka3.Name = "lblSciezka3";
            this.lblSciezka3.Size = new System.Drawing.Size(196, 20);
            this.lblSciezka3.TabIndex = 9;
            this.lblSciezka3.Text = "Scieżka pliku danych 3:";
            this.lblSciezka3.Visible = false;
            this.lblSciezka3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSciezkaPliku2
            // 
            this.txtSciezkaPliku2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSciezkaPliku2.Location = new System.Drawing.Point(208, 115);
            this.txtSciezkaPliku2.Name = "txtSciezkaPliku2";
            this.txtSciezkaPliku2.Size = new System.Drawing.Size(215, 26);
            this.txtSciezkaPliku2.TabIndex = 4;
            // 
            // txtSciezkaPliku3
            // 
            this.txtSciezkaPliku3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSciezkaPliku3.Location = new System.Drawing.Point(208, 148);
            this.txtSciezkaPliku3.Name = "txtSciezkaPliku3";
            this.txtSciezkaPliku3.Size = new System.Drawing.Size(215, 26);
            this.txtSciezkaPliku3.TabIndex = 2;
            this.txtSciezkaPliku3.Visible = false;
            // 
            // ofdSciezkaPliku1
            // 
            this.ofdSciezkaPliku1.FileName = "openFileDialog1";
            // 
            // frmWykres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 807);
            this.Controls.Add(this.grbMenu);
            this.Controls.Add(this.crtWykresy);
            this.Name = "frmWykres";
            this.Text = "Wykres";
            ((System.ComponentModel.ISupportInitialize)(this.crtWykresy)).EndInit();
            this.grbMenu.ResumeLayout(false);
            this.grbMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIleKrzywych)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart crtWykresy;
        private System.Windows.Forms.TextBox txtSciezkaPliku1;
        private System.Windows.Forms.Label lblSciezka1;
        private System.Windows.Forms.Button btnWczytajDane;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.GroupBox grbMenu;
        private System.Windows.Forms.Label lblSciezka2;
        private System.Windows.Forms.TextBox txtSciezkaPliku2;
        private System.Windows.Forms.Button btbBrowse;
        private System.Windows.Forms.Button btnPodglad;
        private System.Windows.Forms.Label lblNumerWiersza;
        private System.Windows.Forms.TextBox txtNumerWiersza;
        private System.Windows.Forms.OpenFileDialog ofdSciezkaPliku1;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.Button btnParametry;
        private System.Windows.Forms.Label lblSciezka4;
        private System.Windows.Forms.TextBox txtSciezkaPliku4;
        private System.Windows.Forms.Label lblSciezka3;
        private System.Windows.Forms.TextBox txtSciezkaPliku3;
        private System.Windows.Forms.Button btnBrowse3;
        private System.Windows.Forms.Button btnBrowse4;
        private System.Windows.Forms.NumericUpDown numIleKrzywych;
        private System.Windows.Forms.Label lblIleKrzywych;
        private System.Windows.Forms.TextBox txtDelta4;
        private System.Windows.Forms.TextBox txtDelta3;
        private System.Windows.Forms.TextBox txtDelta2;
        private System.Windows.Forms.TextBox txtDelta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProbkowanie4;
        private System.Windows.Forms.TextBox txtProbkowanie3;
        private System.Windows.Forms.TextBox txtProbkowanie2;
        private System.Windows.Forms.TextBox txtProbkowanie1;
        private System.Windows.Forms.Label tltKrok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGruboscWarstwyPalnej;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCisnienieZaplonu;
        private System.Windows.Forms.CheckBox chbEksport4;
        private System.Windows.Forms.CheckBox chbEksport3;
        private System.Windows.Forms.CheckBox chbEksport2;
        private System.Windows.Forms.CheckBox chbEksport1;
        private System.Windows.Forms.Button btnPomoc;
    }
}