namespace FilmCataloger.View.CatalogForms
{
    partial class FilmsCatalogForm
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
            this.Films_listView = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchField_textBox = new System.Windows.Forms.TextBox();
            this.SearchPlus_button = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.MainMenu_button = new System.Windows.Forms.Button();
            this.Genres_comboBox = new System.Windows.Forms.ComboBox();
            this.Countries_comboBox = new System.Windows.Forms.ComboBox();
            this.IMDb_comboBox = new System.Windows.Forms.ComboBox();
            this.Sort_comboBox = new System.Windows.Forms.ComboBox();
            this.Year_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Year_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Films_listView
            // 
            this.Films_listView.HideSelection = false;
            this.Films_listView.Location = new System.Drawing.Point(12, 112);
            this.Films_listView.Name = "Films_listView";
            this.Films_listView.Size = new System.Drawing.Size(751, 400);
            this.Films_listView.TabIndex = 5;
            this.Films_listView.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchField_textBox);
            this.groupBox1.Controls.Add(this.SearchPlus_button);
            this.groupBox1.Controls.Add(this.Search_button);
            this.groupBox1.Controls.Add(this.MainMenu_button);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 59);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // SearchField_textBox
            // 
            this.SearchField_textBox.Location = new System.Drawing.Point(478, 24);
            this.SearchField_textBox.Name = "SearchField_textBox";
            this.SearchField_textBox.Size = new System.Drawing.Size(183, 20);
            this.SearchField_textBox.TabIndex = 10;
            // 
            // SearchPlus_button
            // 
            this.SearchPlus_button.BackColor = System.Drawing.SystemColors.Control;
            this.SearchPlus_button.BackgroundImage = global::FilmCataloger.Properties.Resources.searchPlus;
            this.SearchPlus_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchPlus_button.Location = new System.Drawing.Point(702, 19);
            this.SearchPlus_button.Name = "SearchPlus_button";
            this.SearchPlus_button.Size = new System.Drawing.Size(28, 28);
            this.SearchPlus_button.TabIndex = 9;
            this.SearchPlus_button.UseVisualStyleBackColor = false;
            this.SearchPlus_button.Click += new System.EventHandler(this.SearchPlus_button_Click);
            // 
            // Search_button
            // 
            this.Search_button.BackgroundImage = global::FilmCataloger.Properties.Resources.search;
            this.Search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Search_button.Location = new System.Drawing.Point(667, 19);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(29, 28);
            this.Search_button.TabIndex = 8;
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // MainMenu_button
            // 
            this.MainMenu_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenu_button.BackgroundImage = global::FilmCataloger.Properties.Resources.camera;
            this.MainMenu_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainMenu_button.Location = new System.Drawing.Point(6, 15);
            this.MainMenu_button.Name = "MainMenu_button";
            this.MainMenu_button.Size = new System.Drawing.Size(150, 38);
            this.MainMenu_button.TabIndex = 7;
            this.MainMenu_button.UseVisualStyleBackColor = false;
            this.MainMenu_button.Click += new System.EventHandler(this.MainMenu_button_Click);
            // 
            // Genres_comboBox
            // 
            this.Genres_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Genres_comboBox.FormattingEnabled = true;
            this.Genres_comboBox.Items.AddRange(new object[] {
            "Жанры"});
            this.Genres_comboBox.Location = new System.Drawing.Point(20, 86);
            this.Genres_comboBox.Name = "Genres_comboBox";
            this.Genres_comboBox.Size = new System.Drawing.Size(104, 21);
            this.Genres_comboBox.TabIndex = 6;
            // 
            // Countries_comboBox
            // 
            this.Countries_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Countries_comboBox.FormattingEnabled = true;
            this.Countries_comboBox.Items.AddRange(new object[] {
            "Страна"});
            this.Countries_comboBox.Location = new System.Drawing.Point(130, 86);
            this.Countries_comboBox.Name = "Countries_comboBox";
            this.Countries_comboBox.Size = new System.Drawing.Size(104, 21);
            this.Countries_comboBox.TabIndex = 8;
            // 
            // IMDb_comboBox
            // 
            this.IMDb_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IMDb_comboBox.FormattingEnabled = true;
            this.IMDb_comboBox.Items.AddRange(new object[] {
            "Рейтинг",
            "от 9",
            "от 8",
            "от 7",
            "от 6",
            "от 5",
            "от 4",
            "от 3",
            "от 2",
            "от 1"});
            this.IMDb_comboBox.Location = new System.Drawing.Point(240, 86);
            this.IMDb_comboBox.Name = "IMDb_comboBox";
            this.IMDb_comboBox.Size = new System.Drawing.Size(104, 21);
            this.IMDb_comboBox.TabIndex = 9;
            // 
            // Sort_comboBox
            // 
            this.Sort_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sort_comboBox.FormattingEnabled = true;
            this.Sort_comboBox.Items.AddRange(new object[] {
            "По умолчанию",
            "По рейтингу",
            "По алфавиту",
            "По дате выхода",
            "По сборам"});
            this.Sort_comboBox.Location = new System.Drawing.Point(549, 86);
            this.Sort_comboBox.Name = "Sort_comboBox";
            this.Sort_comboBox.Size = new System.Drawing.Size(214, 21);
            this.Sort_comboBox.TabIndex = 10;
            // 
            // Year_dateTimePicker
            // 
            this.Year_dateTimePicker.CustomFormat = "yyyy";
            this.Year_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Year_dateTimePicker.Location = new System.Drawing.Point(350, 87);
            this.Year_dateTimePicker.Name = "Year_dateTimePicker";
            this.Year_dateTimePicker.Size = new System.Drawing.Size(67, 20);
            this.Year_dateTimePicker.TabIndex = 11;
            // 
            // Year_checkBox
            // 
            this.Year_checkBox.AutoSize = true;
            this.Year_checkBox.Location = new System.Drawing.Point(423, 90);
            this.Year_checkBox.Name = "Year_checkBox";
            this.Year_checkBox.Size = new System.Drawing.Size(15, 14);
            this.Year_checkBox.TabIndex = 12;
            this.Year_checkBox.UseVisualStyleBackColor = true;
            // 
            // FilmsCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 529);
            this.Controls.Add(this.Year_checkBox);
            this.Controls.Add(this.Year_dateTimePicker);
            this.Controls.Add(this.Sort_comboBox);
            this.Controls.Add(this.IMDb_comboBox);
            this.Controls.Add(this.Countries_comboBox);
            this.Controls.Add(this.Genres_comboBox);
            this.Controls.Add(this.Films_listView);
            this.Controls.Add(this.groupBox1);
            this.Name = "FilmsCatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог фильмов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Films_listView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SearchField_textBox;
        private System.Windows.Forms.Button SearchPlus_button;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button MainMenu_button;
        private System.Windows.Forms.ComboBox Genres_comboBox;
        private System.Windows.Forms.ComboBox Countries_comboBox;
        private System.Windows.Forms.ComboBox IMDb_comboBox;
        private System.Windows.Forms.ComboBox Sort_comboBox;
        private System.Windows.Forms.DateTimePicker Year_dateTimePicker;
        private System.Windows.Forms.CheckBox Year_checkBox;
    }
}