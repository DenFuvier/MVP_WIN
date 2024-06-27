namespace FootWinGG
{
    partial class MainForm
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
            AddLiga = new Button();
            LigaItems = new ListBox();
            DeleteLiga = new Button();
            TeamsListBox = new ListBox();
            PlayersTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PlayersTable).BeginInit();
            SuspendLayout();
            // 
            // AddLiga
            // 
            AddLiga.Location = new Point(12, 337);
            AddLiga.Name = "AddLiga";
            AddLiga.Size = new Size(75, 23);
            AddLiga.TabIndex = 0;
            AddLiga.Text = "Добавить";
            AddLiga.UseVisualStyleBackColor = true;
            // 
            // LigaItems
            // 
            LigaItems.FormattingEnabled = true;
            LigaItems.ItemHeight = 15;
            LigaItems.Location = new Point(12, 12);
            LigaItems.Name = "LigaItems";
            LigaItems.Size = new Size(219, 319);
            LigaItems.TabIndex = 2;
            // 
            // DeleteLiga
            // 
            DeleteLiga.Location = new Point(93, 337);
            DeleteLiga.Name = "DeleteLiga";
            DeleteLiga.Size = new Size(75, 23);
            DeleteLiga.TabIndex = 3;
            DeleteLiga.Text = "Удалить";
            DeleteLiga.UseVisualStyleBackColor = true;
            DeleteLiga.Click += DeleteLiga_Click;
            // 
            // TeamsListBox
            // 
            TeamsListBox.FormattingEnabled = true;
            TeamsListBox.ItemHeight = 15;
            TeamsListBox.Location = new Point(299, 12);
            TeamsListBox.Name = "TeamsListBox";
            TeamsListBox.Size = new Size(219, 319);
            TeamsListBox.TabIndex = 4;
            // 
            // PlayersTable
            // 
            PlayersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PlayersTable.Location = new Point(579, 12);
            PlayersTable.Name = "PlayersTable";
            PlayersTable.Size = new Size(426, 277);
            PlayersTable.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 567);
            Controls.Add(PlayersTable);
            Controls.Add(TeamsListBox);
            Controls.Add(DeleteLiga);
            Controls.Add(LigaItems);
            Controls.Add(AddLiga);
            Name = "MainForm";
            Text = "==";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)PlayersTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AddLiga;
        private ListBox LigaItems;
        private Button DeleteLiga;
        private ListBox TeamsListBox;
        private DataGridView PlayersTable;
    }
}
