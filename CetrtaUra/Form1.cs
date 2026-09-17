using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CetrtaUra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ustvarimo objekt razreda stream reader
            StreamReader sr = File.OpenText("besedilo.txt");
            //preberemo prvo vrstico
            string vrstica = sr.ReadLine();
            //napovemo 1D tabelo
            string[] tab;
            while (vrstica != null)
            {
                tab = vrstica.Split(';');
                //prikazemo podatke v DGV (Data Grid View)
                dataGridView1.Rows.Add(tab);
                //MessageBox.Show(vrstica);
                //preberemo naslednjo vrstico
                vrstica = sr.ReadLine(); //ce to zbrisemo je neskoncna zanka
            }
            sr.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ustvarimo objekt razreda stream reader
            StreamReader sr = File.OpenText("besedilo.txt");
            //preberemo prvo vrstico
            string vrstica = sr.ReadLine();
            //napovemo 1D tabelo
            string[] tab;
            int stevec = 1;
            while (vrstica != null)
            {
                tab = vrstica.Split(';');
                //prikazemo podatke v DGV (Data Grid View)
                dataGridView1.Rows.Add(stevec, tab[0], tab[1], tab[2], tab[3]);
                stevec++;
                //MessageBox.Show(vrstica);
                //preberemo naslednjo vrstico
                vrstica = sr.ReadLine(); //ce to zbrisemo je neskoncna zanka
            }
            sr.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
