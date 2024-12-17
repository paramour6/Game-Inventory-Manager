namespace Game_Inventory
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GameTitleLabel = new Label();
            GameDescriptionLabel = new Label();
            GamePriceLabel = new Label();
            GameQuantityLabel = new Label();
            GameRatingLabel = new Label();
            GameGenreLabel = new Label();
            GameQuantityTextBox = new TextBox();
            GamePriceTextBox = new TextBox();
            GameTitleTextBox = new TextBox();
            GameGenreTextBox = new TextBox();
            GameRatingComboBox = new ComboBox();
            GameDescriptionTextBox = new TextBox();
            DoneButton = new Button();
            InvalidInputsLabel = new Label();
            SuspendLayout();
            // 
            // GameTitleLabel
            // 
            GameTitleLabel.AutoSize = true;
            GameTitleLabel.Location = new Point(12, 9);
            GameTitleLabel.Name = "GameTitleLabel";
            GameTitleLabel.Size = new Size(65, 32);
            GameTitleLabel.TabIndex = 0;
            GameTitleLabel.Text = "Title:";
            // 
            // GameDescriptionLabel
            // 
            GameDescriptionLabel.AutoSize = true;
            GameDescriptionLabel.Location = new Point(367, 6);
            GameDescriptionLabel.Name = "GameDescriptionLabel";
            GameDescriptionLabel.Size = new Size(140, 32);
            GameDescriptionLabel.TabIndex = 1;
            GameDescriptionLabel.Text = "Description:";
            // 
            // GamePriceLabel
            // 
            GamePriceLabel.AutoSize = true;
            GamePriceLabel.Location = new Point(12, 78);
            GamePriceLabel.Name = "GamePriceLabel";
            GamePriceLabel.Size = new Size(118, 32);
            GamePriceLabel.TabIndex = 2;
            GamePriceLabel.Text = "Price:     $";
            // 
            // GameQuantityLabel
            // 
            GameQuantityLabel.AutoSize = true;
            GameQuantityLabel.Location = new Point(12, 147);
            GameQuantityLabel.Name = "GameQuantityLabel";
            GameQuantityLabel.Size = new Size(111, 32);
            GameQuantityLabel.TabIndex = 3;
            GameQuantityLabel.Text = "Quantity:";
            // 
            // GameRatingLabel
            // 
            GameRatingLabel.AutoSize = true;
            GameRatingLabel.Location = new Point(12, 216);
            GameRatingLabel.Name = "GameRatingLabel";
            GameRatingLabel.Size = new Size(87, 32);
            GameRatingLabel.TabIndex = 4;
            GameRatingLabel.Text = "Rating:";
            // 
            // GameGenreLabel
            // 
            GameGenreLabel.AutoSize = true;
            GameGenreLabel.Location = new Point(12, 285);
            GameGenreLabel.Name = "GameGenreLabel";
            GameGenreLabel.Size = new Size(83, 32);
            GameGenreLabel.TabIndex = 5;
            GameGenreLabel.Text = "Genre:";
            // 
            // GameQuantityTextBox
            // 
            GameQuantityTextBox.Location = new Point(129, 144);
            GameQuantityTextBox.Name = "GameQuantityTextBox";
            GameQuantityTextBox.Size = new Size(217, 39);
            GameQuantityTextBox.TabIndex = 3;
            // 
            // GamePriceTextBox
            // 
            GamePriceTextBox.Location = new Point(129, 75);
            GamePriceTextBox.Name = "GamePriceTextBox";
            GamePriceTextBox.Size = new Size(217, 39);
            GamePriceTextBox.TabIndex = 2;
            // 
            // GameTitleTextBox
            // 
            GameTitleTextBox.Location = new Point(129, 6);
            GameTitleTextBox.Name = "GameTitleTextBox";
            GameTitleTextBox.Size = new Size(217, 39);
            GameTitleTextBox.TabIndex = 1;
            // 
            // GameGenreTextBox
            // 
            GameGenreTextBox.Location = new Point(129, 282);
            GameGenreTextBox.Name = "GameGenreTextBox";
            GameGenreTextBox.Size = new Size(217, 39);
            GameGenreTextBox.TabIndex = 5;
            // 
            // GameRatingComboBox
            // 
            GameRatingComboBox.FormattingEnabled = true;
            GameRatingComboBox.Items.AddRange(new object[] { "E", "T", "M", "18+" });
            GameRatingComboBox.Location = new Point(129, 213);
            GameRatingComboBox.Name = "GameRatingComboBox";
            GameRatingComboBox.Size = new Size(217, 40);
            GameRatingComboBox.TabIndex = 4;
            GameRatingComboBox.Text = "Select Rating";
            // 
            // GameDescriptionTextBox
            // 
            GameDescriptionTextBox.Location = new Point(513, 9);
            GameDescriptionTextBox.Multiline = true;
            GameDescriptionTextBox.Name = "GameDescriptionTextBox";
            GameDescriptionTextBox.Size = new Size(263, 312);
            GameDescriptionTextBox.TabIndex = 6;
            // 
            // DoneButton
            // 
            DoneButton.Location = new Point(332, 340);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new Size(150, 62);
            DoneButton.TabIndex = 7;
            DoneButton.Text = "Done";
            DoneButton.UseVisualStyleBackColor = true;
            DoneButton.Click += DoneButtonClickEvent;
            // 
            // InvalidInputsLabel
            // 
            InvalidInputsLabel.AutoSize = true;
            InvalidInputsLabel.ForeColor = Color.Red;
            InvalidInputsLabel.Location = new Point(12, 373);
            InvalidInputsLabel.Name = "InvalidInputsLabel";
            InvalidInputsLabel.Size = new Size(164, 32);
            InvalidInputsLabel.TabIndex = 13;
            InvalidInputsLabel.Text = "Invalid Inputs!";
            // 
            // AddGameForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 414);
            Controls.Add(InvalidInputsLabel);
            Controls.Add(DoneButton);
            Controls.Add(GameDescriptionTextBox);
            Controls.Add(GameRatingComboBox);
            Controls.Add(GameGenreTextBox);
            Controls.Add(GameTitleTextBox);
            Controls.Add(GamePriceTextBox);
            Controls.Add(GameQuantityTextBox);
            Controls.Add(GameGenreLabel);
            Controls.Add(GameRatingLabel);
            Controls.Add(GameQuantityLabel);
            Controls.Add(GamePriceLabel);
            Controls.Add(GameDescriptionLabel);
            Controls.Add(GameTitleLabel);
            Name = "AddGameForm";
            Text = "Enter Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label GameTitleLabel;
        private Label GameDescriptionLabel;
        private Label GamePriceLabel;
        private Label GameQuantityLabel;
        private Label GameRatingLabel;
        private Label GameGenreLabel;
        private TextBox GameQuantityTextBox;
        private TextBox GamePriceTextBox;
        private TextBox GameTitleTextBox;
        private TextBox GameGenreTextBox;
        private ComboBox GameRatingComboBox;
        private TextBox GameDescriptionTextBox;
        private Button DoneButton;
        private Label InvalidInputsLabel;
    }
}