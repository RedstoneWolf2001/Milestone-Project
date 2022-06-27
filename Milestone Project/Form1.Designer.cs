namespace Milestone_Project
{
    partial class Inventory
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
            this.DataListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.reorderButton = new System.Windows.Forms.Button();
            this.readGenreTB = new System.Windows.Forms.TextBox();
            this.readTitleTB = new System.Windows.Forms.TextBox();
            this.searchTitleTB = new System.Windows.Forms.TextBox();
            this.searchGenreTB = new System.Windows.Forms.TextBox();
            this.readIndexTB = new System.Windows.Forms.TextBox();
            this.GenreLB = new System.Windows.Forms.Label();
            this.IndexLB = new System.Windows.Forms.Label();
            this.TitleLB = new System.Windows.Forms.Label();
            this.searchIndexTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DataListBox
            // 
            this.DataListBox.FormattingEnabled = true;
            this.DataListBox.Location = new System.Drawing.Point(13, 13);
            this.DataListBox.Name = "DataListBox";
            this.DataListBox.Size = new System.Drawing.Size(321, 95);
            this.DataListBox.TabIndex = 0;
            this.DataListBox.SelectedIndexChanged += new System.EventHandler(this.DataListBox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addButton.Location = new System.Drawing.Point(13, 167);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(95, 167);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(177, 167);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // reorderButton
            // 
            this.reorderButton.Location = new System.Drawing.Point(259, 167);
            this.reorderButton.Name = "reorderButton";
            this.reorderButton.Size = new System.Drawing.Size(75, 23);
            this.reorderButton.TabIndex = 4;
            this.reorderButton.Text = "Set";
            this.reorderButton.UseVisualStyleBackColor = true;
            this.reorderButton.Click += new System.EventHandler(this.reorderButton_Click);
            // 
            // readGenreTB
            // 
            this.readGenreTB.Location = new System.Drawing.Point(13, 141);
            this.readGenreTB.Name = "readGenreTB";
            this.readGenreTB.Size = new System.Drawing.Size(75, 20);
            this.readGenreTB.TabIndex = 5;
            // 
            // readTitleTB
            // 
            this.readTitleTB.Location = new System.Drawing.Point(142, 141);
            this.readTitleTB.Name = "readTitleTB";
            this.readTitleTB.Size = new System.Drawing.Size(192, 20);
            this.readTitleTB.TabIndex = 6;
            // 
            // searchTitleTB
            // 
            this.searchTitleTB.Location = new System.Drawing.Point(142, 196);
            this.searchTitleTB.Name = "searchTitleTB";
            this.searchTitleTB.Size = new System.Drawing.Size(192, 20);
            this.searchTitleTB.TabIndex = 9;
            this.searchTitleTB.Text = "Search";
            // 
            // searchGenreTB
            // 
            this.searchGenreTB.Location = new System.Drawing.Point(13, 196);
            this.searchGenreTB.Name = "searchGenreTB";
            this.searchGenreTB.Size = new System.Drawing.Size(75, 20);
            this.searchGenreTB.TabIndex = 7;
            this.searchGenreTB.Text = "Type?";
            // 
            // readIndexTB
            // 
            this.readIndexTB.Location = new System.Drawing.Point(95, 141);
            this.readIndexTB.Name = "readIndexTB";
            this.readIndexTB.Size = new System.Drawing.Size(41, 20);
            this.readIndexTB.TabIndex = 9;
            // 
            // GenreLB
            // 
            this.GenreLB.AutoSize = true;
            this.GenreLB.Location = new System.Drawing.Point(13, 115);
            this.GenreLB.Name = "GenreLB";
            this.GenreLB.Size = new System.Drawing.Size(36, 13);
            this.GenreLB.TabIndex = 11;
            this.GenreLB.Text = "Genre";
            // 
            // IndexLB
            // 
            this.IndexLB.AutoSize = true;
            this.IndexLB.Location = new System.Drawing.Point(95, 115);
            this.IndexLB.Name = "IndexLB";
            this.IndexLB.Size = new System.Drawing.Size(33, 13);
            this.IndexLB.TabIndex = 12;
            this.IndexLB.Text = "Index";
            // 
            // TitleLB
            // 
            this.TitleLB.AutoSize = true;
            this.TitleLB.Location = new System.Drawing.Point(142, 115);
            this.TitleLB.Name = "TitleLB";
            this.TitleLB.Size = new System.Drawing.Size(27, 13);
            this.TitleLB.TabIndex = 13;
            this.TitleLB.Text = "Title";
            // 
            // searchIndexTB
            // 
            this.searchIndexTB.Enabled = false;
            this.searchIndexTB.Location = new System.Drawing.Point(95, 196);
            this.searchIndexTB.Name = "searchIndexTB";
            this.searchIndexTB.Size = new System.Drawing.Size(41, 20);
            this.searchIndexTB.TabIndex = 8;
            this.searchIndexTB.Text = "Num";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 234);
            this.Controls.Add(this.TitleLB);
            this.Controls.Add(this.IndexLB);
            this.Controls.Add(this.GenreLB);
            this.Controls.Add(this.searchIndexTB);
            this.Controls.Add(this.readIndexTB);
            this.Controls.Add(this.searchTitleTB);
            this.Controls.Add(this.searchGenreTB);
            this.Controls.Add(this.readTitleTB);
            this.Controls.Add(this.readGenreTB);
            this.Controls.Add(this.reorderButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.DataListBox);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DataListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button reorderButton;
        private System.Windows.Forms.TextBox readGenreTB;
        private System.Windows.Forms.TextBox readTitleTB;
        private System.Windows.Forms.TextBox searchTitleTB;
        private System.Windows.Forms.TextBox searchGenreTB;
        private System.Windows.Forms.TextBox readIndexTB;
        private System.Windows.Forms.Label GenreLB;
        private System.Windows.Forms.Label IndexLB;
        private System.Windows.Forms.Label TitleLB;
        private System.Windows.Forms.TextBox searchIndexTB;
    }
}

