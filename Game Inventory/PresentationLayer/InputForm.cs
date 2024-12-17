/*
 *Author: Seth Freeman
 *Date: 12/16/2024
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_Inventory.Models;
using Game_Inventory.BusinessLayer;

namespace Game_Inventory
{
    public partial class InputForm : Form
    {
        private new InventoryForm ParentForm;

        /*
         * This constructor is for adding a new game.
         */
        public InputForm(InventoryForm ParentForm)
        {
            InitializeComponent();

            this.ParentForm = ParentForm;
            InvalidInputsLabel.Text = "";
        }

        /*
         * This constructor is for modifying an existing game.
         */
        public InputForm(InventoryForm ParentForm, Game Game)
        {
            InitializeComponent();

            this.ParentForm = ParentForm;
            InvalidInputsLabel.Text = "";

            GameTitleTextBox.Text = Game.GetTitle();
            GamePriceTextBox.Text = Convert.ToString(Game.GetPrice());
            GameQuantityTextBox.Text = Convert.ToString(Game.GetQuantity());
            GameRatingComboBox.Text = Game.GetRating();
            GameGenreTextBox.Text = Game.GetGenre();
            GameDescriptionTextBox.Text = Game.GetDescription();
        }

        /*
         * Parses information from textboxes if their validand adds
         * it to the GameInventory.
         */
        private void DoneButtonClickEvent(object sender, EventArgs e)
        {
            Inventory GameInventory = ParentForm.GetInventory();

            String Title = GameTitleTextBox.Text;
            String Price = GamePriceTextBox.Text;
            String Quantity = GameQuantityTextBox.Text;
            String Rating = GameRatingComboBox.Text;
            String Genre = GameGenreTextBox.Text;
            String Description = GameDescriptionTextBox.Text;

            if(GameInventory.IsValidInputs(Title, Price, Quantity, Rating,
                Genre, Description))
            {
                Game Game = new Game(Title, decimal.Parse(Price), int.Parse(Quantity),
                    Rating, Genre, Description);
                GameInventory.AddGame(Game);

                this.Close();
            }
            else
            {
                InvalidInputsLabel.Text = "Invalid Inputs!";
            }
        }
    }
}
