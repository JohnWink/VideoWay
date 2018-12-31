namespace VideoWay
{
    partial class CreateAccountForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameCreateTextBox = new System.Windows.Forms.TextBox();
            this.passwordCreateTextBox = new System.Windows.Forms.TextBox();
            this.passwordConfirmTextBox = new System.Windows.Forms.TextBox();
            this.emailCreateTextBox = new System.Windows.Forms.TextBox();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create Password: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Email: ";
            // 
            // usernameCreateTextBox
            // 
            this.usernameCreateTextBox.Location = new System.Drawing.Point(209, 76);
            this.usernameCreateTextBox.Name = "usernameCreateTextBox";
            this.usernameCreateTextBox.Size = new System.Drawing.Size(100, 22);
            this.usernameCreateTextBox.TabIndex = 4;
            // 
            // passwordCreateTextBox
            // 
            this.passwordCreateTextBox.Location = new System.Drawing.Point(209, 136);
            this.passwordCreateTextBox.Name = "passwordCreateTextBox";
            this.passwordCreateTextBox.Size = new System.Drawing.Size(100, 22);
            this.passwordCreateTextBox.TabIndex = 5;
            // 
            // passwordConfirmTextBox
            // 
            this.passwordConfirmTextBox.Location = new System.Drawing.Point(209, 199);
            this.passwordConfirmTextBox.Name = "passwordConfirmTextBox";
            this.passwordConfirmTextBox.Size = new System.Drawing.Size(100, 22);
            this.passwordConfirmTextBox.TabIndex = 6;
            // 
            // emailCreateTextBox
            // 
            this.emailCreateTextBox.Location = new System.Drawing.Point(209, 265);
            this.emailCreateTextBox.Name = "emailCreateTextBox";
            this.emailCreateTextBox.Size = new System.Drawing.Size(100, 22);
            this.emailCreateTextBox.TabIndex = 7;
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(97, 343);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(177, 50);
            this.createAccountButton.TabIndex = 8;
            this.createAccountButton.Text = "Create";
            this.createAccountButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(387, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 427);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.emailCreateTextBox);
            this.Controls.Add(this.passwordConfirmTextBox);
            this.Controls.Add(this.passwordCreateTextBox);
            this.Controls.Add(this.usernameCreateTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CreateAccountForm";
            this.Text = "CreateAccountForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernameCreateTextBox;
        private System.Windows.Forms.TextBox passwordCreateTextBox;
        private System.Windows.Forms.TextBox passwordConfirmTextBox;
        private System.Windows.Forms.TextBox emailCreateTextBox;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}