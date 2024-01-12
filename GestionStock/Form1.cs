using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (prsBar.Value < 100)
            {
                prsBar.Value += 1;
                label2.Text = prsBar.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                this.Hide();

                Form2 login = new Form2();
                login.Show();
            }
        }

        private void prsBar_Click(object sender, EventArgs e)
        {
         
        }
    }
}
