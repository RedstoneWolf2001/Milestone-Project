/*  Code by Chris Peterson
    Milestone 3
    06-28-2022 at turn in
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
        }



        private void addButton_click(object sender, EventArgs e) //Adds an item to the list
        {
            if (int.TryParse(readQuantityTB.Text, out int quantity))
            {
                Book input = new Book(readGenreTB.Text, readTitleTB.Text, quantity);
                DataListBox.Items.Add(input);
                readGenreTB.Clear();
                readTitleTB.Clear();
                readQuantityTB.Clear();
            }
        }

        private void editButton_Click(object sender, EventArgs e)//Takes the populated item and edits it
        {
            Book input = (Book)DataListBox.SelectedItem;
            if (input != null)
            {
                input.SetGenre(readGenreTB.Text);
                input.SetTitle(readTitleTB.Text);
                input.SetQuantity(int.Parse(readQuantityTB.Text));

                DataListBox.Items.Remove(DataListBox.SelectedItem);
                DataListBox.Items.Add(input);
            }
        }

        private void removeButton_Click(object sender, EventArgs e) //Removes the selected item
        {
            DataListBox.Items.Remove(DataListBox.SelectedItem);
        }

        private void searchButton_Click(object sender, EventArgs e) // Searches for an item based off of the approprate criteria
        {
            Book input = (Book)DataListBox.SelectedItem;

            if (searchGenreTB.Text.Trim().Length > 0)
                DataListBox.SelectedIndex = DataListBox.FindString(searchGenreTB.Text);
            else if (searchTitleTB.Text.Trim().Length > 0)
                DataListBox.SelectedIndex = DataListBox.FindString(searchTitleTB.Text);

            
        }

        private void DataListBox_SelectedIndexChanged(object sender, EventArgs e) //Populates the text boxes for editing and removing.
        {
            Book input = (Book)DataListBox.SelectedItem;
            if (input != null)
            {
                readGenreTB.Text = input.GetGenre();
                readTitleTB.Text = input.GetTitle();
                readQuantityTB.Text = input.GetQuantity().ToString();
            }

        }

        private void searchGenreTB_Enter(object sender, EventArgs e) //Clears the box for input
        {
            searchGenreTB.Clear();
        }
    }



    public class Book
    {

        private string Genre;
        private string Title;
        private int Quantity;

        public Book(string genre, string title, int quantity)
        {
            Genre = genre;
            Title = title;
            Quantity = quantity;
        }

        public string GetGenre()
        {
            return Genre;
        }

        public string GetTitle()
        {
            return Title;
        }

        public int GetQuantity()
        {
            return Quantity;
        }

        public void SetGenre(string genre)
        {
            Genre = genre.Trim();
        }

        public void SetTitle(string title)
        {
            Title = title.Trim();
        }

        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }

        public override string ToString()
        {
            return (Genre + " " + Title + " " + Quantity);
        }
    }
}
