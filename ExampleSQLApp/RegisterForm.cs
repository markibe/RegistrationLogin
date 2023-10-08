using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            PasswordBox.AutoSize = false;
            PasswordBox.Size = new Size(PasswordBox.Size.Width, LoginBox.Size.Height);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point LastPoint;
        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - LastPoint.X;
                Top += e.Y - LastPoint.Y;
            }
        }

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.ForeColor = Color.LightGray;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Black;
        }

        private void Close_MouseDown(object sender, MouseEventArgs e)
        {
            Close.ForeColor = Color.White;
        }

        private void HideShow_Click(object sender, EventArgs e)
        {
            if (PasswordBox.UseSystemPasswordChar == true)
            {
                PasswordBox.UseSystemPasswordChar = false;
                HideShow.Image = Image.FromFile(@"D:\Visual Studio Projects\ExampleSQLApp\ExampleSQLApp\images\eye_off_icon.png");
            }
            else
            {
                PasswordBox.UseSystemPasswordChar = true;
                HideShow.Image = Image.FromFile(@"D:\Visual Studio Projects\ExampleSQLApp\ExampleSQLApp\images\eye_icon.png");
                HideShow.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            String LoginUser = LoginBox.Text;
            String PassUser = PasswordBox.Text;

            if (LoginUser == "" || PassUser == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
                return;
            }

            if (ChekUserExist())
            {
                return;
            }


            DB db = new DB();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand
            ("INSERT INTO `users` (`login`, `pass`) VALUES (@Log, @Pass)",
            db.GetConnection());

            command.Parameters.Add("@Log", MySqlDbType.VarChar).Value = LoginUser;

            command.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = PassUser;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Успешнo", "Регистрация");
            }
            else
            {
                MessageBox.Show("Не успешно", "Регистрация");
            }

            db.CloseConnection();
        }

        public bool ChekUserExist()
        {
            DB dB = new DB();

            DataTable dataTable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand
                ("SELECT * FROM `users` WHERE `login` = @UserL",
                dB.GetConnection());

            command.Parameters.Add 
                ("@UserL", MySqlDbType.VarChar).Value = LoginBox.Text;

            adapter.SelectCommand = command;
            
            adapter.Fill(dataTable);

            
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользователь уже есть", "Ошибка");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ToLognForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
