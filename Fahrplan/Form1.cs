using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrplan
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            datetimepickerabfahrt.Format = DateTimePickerFormat.Custom;
            datetimepickerabfahrt.CustomFormat = "dd/MM/yyyy hh:mm";
            datetimepickerabfahrt.ShowUpDown = true;

        }
        SwissTransport.Transport transport = new SwissTransport.Transport();













        private void double_clicknach(object sender, EventArgs e)
        {
            bool click = false;
            int i = 0;
            while (i < 1)
                if (!click)
                {
                    textboxnach = sender as TextBox;
                    textboxvon = sender as TextBox;
                    textboxnach.Text = String.Empty;
                    textboxvon.Text = String.Empty;
                    click = true;
                    i++;
                }

        }

        private void double_clickvon(object sender, EventArgs e)
        {
            bool click = false;
            int i = 0;
            while (i < 1)
                if (!click)
                {
                    textboxnach = sender as TextBox;
                    textboxvon = sender as TextBox;
                    textboxnach.Text = String.Empty;
                    textboxvon.Text = String.Empty;
                    click = true;
                    i++;
                }
        }

        private void buttonverbindungen_Click(object sender, EventArgs e)
        {

            if (textboxvon.Text == string.Empty && textboxnach.Text == string.Empty)
            {
                MessageBox.Show("Es müssen Von und Nach Ort eingegeben werden");
            }
            else if (textboxvon.Text == string.Empty)
            {
                MessageBox.Show("Es müssen den Von Ort eingegeben werden");
            }
            else if (textboxnach.Text == string.Empty)
            {
                MessageBox.Show("Es muss der Nach Ort eingegeben werden");
            }
            else
            {

            }
           

            SwissTransport.Stations von = transport.GetStations(query: "Luzern");
            SwissTransport.Stations nach = transport.GetStations(query: "Bern");

        }



        private void textboxvon_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                listBox2.Items.Clear();
                Stations resultat = transport.GetStations(textboxvon.Text);
                listBox1.Items.Clear();

                foreach (Station station in resultat.StationList)
                {
                    listBox1.Items.Add(station.Name);
                }
            }


            catch
            {

            }










        }

        private void textboxnach_KeyUp(object sender, KeyEventArgs e)
        {
            listBox2.Items.Clear();
            Stations resultat = transport.GetStations(textboxnach.Text);
            listBox2.Items.Clear();

            foreach (Station station in resultat.StationList)
            {
                listBox2.Items.Add(station.Name);
            }

        }
    }
}
