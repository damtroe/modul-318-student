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
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(DateTime.Now.Hour);
    }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string suche = textBox1.Text;

            ITransport testee = new Transport();
            var stations = testee.GetStations(suche);
            foreach (Station s in stations.StationList)
            {
                listBox1.Items.Add(": " + s.Name + "X:" + s.Coordinate.XCoordinate.ToString() + "Score" + s.Score);


            }     
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string suche = textBox1.Text;

            ITransport testee = new Transport();
            var stations = testee.GetStations(suche);
            foreach (Station s in stations.StationList)
            {
                listBox1.Items.Add(" " + s.Name + "X:" + s.Coordinate.XCoordinate.ToString() + "Score" + s.Score);


            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
    }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(DateTime.Now.Hour) + " : " + Convert.ToString(DateTime.Now.Minute) + " : " + Convert.ToString(DateTime.Now.Second);
        }
    }
}
