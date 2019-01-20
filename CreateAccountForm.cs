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
            // The "UtilizadorFile" notepad is located in the project folder
            string userFile = @"..\\..\\UtilizadorFile.txt";

            //  checks if both entered passwords are identical and summons a method to verify if the username and/or email already exists in the registered accounts
            if (passwordCreateTextBox.Text == passwordConfirmTextBox.Text && verify(usernameCreateTextBox.Text, emailCreateTextBox.Text) == true)
            {
                if (passwordCreateTextBox.Text.Contains(';') == false && usernameCreateTextBox.Text.Contains(';') == false && emailCreateTextBox.Text.Contains(';') == false)
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
                    System.Windows.Forms.MessageBox.Show("Account Created");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Avoid using ';' in your username or password or email");
                    
                }
            }
            else
            {
                if (passwordCreateTextBox.Text != passwordConfirmTextBox.Text)
                {
                    System.Windows.Forms.MessageBox.Show("Erro: Passwords não coincidem!");
                }
                if (verify(usernameCreateTextBox.Text, emailCreateTextBox.Text) == false)
                {
                    System.Windows.Forms.MessageBox.Show("Erro: Username ou Email já existem");
                }
            }
                
       



        }

        //checks if name already exists in the User's text file
        private bool verify(string name, string email)  
        {
            string userFile = @"..\\..\\UtilizadorFile.txt";
            StreamReader sr;

            if (File.Exists(userFile))
            {
                sr = File.OpenText(userFile);

                String line;

                //Goes through every line of the text file until it checks that there are no more lines to read
                while ((line = sr.ReadLine())  != null)
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

        private void CreateAccountForm_Load(object sender, EventArgs e)
        {

        }
    }
}
