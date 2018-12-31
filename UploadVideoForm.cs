using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoWay
{
    public partial class UploadVideoForm : Form
    {
        public UploadVideoForm()
        {
            InitializeComponent();
        }

        private void previewVideoPlayButton_Click(object sender, EventArgs e)
        {
            //when pressed it will start the webbrowser if the item is sellected from the item box
            //if not then add a message box
            webBrowser1.Navigate(listBox1.SelectedItem.ToString());
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
            //note need to see if pre defined categories or if he can add new catergories

        }

        private void adicionarVideoButton_Click(object sender, EventArgs e)
        {
            //upgrade to do: there can not be any duplicate links
            if(textBox1.Text != "")
            {
                string link = textBox1.Text;
                listBox1.Items.Add(link);
                textBox1.Text = "";

            }

            else
            {
                toolStripStatusLabel1.Text = "Insira o link of video";
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
            //if pre defined categories we will load the category text file
            
        }
    }
}
