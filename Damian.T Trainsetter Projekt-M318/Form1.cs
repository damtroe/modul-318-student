using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace Damian.T_Trainsetter_Projekt_M318
{
    public partial class Form1 : Form
    {        
        public ITransport Transit = new Transport();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(DateTime.Now.Hour);
    }

        private void button1_Click(object sender, EventArgs e)
        {
            string Connections = cbBox1.Text;
            {

                listBox1.Items.Clear();               
                ITransport Transit = new Transport();
                var connections = Transit.GetConnections(cbBox1.Text, cbBox2.Text);
                foreach (Connection c in connections.ConnectionList)
                {
                    listBox1.Items.Add(" " + "Startstation" + "\t" + "Endstation" + "\t" + "Abfahrt" + "\t" + "Ankunft" + "\t" + "Dauer");
                    listBox1.Items.Add(" " + c.From.Station.Name + "\t" + c.To.Station.Name +"\t\t"+ c.From.Departure +"\t"+ c.To.Arrival +"\t"+ c.Duration+" Min");
                }
                if (cbBox1.Text == "" || cbBox2.Text == "")
                {
                    MessageBox.Show("Abfahrtsort muss ausgewählt werden!");
                }
            }
        }

         
        //Uhrzeit
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(DateTime.Now.Hour) + " : " + Convert.ToString(DateTime.Now.Minute) + " : " + Convert.ToString(DateTime.Now.Second);
        }



        //DropBox Events

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string suche = cbBox1.Text;

            ITransport Transit = new Transport();
            var stations = Transit.GetStations(suche);
            foreach (Station s in stations.StationList)
            {
            cbBox1.Items.Add("" + s.Name  );
            }
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            string suche = cbBox2.Text;

            ITransport Transit = new Transport();
            var stations = Transit.GetStations(suche);
            foreach (Station s in stations.StationList)
            {
                cbBox2.Items.Add("" + s.Name);
            }
        }

            //Auto vervollständigungs Methode

            private void Autovervollständigung(ComboBox cb)
        {
            string cbtext = cb.Text;

            if (cbtext.Length >= 3)
            {

                Stations stations = new Stations();
                stations = Transit.GetStations(cbtext + ",");
                cb.Items.Clear();
                cb.DroppedDown = true;
                cb.SelectionStart = cb.Text.Length;
                foreach (Station s in stations.StationList)
                {
                    cb.Items.Add(s.Name);

                }

            }
        }
            //Auto vervollständigungs Event
        private void cbBox1_TextUpdate(object sender, EventArgs e)
        {
            Autovervollständigung(cbBox1);
        }

        private void cbBox2_TextUpdate(object sender, EventArgs e)
        {
            Autovervollständigung(cbBox2);
        }
    }
}


