using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VideoWay
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            string userFile = @"..\\..\\UtilizadorFile.txt";
           
            if(verify(usernameLoginTextBox.Text, passwordLoginTextBox.Text) == true)
            {
                System.Windows.Forms.MessageBox.Show("Entrou com sucesso!!");

                UserMainPageForm mainPage = new UserMainPageForm();
                mainPage.Show();

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Erro: Username ou Password incorreta");
            }

            
        }

        private bool verify(string username, string password)
        {
            string userFile = @"..\\..\\UtilizadorFile.txt";

            if (File.Exists(userFile))
            {
                StreamReader sr;
                sr = File.OpenText(userFile);
                String line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] field = line.Split(';');

                    if (field[0] == username && field[1] == password)
                    {
                        return true;
                    }

                }
            }
            return false;
        }

        private void createAccountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccountForm createAccount = new CreateAccountForm();
            createAccount.Show();
        }
    }
}
