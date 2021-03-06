﻿using System;
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
    public partial class VideoWatchForm : Form
    {
        //bringing users and video links
        public string username;
        public string listtile;
        public string category;
        public string date;
        public string views;

        public VideoWatchForm(String name, String title,String type,String pop,String time )
        {
            username = name;
            listtile = title;
            category = type;
            views = pop;
            date = time;

            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try{

                if (richTextBox1.Text != "")
                {
                    //string from the comment box  and then add to the listbox 2 has an item
                    // it will need to put the users name + " " +date  + ": "+ ritchtextbox1.text;
                    string comment = username + " " + DateTime.Now.ToString() + ": " + richTextBox1.Text;
                    listBox2.Items.Add(comment);


                    // after the comment it will save this in the file

                    string commentpath = @"text_folder/" + listtile + "-comments.txt";
                    StreamWriter sw;
                    if (File.Exists(commentpath))
                    {
                        //deletes the old one and creates a new one 
                        File.Delete(commentpath);

                        sw = File.CreateText(commentpath);

                        string num = listBox2.Items.Count.ToString();
                        int num1 = Convert.ToInt16(num);

                        for (int i = 0; i < num1; i++)
                        {
                            string linha = listBox2.Items[i].ToString();
                            sw.WriteLine(linha);
                        }

                        sw.Close();

                        //clear comment box
                        richTextBox1.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Please Write what you want to comment before Pressing the 'Comment' button");
                }
            }catch(Exception)
            {
                MessageBox.Show("An unexpected Error has ocurred, our Developers have been informed to deal with this issue, We apologise for the inconveniance");
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                //first it will seach the position of the selected item
                int pos = listBox2.SelectedIndex;
                // we make a string of the comment we intend to reply
                string commentext = listBox2.SelectedItem.ToString();

                //after we will search if theres space chars on the sellected item, if so we will add those spacces, if not there no spacess added
                string space = "";
                int count = 0;
                while (commentext[count] == ' ')
                {
                    count++;
                    space = space + " ";
                }

                //on the reply it it will add more spaces to make a stair effect
                // needs: space + "       " + user + " " + date + ": " + ritchtextbox1.text;
                string rcomment = username + " " + DateTime.Now.ToString() + ": " + richTextBox1.Text;
                string reply = space + "      " + rcomment;
                //it will add the new line (reply after the commnet)
                listBox2.Items.Insert(pos + 1, reply);


                // after the reply it will save all in the file

                string commentpath = @"text_folder/" + listtile + "-comments.txt";
                StreamWriter sw;
                if (File.Exists(commentpath))
                {
                    //deletes the old one and creates a new one 
                    File.Delete(commentpath);

                    sw = File.CreateText(commentpath);

                    string num = listBox2.Items.Count.ToString();
                    int num1 = Convert.ToInt16(num);

                    for (int i = 0; i < num1; i++)
                    {
                        string linha = listBox2.Items[i].ToString();
                        sw.WriteLine(linha);
                    }

                    sw.Close();

                }

                //clear comment box
                richTextBox1.Text = "";

            }
            else
            {
                MessageBox.Show("Please Write what you want to comment before Pressing the 'Comment' button");
            }

        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            // if an item is sellected then the reply button becomes enabled
            button3.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //when pressed and if  the item is sellect from list box 1, then this button becomes enabled, and it will open
            // a new form wiht the link info and open a bigger webpage so the user can see it in a bigger view
            try
            {
                string item = listBox1.SelectedItem.ToString();
           
            int comp = item.Length;
                int position = item.IndexOf(";");
                string link = item.Substring(position + 1, comp - position - 1);
                Biggerview formview = new Biggerview(link);
                formview.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select the video you want to watch and NOT the box that the video is in");
                return;
            }

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VideoWatchForm_Load(object sender, EventArgs e)
        {
            //adding the labels whit the tittle date category and views
            label4.Text = listtile;
            label3.Text = date;
            label7.Text = category;

            // adding 1 view each time you enter a playlist
            int countV = Int32.Parse(views) + 1;
            textBox1.Text = countV.ToString();

            //now to save it by opening the play list
            string playlists = @"text_folder/playlists.txt";
            if (File.Exists(playlists))
            {
                //first open the playlist and we will read it and modify each line
                StreamReader sr = File.OpenText(playlists);
                
                string line = "";
                int linecount = 0;
                // we will start reading and turning the lines in to string arrays
                while ((line = sr.ReadLine()) != null)
                {

                    //if the tittle whatches whit the first possition of the string, then we will modify 
                    //the 3rd possition whit the new veiw count
                    string[] contents = line.Split(';');

                    if (contents[0] == listtile)
                    {

                        contents[2] = countV.ToString();

                        int comp = contents.Length;
                        string newline = "";
                        // now making our new modified line whit the updated view count
                        for(int i =0; i<comp; i++)
                        {
                            newline += contents[i] + ";";
                        }

                        sr.Close();
                        string[] arrLine = File.ReadAllLines(playlists);
                        arrLine[linecount] = newline;
                        File.WriteAllLines(playlists, arrLine);

                        //once modified and in the text file, we will break out of this loop
                        break;




                    }
                    //if there were no match then we write it whit no modifications

                    linecount++;
                }
                
                sr.Close();
            }

            else
            {
                MessageBox.Show("The playlist doesnt seem to exist!");
            }
            




            // whit the tittle we can search for the video path and open the coment file and video list file
            // load the playlist and comments, searching for the file trough the tittle of the playlist

            //setting the path bases
            string videopath = @"text_folder/" + listtile + "-list.txt";
            string commentpath = @"text_folder/" + listtile + "-comments.txt";

            //video list box part-------------------------
            if (File.Exists(videopath))
            {
                //if the file exist it will add to the list box the items
                StreamReader sr;
                sr = File.OpenText(videopath);
                string line1;
                while ((line1 = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(line1);
                }
                sr.Close();
            }

            else
            {
                MessageBox.Show("The videolist doesnt seem to exist!");
            }

            // comment section part-------------------------------------

            if (File.Exists(commentpath))
            {
                //if the file exist it will add to the list box the items
                StreamReader sr;
                sr = File.OpenText(commentpath);
                string line2;
                while ((line2 = sr.ReadLine()) != null)
                {
                    listBox2.Items.Add(line2);
                }
                sr.Close();
            }

            else
            {
                MessageBox.Show("The videolist doesnt seem to exist!");
            }


        }
    }
}
