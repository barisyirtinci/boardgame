using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BARISYIRTINCIboardgame
{
    public partial class Form1 : Form
    {
        string user1 = "Admin";  //kullanıcı kayıtları
        string user2 = "User";
        string pass1 = "admin";
        string pass2 = "user";
        public Form1()
        {
            InitializeComponent();
        }

        void checkLogin()     //giriş yapmak için kontrol fonksiyonu
        {
            if ((txtUsername.Text == "Admin" && txtPassword.Text == "admin") || (txtUsername.Text == "User" && txtPassword.Text == "user"))
            {
                Form2 form2 = new Form2();
                Form1 form1 = this;
                form2.Show();
                form1.Hide();
                
            }else if (txtPassword.Text == "" || txtUsername.Text == "")
            {
                MessageBox.Show("Please enter the username and password");
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            
            txtUsername.Select();      //açılışta kullanıcı adı kısmının seçili olması
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkLogin();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)    //enter kullanımı için keydown eventi
            {
                checkLogin();
            }
        }
    }
}
