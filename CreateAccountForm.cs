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
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            string userFile = @"..\\..\\UtilizadorFile.txt";

            if(passwordCreateTextBox.Text == passwordConfirmTextBox.Text && verify(usernameCreateTextBox.Text, emailCreateTextBox.Text) == true)
            {
     
                Utilizadoress user = new Utilizadoress();
                user.username = usernameCreateTextBox.Text;
                user.password = passwordCreateTextBox.Text;
                user.email = emailCreateTextBox.Text;
                user.status = "user";

                StreamWriter sw;

                if (File.Exists(userFile))
                {
                    sw = File.AppendText(userFile);
                }
                else
                {
                    sw = File.CreateText(userFile);
                }

                string line = user.username + ";" + user.password + ";" + user.email + ";" + user.status + ";";
                sw.WriteLine(line);
                sw.Close();
                System.Windows.Forms.MessageBox.Show("Conta Criada!");
                Application.Exit();

            }
            else
            {
                if(passwordCreateTextBox.Text != passwordConfirmTextBox.Text)
                {
                    System.Windows.Forms.MessageBox.Show("Erro: Passwords não coincidem!");
                }
                if(verify(usernameCreateTextBox.Text, emailCreateTextBox.Text) == false)
                {
                    System.Windows.Forms.MessageBox.Show("Erro: Username ou Email já existem");
                }
            }

       



        }

        private bool verify(string name, string email)  //checks if name already exists in the User's text file
        {
            string userFile = @"..\\..\\UtilizadorFile.txt";
            StreamReader sr;

            if (File.Exists(userFile))
            {
                sr = File.OpenText(userFile);

                String line;

                while((line = sr.ReadLine())  != null)//Goes through every line of the text file until it checks that there are no more lines to read
                {
                    string[] field = line.Split(';');
                    if(field[0] == name || field[2] == email)
                    {
                        return false;
                    }
                }

                sr.Close();
            }

            return true;
        }

            
    }
}
