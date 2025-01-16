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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AuthApp
{
    public partial class mainform : Form
    {
        private string localUser;
        public mainform(string localUser)
        {
            InitializeComponent();
            this.localUser = localUser;

        }

      


        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void welcomLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db db = new db();
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `name` = @name, `otchestvo` = @otchestvo, `sex` = @sex, `stud_bilet` = @bilet, `osnova` = @osnova, `zadol` = @zadol, `prim` = @prim WHERE `lastname` = @lastname", db.getConnection());

            // Предполагается, что у вас есть текстовое поле для ввода ID пользователя


            command.Parameters.Add("@name", MySqlDbType.Text).Value = textBox3.Text;
            command.Parameters.Add("@lastname", MySqlDbType.Text).Value = textBox4.Text;
            command.Parameters.Add("@otchestvo", MySqlDbType.Text).Value = textBox5.Text;
            command.Parameters.Add("@sex", MySqlDbType.Text).Value = textBox6.Text;
            command.Parameters.Add("@bilet", MySqlDbType.Text).Value = textBox7.Text;
            command.Parameters.Add("@osnova", MySqlDbType.Text).Value = textBox8.Text;
            command.Parameters.Add("@zadol", MySqlDbType.Text).Value = textBox9.Text;
            command.Parameters.Add("@prim", MySqlDbType.Text).Value = textBox10.Text;

            try
            {
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Данные были обновлены");
                else
                    MessageBox.Show("Данные не были обновлены");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            users usersform = new users();
            usersform.Show();
        }
    }

}
