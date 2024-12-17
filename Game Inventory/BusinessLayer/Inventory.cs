/*
 *Author: Seth Freeman
 *Date: 12/4/2024
 *Course: CST-150
 *Assignment: Final Milestone
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Game_Inventory.Models;

namespace Game_Inventory.BusinessLayer
{
    public class Inventory
    {
        private List<Game> GameList;
        private DataTable DataTable;
        private const int NUMBER_GAME_ATTRIBUTES = 6;

        public Inventory()
        {
            GameList = new List<Game>();
            DataTable = new DataTable();

            DataTable.Columns.Add("Title:", typeof(String));
            DataTable.Columns.Add("Price:", typeof(decimal));
            DataTable.Columns.Add("Quantity:", typeof(int));
            DataTable.Columns.Add("Rating:", typeof(String));
            DataTable.Columns.Add("Genre:", typeof(String));
            DataTable.Columns.Add("Description", typeof(String));
        }

        /*
         * Checks if the game already exists in the game list
         * via the overriden .Equals() method and adds to its quantity if
         * it does, or just adds to game list if not.
         */
        public void AddGame(Game Game)
        {
            foreach(Game GameItem in GameList)
            {
                if(Game.Equals(GameItem))
                {
                    GameItem.SetQuantity(GameItem.GetQuantity() + Game.GetQuantity());
                    return;
                }
            }

            GameList.Add(Game);
        }

        /*
         * Simply removes the game from the game list.
         */
        public void RemoveGame(Game Game)
        {
            GameList.Remove(Game);
        }

        /*
         * Creates a new DataTable and fills its rows with Games
         * that contain the search criteria by title or description.
         */
        public DataTable SearchGames(String Criteria)
        {
            DataTable DataTable = new DataTable();
            DataTable.Columns.Add("Title:", typeof(String));
            DataTable.Columns.Add("Price:", typeof(decimal));
            DataTable.Columns.Add("Quantity:", typeof(int));
            DataTable.Columns.Add("Rating:", typeof(String));
            DataTable.Columns.Add("Genre:", typeof(String));
            DataTable.Columns.Add("Description", typeof(String));

            foreach(Game Game in GameList)
            {
                if(Game.GetTitle().ToLower().Contains(Criteria.ToLower()) ||
                    Game.GetDescription().ToLower().Contains(Criteria.ToLower()))
                {
                    DataTable.Rows.Add(Game.GetTitle(), Game.GetPrice(),
                        Game.GetQuantity(), Game.GetRating(), Game.GetGenre(),
                        Game.GetDescription());
                }
            }

            return DataTable;
        }

        /*
         * Returns the game list.
         */
        public List<Game> GetGameList()
        {
            return GameList;
        }

        /*
         * Writes each game as a line and writes them
         * to the file provided by the filepath.
         */
        public void SaveInventoryToFile(String FilePath)
        {
            String[] Lines = new String[GameList.Count];
            
            for(int i = 0; i < GameList.Count; i++)
            {
                Game Game = GameList[i];

                String Title = Game.GetTitle();
                decimal Price = Game.GetPrice();
                int Quantity = Game.GetQuantity();
                String Rating = Game.GetRating();
                String Genre = Game.GetGenre();
                String Description = Game.GetDescription();

                String Line = String.Format("{0},{1},{2},{3},{4},{5}", Title,
                    Price, Quantity, Rating, Genre, Description);
                Lines[i] = Line;
            }

            File.WriteAllLines(FilePath, Lines);
        }

        /*
         * Parses lines (games) from the file provided
         * by the filepath.
         */
        public void LoadInventoryFromFile(String FilePath)
        {
            String[] FileLines = File.ReadAllLines(FilePath);

            foreach(String CurrentLine in FileLines)
            {
                String[] GameAttributes = CurrentLine.Split(",");

                if (GameAttributes.Length != NUMBER_GAME_ATTRIBUTES)
                {
                    continue;
                }

                if (IsValidInputs(GameAttributes[0], GameAttributes[1],
                    GameAttributes[2], GameAttributes[3], GameAttributes[4],
                    GameAttributes[5]))
                {
                    Game Game = new Game(GameAttributes[0],
                        decimal.Parse(GameAttributes[1]), int.Parse(GameAttributes[2]),
                        GameAttributes[3], GameAttributes[4], GameAttributes[5]);

                    AddGame(Game);
                }
            }
        }

        /*
         * Clears and refills the ListBox in the main form.
         */
        public void UpdateListBox(ListBox ListBox)
        {
            ListBox.Items.Clear();

            foreach(Game Game in GameList)
            {
                ListBox.Items.Add(Game);
            }
        }
        
        /*
         * Clears the DataTable and refills the rows
         * with the games in the game list.
         */
        public void UpdateDataGridView(DataGridView DataGridView)
        {
            DataTable.Clear();

            foreach(Game Game in GameList)
            {
                DataTable.Rows.Add(Game.GetTitle(), Game.GetPrice(),
                    Game.GetQuantity(), Game.GetRating(), Game.GetGenre(),
                    Game.GetDescription());
            }

            DataGridView.DataSource = null;
            DataGridView.DataSource = DataTable;
        }

        /*
         * Checks if the inputs for Game attributes are valid such as 
         * length and parsing numerics.
         */
        public bool IsValidInputs(String Title, String Price, String Quantity,
            String Rating, String Genre, String Description)
        {
            int TestQuantity = 0;
            decimal TestPrice = 0.0M;

            if (Title.Length <= 0) return false;
            if (!decimal.TryParse(Price, out TestPrice)) return false;
            if (!int.TryParse(Quantity, out TestQuantity)) return false;
            if (Rating.Length <= 0) return false;
            if (Genre.Length <= 0) return false;
            if (Description.Length <= 0) return false;

            return true;
        }
    }
}
