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

            if (textboxvon.Text == "Von")
                MessageBox.Show("Der Wert muss verändert werden.");

            if (textboxnach.Text == "Nach")
                MessageBox.Show("Der Wert muss verändert werden.");


            // var result = transport.GetConnections(textboxvon.Name, textboxnach.Name, datetimepickerabfahrt.Value);
            var result = transport.GetConnections(textboxvon.Text, textboxnach.Text, datetimepickerabfahrt.Value);
            listboxausgabe.Items.Clear();

           foreach (SwissTransport.Connection connection in result.ConnectionList)
            {
               listboxausgabe.Items.Add(  "Von" + " " + textboxvon.Text + " " + "nach" +" " + connection.To.station.Name  );
            }



            

           

           

            

        }



        private void textboxvon_KeyUp(object sender, KeyEventArgs e)
        {
            listBox1.Items.Clear();
            Stations resultat = transport.GetStations(textboxvon.Text);
            
            foreach (Station station in resultat.StationList)
            {
                listBox1.Items.Add(station.Name);
            }
        }

        private void textboxnach_KeyUp(object sender, KeyEventArgs e)
        {
           
            Stations resultat = transport.GetStations(textboxnach.Text);
            listBox2.Items.Clear();

            foreach (Station station in resultat.StationList)
            {
                listBox2.Items.Add(station.Name);
            }

           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = listBox1.SelectedItem.ToString();
            textboxvon.Text = value;


        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = listBox2.SelectedItem.ToString();
            textboxnach.Text = value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
