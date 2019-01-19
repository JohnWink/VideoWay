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
    public partial class Whatsnew : Form
    {
        //bringing the user
        string username;

        public Whatsnew(String name)
        {
            username = name;
            InitializeComponent();
        }

        //path of the files 
        public string playlists = @"text_folder/playlists.txt";

        private void Whatsnew_Load(object sender, EventArgs e)
        {
            // we will add check the file and check the latest videos filter

            if (File.Exists(playlists))
            {
                StreamReader sr = File.OpenText(playlists);
                string line = "";
                int lin = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] contents = line.Split(';');

                    int row_counter = dataGridView1.RowCount;

                    dataGridView1.Rows.Add(1);
                    row_counter = dataGridView1.RowCount;

                    dataGridView1[0, lin].Value = contents[0].ToString();
                    dataGridView1[1, lin].Value = contents[1].ToString();
                    dataGridView1[2, lin].Value = contents[2].ToString();
                    dataGridView1[3, lin].Value = contents[3].ToString();


                    lin++;

                }

                //will have to check if it does sort correctly

                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);

                sr.Close();
            }
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if row sellected it will take the tittle to the watchform
            //if not selected then message box

            if (dataGridView1.CurrentRow.Selected)
            {
                //take the tittle cell and brng it to the form so it can load on the wathcform
                int row = dataGridView1.CurrentRow.Index;
                string title = dataGridView1[0, row].Value.ToString();
                string category = dataGridView1[1, row].Value.ToString();
                string views = dataGridView1[2, row].Value.ToString();
                string date = dataGridView1[3, row].Value.ToString();
                Parameters.CurrentForm = Form.ActiveForm;
                this.Hide();
                VideoWatchForm watchform = new VideoWatchForm(username,title,category,views,date);
                watchform.Show();
                

            }

            else
            {
                MessageBox.Show("Please select a row!");
            }
        }
    }
}
