using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_MT
{
    public partial class Form1 : Form
    {
        public double PAL = 0;
        public double PPM = 0;
        public string plec = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void oblicz_Click(object sender, EventArgs e)
        {
            if (mezczyzna.Checked)
            {
                plec = "Mężczyzna";
                if (lista_aktywnosc.SelectedIndex == 0)
                {
                    PAL = 1.2;
                }
                else if (lista_aktywnosc.SelectedIndex == 1)
                {
                    PAL = 1.3;
                }
                else if (lista_aktywnosc.SelectedIndex == 2)
                {
                    PAL = 1.6;
                }
                else if (lista_aktywnosc.SelectedIndex == 3)
                {
                    PAL = 1.7;
                }
                else if (lista_aktywnosc.SelectedIndex == 4)
                {
                    PAL = 2.1;
                }
                else if (lista_aktywnosc.SelectedIndex == 5)
                {
                    PAL = 2.4;
                }
            }
            else
            {
                plec = "Kobieta";
                if (lista_aktywnosc.SelectedIndex == 0)
                {
                    PAL = 1.2;
                }
                else if (lista_aktywnosc.SelectedIndex == 1)
                {
                    PAL = 1.3;
                }
                else if (lista_aktywnosc.SelectedIndex == 2)
                {
                    PAL = 1.5;
                }
                else if (lista_aktywnosc.SelectedIndex == 3)
                {
                    PAL = 1.6;
                }
                else if (lista_aktywnosc.SelectedIndex == 4)
                {
                    PAL = 1.9;
                }
                else if (lista_aktywnosc.SelectedIndex == 5)
                {
                    PAL = 2.2;
                }
            }
            PPM = ((10 * double.Parse(waga.Text)) + (6.25 * double.Parse(wzrost.Text)) - (5 * double.Parse(wiek.Text)) + 5);
            klasa BMI = new klasa()
            {
                Plec2 = plec,
                Wiek = double.Parse(wiek.Text),
                Waga = double.Parse(waga.Text),
                Wzrost = double.Parse(wzrost.Text),
                Aktywnosc = lista_aktywnosc.SelectedItem.ToString(),
                Ppm = PPM,
                Bmi = double.Parse(waga.Text) / Math.Pow(double.Parse(wzrost.Text) / 100, 2),
                Cpm = PPM * PAL,
            };
            MessageBox.Show(BMI.wyswietl());
        }

        private void wzrost_ValueChanged(object sender, EventArgs e)
        {
            wzrost.Maximum = 500;
        }
        private void wiek_ValueChanged(object sender, EventArgs e)
        {
            wiek.Minimum = 18;
            wiek.Maximum = 99;
        }
    }




    public class klasa
    {
        private string plec2;
        private double wiek;
        private double waga;
        private double wzrost;
        private string aktywnosc;
        private double PPM;
        private double BMI;
        private double CPM;
        public string Plec2
        {
            get { return plec2; }
            set { plec2 = value; }
        }
        public double Wiek
        {
            get { return wiek; }
            set { wiek = value; }
        }
        public double Waga
        {
            get { return waga; }
            set { waga = value; }
        }
        public double Wzrost
        {
            get { return wzrost; }
            set { wzrost = value; }
        }
        public string Aktywnosc
        {
            get { return aktywnosc; }
            set { aktywnosc = value; }
        }
        public double Ppm
        {
            get { return PPM; }
            set { PPM = value; }
        }
        public double Bmi
        {
            get { return BMI; }
            set { BMI = value; }
        }
        public double Cpm
        {
            get { return CPM; }
            set { CPM = value; }
        }
        public klasa()
        {
            plec2 = "";
            wiek = 0;
            waga = 0;
            wzrost = 0;
            aktywnosc = "";
            PPM = 0;
            BMI = 0;
            CPM = 0;
        }

        public klasa(string plec2, double wiek, double waga, double wzrost, string aktywnosc, double PPM, double BMI, double CPM)
        {
            this.Plec2 = plec2;
            this.Wiek = wiek;
            this.Waga = waga;
            this.Wzrost = wzrost;
            this.Aktywnosc = aktywnosc;
            this.Ppm = PPM;
            this.Bmi = BMI;
            this.Cpm = CPM;
        }
        public string wyswietl()
        {
            return ("Płeć: " + plec2 + "\nWiek: " + wiek + "\nWaga: " + waga + "\nWzrost: " + wzrost + "\nAktywność: " + aktywnosc + "\nPPM: " + PPM + "\nBMI: " + BMI + "\nCPM: " + CPM);
        }
    }
}
