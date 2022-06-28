/*  Code by Chris Peterson
    Milestone 2
    06-13-2022 at turn in
*/

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_Project
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            readIndexTB.Text = DataListBox.Items.Count.ToString();
        }



        private void addButton_click(object sender, EventArgs e)
        {
            Book input = new Book(readGenreTB.Text, DataListBox.Items.Count, readTitleTB.Text);
            DataListBox.Items.Add(input);
            readIndexTB.Text = DataListBox.Items.Count.ToString();
            readGenreTB.Clear();
            readTitleTB.Clear();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Book input = (Book)DataListBox.SelectedItem;
            input.SetGenre(readGenreTB.Text);
            input.SetTitle(readTitleTB.Text);
            input.SetIndex(int.Parse(readIndexTB.Text));
            DataListBox.Items.Remove(DataListBox.SelectedItem);

            DataListBox.Items.Insert(input.GetIndex(), input);
            readIndexTB.Text = DataListBox.Items.Count.ToString();

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            DataListBox.Items.Remove(DataListBox.SelectedItem);
        }

        private void reorderButton_Click(object sender, EventArgs e)
        {
            Book input = (Book)DataListBox.SelectedItem;
            searchGenreTB.Text = input.GetGenre();
            searchTitleTB.Text = input.GetTitle();
            searchIndexTB.Text = input.GetIndex().ToString();
        }

        private void DataListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book input = (Book)DataListBox.SelectedItem;
            if (input != null)
            {
                readGenreTB.Text = input.GetGenre();
                readTitleTB.Text = input.GetTitle();
                readIndexTB.Text = input.GetIndex().ToString();
            }

        }
    }



    public class Book
    {

        private string Genre;
        private int Index;
        private string Title;

        public Book(string genre, int index, string title)
        {
            Genre = genre;
            Index = index;
            Title = title;
        }

        public string GetGenre()
        {
            return Genre;
        }

        public string GetTitle()
        {
            return Title;
        }

        public int GetIndex()
        {
            return Index;
        }

        public void SetGenre(string genre)
        {
            Genre = genre.Trim();
        }

        public void SetTitle(string title)
        {
            Title = title.Trim();
        }

        public void SetIndex(int index)
        {
            Index = index;
        }

        public override string ToString()
        {
            return Genre + " " + Index + " " + Title;
        }

    }




}
