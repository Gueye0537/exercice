using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace GestionStock
{

    public partial class Form2 : Form
    {
        bool ptrEyeClicked = false;

        public Form2()
        {

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (textPassword.UseSystemPasswordChar = true)
            {
                ptrEye.Hide();
                ptrEyeBar.Show();


            }
            else if(textPassword.UseSystemPasswordChar = false)
            {
                ptrEye.Show();
                ptrEyeBar.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            MySqlConnection connexion= new MySqlConnection("database=gestionstock;server=localhost;user id=root; pwd=");
            this.Hide();
            try{
                //s string Query="select * from user where login=
                menu.Show();
                connexion.Open();
                MessageBox.Show("Connecté");
            }
            catch
            {
                MessageBox.Show("Non Connecté");
            }
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void ptrEye_Click(object sender, EventArgs e)
        {
            ptrEye.Visible = false;
            ptrEyeBar.Visible = true;
            textPassword.UseSystemPasswordChar = true;
            ptrEyeClicked = true;
        }

        private void ptrEyeBar_Click(object sender, EventArgs e)
        {
            ptrEyeBar.Visible = false;
            ptrEye.Visible = true;
            textPassword.UseSystemPasswordChar = false;
            ptrEyeClicked = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
