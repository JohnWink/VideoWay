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
        string status;
        

        public UserMainPageForm(String name, String psw, String stat) // Calling the login info from the LoginUser Form
        {
            username = name;
            password = psw;
            status = stat;
            InitializeComponent();
        }

        //some paths of files
        public string categpath = @"text_folder/categories.txt";
        public string playlists = @"text_folder/playlists.txt";
        public string userFile = @"..\\..\\UtilizadorFile.txt";

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserMainPageForm_Load(object sender, EventArgs e)
        {
            // by default when logged it it will show you the most recent videolist added , the existing category list
            //current question rihgt now is if we add  new category in the upload, will it reload and add the new category to the list? if not then a refresh button is needed

            //on load we will check the users status, if admin then make the createvidolist strip visible

            if(status == "admin")
            {
                criarContaToolStripMenuItem.Visible = true;
            }
            
            


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

            // load a new small form , our alert news
            //Note it will show behind the Mainform for some reason
            Whatsnew popup = new Whatsnew();
            popup.Show();



        }

        private void applyFilterButton_Click(object sender, EventArgs e)
        {
            //ADD an if condition , if item is selected then it will fillter acording to that category

            //if item is not selected fromt he list box it will do a filter whit all the video lists filter 
            
                //Popularity filter by the number of veiws, in a descending order from most popular to least popular
                //grid is not workingatm i will have to check the exerccice and not freak out
                //note didnt work becuase i forgot to put .txt  on the path duh!
                   
                



            

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

        private void button1_Click(object sender, EventArgs e)
        {
            //this button will allow you to deselect a category
            listBox1.SelectedIndex = -1;
            listBox1.Update();
            
        }
    }
}
