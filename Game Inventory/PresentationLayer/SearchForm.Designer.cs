namespace Game_Inventory.PresentationLayer
{
    partial class SearchForm
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
            SearchButton = new Button();
            SearchTextBox = new TextBox();
            dgvSearchResults = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSearchResults).BeginInit();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(12, 12);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(150, 46);
            SearchButton.TabIndex = 0;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButtonClickEvent;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(168, 16);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PlaceholderText = "Search by Title or Description";
            SearchTextBox.Size = new Size(718, 39);
            SearchTextBox.TabIndex = 1;
            // 
            // dgvSearchResults
            // 
            dgvSearchResults.AllowUserToAddRows = false;
            dgvSearchResults.AllowUserToDeleteRows = false;
            dgvSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchResults.Location = new Point(12, 64);
            dgvSearchResults.Name = "dgvSearchResults";
            dgvSearchResults.ReadOnly = true;
            dgvSearchResults.RowHeadersWidth = 82;
            dgvSearchResults.Size = new Size(874, 496);
            dgvSearchResults.TabIndex = 2;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 572);
            Controls.Add(dgvSearchResults);
            Controls.Add(SearchTextBox);
            Controls.Add(SearchButton);
            Name = "SearchForm";
            Text = "Search Games";
            ((System.ComponentModel.ISupportInitialize)dgvSearchResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton;
        private TextBox SearchTextBox;
        private DataGridView dgvSearchResults;
    }
}