namespace FilmCataloger.View.AdminForms
{
    partial class CreateFilmForm
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
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.IMDb_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Production_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PictureRef_textBox = new System.Windows.Forms.TextBox();
            this.Genres_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.Persons_listBox = new System.Windows.Forms.ListBox();
            this.RelatedFilms_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CreateFilm_button = new System.Windows.Forms.Button();
            this.AddPerson_button = new System.Windows.Forms.Button();
            this.AddRelatedFilm_button = new System.Windows.Forms.Button();
            this.Description_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Fees_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Countries_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Duration_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AgeLimit_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.IMDb_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fees_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(33, 40);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(293, 20);
            this.Name_textBox.TabIndex = 0;
            // 
            // IMDb_numericUpDown
            // 
            this.IMDb_numericUpDown.DecimalPlaces = 1;
            this.IMDb_numericUpDown.Location = new System.Drawing.Point(33, 118);
            this.IMDb_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.IMDb_numericUpDown.Name = "IMDb_numericUpDown";
            this.IMDb_numericUpDown.Size = new System.Drawing.Size(293, 20);
            this.IMDb_numericUpDown.TabIndex = 1;
            // 
            // Production_dateTimePicker
            // 
            this.Production_dateTimePicker.CustomFormat = "dd/yyyy";
            this.Production_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Production_dateTimePicker.Location = new System.Drawing.Point(33, 79);
            this.Production_dateTimePicker.Name = "Production_dateTimePicker";
            this.Production_dateTimePicker.Size = new System.Drawing.Size(293, 20);
            this.Production_dateTimePicker.TabIndex = 3;
            // 
            // PictureRef_textBox
            // 
            this.PictureRef_textBox.Location = new System.Drawing.Point(33, 194);
            this.PictureRef_textBox.Name = "PictureRef_textBox";
            this.PictureRef_textBox.Size = new System.Drawing.Size(293, 20);
            this.PictureRef_textBox.TabIndex = 4;
            // 
            // Genres_checkedListBox
            // 
            this.Genres_checkedListBox.CheckOnClick = true;
            this.Genres_checkedListBox.FormattingEnabled = true;
            this.Genres_checkedListBox.HorizontalScrollbar = true;
            this.Genres_checkedListBox.Location = new System.Drawing.Point(400, 40);
            this.Genres_checkedListBox.MultiColumn = true;
            this.Genres_checkedListBox.Name = "Genres_checkedListBox";
            this.Genres_checkedListBox.Size = new System.Drawing.Size(302, 169);
            this.Genres_checkedListBox.TabIndex = 5;
            // 
            // Persons_listBox
            // 
            this.Persons_listBox.FormattingEnabled = true;
            this.Persons_listBox.HorizontalScrollbar = true;
            this.Persons_listBox.Location = new System.Drawing.Point(144, 254);
            this.Persons_listBox.Name = "Persons_listBox";
            this.Persons_listBox.Size = new System.Drawing.Size(360, 134);
            this.Persons_listBox.TabIndex = 6;
            // 
            // RelatedFilms_listBox
            // 
            this.RelatedFilms_listBox.FormattingEnabled = true;
            this.RelatedFilms_listBox.HorizontalScrollbar = true;
            this.RelatedFilms_listBox.Location = new System.Drawing.Point(534, 254);
            this.RelatedFilms_listBox.Name = "RelatedFilms_listBox";
            this.RelatedFilms_listBox.Size = new System.Drawing.Size(360, 134);
            this.RelatedFilms_listBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Премьера";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(30, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Рейтинг IMDb";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(30, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ссылка на изображение";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(397, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Жанры";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(141, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Создатели / актеры";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(531, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Связанные фильмы";
            // 
            // CreateFilm_button
            // 
            this.CreateFilm_button.Location = new System.Drawing.Point(400, 574);
            this.CreateFilm_button.Name = "CreateFilm_button";
            this.CreateFilm_button.Size = new System.Drawing.Size(221, 54);
            this.CreateFilm_button.TabIndex = 15;
            this.CreateFilm_button.Text = "Создать фильм";
            this.CreateFilm_button.UseVisualStyleBackColor = true;
            this.CreateFilm_button.Click += new System.EventHandler(this.CreateFilm_button_Click);
            // 
            // AddPerson_button
            // 
            this.AddPerson_button.Location = new System.Drawing.Point(243, 407);
            this.AddPerson_button.Name = "AddPerson_button";
            this.AddPerson_button.Size = new System.Drawing.Size(181, 41);
            this.AddPerson_button.TabIndex = 16;
            this.AddPerson_button.Text = "Добавить создателя / актера";
            this.AddPerson_button.UseVisualStyleBackColor = true;
            this.AddPerson_button.Click += new System.EventHandler(this.AddPerson_button_Click);
            // 
            // AddRelatedFilm_button
            // 
            this.AddRelatedFilm_button.Location = new System.Drawing.Point(632, 407);
            this.AddRelatedFilm_button.Name = "AddRelatedFilm_button";
            this.AddRelatedFilm_button.Size = new System.Drawing.Size(181, 41);
            this.AddRelatedFilm_button.TabIndex = 17;
            this.AddRelatedFilm_button.Text = "Добавить связанный фильм";
            this.AddRelatedFilm_button.UseVisualStyleBackColor = true;
            this.AddRelatedFilm_button.Click += new System.EventHandler(this.AddRelatedFilm_button_Click);
            // 
            // Description_textBox
            // 
            this.Description_textBox.Location = new System.Drawing.Point(33, 475);
            this.Description_textBox.Multiline = true;
            this.Description_textBox.Name = "Description_textBox";
            this.Description_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Description_textBox.Size = new System.Drawing.Size(711, 72);
            this.Description_textBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(30, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Описание";
            // 
            // Fees_numericUpDown
            // 
            this.Fees_numericUpDown.Location = new System.Drawing.Point(790, 527);
            this.Fees_numericUpDown.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.Fees_numericUpDown.Name = "Fees_numericUpDown";
            this.Fees_numericUpDown.Size = new System.Drawing.Size(236, 20);
            this.Fees_numericUpDown.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(787, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Возрастное ограничение";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(786, 511);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Бюджет фильма";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(721, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Страны";
            // 
            // Countries_checkedListBox
            // 
            this.Countries_checkedListBox.CheckOnClick = true;
            this.Countries_checkedListBox.FormattingEnabled = true;
            this.Countries_checkedListBox.HorizontalScrollbar = true;
            this.Countries_checkedListBox.Location = new System.Drawing.Point(721, 40);
            this.Countries_checkedListBox.MultiColumn = true;
            this.Countries_checkedListBox.Name = "Countries_checkedListBox";
            this.Countries_checkedListBox.Size = new System.Drawing.Size(302, 169);
            this.Countries_checkedListBox.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(30, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Продолжительность фильма";
            // 
            // Duration_dateTimePicker
            // 
            this.Duration_dateTimePicker.CustomFormat = "HH:mm";
            this.Duration_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Duration_dateTimePicker.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Duration_dateTimePicker.Location = new System.Drawing.Point(33, 157);
            this.Duration_dateTimePicker.Name = "Duration_dateTimePicker";
            this.Duration_dateTimePicker.Size = new System.Drawing.Size(293, 20);
            this.Duration_dateTimePicker.TabIndex = 26;
            this.Duration_dateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
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
            this.AgeLimit_comboBox.Location = new System.Drawing.Point(790, 475);
            this.AgeLimit_comboBox.Name = "AgeLimit_comboBox";
            this.AgeLimit_comboBox.Size = new System.Drawing.Size(237, 21);
            this.AgeLimit_comboBox.TabIndex = 28;
            // 
            // CreateFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1082, 652);
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
            this.Name = "CreateFilmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление фильма";
            ((System.ComponentModel.ISupportInitialize)(this.IMDb_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fees_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.NumericUpDown IMDb_numericUpDown;
        private System.Windows.Forms.DateTimePicker Production_dateTimePicker;
        private System.Windows.Forms.TextBox PictureRef_textBox;
        private System.Windows.Forms.CheckedListBox Genres_checkedListBox;
        private System.Windows.Forms.ListBox Persons_listBox;
        private System.Windows.Forms.ListBox RelatedFilms_listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CreateFilm_button;
        private System.Windows.Forms.Button AddPerson_button;
        private System.Windows.Forms.Button AddRelatedFilm_button;
        private System.Windows.Forms.TextBox Description_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown Fees_numericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox Countries_checkedListBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker Duration_dateTimePicker;
        private System.Windows.Forms.ComboBox AgeLimit_comboBox;
    }
}