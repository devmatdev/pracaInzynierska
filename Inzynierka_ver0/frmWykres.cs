using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;
using System.IO;

namespace Inzynierka_ver0
{

    public partial class frmWykres : Form
    {
        public static double CisnienieMaksymalne1 { get; private set; }
        public static double CisnienieMaksymalne2 { get; private set; }
        public static double CisnienieMaksymalne3 { get; private set; }
        public static double CisnienieMaksymalne4 { get; private set; }
        public static double CisnienieMaksymalne1skorygowane { get; private set; }
        public static double CisnienieMaksymalne2skorygowane { get; private set; }
        public static double CisnienieMaksymalne3skorygowane { get; private set; }
        public static double CisnienieMaksymalne4skorygowane { get; private set; }
        public static double Tr1 { get; private set; }
        public static double Tr2 { get; private set; }
        public static double Tr3 { get; private set; }
        public static double Tr4 { get; private set; }
        public static double Tq { get; private set; }
        public static double Ah { get; private set; }
        public static double Alfa { get; private set; }
        public static double F { get; private set; }
        public static double U1 { get; private set; }
        public static double U2 { get; private set; }
        public static double U3 { get; private set; }
        public static double U4 { get; private set; }
        public static double USrednia { get; private set; }
        public static double Th1 { get; private set; }
        public static double Th2 { get; private set; }
        public static double Th3 { get; private set; }
        public static double Th4 { get; private set; }


        double _zamianaPaNaMpa = 0.000001;
        public frmWykres()
        {
            InitializeComponent();

        }


        private void chartWykres_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWczytajDane_Click(object sender, EventArgs e)
        {
            btnParametry.Enabled = true;
            string sciezkaPliku1 = txtSciezkaPliku1.Text;
            int numerWierszaDanych = Convert.ToInt32(txtNumerWiersza.Text);
            double[] daneKonw = Funkcja.WczytajDane(sciezkaPliku1, numerWierszaDanych);
            double eJeden = Convert.ToDouble(txtGruboscWarstwyPalnej.Text);
            double cisnienieZaplonu = Convert.ToDouble(txtCisnienieZaplonu.Text);
            double indexPunktZaplonu = Funkcja.PunktZaplonu(Wybor.index, daneKonw, cisnienieZaplonu);
            double wartoscPunktZaplonu = Funkcja.PunktZaplonu(Wybor.wartosc, daneKonw, cisnienieZaplonu);

            double[] daneObrobione1 = Funkcja.ObrobkaDanych(daneKonw, Convert.ToInt32(indexPunktZaplonu), wartoscPunktZaplonu);
            double indexMax = Array.IndexOf(daneObrobione1, Funkcja.Maximum(daneObrobione1));
            double[] osX1 = Funkcja.osX(daneObrobione1, Convert.ToDouble(txtProbkowanie1.Text));
            double pmax = Funkcja.Maximum(daneObrobione1);
            double delta = Convert.ToDouble(txtDelta.Text);

            double indexPunktK = Funkcja.PunktK(Wybor.index, daneObrobione1);
            double wartoscPunktK = Funkcja.PunktK(Wybor.wartosc, daneObrobione1);

            double id = Funkcja.LiczCalkeMetodaProstokatow(Convert.ToInt32(indexMax), Convert.ToInt32(indexPunktK), osX1, daneObrobione1);
            double tr = Funkcja.LiczTr(id, pmax, wartoscPunktK);

            double[] osXwMs = new double[osX1.Length];
            osXwMs = Funkcja.ZmianaWartosciDoWykresu(WyborOsi.osX, osX1);
            crtWykresy.Series["Pomiary"].Points.DataBindXY(osXwMs, Funkcja.ZmianaWartosciDoWykresu(WyborOsi.osY, daneObrobione1));

            if (numIleKrzywych.Value == 2)
            {
                string sciezkaPliku2 = txtSciezkaPliku2.Text;
                double[] daneKonw2 = Funkcja.WczytajDane(sciezkaPliku2, numerWierszaDanych);

                double indexPunktZaplonu2 = Funkcja.PunktZaplonu(Wybor.index, daneKonw2, cisnienieZaplonu);
                double wartoscPunktZaplonu2 = Funkcja.PunktZaplonu(Wybor.wartosc, daneKonw2, cisnienieZaplonu);

                double[] daneObrobione2 = Funkcja.ObrobkaDanych(daneKonw2, Convert.ToInt32(indexPunktZaplonu2), wartoscPunktZaplonu2);
                double indexMax2 = Array.IndexOf(daneObrobione2, Funkcja.Maximum(daneObrobione2));
                double[] osX2 = Funkcja.osX(daneObrobione2, Convert.ToDouble(txtProbkowanie2.Text));

                double pmax2 = Funkcja.Maximum(daneObrobione2);

                double indexPunktK2 = Funkcja.PunktK(Wybor.index, daneObrobione2);
                double wartoscPunktK2 = Funkcja.PunktK(Wybor.wartosc, daneObrobione2);

                double id2 = Funkcja.LiczCalkeMetodaProstokatow(Convert.ToInt32(indexMax2), Convert.ToInt32(indexPunktK2), osX2, daneObrobione2);
                double tr2 = Funkcja.LiczTr(id2, pmax2, wartoscPunktK2);

                double[] osXwMs2 = new double[osX2.Length];
                osXwMs2 = Funkcja.ZmianaWartosciDoWykresu(WyborOsi.osX, osX2);
                crtWykresy.Series["Pomiary2"].Points.DataBindXY(osXwMs2, Funkcja.ZmianaWartosciDoWykresu(WyborOsi.osY, daneObrobione2));

                //korekcja krzywej cisnienia

                var trTab = new double[Convert.ToInt32(numIleKrzywych.Value)];
                trTab[0] = tr;
                trTab[1] = tr2;

                var deltaTab = new double[Convert.ToInt32(numIleKrzywych.Value)];
                deltaTab[0] = Convert.ToDouble(txtDelta.Text);
                deltaTab[1] = Convert.ToDouble(txtDelta2.Text);

                double ah = Funkcja.RegresjaLiniowa(WyborRegresja.a, trTab, deltaTab);
                double tq = Funkcja.RegresjaLiniowa(WyborRegresja.b, trTab, deltaTab);

                //Korekcja dla 1 krzywej

                double th1 = Funkcja.LiczTh(delta, ah);
                double[] skorygowanaWartoscCisnienia1 = new double[daneObrobione1.Length];
                skorygowanaWartoscCisnienia1 = Funkcja.KorekcjaKrzywejCisnienia(daneObrobione1, osX1, tr);

                crtWykresy.Series["SkorygowanePomiary"].Points.DataBindXY(osXwMs, Funkcja.ZmianaWartosciDoWykresu(WyborOsi.osY, skorygowanaWartoscCisnienia1));

                //Korekcja dla 2 krzywej
                double th2 = Funkcja.LiczTh(deltaTab[1], ah);

                double[] skorygowanaWartoscCisnienia2 = new double[daneObrobione2.Length];
                skorygowanaWartoscCisnienia2 = Funkcja.KorekcjaKrzywejCisnienia(daneObrobione2, osX2, tr2);
                crtWykresy.Series["SkorygowanePomiary2"].Points.DataBindXY(osXwMs2, Funkcja.ZmianaWartosciDoWykresu(WyborOsi.osY, skorygowanaWartoscCisnienia2));

                //Liniowe prawo spalania
                double pmax1skorygowane = Funkcja.Maximum(skorygowanaWartoscCisnienia1);
                double pmax2skorygowane = Funkcja.Maximum(skorygowanaWartoscCisnienia2);
                double pk1skorygowane = Funkcja.PunktK(Wybor.wartosc, skorygowanaWartoscCisnienia1);
                double pk2skorygowane = Funkcja.PunktK(Wybor.wartosc, skorygowanaWartoscCisnienia2);

                var pmaxTab = new double[Convert.ToInt32(numIleKrzywych.Value)];
                pmaxTab[0] = pmax1skorygowane;
                pmaxTab[1] = pmax2skorygowane;
                var pmaxPrzezDeltaTab = new double[Convert.ToInt32(numIleKrzywych.Value)];
                pmaxPrzezDeltaTab[0] = pmax1skorygowane / deltaTab[0];
                pmaxPrzezDeltaTab[1] = pmax2skorygowane / deltaTab[1];

                double alfa = Funkcja.RegresjaLiniowa2(WyborRegresja.a, pmaxPrzezDeltaTab, pmaxTab);
                double f = Funkcja.RegresjaLiniowa2(WyborRegresja.b, pmaxPrzezDeltaTab, pmaxTab);
                double[] u1Tab = new double[Convert.ToInt32(numIleKrzywych.Value)];
                u1Tab[0] = Funkcja.LiczU1(skorygowanaWartoscCisnienia1, osX1, eJeden);
                u1Tab[1] = Funkcja.LiczU1(skorygowanaWartoscCisnienia2, osX2, eJeden);
                double u1Srednia = Funkcja.SredniaU1(u1Tab);

                //ustawianie parametrow
                Tq = tq;
                Ah = ah;
                Alfa = alfa;
                F = f;
                USrednia = u1Srednia;
                CisnienieMaksymalne1 = pmax * _zamianaPaNaMpa;
                CisnienieMaksymalne2 = pmax2 * _zamianaPaNaMpa;
                CisnienieMaksymalne1skorygowane = pmax1skorygowane * _zamianaPaNaMpa;
                CisnienieMaksymalne2skorygowane = pmax2skorygowane * _zamianaPaNaMpa;
                Tr1 = tr;
                Tr2 = tr2;
                U1 = u1Tab[0];
                U2 = u1Tab[1];
                Th1 = th1;
                Th2 = th2;

                //zapisywanie do pliku
                if (chbEksport1.Checked == true)
                {
                    Funkcja.ZapiszDaneDoPliku("sciezka1.txt", skorygowanaWartoscCisnienia1);
                }
                if (chbEksport2.Checked == true)
                {
                    Funkcja.ZapiszDaneDoPliku("sciezka2.txt", skorygowanaWartoscCisnienia2);
                }
            }
            else if (numIleKrzywych.Value == 3)
            {
                //2 krzywa

                string sciezkaPliku2 = txtSciezkaPliku2.Text;
                double[] daneKonw2 = Funkcja.WczytajDane(sciezkaPliku2, numerWierszaDanych);

                double indexPunktZaplonu2 = Funkcja.PunktZaplonu(Wybor.index, daneKonw2, cisnienieZaplonu);
                double wartoscPunktZaplonu2 = Funkcja.PunktZaplonu(Wybor.wartosc, daneKonw2, cisnienieZaplonu);

                double[] daneObrobione2 = Funkcja.ObrobkaDanych(daneKonw2, Convert.ToInt32(indexPunktZaplonu2), wartoscPunktZaplonu2);
                double indexMax2 = Array.IndexOf(daneObrobione2, Funkcja.Maximum(daneObrobione2));
                double[] osX2 = Funkcja.osX(daneObrobione2, Convert.ToDouble(txtProbkowanie2.Text));

                double pmax2 = Funkcja.Maximum(daneObrobione2);

                double indexPunktK2 = Funkcja.PunktK(Wybor.index, daneObrobione2);
                double wartoscPunktK2 = Funkcja.PunktK(Wybor.wartosc, daneObrobione2);

                double id2 = Funkcja.LiczCalkeMetodaProstokatow(Convert.ToInt32(indexMax2), Convert.ToInt32(indexPunktK2), osX2, daneObrobione2);
                double tr2 = Funkcja.LiczTr(id2, pmax2, wartoscPunktK2);

                double[] osXwMs2 = new double[osX2.Length];
                osXwMs2 = Funkcja.ZmianaWartosciDoWykresu(WyborOsi.osX, osX2);
                crtWykresy.Series["Pomiary2"].Points.DataBindXY(osXwMs2, Funkcja.ZmianaWartosciDoWykresu(WyborOsi.osY, daneObrobione2));


                // 3 krzywa

                string sciezkaPliku3 = txtSciezkaPliku3.Text;
                double[] daneKonw3 = Funkcja.WczytajDane(sciezkaPliku3, numerWierszaDanych);

                double indexPunktZaplonu3 = Funkcja.PunktZaplonu(Wybor.index, daneKonw3, cisnienieZaplonu);
                double wartoscPunktZaplonu3 = Funkcja.PunktZaplonu(Wybor.wartosc, daneKonw3, cisnienieZaplonu);

                double[] daneObrobione3 = Funkcja.ObrobkaDanych(daneKonw3, Convert.ToInt32(indexPunktZaplonu3), wartoscPunktZaplonu3);
                double indexMax3 = Array.IndexOf(daneObrobione3, Funkcja.Maximum(daneObrobione3));
                double[] osX3 = Funkcja.osX(daneObrobione3, Convert.ToDouble(txtProbkowanie3.Text));

                double pmax3 = Funkcja.Maximum(daneObrobione3);


                double indexPunktK3 = Funkcja.PunktK(Wybor.index, daneObrobione3);
                double wartoscPunktK3 = Funkcja.PunktK(Wybor.wartosc, daneObrobione3);



                double id3 = Funkcja.LiczCalkeMetodaProstokatow(Convert.ToInt32(indexMax3), Convert.ToInt32(indexPunktK3), osX3, daneObrobione3);
                double tr3 = Funkcja.LiczTr(id3, pmax3, wartoscPunktK3);

                double[] osXwMs3 = new double[osX3.Length];
                osXwMs3 = Funkcja.ZmianaWartosciDoWykresu(WyborOsi.osX, osX3);
                crtWykresy.Series["Pomiary3"].Points.DataBindXY(osXwMs3, Funkcja.ZmianaWartosciDoWykresu(WyborOsi.osY, daneObrobione3));

                //korekcja krzywej cisnienia

                var trTab = new double[Convert.ToInt32(numIleKrzywych.Value)];
                trTab[0] = tr;
                trTab[1] = tr2;
                trTab[2] = tr3;

                var deltaTab = new double[Convert.ToInt32(numIleKrzywych.Value)];
                deltaTab[0] = Convert.ToDouble(txtDelta.Text);
                deltaTab[1] = Convert.ToDouble(txtDelta2.Text);
                deltaTab[2] = Convert.ToDouble(txtDelta3.Text);

                double ah = Funkcja.RegresjaLiniowa(WyborRegresja.a, trTab, deltaTab);
                double tq = Funkcja.RegresjaLiniowa(WyborRegresja.b, trTab, deltaTab);

                //Korekcja dla 1 krzywej

                double th1 = Funkcja.LiczTh(delta, ah);
                double[] skorygowanaWartoscCisnienia1 = new double[daneObrobione1.Length];
                skorygowanaWartoscCisnienia1 = Funkcja.KorekcjaKrzywejCisnienia(daneObrobione1, osX1, tr);
                crtWykresy.Series["SkorygowanePomiary"].Points.DataBindXY(osXwMs, Funkcja.ZmianaWartosciDoWykresu(WyborOsi.osY, skorygowanaWartoscCisnienia1));

                //Korekcja dla 2 krzywej

                double th2 = Funkcja.LiczTh(deltaTab[1], ah);
                double[] skorygowanaWartoscCisnienia2 = new double[daneObrobione2.Length];
                skorygowanaWartoscCisnienia2 = Funkcja.KorekcjaKrzywejCisnienia(daneObrobione2, osX2, tr2);
                crtWykresy.Series["SkorygowanePomiary2"].Points.DataBindXY(osXwMs2, Funkcja.ZmianaWartosciDoWykresu(WyborOsi.osY, skorygowanaWartoscCisnienia2));

                //Korekcja dla 3 krzywej

                double th3 = Funkcja.LiczTh(deltaTab[2], ah);
                double[] skorygowanaWartoscCisnienia3 = new double[daneObrobione3.Length];
                skorygowanaWartoscCisnienia3 = Funkcja.KorekcjaKrzywejCisnienia(daneObrobione3, osX3, tr3);
                crtWykresy.Series["SkorygowanePomiary3"].Points.DataBindXY(osXwMs3, Funkcja.ZmianaWartosciDoWykresu(WyborOsi.osY, skorygowanaWartoscCisnienia3));

                //Liniowe prawo spalania
                double pmax1skorygowane = Funkcja.Maximum(skorygowanaWartoscCisnienia1);
                double pmax2skorygowane = Funkcja.Maximum(skorygowanaWartoscCisnienia2);
                double pmax3skorygowane = Funkcja.Maximum(skorygowanaWartoscCisnienia3);
                double pk1skorygowane = Funkcja.PunktK(Wybor.wartosc, skorygowanaWartoscCisnienia1);
                double pk2skorygowane = Funkcja.PunktK(Wybor.wartosc, skorygowanaWartoscCisnienia2);
                double pk3skorygowane = Funkcja.PunktK(Wybor.wartosc, skorygowanaWartoscCisnienia3);

                var pmaxTab = new double[Convert.ToInt32(numIleKrzywych.Value)];
                pmaxTab[0] = pmax1skorygowane;
                pmaxTab[1] = pmax2skorygowane;
                pmaxTab[2] = pmax3skorygowane;

                var pmaxPrzezDeltaTab = new double[Convert.ToInt32(numIleKrzywych.Value)];
                pmaxPrzezDeltaTab[0] = pmax1skorygowane / deltaTab[0];
                pmaxPrzezDeltaTab[1] = pmax2skorygowane / deltaTab[1];
                pmaxPrzezDeltaTab[2] = pmax3skorygowane / deltaTab[2];

                double alfa = Funkcja.RegresjaLiniowa2(WyborRegresja.a, pmaxPrzezDeltaTab, pmaxTab);
                double f = Funkcja.RegresjaLiniowa2(WyborRegresja.b, pmaxPrzezDeltaTab, pmaxTab);
                double[] u1Tab = new double[Convert.ToInt32(numIleKrzywych.Value)];
                u1Tab[0] = Funkcja.LiczU1(skorygowanaWartoscCisnienia1, osX1, eJeden);
                u1Tab[1] = Funkcja.LiczU1(skorygowanaWartoscCisnienia2, osX2, eJeden);
                u1Tab[2] = Funkcja.LiczU1(skorygowanaWartoscCisnienia3, osX3, eJeden);
                double u1Srednia = Funkcja.SredniaU1(u1Tab);

                //ustawianie parametrow
                Tq = tq;
                Ah = ah;
                Alfa = alfa;
                F = f;
                USrednia = u1Srednia;
                CisnienieMaksymalne1 = pmax * _zamianaPaNaMpa;
                CisnienieMaksymalne2 = pmax2 * _zamianaPaNaMpa;
                CisnienieMaksymalne3 = pmax3 * _zamianaPaNaMpa;
                CisnienieMaksymalne1skorygowane = pmax1skorygowane * _zamianaPaNaMpa;
                CisnienieMaksymalne2skorygowane = pmax2skorygowane * _zamianaPaNaMpa;
                CisnienieMaksymalne3skorygowane = pmax3skorygowane * _zamianaPaNaMpa;
                Tr1 = tr;
                Tr2 = tr2;
                Tr3 = tr3;
                U1 = u1Tab[0];
                U2 = u1Tab[1];
                U3 = u1Tab[2];
                Th1 = th1;
                Th2 = th2;
                Th3 = th3;

                //zapisywanie do pliku
                if (chbEksport1.Checked == true)
                {
                    Funkcja.ZapiszDaneDoPliku("sciezka1.txt", skorygowanaWartoscCisnienia1);
                }
                if (chbEksport2.Checked == true)
                {
                    Funkcja.ZapiszDaneDoPliku("sciezka2.txt", skorygowanaWartoscCisnienia2);
                }
                if (chbEksport3.Checked == true)
                {
                    Funkcja.ZapiszDaneDoPliku("sciezka3.txt", skorygowanaWartoscCisnienia3);
                }
            }
            else if (numIleKrzywych.Value == 4)
            {
                //2 krzywa

                string sciezkaPliku2 = txtSciezkaPliku2.Text;
                double[] daneKonw2 = Funkcja.WczytajDane(sciezkaPliku2, numerWierszaDanych);

                double indexPunktZaplonu2 = Funkcja.PunktZaplonu(Wybor.index, daneKonw2, cisnienieZaplonu);
                double wartoscPunktZaplonu2 = Funkcja.PunktZaplonu(Wybor.wartosc, daneKonw2, cisnienieZaplonu);

                double[] daneObrobione2 = Funkcja.ObrobkaDanych(daneKonw2, Convert.ToInt32(indexPunktZaplonu2), wartoscPunktZaplonu2);
                double indexMax2 = Array.IndexOf(daneObrobione2, Funkcja.Maximum(daneObrobione2));
                double[] osX2 = Funkcja.osX(daneObrobione2, Convert.ToDouble(txtProbkowanie2.Text));

                double pmax2 = Funkcja.Maximum(daneObrobione2);

                double indexPunktK2 = Funkcja.PunktK(Wybor.index, daneObrobione2);
                double wartoscPunktK2 = Funkcja.PunktK(Wybor.wartosc, daneObrobione2);

                double id2 = Funkcja.LiczCalkeMetodaProstokatow(Convert.ToInt32(indexMax2), Convert.ToInt32(indexPunktK2), osX2, daneObrobione2);
                double tr2 = Funkcja.LiczTr(id2, pmax2, wartoscPunktK2);

                double[] osXwMs2 = new double[osX2.Length];
                osXwMs2 = Funkcja.ZmianaWartosciDoWykresu(WyborOsi.osX, osX2);
                crtWykresy.Series["Pomiary2"].Points.DataBindXY(osXwMs2, Funkcja.ZmianaWartosciDoWykresu(WyborOsi.osY, daneObrobione2));


                // 3 krzywa

                string sciezkaPliku3 = txtSciezkaPliku3.Text;
                double[] daneKonw3 = Funkcja.WczytajDane(sciezkaPliku3, numerWierszaDanych);

                double indexPunktZaplonu3 = Funkcja.PunktZaplonu(Wybor.index, daneKonw3, cisnienieZaplonu);
                double wartoscPunktZaplonu3 = Funkcja.PunktZaplonu(Wybor.wartosc, daneKonw3, cisnienieZaplonu);

                double[] daneObrobione3 = Funkcja.ObrobkaDanych(daneKonw3, Convert.ToInt32(indexPunktZaplonu3), wartoscPunktZaplonu3);
                double indexMax3 = Array.IndexOf(daneObrobione3, Funkcja.Maximum(daneObrobione3));
                double[] osX3 = Funkcja.osX(daneObrobione3, Convert.ToDouble(txtProbkowanie3.Text));

                double pmax3 = Funkcja.Maximum(daneObrobione3);


                double indexPunktK3 = Funkcja.PunktK(Wybor.index, daneObrobione3);
                double wartoscPunktK3 = Funkcja.PunktK(Wybor.wartosc, daneObrobione3);



                double id3 = Funkcja.LiczCalkeMetodaProstokatow(Convert.ToInt32(indexMax3), Convert.ToInt32(indexPunktK3), osX3, daneObrobione3);
                double tr3 = Funkcja.LiczTr(id3, pmax3, wartoscPunktK3);

                double[] osXwMs3 = new double[osX3.Length];
                osXwMs3 = Funkcja.ZmianaWartosciDoWykresu(WyborOsi.osX, osX3);
                crtWykresy.Series["Pomiary3"].Points.DataBindXY(osXwMs3, Funkcja.ZmianaWartosciDoWykresu(WyborOsi.osY, daneObrobione3));

                //4 krzywa

                string sciezkaPliku4 = txtSciezkaPliku4.Text;
                double[] daneKonw4 = Funkcja.WczytajDane(sciezkaPliku4, numerWierszaDanych);

                double indexPunktZaplonu4 = Funkcja.PunktZaplonu(Wybor.index, daneKonw4, cisnienieZaplonu);
                double wartoscPunktZaplonu4 = Funkcja.PunktZaplonu(Wybor.wartosc, daneKonw4, cisnienieZaplonu);

                double[] daneObrobione4 = Funkcja.ObrobkaDanych(daneKonw4, Convert.ToInt32(indexPunktZaplonu4), wartoscPunktZaplonu4);
                double indexMax4 = Array.IndexOf(daneObrobione4, Funkcja.Maximum(daneObrobione4));
                double[] osX4 = Funkcja.osX(daneObrobione4, Convert.ToDouble(txtProbkowanie4.Text));

                double pmax4 = Funkcja.Maximum(daneObrobione4);

                double indexPunktK4 = Funkcja.PunktK(Wybor.index, daneObrobione4);
                double wartoscPunktK4 = Funkcja.PunktK(Wybor.wartosc, daneObrobione4);

                double id4 = Funkcja.LiczCalkeMetodaProstokatow(Convert.ToInt32(indexMax4), Convert.ToInt32(indexPunktK4), osX4, daneObrobione4);
                double tr4 = Funkcja.LiczTr(id4, pmax4, wartoscPunktK4);

                double[] osXwMs4 = new double[osX4.Length];
                osXwMs4 = Funkcja.ZmianaWartosciDoWykresu(WyborOsi.osX, osX4);
                crtWykresy.Series["Pomiary4"].Points.DataBindXY(osXwMs4, Funkcja.ZmianaWartosciDoWykresu(WyborOsi.osY, daneObrobione4));

                //korekcja krzywej cisnienia

                var trTab = new double[Convert.ToInt32(numIleKrzywych.Value)];
                trTab[0] = tr;
                trTab[1] = tr2;
                trTab[2] = tr3;
                trTab[3] = tr4;

                var deltaTab = new double[Convert.ToInt32(numIleKrzywych.Value)];
                deltaTab[0] = Convert.ToDouble(txtDelta.Text);
                deltaTab[1] = Convert.ToDouble(txtDelta2.Text);
                deltaTab[2] = Convert.ToDouble(txtDelta3.Text);
                deltaTab[3] = Convert.ToDouble(txtDelta4.Text);

                double ah = Funkcja.RegresjaLiniowa(WyborRegresja.a, trTab, deltaTab);
                double tq = Funkcja.RegresjaLiniowa(WyborRegresja.b, trTab, deltaTab);

                //Korekcja dla 1 krzywej

                double th1 = Funkcja.LiczTh(delta, ah);
                double[] skorygowanaWartoscCisnienia1 = new double[daneObrobione1.Length];
                skorygowanaWartoscCisnienia1 = Funkcja.KorekcjaKrzywejCisnienia(daneObrobione1, osX1, tr);
                crtWykresy.Series["SkorygowanePomiary"].Points.DataBindXY(osXwMs, Funkcja.ZmianaWartosciDoWykresu(WyborOsi.osY, skorygowanaWartoscCisnienia1));

                //Korekcja dla 2 krzywej

                double th2 = Funkcja.LiczTh(deltaTab[1], ah);
                double[] skorygowanaWartoscCisnienia2 = new double[daneObrobione2.Length];
                skorygowanaWartoscCisnienia2 = Funkcja.KorekcjaKrzywejCisnienia(daneObrobione2, osX2, tr2);
                crtWykresy.Series["SkorygowanePomiary2"].Points.DataBindXY(osXwMs2, Funkcja.ZmianaWartosciDoWykresu(WyborOsi.osY, skorygowanaWartoscCisnienia2));

                //Korekcja dla 3 krzywej

                double th3 = Funkcja.LiczTh(deltaTab[2], ah);
                double[] skorygowanaWartoscCisnienia3 = new double[daneObrobione3.Length];
                skorygowanaWartoscCisnienia3 = Funkcja.KorekcjaKrzywejCisnienia(daneObrobione3, osX3, tr3);
                crtWykresy.Series["SkorygowanePomiary3"].Points.DataBindXY(osXwMs3, Funkcja.ZmianaWartosciDoWykresu(WyborOsi.osY, skorygowanaWartoscCisnienia3));

                //Korekcja dla 4 krzywej

                double th4 = Funkcja.LiczTh(deltaTab[3], ah);
                double[] skorygowanaWartoscCisnienia4 = new double[daneObrobione4.Length];
                skorygowanaWartoscCisnienia4 = Funkcja.KorekcjaKrzywejCisnienia(daneObrobione4, osX4, tr4);
                crtWykresy.Series["SkorygowanePomiary4"].Points.DataBindXY(osXwMs4, Funkcja.ZmianaWartosciDoWykresu(WyborOsi.osY, skorygowanaWartoscCisnienia4));

                //Liniowe prawo spalania
                double pmax1skorygowane = Funkcja.Maximum(skorygowanaWartoscCisnienia1);
                double pmax2skorygowane = Funkcja.Maximum(skorygowanaWartoscCisnienia2);
                double pmax3skorygowane = Funkcja.Maximum(skorygowanaWartoscCisnienia3);
                double pmax4skorygowane = Funkcja.Maximum(skorygowanaWartoscCisnienia4);
                double pk1skorygowane = Funkcja.PunktK(Wybor.wartosc, skorygowanaWartoscCisnienia1);
                double pk2skorygowane = Funkcja.PunktK(Wybor.wartosc, skorygowanaWartoscCisnienia2);
                double pk3skorygowane = Funkcja.PunktK(Wybor.wartosc, skorygowanaWartoscCisnienia3);
                double pk4skorygowane = Funkcja.PunktK(Wybor.wartosc, skorygowanaWartoscCisnienia4);

                var pmaxTab = new double[Convert.ToInt32(numIleKrzywych.Value)];
                pmaxTab[0] = pmax1skorygowane;
                pmaxTab[1] = pmax2skorygowane;
                pmaxTab[2] = pmax3skorygowane;
                pmaxTab[3] = pmax4skorygowane;


                var pmaxPrzezDeltaTab = new double[Convert.ToInt32(numIleKrzywych.Value)];
                pmaxPrzezDeltaTab[0] = pmax1skorygowane / deltaTab[0];
                pmaxPrzezDeltaTab[1] = pmax2skorygowane / deltaTab[1];
                pmaxPrzezDeltaTab[2] = pmax3skorygowane / deltaTab[2];
                pmaxPrzezDeltaTab[3] = pmax4skorygowane / deltaTab[3];


                double alfa = Funkcja.RegresjaLiniowa2(WyborRegresja.a, pmaxPrzezDeltaTab, pmaxTab);
                double f = Funkcja.RegresjaLiniowa2(WyborRegresja.b, pmaxPrzezDeltaTab, pmaxTab);
                double[] u1Tab = new double[Convert.ToInt32(numIleKrzywych.Value)];
                u1Tab[0] = Funkcja.LiczU1(skorygowanaWartoscCisnienia1, osX1, eJeden);
                u1Tab[1] = Funkcja.LiczU1(skorygowanaWartoscCisnienia2, osX2, eJeden);
                u1Tab[2] = Funkcja.LiczU1(skorygowanaWartoscCisnienia3, osX3, eJeden);
                u1Tab[3] = Funkcja.LiczU1(skorygowanaWartoscCisnienia4, osX4, eJeden);
                double u1Srednia = Funkcja.SredniaU1(u1Tab);

                //ustawianie parametrow
                Tq = tq;
                Ah = ah;
                Alfa = alfa;
                F = f;
                USrednia = u1Srednia;
                CisnienieMaksymalne1 = pmax * _zamianaPaNaMpa;
                CisnienieMaksymalne2 = pmax2 * _zamianaPaNaMpa;
                CisnienieMaksymalne3 = pmax3 * _zamianaPaNaMpa;
                CisnienieMaksymalne4 = pmax4 * _zamianaPaNaMpa;
                CisnienieMaksymalne1skorygowane = pmax1skorygowane * _zamianaPaNaMpa;
                CisnienieMaksymalne2skorygowane = pmax2skorygowane * _zamianaPaNaMpa;
                CisnienieMaksymalne3skorygowane = pmax3skorygowane * _zamianaPaNaMpa;
                CisnienieMaksymalne4skorygowane = pmax4skorygowane * _zamianaPaNaMpa;
                Tr1 = tr;
                Tr2 = tr2;
                Tr3 = tr3;
                Tr4 = tr4;
                U1 = u1Tab[0];
                U2 = u1Tab[1];
                U3 = u1Tab[2];
                U4 = u1Tab[3];
                Th1 = th1;
                Th2 = th2;
                Th3 = th3;
                Th4 = th4;
                //zapisywanie do pliku
                if (chbEksport1.Checked == true)
                {
                    Funkcja.ZapiszDaneDoPliku("sciezka1.txt", skorygowanaWartoscCisnienia1);
                }
                if (chbEksport2.Checked == true)
                {
                    Funkcja.ZapiszDaneDoPliku("sciezka2.txt", skorygowanaWartoscCisnienia2);
                }
                if (chbEksport3.Checked == true)
                {
                    Funkcja.ZapiszDaneDoPliku("sciezka3.txt", skorygowanaWartoscCisnienia3);
                }
                if (chbEksport4.Checked == true)
                {
                    Funkcja.ZapiszDaneDoPliku("sciezka4.txt", skorygowanaWartoscCisnienia4);
                }
            }



        }
        private void button1_Click(object sender, EventArgs e)
        {
            ofdSciezkaPliku1.ShowDialog();
            txtSciezkaPliku1.Text = ofdSciezkaPliku1.FileName;
        }

        private void btnPodglad_Click(object sender, EventArgs e)
        {
            frmPodglad frmPodglad = new frmPodglad();
            frmPodglad.Show();
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            ofdSciezkaPliku1.ShowDialog();
            txtSciezkaPliku2.Text = ofdSciezkaPliku1.FileName;
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            ofdSciezkaPliku1.ShowDialog();
            txtSciezkaPliku3.Text = ofdSciezkaPliku1.FileName;
        }
        private void btnBrowse4_Click(object sender, EventArgs e)
        {
            ofdSciezkaPliku1.ShowDialog();
            txtSciezkaPliku4.Text = ofdSciezkaPliku1.FileName;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmParametry frmParametry = new frmParametry();

            frmParametry.Show();

        }



        private void numIleKrzywych_ValueChanged(object sender, EventArgs e)
        {
            numIleKrzywych.Maximum = 4;
            numIleKrzywych.Minimum = 2;
            /*  if(numIleKrzywych.Value== 1)
              {
                  lblSciezka2.Visible = false; txtSciezkaPliku2.Visible = false; txtSciezkaPliku2.Text = null;  btnBrowse2.Visible = false; txtDelta2.Visible = false; txtDelta2.Text = null;
                  lblSciezka3.Visible = false; txtSciezkaPliku3.Visible = false; txtSciezkaPliku3.Text = null;  btnBrowse3.Visible = false; txtDelta3.Visible = false; txtDelta3.Text = null;
                  lblSciezka4.Visible = false; txtSciezkaPliku4.Visible = false; txtSciezkaPliku4.Text = null;  btnBrowse4.Visible = false; txtDelta4.Visible = false; txtDelta4.Text = null;
                  txtProbkowanie2.Visible = false; txtProbkowanie2.Text = null;
                  txtProbkowanie3.Visible = false; txtProbkowanie3.Text = null;
                  txtProbkowanie4.Visible = false; txtProbkowanie4.Text = null;
                  chbEksport2.Visible = false; chbEksport2.Checked = false;
                  chbEksport3.Visible = false; chbEksport3.Checked = false;
                  chbEksport4.Visible = false; chbEksport4.Checked = false;
              }
            */
            if (numIleKrzywych.Value == 2)
            {
                lblSciezka2.Visible = true; txtSciezkaPliku2.Visible = true; btnBrowse2.Visible = true; txtDelta2.Visible = true;
                lblSciezka3.Visible = false; txtSciezkaPliku3.Visible = false; txtSciezkaPliku3.Text = null; btnBrowse3.Visible = false; txtDelta3.Visible = false; txtDelta3.Text = null;
                lblSciezka4.Visible = false; txtSciezkaPliku4.Visible = false; txtSciezkaPliku4.Text = null; btnBrowse4.Visible = false; txtDelta4.Visible = false; txtDelta4.Text = null;
                txtProbkowanie2.Visible = true;
                txtProbkowanie3.Visible = false; txtProbkowanie3.Text = null;
                txtProbkowanie4.Visible = false; txtProbkowanie4.Text = null;
                chbEksport2.Visible = true;
                chbEksport3.Visible = false; chbEksport3.Checked = false;
                chbEksport4.Visible = false; chbEksport4.Checked = false;
            }
            else if (numIleKrzywych.Value == 3)
            {
                lblSciezka2.Visible = true; txtSciezkaPliku2.Visible = true; btnBrowse2.Visible = true; txtDelta2.Visible = true;
                lblSciezka3.Visible = true; txtSciezkaPliku3.Visible = true; btnBrowse3.Visible = true; txtDelta3.Visible = true;
                lblSciezka4.Visible = false; txtSciezkaPliku4.Visible = false; txtSciezkaPliku4.Text = null; btnBrowse4.Visible = false; txtDelta4.Visible = false; txtDelta4.Text = null;
                txtProbkowanie2.Visible = true;
                txtProbkowanie3.Visible = true;
                txtProbkowanie4.Visible = false; txtProbkowanie4.Text = null;
                chbEksport2.Visible = true;
                chbEksport3.Visible = true;
                chbEksport4.Visible = false; chbEksport4.Checked = false;
            }
            else if (numIleKrzywych.Value == 4)
            {
                lblSciezka2.Visible = true; txtSciezkaPliku2.Visible = true; btnBrowse2.Visible = true; txtDelta2.Visible = true;
                lblSciezka3.Visible = true; txtSciezkaPliku3.Visible = true; btnBrowse3.Visible = true; txtDelta3.Visible = true;
                lblSciezka4.Visible = true; txtSciezkaPliku4.Visible = true; btnBrowse4.Visible = true; txtDelta4.Visible = true;
                txtProbkowanie2.Visible = true;
                txtProbkowanie3.Visible = true;
                txtProbkowanie4.Visible = true;
                chbEksport2.Visible = true;
                chbEksport3.Visible = true;
                chbEksport4.Visible = true;
            }
        }

        private void btnPomoc_Click(object sender, EventArgs e)
        {
            frmPomoc frmPomoc = new frmPomoc();
            frmPomoc.Show();
        }
    }
}
