/*
 *Author: Seth Freeman
 *Date: 12/4/2024
 *Course: CST-150
 *Assignment: Final Milestone
 */

using Game_Inventory.Models;
using Game_Inventory.BusinessLayer;
using Game_Inventory.PresentationLayer;
using System.Data;

namespace Game_Inventory
{
    public partial class InventoryForm : Form
    {
        private Inventory GameInventory;

        public InventoryForm()
        {
            InitializeComponent();

            GameInventory = new Inventory();
        }

        /*
         * Called when main form loads. Sets up LoadFileDialog,
         * clears the labels, and disables buttons.
         */
        private void GameInventoryFormEventLoad(object sender, EventArgs e)
        {
            LoadFileDialog.InitialDirectory = Application.StartupPath + @"Data";
            LoadFileDialog.Title = "Select Load File";
            LoadFileDialog.DefaultExt = "txt";
            LoadFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            GameDescriptionTextBox.Text = "";
            GamePriceLabel.Text = "";
            GameQuantityLabel.Text = "";
            GameRatingLabel.Text = "";
            GameGenreLabel.Text = "";
            FileSavedLabel.Text = "";

            GameInventory.UpdateDataGridView(dgvInventoryDisplay);

            EditGameButton.Enabled = false;
            RemoveGameButton.Enabled = false;
            SearchButton.Enabled = false;
        }

        /*
         * Creates a new InputForm to add game information
         * then updates the inventory display.
         */
        private void AddGameClickEvent(object sender, EventArgs e)
        {
            InputForm InputForm = new InputForm(this);
            InputForm.ShowDialog();

            UpdateInventoryDisplay();
        }

        /*
         * Removes the selected game from the game list
         * and opens new InputForm to modify its info before
         * sending it back again.
         */
        private void EditGameClickEvent(object sender, EventArgs e)
        {
            int Index = GameListBox.SelectedIndex;

            if (Index >= 0 && Index < GameInventory.GetGameList().Count)
            {
                Game Game = GameInventory.GetGameList()[Index];
                GameInventory.RemoveGame(Game);
                GameListBox.Items.Remove(Game);

                InputForm InputForm = new InputForm(this, Game);
                InputForm.ShowDialog();

                UpdateInventoryDisplay();
            }
        }

        /*
         * Removes the game with specified index from game list
         * and updates inventory display.
         */
        private void RemoveGameClickEvent(object sender, EventArgs e)
        {
            int Index = GameListBox.SelectedIndex;

            if (Index >= 0 && Index < GameInventory.GetGameList().Count)
            {
                Game Game = GameInventory.GetGameList()[Index];
                GameInventory.RemoveGame(Game);

                UpdateInventoryDisplay();
            }
        }

        /*
         * Opens a SearchForm window that performs all the logic.
         */
        private void SearchButtonClickEvent(object sender, EventArgs e)
        {
            SearchForm SearchForm = new SearchForm(this);
            SearchForm.ShowDialog();
        }

        /*
         * Calls the LoadInventory method in GameInventory by providing
         * the filepath from the file dialog.
         */
        private void LoadFileClickEvent(object sender, EventArgs e)
        {
            DialogResult DialogResult = LoadFileDialog.ShowDialog();

            if (DialogResult != DialogResult.OK)
            {
                return;
            }

            GameInventory.LoadInventoryFromFile(LoadFileDialog.FileName);
            UpdateInventoryDisplay();
        }

        /*
         * Calls the SaveFile method in GameInventory by
         * providing the filepath.
         */
        private void SaveFileClickEvent(object sender, EventArgs e)
        {
            GameInventory.SaveInventoryToFile(Application.StartupPath +
                "\\Data\\Inventory.txt");
            FileSavedLabel.Text = "File Saved...";
        }

        /*
         * When user clicks different item in the ListBox, this is called
         * which will update the labels with the game's info.
         */
        private void GameListSelectedIndexChange(object sender, EventArgs e)
        {
            int Index = GameListBox.SelectedIndex;

            if (Index >= 0 && Index < GameListBox.Items.Count)
            {
                EditGameButton.Enabled = true;
                RemoveGameButton.Enabled = true;

                Game Game = GameInventory.GetGameList()[Index];
                GameDescriptionTextBox.Text = Game.GetDescription();
                GamePriceLabel.Text = "$" + Convert.ToString(Game.GetPrice());
                GameQuantityLabel.Text = Convert.ToString(Game.GetQuantity());
                GameRatingLabel.Text = Game.GetRating();
                GameGenreLabel.Text = Game.GetGenre();
            }
        }

        /*
         * Updates the ListBox and DataGridView as well as updates
         * labels and button states depending on SelectedIndex or
         * if any games are in the list.
         */
        private void UpdateInventoryDisplay()
        {
            GameInventory.UpdateListBox(GameListBox);
            GameInventory.UpdateDataGridView(dgvInventoryDisplay);

            FileSavedLabel.Text = "";

            int Index = GameListBox.SelectedIndex;

            if (GameListBox.Items.Count > 0)
            {
                SearchButton.Enabled = true;
            }
            else SearchButton.Enabled = false;

            if (Index >= 0 && Index < GameListBox.Items.Count)
            {
                EditGameButton.Enabled = true;
                RemoveGameButton.Enabled = true;

                Game Game = GameInventory.GetGameList()[Index];
                GameDescriptionTextBox.Text = Game.GetDescription();
                GamePriceLabel.Text = "$" + Convert.ToString(Game.GetPrice());
                GameQuantityLabel.Text = Convert.ToString(Game.GetQuantity());
                GameRatingLabel.Text = Game.GetRating();
                GameGenreLabel.Text = Game.GetGenre();
            }
            else
            {
                EditGameButton.Enabled = false;
                RemoveGameButton.Enabled = false;

                GameDescriptionTextBox.Text = "";
                GamePriceLabel.Text = "";
                GameQuantityLabel.Text = "";
                GameRatingLabel.Text = "";
                GameGenreLabel.Text = "";
            }
        }

        /*
         * Returns the GameInventory. Used in other forms.
         */
        public Inventory GetInventory()
        {
            return GameInventory;
        }
    }
}