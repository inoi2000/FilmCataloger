namespace FilmCataloger.View.SearchForms
{
    partial class PersonSearchForm
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
            this.Countries_comboBox = new System.Windows.Forms.ComboBox();
            this.BirthDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.StartSearch_button = new System.Windows.Forms.Button();
            this.Gender_comboBox = new System.Windows.Forms.ComboBox();
            this.Professions_comboBox = new System.Windows.Forms.ComboBox();
            this.BirthDate_checkBox = new System.Windows.Forms.CheckBox();
            this.Name_checkBox = new System.Windows.Forms.CheckBox();
            this.Countries_checkBox = new System.Windows.Forms.CheckBox();
            this.Professions_checkBox = new System.Windows.Forms.CheckBox();
            this.Gender_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Countries_comboBox
            // 
            this.Countries_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Countries_comboBox.FormattingEnabled = true;
            this.Countries_comboBox.Location = new System.Drawing.Point(32, 210);
            this.Countries_comboBox.Name = "Countries_comboBox";
            this.Countries_comboBox.Size = new System.Drawing.Size(237, 21);
            this.Countries_comboBox.TabIndex = 58;
            // 
            // BirthDate_dateTimePicker
            // 
            this.BirthDate_dateTimePicker.CustomFormat = "";
            this.BirthDate_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDate_dateTimePicker.Location = new System.Drawing.Point(32, 88);
            this.BirthDate_dateTimePicker.Name = "BirthDate_dateTimePicker";
            this.BirthDate_dateTimePicker.Size = new System.Drawing.Size(237, 20);
            this.BirthDate_dateTimePicker.TabIndex = 49;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(34, 39);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(237, 20);
            this.Name_textBox.TabIndex = 45;
            // 
            // StartSearch_button
            // 
            this.StartSearch_button.Location = new System.Drawing.Point(46, 319);
            this.StartSearch_button.Name = "StartSearch_button";
            this.StartSearch_button.Size = new System.Drawing.Size(205, 47);
            this.StartSearch_button.TabIndex = 59;
            this.StartSearch_button.Text = "ПОИСК";
            this.StartSearch_button.UseVisualStyleBackColor = true;
            this.StartSearch_button.Click += new System.EventHandler(this.StartSearch_button_Click);
            // 
            // Gender_comboBox
            // 
            this.Gender_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender_comboBox.FormattingEnabled = true;
            this.Gender_comboBox.Location = new System.Drawing.Point(34, 146);
            this.Gender_comboBox.Name = "Gender_comboBox";
            this.Gender_comboBox.Size = new System.Drawing.Size(235, 21);
            this.Gender_comboBox.TabIndex = 62;
            // 
            // Professions_comboBox
            // 
            this.Professions_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Professions_comboBox.FormattingEnabled = true;
            this.Professions_comboBox.Location = new System.Drawing.Point(32, 272);
            this.Professions_comboBox.Name = "Professions_comboBox";
            this.Professions_comboBox.Size = new System.Drawing.Size(235, 21);
            this.Professions_comboBox.TabIndex = 60;
            // 
            // BirthDate_checkBox
            // 
            this.BirthDate_checkBox.AutoSize = true;
            this.BirthDate_checkBox.Location = new System.Drawing.Point(12, 65);
            this.BirthDate_checkBox.Name = "BirthDate_checkBox";
            this.BirthDate_checkBox.Size = new System.Drawing.Size(105, 17);
            this.BirthDate_checkBox.TabIndex = 63;
            this.BirthDate_checkBox.Text = "Дата рождения";
            this.BirthDate_checkBox.UseVisualStyleBackColor = true;
            this.BirthDate_checkBox.CheckedChanged += new System.EventHandler(this.BirthDate_checkBox_CheckedChanged);
            // 
            // Name_checkBox
            // 
            this.Name_checkBox.AutoSize = true;
            this.Name_checkBox.Location = new System.Drawing.Point(12, 16);
            this.Name_checkBox.Name = "Name_checkBox";
            this.Name_checkBox.Size = new System.Drawing.Size(168, 17);
            this.Name_checkBox.TabIndex = 64;
            this.Name_checkBox.Text = "Имя (полное или частичное)";
            this.Name_checkBox.UseVisualStyleBackColor = true;
            this.Name_checkBox.CheckedChanged += new System.EventHandler(this.Name_checkBox_CheckedChanged);
            // 
            // Countries_checkBox
            // 
            this.Countries_checkBox.AutoSize = true;
            this.Countries_checkBox.Location = new System.Drawing.Point(12, 187);
            this.Countries_checkBox.Name = "Countries_checkBox";
            this.Countries_checkBox.Size = new System.Drawing.Size(111, 17);
            this.Countries_checkBox.TabIndex = 65;
            this.Countries_checkBox.Text = "Место рождения";
            this.Countries_checkBox.UseVisualStyleBackColor = true;
            this.Countries_checkBox.CheckedChanged += new System.EventHandler(this.Countries_checkBox_CheckedChanged);
            // 
            // Professions_checkBox
            // 
            this.Professions_checkBox.AutoSize = true;
            this.Professions_checkBox.Location = new System.Drawing.Point(12, 249);
            this.Professions_checkBox.Name = "Professions_checkBox";
            this.Professions_checkBox.Size = new System.Drawing.Size(84, 17);
            this.Professions_checkBox.TabIndex = 66;
            this.Professions_checkBox.Text = "Профессии";
            this.Professions_checkBox.UseVisualStyleBackColor = true;
            this.Professions_checkBox.CheckedChanged += new System.EventHandler(this.Professions_checkBox_CheckedChanged);
            // 
            // Gender_checkBox
            // 
            this.Gender_checkBox.AutoSize = true;
            this.Gender_checkBox.Location = new System.Drawing.Point(12, 123);
            this.Gender_checkBox.Name = "Gender_checkBox";
            this.Gender_checkBox.Size = new System.Drawing.Size(46, 17);
            this.Gender_checkBox.TabIndex = 67;
            this.Gender_checkBox.Text = "Пол";
            this.Gender_checkBox.UseVisualStyleBackColor = true;
            this.Gender_checkBox.CheckedChanged += new System.EventHandler(this.Gender_checkBox_CheckedChanged);
            // 
            // PersonSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(315, 394);
            this.Controls.Add(this.Gender_checkBox);
            this.Controls.Add(this.Professions_checkBox);
            this.Controls.Add(this.Countries_checkBox);
            this.Controls.Add(this.Name_checkBox);
            this.Controls.Add(this.BirthDate_checkBox);
            this.Controls.Add(this.Gender_comboBox);
            this.Controls.Add(this.Professions_comboBox);
            this.Controls.Add(this.StartSearch_button);
            this.Controls.Add(this.Countries_comboBox);
            this.Controls.Add(this.BirthDate_dateTimePicker);
            this.Controls.Add(this.Name_textBox);
            this.Name = "PersonSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonSearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Countries_comboBox;
        private System.Windows.Forms.DateTimePicker BirthDate_dateTimePicker;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Button StartSearch_button;
        private System.Windows.Forms.ComboBox Gender_comboBox;
        private System.Windows.Forms.ComboBox Professions_comboBox;
        private System.Windows.Forms.CheckBox BirthDate_checkBox;
        private System.Windows.Forms.CheckBox Name_checkBox;
        private System.Windows.Forms.CheckBox Countries_checkBox;
        private System.Windows.Forms.CheckBox Professions_checkBox;
        private System.Windows.Forms.CheckBox Gender_checkBox;
    }
}