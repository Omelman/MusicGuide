﻿namespace MusicGuide.UserApp
{
    partial class MenuUser
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddNewFlatButton = new System.Windows.Forms.Button();
            this.ShowCustomersButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ManePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManePanel
            // 
            this.ManePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(218)))), ((int)(((byte)(219)))));
            this.ManePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManePanel.Controls.Add(this.button1);
            this.ManePanel.Controls.Add(this.label5);
            this.ManePanel.Controls.Add(this.label4);
            this.ManePanel.Controls.Add(this.listBox3);
            this.ManePanel.Controls.Add(this.listBox2);
            this.ManePanel.Controls.Add(this.label3);
            this.ManePanel.Controls.Add(this.listBox1);
            this.ManePanel.Controls.Add(this.AddNewFlatButton);
            this.ManePanel.Controls.Add(this.ShowCustomersButton);
            this.ManePanel.Controls.Add(this.panel2);
            this.ManePanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ManePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManePanel.Location = new System.Drawing.Point(0, 0);
            this.ManePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ManePanel.Name = "ManePanel";
            this.ManePanel.Size = new System.Drawing.Size(1011, 642);
            this.ManePanel.TabIndex = 8;
            this.ManePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ManePanel_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(653, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 37);
            this.label5.TabIndex = 18;
            this.label5.Text = "Songs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(367, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 37);
            this.label4.TabIndex = 17;
            this.label4.Text = "Albums";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(617, 185);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(189, 404);
            this.listBox3.TabIndex = 16;
            this.listBox3.DoubleClick += new System.EventHandler(this.listBox3_DoubleClick);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(336, 185);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(193, 404);
            this.listBox2.TabIndex = 15;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(96, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "Artists";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(48, 185);
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
            this.panel2.Size = new System.Drawing.Size(1009, 89);
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
            this.label1.Size = new System.Drawing.Size(1009, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(838, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 41);
            this.button1.TabIndex = 19;
            this.button1.Text = "Search music";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MenuUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 642);
            this.Controls.Add(this.ManePanel);
            this.Name = "MenuUser";
            this.Text = "MenuUser";
            this.ManePanel.ResumeLayout(false);
            this.ManePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ManePanel;
        private System.Windows.Forms.Button AddNewFlatButton;
        private System.Windows.Forms.Button ShowCustomersButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}