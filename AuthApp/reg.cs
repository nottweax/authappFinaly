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
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 6 ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @"[A-Z]") || // Проверка на наличие хотя бы одной прописной буквы
                !System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @"[0-9]") || // Проверка на наличие хотя бы одной цифры
                !System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @"[\W_]")) // Проверка на наличие хотя бы одного специального символа
            {
                MessageBox.Show("Пароль должен содержать минимум 6 символов, одну прописную букву, одну цифру и один специальный символ.");
            }
            else {
                db db = new db();
                MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`id`, `login`, `password`, `name`, `lastname`, `otchestvo`, `sex`, `stud_bilet`, `osnova`, `zadol`, `prim`) VALUES (NULL, @login, @password, @name, @lastname, @otchestvo, @sex, @bilet, @osnova, @zadol, @prim)", db.getConnection());

                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = textBox2.Text; // Рекомендуется хешировать пароль
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
                        MessageBox.Show("Аккаунт был создан");
                    else
                        MessageBox.Show("Аккаунт не был создан");
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



        }

        private void toauth_Click(object sender, EventArgs e)
        {
            this.Hide();
            auth authform = new auth();
            authform.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
