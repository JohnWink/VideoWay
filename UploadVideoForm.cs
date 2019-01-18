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
    public partial class UploadVideoForm : Form
    {
        public UploadVideoForm()
        {
            InitializeComponent();
        }
        //some paths of files
        public string categpath = @"text_folder/categories.txt";
        public string playlists = @"text_folder/playlists.txt";

        private void previewVideoPlayButton_Click(object sender, EventArgs e)
        {
            //when pressed it will start the webbrowser if the item is sellected from the item box
            
            string item = listBox1.SelectedItem.ToString();
            int comp = item.Length;
            int position = item.IndexOf(";");
            string link = item.Substring(position+1,comp-position-1);
            webBrowser1.Navigate(link);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // first here has to be some conditions before uploading and after
            // 1- there cannot be any any list whit the same name, so theres a need to search to see if hereres name tittles
            // and the textbox tittle cannot be emphty.
            // 2- , there has to be something on the list of videos, even if its just one, 
            // 3- before uploading it will show a confirmation message box
            // 4-after the video is uploaded, text box will be cleared along whit the video list, and i will show on the status bar the success

            //first making sure the list isnt emphty, that theres a tittle sellected and that thres a category added
            //secod check if an existing tittle exist

            //checking if the if all text boxes whit the data we want are filled,
            
            if(textBox2.Text != "" && comboBox1.Text != "")
            {
                //after, we check if theres a textfile whit the same tittle, ergo, if a list whit the name tittle exists

                if(File.Exists(@"text_folder/" + textBox2.Text + "-list.txt"))
                {
                    toolStripStatusLabel1.Text = "Este titulo existe, tente novamente.";
                    
                }


                
                else
                {
                    //summon constructor base
                    VideoList list = new VideoList();

                    //adding data do the bases
                    list.listname = textBox2.Text;
                    list.category = comboBox1.Text;
//<<<<<<< Updated upstream
                    list.listviews = 0;
                    list.date = DateTime.Now.ToString();
//=======
                    list.listviews = 0;// CORRECT THIS----------------------------------------------------------------------------< CHECK THIS QUICKLY
//>>>>>>> Stashed changes
                    list.videopath = @"text_folder/" + list.listname + "-list.txt";
                    list.commentpath = @"text_folder/" + list.listname + "-comments.txt";

                    // after all those are done, we will open the SW and save our files
                    StreamWriter sw;
                    //creating the paths by order of construction
                    sw = File.CreateText(list.commentpath);
                    sw.Close();

                    StreamWriter sw2;
                    //adding to the info the the playlist files (first check if the files existence)
                    if (File.Exists(playlists))
                    {
                        sw2 = File.AppendText(playlists);
                        sw2.WriteLine(list.listname + ";" + list.category + ";" + list.listviews + ";" + list.date + ";" + list.videopath + ";" + list.commentpath);

                    }

                    else
                    {
                        sw2 = File.CreateText(playlists);
                        sw2.WriteLine(list.listname + ";" + list.category + ";" + list.listviews + ";" + list.date + ";" + list.videopath + ";" + list.commentpath);
                    }
                    
                    
                    sw2.Close();

                    StreamWriter sw3;
                    //after the files are created we need to add the listbox1 links and tittle to the of the videos
                    sw3 = File.CreateText(list.videopath);
                    //get the number of items for the for cycle
                    string numb = listBox1.Items.Count.ToString();
                    int counter = Convert.ToInt16(numb);

                    for (int i = 0; i < counter; i++)
                    {
                        string line = listBox1.Items[i].ToString();
                        sw3.WriteLine(line);//this will be in seperate lines has in ENTER kind
                    }
                    sw3.Close();

                    toolStripStatusLabel1.Text = "Upload da playlist , com sucesso";


                }
                

            }

            else
            {
                toolStripStatusLabel1.Text = " Selecione a categoria e insira o titulo.";
            }
            
        }

        private void adicionarVideoButton_Click(object sender, EventArgs e)
        {
            //upgrade to do: there can not be any duplicate links
            if(textBox1.Text != "" && textBox3.Text != "")
            {
                string link = textBox1.Text;
                string title = textBox3.Text;
                listBox1.Items.Add(title + ";" + link);
                textBox1.Text = "";
                textBox3.Text = "";

            }

            else
            {
                toolStripStatusLabel1.Text = "Insira o link of video e titulo";
            }
            
        }

        private void removerVideoButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            removerVideoButton.Enabled = true;
            previewVideoPlayButton.Enabled = true;
        }

        private void UploadVideoForm_Load(object sender, EventArgs e)
        {
            // status will show time and status of the stuff
            //we will need to load the category file txt and  file the combo box
            if (File.Exists(categpath))
            {
                StreamReader sr;
                sr = File.OpenText(categpath);
                string line;
                while((line=sr.ReadLine()) != null)
                {
                    comboBox1.Items.Add(line);
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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //when the button clicks it wil fetch te text on the text box, open the streamwriter and write it on the category txt file
            string category = textBox4.Text;

            // we wont need to check the existence of the files sence that will be done on load
            StreamWriter sw;
            sw = File.AppendText(categpath);
            
            // after the commands are set, we can now add the category

            sw.WriteLine(category);
            comboBox1.Items.Add(category);
            textBox4.Text = "";

            sw.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
