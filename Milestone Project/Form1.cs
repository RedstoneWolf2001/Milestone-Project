using System;
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



        private void addButton_click(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {

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

        public bool MoveIndex(int index)
        {
            if (Index != index)
            {
                Index = index;
                return true;
            }
            else { return false; }
        }

    }





}
