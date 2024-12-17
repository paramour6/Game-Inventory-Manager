namespace Game_Inventory
{
    partial class InventoryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StockGroupBox = new GroupBox();
            SearchButton = new Button();
            FileSavedLabel = new Label();
            SaveFileButton = new Button();
            LoadFileButton = new Button();
            EditGameButton = new Button();
            GameDescriptionTextBox = new TextBox();
            GameGenreLabel = new Label();
            GameRatingLabel = new Label();
            GameQuantityLabel = new Label();
            GamePriceLabel = new Label();
            RemoveGameButton = new Button();
            AddGameButton = new Button();
            GenreLabel = new Label();
            RatingLabel = new Label();
            QuantityLabel = new Label();
            PriceLabel = new Label();
            DescriptionLabel = new Label();
            GameListBox = new ListBox();
            DisplayGroupBox = new GroupBox();
            dgvInventoryDisplay = new DataGridView();
            LoadFileDialog = new OpenFileDialog();
            StockGroupBox.SuspendLayout();
            DisplayGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventoryDisplay).BeginInit();
            SuspendLayout();
            // 
            // StockGroupBox
            // 
            StockGroupBox.Controls.Add(SearchButton);
            StockGroupBox.Controls.Add(FileSavedLabel);
            StockGroupBox.Controls.Add(SaveFileButton);
            StockGroupBox.Controls.Add(LoadFileButton);
            StockGroupBox.Controls.Add(EditGameButton);
            StockGroupBox.Controls.Add(GameDescriptionTextBox);
            StockGroupBox.Controls.Add(GameGenreLabel);
            StockGroupBox.Controls.Add(GameRatingLabel);
            StockGroupBox.Controls.Add(GameQuantityLabel);
            StockGroupBox.Controls.Add(GamePriceLabel);
            StockGroupBox.Controls.Add(RemoveGameButton);
            StockGroupBox.Controls.Add(AddGameButton);
            StockGroupBox.Controls.Add(GenreLabel);
            StockGroupBox.Controls.Add(RatingLabel);
            StockGroupBox.Controls.Add(QuantityLabel);
            StockGroupBox.Controls.Add(PriceLabel);
            StockGroupBox.Controls.Add(DescriptionLabel);
            StockGroupBox.Controls.Add(GameListBox);
            StockGroupBox.Location = new Point(12, 12);
            StockGroupBox.Name = "StockGroupBox";
            StockGroupBox.Size = new Size(617, 563);
            StockGroupBox.TabIndex = 0;
            StockGroupBox.TabStop = false;
            StockGroupBox.Text = "Stock";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(6, 511);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(136, 46);
            SearchButton.TabIndex = 16;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButtonClickEvent;
            // 
            // FileSavedLabel
            // 
            FileSavedLabel.AutoSize = true;
            FileSavedLabel.ForeColor = Color.Green;
            FileSavedLabel.Location = new Point(432, 525);
            FileSavedLabel.Name = "FileSavedLabel";
            FileSavedLabel.Size = new Size(137, 32);
            FileSavedLabel.TabIndex = 15;
            FileSavedLabel.Text = "File Saved...";
            // 
            // SaveFileButton
            // 
            SaveFileButton.Location = new Point(290, 511);
            SaveFileButton.Name = "SaveFileButton";
            SaveFileButton.Size = new Size(136, 46);
            SaveFileButton.TabIndex = 14;
            SaveFileButton.Text = "Save File";
            SaveFileButton.UseVisualStyleBackColor = true;
            SaveFileButton.Click += SaveFileClickEvent;
            // 
            // LoadFileButton
            // 
            LoadFileButton.Location = new Point(148, 511);
            LoadFileButton.Name = "LoadFileButton";
            LoadFileButton.Size = new Size(136, 46);
            LoadFileButton.TabIndex = 13;
            LoadFileButton.Text = "Load File";
            LoadFileButton.UseVisualStyleBackColor = true;
            LoadFileButton.Click += LoadFileClickEvent;
            // 
            // EditGameButton
            // 
            EditGameButton.Location = new Point(148, 456);
            EditGameButton.Name = "EditGameButton";
            EditGameButton.Size = new Size(136, 46);
            EditGameButton.TabIndex = 2;
            EditGameButton.Text = "Edit";
            EditGameButton.UseVisualStyleBackColor = true;
            EditGameButton.Click += EditGameClickEvent;
            // 
            // GameDescriptionTextBox
            // 
            GameDescriptionTextBox.Location = new Point(252, 73);
            GameDescriptionTextBox.Multiline = true;
            GameDescriptionTextBox.Name = "GameDescriptionTextBox";
            GameDescriptionTextBox.ReadOnly = true;
            GameDescriptionTextBox.ScrollBars = ScrollBars.Vertical;
            GameDescriptionTextBox.Size = new Size(359, 144);
            GameDescriptionTextBox.TabIndex = 5;
            // 
            // GameGenreLabel
            // 
            GameGenreLabel.AutoSize = true;
            GameGenreLabel.Location = new Point(369, 394);
            GameGenreLabel.Name = "GameGenreLabel";
            GameGenreLabel.Size = new Size(78, 32);
            GameGenreLabel.TabIndex = 12;
            GameGenreLabel.Text = "Genre";
            // 
            // GameRatingLabel
            // 
            GameRatingLabel.AutoSize = true;
            GameRatingLabel.Location = new Point(369, 336);
            GameRatingLabel.Name = "GameRatingLabel";
            GameRatingLabel.Size = new Size(82, 32);
            GameRatingLabel.TabIndex = 11;
            GameRatingLabel.Text = "Rating";
            // 
            // GameQuantityLabel
            // 
            GameQuantityLabel.AutoSize = true;
            GameQuantityLabel.Location = new Point(369, 278);
            GameQuantityLabel.Name = "GameQuantityLabel";
            GameQuantityLabel.Size = new Size(102, 32);
            GameQuantityLabel.TabIndex = 10;
            GameQuantityLabel.Text = "quantity";
            // 
            // GamePriceLabel
            // 
            GamePriceLabel.AutoSize = true;
            GamePriceLabel.Location = new Point(360, 220);
            GamePriceLabel.Name = "GamePriceLabel";
            GamePriceLabel.Size = new Size(79, 32);
            GamePriceLabel.TabIndex = 9;
            GamePriceLabel.Text = "$price";
            // 
            // RemoveGameButton
            // 
            RemoveGameButton.Location = new Point(290, 456);
            RemoveGameButton.Name = "RemoveGameButton";
            RemoveGameButton.Size = new Size(136, 46);
            RemoveGameButton.TabIndex = 3;
            RemoveGameButton.Text = "Remove";
            RemoveGameButton.UseVisualStyleBackColor = true;
            RemoveGameButton.Click += RemoveGameClickEvent;
            // 
            // AddGameButton
            // 
            AddGameButton.Location = new Point(6, 456);
            AddGameButton.Name = "AddGameButton";
            AddGameButton.Size = new Size(136, 46);
            AddGameButton.TabIndex = 1;
            AddGameButton.Text = "Add Game";
            AddGameButton.UseVisualStyleBackColor = true;
            AddGameButton.Click += AddGameClickEvent;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(252, 394);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(83, 32);
            GenreLabel.TabIndex = 5;
            GenreLabel.Text = "Genre:";
            // 
            // RatingLabel
            // 
            RatingLabel.AutoSize = true;
            RatingLabel.Location = new Point(252, 336);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(87, 32);
            RatingLabel.TabIndex = 4;
            RatingLabel.Text = "Rating:";
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Location = new Point(252, 278);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(111, 32);
            QuantityLabel.TabIndex = 3;
            QuantityLabel.Text = "Quantity:";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(252, 220);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(70, 32);
            PriceLabel.TabIndex = 2;
            PriceLabel.Text = "Price:";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(252, 38);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(140, 32);
            DescriptionLabel.TabIndex = 1;
            DescriptionLabel.Text = "Description:";
            // 
            // GameListBox
            // 
            GameListBox.FormattingEnabled = true;
            GameListBox.Location = new Point(6, 38);
            GameListBox.Name = "GameListBox";
            GameListBox.Size = new Size(240, 388);
            GameListBox.TabIndex = 0;
            GameListBox.SelectedIndexChanged += GameListSelectedIndexChange;
            // 
            // DisplayGroupBox
            // 
            DisplayGroupBox.Controls.Add(dgvInventoryDisplay);
            DisplayGroupBox.Location = new Point(635, 12);
            DisplayGroupBox.Name = "DisplayGroupBox";
            DisplayGroupBox.Size = new Size(644, 563);
            DisplayGroupBox.TabIndex = 1;
            DisplayGroupBox.TabStop = false;
            DisplayGroupBox.Text = "Inventory Display";
            // 
            // dgvInventoryDisplay
            // 
            dgvInventoryDisplay.AllowUserToAddRows = false;
            dgvInventoryDisplay.AllowUserToDeleteRows = false;
            dgvInventoryDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventoryDisplay.Location = new Point(6, 38);
            dgvInventoryDisplay.Name = "dgvInventoryDisplay";
            dgvInventoryDisplay.ReadOnly = true;
            dgvInventoryDisplay.RowHeadersWidth = 82;
            dgvInventoryDisplay.Size = new Size(632, 519);
            dgvInventoryDisplay.TabIndex = 0;
            // 
            // LoadFileDialog
            // 
            LoadFileDialog.FileName = "openFileDialog1";
            // 
            // GameInventoryForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 587);
            Controls.Add(DisplayGroupBox);
            Controls.Add(StockGroupBox);
            Name = "GameInventoryForm";
            Text = "Game Inventory";
            Load += GameInventoryFormEventLoad;
            StockGroupBox.ResumeLayout(false);
            StockGroupBox.PerformLayout();
            DisplayGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventoryDisplay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox StockGroupBox;
        private ListBox GameListBox;
        private Label RatingLabel;
        private Label QuantityLabel;
        private Label PriceLabel;
        private Label DescriptionLabel;
        private Label GenreLabel;
        private Button RemoveGameButton;
        private Button AddGameButton;
        private Label GameGenreLabel;
        private Label GameRatingLabel;
        private Label GameQuantityLabel;
        private Label GamePriceLabel;
        private TextBox GameDescriptionTextBox;
        private Button EditGameButton;
        private GroupBox DisplayGroupBox;
        private Button LoadFileButton;
        private OpenFileDialog LoadFileDialog;
        private Button SaveFileButton;
        private DataGridView dgvInventoryDisplay;
        private Label FileSavedLabel;
        private Button SearchButton;
    }
}
