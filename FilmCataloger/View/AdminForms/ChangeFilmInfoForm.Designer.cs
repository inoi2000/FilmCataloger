namespace FilmCataloger.View.AdminForms
{
    partial class ChangeFilmInfoForm
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
            this.AgeLimit_comboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Duration_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.Countries_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Fees_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.Description_textBox = new System.Windows.Forms.TextBox();
            this.AddRelatedFilm_button = new System.Windows.Forms.Button();
            this.AddPerson_button = new System.Windows.Forms.Button();
            this.CreateFilm_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RelatedFilms_listBox = new System.Windows.Forms.ListBox();
            this.Persons_listBox = new System.Windows.Forms.ListBox();
            this.Genres_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.PictureRef_textBox = new System.Windows.Forms.TextBox();
            this.Production_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IMDb_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Fees_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMDb_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AgeLimit_comboBox
            // 
            this.AgeLimit_comboBox.FormattingEnabled = true;
            this.AgeLimit_comboBox.Items.AddRange(new object[] {
            "0+",
            "6+",
            "12+",
            "16+",
            "18+"});
            this.AgeLimit_comboBox.Location = new System.Drawing.Point(783, 467);
            this.AgeLimit_comboBox.Name = "AgeLimit_comboBox";
            this.AgeLimit_comboBox.Size = new System.Drawing.Size(237, 21);
            this.AgeLimit_comboBox.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(23, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "Продолжительность фильма";
            // 
            // Duration_dateTimePicker
            // 
            this.Duration_dateTimePicker.CustomFormat = "HH-mm-ss";
            this.Duration_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Duration_dateTimePicker.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Duration_dateTimePicker.Location = new System.Drawing.Point(27, 150);
            this.Duration_dateTimePicker.Name = "Duration_dateTimePicker";
            this.Duration_dateTimePicker.Size = new System.Drawing.Size(293, 20);
            this.Duration_dateTimePicker.TabIndex = 53;
            this.Duration_dateTimePicker.Value = new System.DateTime(2023, 2, 16, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(715, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Страны";
            // 
            // Countries_checkedListBox
            // 
            this.Countries_checkedListBox.CheckOnClick = true;
            this.Countries_checkedListBox.FormattingEnabled = true;
            this.Countries_checkedListBox.HorizontalScrollbar = true;
            this.Countries_checkedListBox.Location = new System.Drawing.Point(715, 32);
            this.Countries_checkedListBox.MultiColumn = true;
            this.Countries_checkedListBox.Name = "Countries_checkedListBox";
            this.Countries_checkedListBox.Size = new System.Drawing.Size(302, 154);
            this.Countries_checkedListBox.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(779, 503);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Бюджет фильма";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(780, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Возрастное ограничение";
            // 
            // Fees_numericUpDown
            // 
            this.Fees_numericUpDown.Location = new System.Drawing.Point(783, 519);
            this.Fees_numericUpDown.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.Fees_numericUpDown.Name = "Fees_numericUpDown";
            this.Fees_numericUpDown.Size = new System.Drawing.Size(236, 20);
            this.Fees_numericUpDown.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(23, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Описание";
            // 
            // Description_textBox
            // 
            this.Description_textBox.Location = new System.Drawing.Point(27, 467);
            this.Description_textBox.Multiline = true;
            this.Description_textBox.Name = "Description_textBox";
            this.Description_textBox.Size = new System.Drawing.Size(711, 72);
            this.Description_textBox.TabIndex = 46;
            // 
            // AddRelatedFilm_button
            // 
            this.AddRelatedFilm_button.Location = new System.Drawing.Point(625, 399);
            this.AddRelatedFilm_button.Name = "AddRelatedFilm_button";
            this.AddRelatedFilm_button.Size = new System.Drawing.Size(181, 41);
            this.AddRelatedFilm_button.TabIndex = 45;
            this.AddRelatedFilm_button.Text = "Добавить связанный фильм";
            this.AddRelatedFilm_button.UseVisualStyleBackColor = true;
            this.AddRelatedFilm_button.Click += new System.EventHandler(this.AddRelatedFilm_button_Click);
            // 
            // AddPerson_button
            // 
            this.AddPerson_button.Location = new System.Drawing.Point(236, 399);
            this.AddPerson_button.Name = "AddPerson_button";
            this.AddPerson_button.Size = new System.Drawing.Size(181, 41);
            this.AddPerson_button.TabIndex = 44;
            this.AddPerson_button.Text = "Добавить создателя / актера";
            this.AddPerson_button.UseVisualStyleBackColor = true;
            this.AddPerson_button.Click += new System.EventHandler(this.AddPerson_button_Click);
            // 
            // CreateFilm_button
            // 
            this.CreateFilm_button.Location = new System.Drawing.Point(393, 566);
            this.CreateFilm_button.Name = "CreateFilm_button";
            this.CreateFilm_button.Size = new System.Drawing.Size(221, 54);
            this.CreateFilm_button.TabIndex = 43;
            this.CreateFilm_button.Text = "Сохранить изменения";
            this.CreateFilm_button.UseVisualStyleBackColor = true;
            this.CreateFilm_button.Click += new System.EventHandler(this.CreateFilm_button_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(524, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Связанные фильмы";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(135, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Создатели / актеры";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(391, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Жанры";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Ссылка на изображение";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(23, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Рейтинг IMDb";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Премьера";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Название";
            // 
            // RelatedFilms_listBox
            // 
            this.RelatedFilms_listBox.FormattingEnabled = true;
            this.RelatedFilms_listBox.HorizontalScrollbar = true;
            this.RelatedFilms_listBox.Location = new System.Drawing.Point(527, 246);
            this.RelatedFilms_listBox.Name = "RelatedFilms_listBox";
            this.RelatedFilms_listBox.Size = new System.Drawing.Size(360, 134);
            this.RelatedFilms_listBox.TabIndex = 35;
            // 
            // Persons_listBox
            // 
            this.Persons_listBox.FormattingEnabled = true;
            this.Persons_listBox.HorizontalScrollbar = true;
            this.Persons_listBox.Location = new System.Drawing.Point(137, 246);
            this.Persons_listBox.Name = "Persons_listBox";
            this.Persons_listBox.Size = new System.Drawing.Size(360, 134);
            this.Persons_listBox.TabIndex = 34;
            // 
            // Genres_checkedListBox
            // 
            this.Genres_checkedListBox.CheckOnClick = true;
            this.Genres_checkedListBox.FormattingEnabled = true;
            this.Genres_checkedListBox.HorizontalScrollbar = true;
            this.Genres_checkedListBox.Location = new System.Drawing.Point(393, 32);
            this.Genres_checkedListBox.MultiColumn = true;
            this.Genres_checkedListBox.Name = "Genres_checkedListBox";
            this.Genres_checkedListBox.Size = new System.Drawing.Size(302, 154);
            this.Genres_checkedListBox.TabIndex = 33;
            // 
            // PictureRef_textBox
            // 
            this.PictureRef_textBox.Location = new System.Drawing.Point(27, 186);
            this.PictureRef_textBox.Name = "PictureRef_textBox";
            this.PictureRef_textBox.Size = new System.Drawing.Size(293, 20);
            this.PictureRef_textBox.TabIndex = 32;
            // 
            // Production_dateTimePicker
            // 
            this.Production_dateTimePicker.CustomFormat = "dd/yyyy";
            this.Production_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Production_dateTimePicker.Location = new System.Drawing.Point(27, 72);
            this.Production_dateTimePicker.Name = "Production_dateTimePicker";
            this.Production_dateTimePicker.Size = new System.Drawing.Size(293, 20);
            this.Production_dateTimePicker.TabIndex = 31;
            // 
            // IMDb_numericUpDown
            // 
            this.IMDb_numericUpDown.DecimalPlaces = 1;
            this.IMDb_numericUpDown.Location = new System.Drawing.Point(27, 110);
            this.IMDb_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.IMDb_numericUpDown.Name = "IMDb_numericUpDown";
            this.IMDb_numericUpDown.Size = new System.Drawing.Size(293, 20);
            this.IMDb_numericUpDown.TabIndex = 30;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(27, 32);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(293, 20);
            this.Name_textBox.TabIndex = 29;
            // 
            // ChangeFilmInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1052, 636);
            this.Controls.Add(this.AgeLimit_comboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Duration_dateTimePicker);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Countries_checkedListBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Fees_numericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Description_textBox);
            this.Controls.Add(this.AddRelatedFilm_button);
            this.Controls.Add(this.AddPerson_button);
            this.Controls.Add(this.CreateFilm_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RelatedFilms_listBox);
            this.Controls.Add(this.Persons_listBox);
            this.Controls.Add(this.Genres_checkedListBox);
            this.Controls.Add(this.PictureRef_textBox);
            this.Controls.Add(this.Production_dateTimePicker);
            this.Controls.Add(this.IMDb_numericUpDown);
            this.Controls.Add(this.Name_textBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChangeFilmInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение информации о фильме";
            ((System.ComponentModel.ISupportInitialize)(this.Fees_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMDb_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AgeLimit_comboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker Duration_dateTimePicker;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox Countries_checkedListBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown Fees_numericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Description_textBox;
        private System.Windows.Forms.Button AddRelatedFilm_button;
        private System.Windows.Forms.Button AddPerson_button;
        private System.Windows.Forms.Button CreateFilm_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox RelatedFilms_listBox;
        private System.Windows.Forms.ListBox Persons_listBox;
        private System.Windows.Forms.CheckedListBox Genres_checkedListBox;
        private System.Windows.Forms.TextBox PictureRef_textBox;
        private System.Windows.Forms.DateTimePicker Production_dateTimePicker;
        private System.Windows.Forms.NumericUpDown IMDb_numericUpDown;
        private System.Windows.Forms.TextBox Name_textBox;
    }
}