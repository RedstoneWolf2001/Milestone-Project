using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_Project
{
    public class Book
    {
        //set up variables
        private string Genre;
        private string Title;
        private int Quantity;

        public Book(string genre, string title, int quantity)//defining book
        {
            Genre = genre;
            Title = title;
            Quantity = quantity;
        }
        //gets
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
        //sets
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
        //to output properly in the Form
        public override string ToString()
        {
            return (Genre + " " + Title + " " + Quantity);
        }
    }
}
