namespace VideoWay
{
    partial class UserMainPageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostRecentRadioButton = new System.Windows.Forms.RadioButton();
            this.mostPopularRadioButton = new System.Windows.Forms.RadioButton();
            this.applyFilterButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.criarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleColumn,
            this.DateColumn,
            this.ViewsColumn,
            this.CategoryColumn});
            this.dataGridView1.Location = new System.Drawing.Point(-2, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(708, 382);
            this.dataGridView1.TabIndex = 1;
            // 
            // TitleColumn
            // 
            this.TitleColumn.HeaderText = "Title";
            this.TitleColumn.Name = "TitleColumn";
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.Name = "DateColumn";
            // 
            // ViewsColumn
            // 
            this.ViewsColumn.HeaderText = "Views";
            this.ViewsColumn.Name = "ViewsColumn";
            // 
            // CategoryColumn
            // 
            this.CategoryColumn.HeaderText = "Category";
            this.CategoryColumn.Name = "CategoryColumn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarListaToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1015, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // mostRecentRadioButton
            // 
            this.mostRecentRadioButton.AutoSize = true;
            this.mostRecentRadioButton.Checked = true;
            this.mostRecentRadioButton.Location = new System.Drawing.Point(753, 35);
            this.mostRecentRadioButton.Name = "mostRecentRadioButton";
            this.mostRecentRadioButton.Size = new System.Drawing.Size(108, 21);
            this.mostRecentRadioButton.TabIndex = 3;
            this.mostRecentRadioButton.TabStop = true;
            this.mostRecentRadioButton.Text = "Most Recent";
            this.mostRecentRadioButton.UseVisualStyleBackColor = true;
            // 
            // mostPopularRadioButton
            // 
            this.mostPopularRadioButton.AutoSize = true;
            this.mostPopularRadioButton.Location = new System.Drawing.Point(753, 62);
            this.mostPopularRadioButton.Name = "mostPopularRadioButton";
            this.mostPopularRadioButton.Size = new System.Drawing.Size(112, 21);
            this.mostPopularRadioButton.TabIndex = 4;
            this.mostPopularRadioButton.Text = "Most Popular";
            this.mostPopularRadioButton.UseVisualStyleBackColor = true;
            // 
            // applyFilterButton
            // 
            this.applyFilterButton.Location = new System.Drawing.Point(889, 43);
            this.applyFilterButton.Name = "applyFilterButton";
            this.applyFilterButton.Size = new System.Drawing.Size(114, 40);
            this.applyFilterButton.TabIndex = 5;
            this.applyFilterButton.Text = "Apply Filter";
            this.applyFilterButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(203, 388);
            this.listBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Videos";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(295, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 382);
            this.panel1.TabIndex = 9;
            // 
            // criarListaToolStripMenuItem
            // 
            this.criarListaToolStripMenuItem.Name = "criarListaToolStripMenuItem";
            this.criarListaToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.criarListaToolStripMenuItem.Text = "Criar Lista";
            // 
            // UserMainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 493);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.applyFilterButton);
            this.Controls.Add(this.mostPopularRadioButton);
            this.Controls.Add(this.mostRecentRadioButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserMainPageForm";
            this.Text = "UserMainPageForm";
            this.Load += new System.EventHandler(this.UserMainPageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.RadioButton mostRecentRadioButton;
        private System.Windows.Forms.RadioButton mostPopularRadioButton;
        private System.Windows.Forms.Button applyFilterButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem criarListaToolStripMenuItem;
    }
}