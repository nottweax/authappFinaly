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

namespace AuthApp
{
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
            LoadUser();

        }

        private void LoadUser()
        {
            db db = new db();
            DataTable table = new DataTable();
            try
            {
                db.getConnection().Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `name`, `lastname`, `osnova` FROM `users` ORDER BY `name` ASC", db.getConnection());
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                db.getConnection().Close();
            }
        }
            private void LoadUserLastName()
        {
            db db = new db();
            DataTable table = new DataTable();
            try
            {
                db.getConnection().Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `name`, `lastname`, `osnova` FROM `users` ORDER BY `lastname` ASC", db.getConnection());
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                db.getConnection().Close();
            }
        }
            private void LoadUserOsnova()
        {
            db db = new db();
            DataTable table = new DataTable();
            try
            {
                db.getConnection().Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `name`, `lastname`, `osnova` FROM `users` ORDER BY `osnova` ASC", db.getConnection());
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                db.getConnection().Close();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUserOsnova();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadUserLastName();
        }
    }
}
