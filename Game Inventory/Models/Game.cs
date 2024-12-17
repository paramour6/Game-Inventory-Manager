/*
 *Author: Seth Freeman
 *Date: 12/16/2024
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Inventory.Models
{
    public class Game
    {
        private string Title { get; set; }
        private decimal Price { get; set; }
        private int Quantity { get; set; }
        private string Rating { get; set; }
        private string Genre { get; set; }
        private string Description { get; set; }

        public Game(string Title, decimal Price, int Quantity, string Rating, string Genre, string Description)
        {
            this.Title = Title;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Rating = Rating;
            this.Genre = Genre;
            this.Description = Description;
        }

        /*
         * Overridden ToString() method to show the title
         * in the list box.
         */
        public override string ToString()
        {
            return Title;
        }

        /*
         * Overridden Equals() method for comparing
         * two Game objects.
         */
        public override bool Equals(object? Object)
        {
            if (Object == null) return false;
            if (Object.GetType() != GetType()) return false;

            Game Game = (Game)Object;

            return GetTitle() == Game.GetTitle()
                && GetPrice() == Game.GetPrice()
                && GetRating() == Game.GetRating()
                && GetGenre() == Game.GetGenre()
                && GetDescription() == Game.GetDescription();
        }

        /*
         * Also has to be overridden if you want to 
         * override .Equals().
         */
        public override int GetHashCode()
        {
            return HashCode.Combine(GetTitle(), GetPrice(), GetRating(), GetGenre(), GetDescription());
        }

        public string GetTitle() { return Title; }
        public void SetTitle(string Title) { this.Title = Title; }
        public decimal GetPrice() { return Price; }
        public void SetPrice(decimal Price) { this.Price = Price; }
        public int GetQuantity() { return Quantity; }
        public void SetQuantity(int Quantity) { this.Quantity = Quantity; }
        public string GetRating() { return Rating; }
        public void SetRating(string Rating) { this.Rating = Rating; }
        public string GetGenre() { return Genre; }
        public void SetGenre(string Genre) { this.Genre = Genre; }
        public string GetDescription() { return Description; }
        public void SetDescription(string Description) { this.Description = Description; }
    }
}
