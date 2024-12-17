/*
 *Author: Seth Freeman
 *Date: 12/4/2024
 *Course: CST-150
 *Assignment: Final Milestone
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
using Game_Inventory.BusinessLayer;
using Game_Inventory.Models;

namespace Game_Inventory.PresentationLayer
{
    public partial class SearchForm : Form
    {
        private new InventoryForm ParentForm;

        public SearchForm(InventoryForm ParentForm)
        {
            InitializeComponent();

            this.ParentForm = ParentForm;
        }

        /*
         * Just assigns the DataTable returned from the method
         * in GameInventory to the DataGridView.
         */
        private void SearchButtonClickEvent(object sender, EventArgs e)
        {
            Inventory GameInventory = ParentForm.GetInventory();
            String Criteria = SearchTextBox.Text;

            dgvSearchResults.DataSource = null;
            dgvSearchResults.DataSource = GameInventory.SearchGames(Criteria);
        }
    }
}
