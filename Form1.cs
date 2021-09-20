using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;  

namespace MySQL_app
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection("Server=localhost;Database=testdb;user=root;Pwd=;SslMode=none");
                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    MessageBox.Show("You can continue everything is working properly.", "Continue", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Something is not working properly.", "Stop Here", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtauthour.Text == string.Empty || txtname.Text == string.Empty || txtage.Text == string.Empty)
            {
                MessageBox.Show("Empty Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("insert into data(author,name,age) values(" +
                    "'" + txtauthour.Text + 
                    "','" + txtname.Text +
                    "','" + txtage.Text + 
                    "')", con);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                txtauthour.Text = string.Empty;
                txtname.Text = string.Empty;
                txtage.Text = string.Empty;
                MessageBox.Show("Information Added", "MySQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
