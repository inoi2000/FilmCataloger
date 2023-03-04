namespace FilmCataloger.View.CatalogForms
{
    partial class PersonsCatalogForm
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
            this.Persons_listView = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchField_textBox = new System.Windows.Forms.TextBox();
            this.SearchPlus_button = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.MainManu_button = new System.Windows.Forms.Button();
            this.Gender_comboBox = new System.Windows.Forms.ComboBox();
            this.Countries_comboBox = new System.Windows.Forms.ComboBox();
            this.Professions_comboBox = new System.Windows.Forms.ComboBox();
            this.Sort_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Persons_listView
            // 
            this.Persons_listView.HideSelection = false;
            this.Persons_listView.Location = new System.Drawing.Point(12, 113);
            this.Persons_listView.Name = "Persons_listView";
            this.Persons_listView.Size = new System.Drawing.Size(751, 399);
            this.Persons_listView.TabIndex = 5;
            this.Persons_listView.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchField_textBox);
            this.groupBox1.Controls.Add(this.SearchPlus_button);
            this.groupBox1.Controls.Add(this.Search_button);
            this.groupBox1.Controls.Add(this.MainManu_button);
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
            this.SearchPlus_button.BackgroundImage = global::FilmCataloger.Properties.Resources.searchPlus;
            this.SearchPlus_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchPlus_button.Location = new System.Drawing.Point(702, 19);
            this.SearchPlus_button.Name = "SearchPlus_button";
            this.SearchPlus_button.Size = new System.Drawing.Size(28, 28);
            this.SearchPlus_button.TabIndex = 9;
            this.SearchPlus_button.UseVisualStyleBackColor = true;
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
            // MainManu_button
            // 
            this.MainManu_button.BackgroundImage = global::FilmCataloger.Properties.Resources.camera;
            this.MainManu_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainManu_button.Location = new System.Drawing.Point(6, 15);
            this.MainManu_button.Name = "MainManu_button";
            this.MainManu_button.Size = new System.Drawing.Size(150, 38);
            this.MainManu_button.TabIndex = 7;
            this.MainManu_button.UseVisualStyleBackColor = true;
            this.MainManu_button.Click += new System.EventHandler(this.MainManu_button_Click);
            // 
            // Gender_comboBox
            // 
            this.Gender_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender_comboBox.FormattingEnabled = true;
            this.Gender_comboBox.Items.AddRange(new object[] {
            "Пол"});
            this.Gender_comboBox.Location = new System.Drawing.Point(232, 86);
            this.Gender_comboBox.Name = "Gender_comboBox";
            this.Gender_comboBox.Size = new System.Drawing.Size(104, 21);
            this.Gender_comboBox.TabIndex = 12;
            // 
            // Countries_comboBox
            // 
            this.Countries_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Countries_comboBox.FormattingEnabled = true;
            this.Countries_comboBox.Items.AddRange(new object[] {
            "Страна"});
            this.Countries_comboBox.Location = new System.Drawing.Point(122, 86);
            this.Countries_comboBox.Name = "Countries_comboBox";
            this.Countries_comboBox.Size = new System.Drawing.Size(104, 21);
            this.Countries_comboBox.TabIndex = 11;
            // 
            // Professions_comboBox
            // 
            this.Professions_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Professions_comboBox.FormattingEnabled = true;
            this.Professions_comboBox.Items.AddRange(new object[] {
            "Профессия"});
            this.Professions_comboBox.Location = new System.Drawing.Point(12, 86);
            this.Professions_comboBox.Name = "Professions_comboBox";
            this.Professions_comboBox.Size = new System.Drawing.Size(104, 21);
            this.Professions_comboBox.TabIndex = 10;
            // 
            // Sort_comboBox
            // 
            this.Sort_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sort_comboBox.FormattingEnabled = true;
            this.Sort_comboBox.Items.AddRange(new object[] {
            "По умолчанию",
            "По алфавиту",
            "По дате рождения"});
            this.Sort_comboBox.Location = new System.Drawing.Point(549, 86);
            this.Sort_comboBox.Name = "Sort_comboBox";
            this.Sort_comboBox.Size = new System.Drawing.Size(214, 21);
            this.Sort_comboBox.TabIndex = 13;
            // 
            // PersonsCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 524);
            this.Controls.Add(this.Sort_comboBox);
            this.Controls.Add(this.Gender_comboBox);
            this.Controls.Add(this.Countries_comboBox);
            this.Controls.Add(this.Professions_comboBox);
            this.Controls.Add(this.Persons_listView);
            this.Controls.Add(this.groupBox1);
            this.Name = "PersonsCatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог дееятелей кино";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Persons_listView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SearchField_textBox;
        private System.Windows.Forms.Button SearchPlus_button;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button MainManu_button;
        private System.Windows.Forms.ComboBox Gender_comboBox;
        private System.Windows.Forms.ComboBox Countries_comboBox;
        private System.Windows.Forms.ComboBox Professions_comboBox;
        private System.Windows.Forms.ComboBox Sort_comboBox;
    }
}