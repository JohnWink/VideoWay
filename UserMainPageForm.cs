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
    
    public partial class UserMainPageForm : Form
    {
        string username; // initialized here to be global on the form
        string password;

        public UserMainPageForm(String name, String psw) // Calling the login info from the LoginUser Form
        {
            username = name;
            password = psw;
            InitializeComponent();
        }

        //some paths of files
        public string categpath = @"text_folder/categories.txt";

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserMainPageForm_Load(object sender, EventArgs e)
        {
            // by default when logged it it will show you the most recent videolist added , the existing category list
            //current question rihgt now is if we add  new category in the upload, will it reload and add the new category to the list? if not then a refresh button is needed


            //checking the category files and adding them to the listbox1
            if (File.Exists(categpath))
            {
                StreamReader sr;
                sr = File.OpenText(categpath);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
                sr.Close();
            }

            else
            {
                StreamWriter sw;
                sw = File.CreateText(categpath);
                sw.Close();
            }
        }

        private void applyFilterButton_Click(object sender, EventArgs e)
        {

        }

        private void criarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadVideoForm uploadform = new UploadVideoForm();
            uploadform.Show();
        }

        private void watchvideofomrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VideoWatchForm videoWatch = new VideoWatchForm();
            videoWatch.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void criarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadVideoForm uploadVideo = new UploadVideoForm();
            uploadVideo.Show();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Parameters.CurrentForm.Show(); // shows previous Form
                        
        }
    }
}
