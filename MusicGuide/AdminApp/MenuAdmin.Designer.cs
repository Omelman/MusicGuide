namespace MusicGuide.AdminApp
{
    partial class MenuAdmin
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
            this.ManePanel = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddNewFlatButton = new System.Windows.Forms.Button();
            this.ShowCustomersButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ManePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManePanel
            // 
            this.ManePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(218)))), ((int)(((byte)(219)))));
            this.ManePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManePanel.Controls.Add(this.button8);
            this.ManePanel.Controls.Add(this.button7);
            this.ManePanel.Controls.Add(this.button6);
            this.ManePanel.Controls.Add(this.button5);
            this.ManePanel.Controls.Add(this.listBox3);
            this.ManePanel.Controls.Add(this.button4);
            this.ManePanel.Controls.Add(this.button3);
            this.ManePanel.Controls.Add(this.listBox2);
            this.ManePanel.Controls.Add(this.button2);
            this.ManePanel.Controls.Add(this.button1);
            this.ManePanel.Controls.Add(this.listBox1);
            this.ManePanel.Controls.Add(this.AddNewFlatButton);
            this.ManePanel.Controls.Add(this.ShowCustomersButton);
            this.ManePanel.Controls.Add(this.panel2);
            this.ManePanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ManePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManePanel.Location = new System.Drawing.Point(0, 0);
            this.ManePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ManePanel.Name = "ManePanel";
            this.ManePanel.Size = new System.Drawing.Size(954, 652);
            this.ManePanel.TabIndex = 9;
            this.ManePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ManePanel_Paint);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(814, 168);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(117, 38);
            this.button8.TabIndex = 23;
            this.button8.Text = "Search music";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Search_Button);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(814, 268);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 41);
            this.button7.TabIndex = 22;
            this.button7.Text = "Show Users";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.User_Button);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(617, 589);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 34);
            this.button6.TabIndex = 21;
            this.button6.Text = "Delete song";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(617, 114);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 34);
            this.button5.TabIndex = 20;
            this.button5.Text = "Add new song";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(594, 168);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(191, 404);
            this.listBox3.TabIndex = 19;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            this.listBox3.DoubleClick += new System.EventHandler(this.listBox3_DoubleClick);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(328, 589);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 34);
            this.button4.TabIndex = 18;
            this.button4.Text = "Delete album";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(328, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 34);
            this.button3.TabIndex = 17;
            this.button3.Text = "Add new album";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(310, 168);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(198, 404);
            this.listBox2.TabIndex = 16;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(49, 589);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 34);
            this.button2.TabIndex = 15;
            this.button2.Text = "Delete artist";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(49, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add new artist";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(29, 168);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 404);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // AddNewFlatButton
            // 
            this.AddNewFlatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.AddNewFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewFlatButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddNewFlatButton.FlatAppearance.BorderSize = 2;
            this.AddNewFlatButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AddNewFlatButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AddNewFlatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewFlatButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewFlatButton.Location = new System.Drawing.Point(82, 708);
            this.AddNewFlatButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddNewFlatButton.Name = "AddNewFlatButton";
            this.AddNewFlatButton.Size = new System.Drawing.Size(302, 51);
            this.AddNewFlatButton.TabIndex = 11;
            this.AddNewFlatButton.Text = "Add new flat";
            this.AddNewFlatButton.UseVisualStyleBackColor = false;
            // 
            // ShowCustomersButton
            // 
            this.ShowCustomersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.ShowCustomersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowCustomersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ShowCustomersButton.FlatAppearance.BorderSize = 2;
            this.ShowCustomersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(187)))));
            this.ShowCustomersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ShowCustomersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowCustomersButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowCustomersButton.Location = new System.Drawing.Point(868, 708);
            this.ShowCustomersButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowCustomersButton.Name = "ShowCustomersButton";
            this.ShowCustomersButton.Size = new System.Drawing.Size(302, 51);
            this.ShowCustomersButton.TabIndex = 5;
            this.ShowCustomersButton.Text = "Show customers";
            this.ShowCustomersButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 89);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(156)))), ((int)(((byte)(153)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(952, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 652);
            this.Controls.Add(this.ManePanel);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.ManePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ManePanel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AddNewFlatButton;
        private System.Windows.Forms.Button ShowCustomersButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
    }
}