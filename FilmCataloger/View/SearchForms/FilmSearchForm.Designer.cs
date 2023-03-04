namespace FilmCataloger.View.SearchForms
{
    partial class FilmSearchForm
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
            this.Name_checkBox = new System.Windows.Forms.CheckBox();
            this.Production_checkBox = new System.Windows.Forms.CheckBox();
            this.YearForm_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.YearTo_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Countries_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.Genres_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.Genres_checkBox = new System.Windows.Forms.CheckBox();
            this.Countries_checkBox = new System.Windows.Forms.CheckBox();
            this.AgeLimit_comboBox = new System.Windows.Forms.ComboBox();
            this.AgeLimit_checkBox = new System.Windows.Forms.CheckBox();
            this.FeesFrom_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FeesTo_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Fees_checkBox = new System.Windows.Forms.CheckBox();
            this.AddPerson_button = new System.Windows.Forms.Button();
            this.Persons_listBox = new System.Windows.Forms.ListBox();
            this.Persons_checkBox = new System.Windows.Forms.CheckBox();
            this.StartSearch_button = new System.Windows.Forms.Button();
            this.IMDb_checkBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IMDbFrom_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.IMDbTo_numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.FeesFrom_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeesTo_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMDbFrom_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMDbTo_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(34, 34);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(293, 20);
            this.Name_textBox.TabIndex = 9;
            // 
            // Name_checkBox
            // 
            this.Name_checkBox.AutoSize = true;
            this.Name_checkBox.Location = new System.Drawing.Point(12, 12);
            this.Name_checkBox.Name = "Name_checkBox";
            this.Name_checkBox.Size = new System.Drawing.Size(196, 17);
            this.Name_checkBox.TabIndex = 11;
            this.Name_checkBox.Text = "Название (полное или частичное)";
            this.Name_checkBox.UseVisualStyleBackColor = true;
            this.Name_checkBox.CheckedChanged += new System.EventHandler(this.Name_checkBox_CheckedChanged);
            // 
            // Production_checkBox
            // 
            this.Production_checkBox.AutoSize = true;
            this.Production_checkBox.Location = new System.Drawing.Point(389, 12);
            this.Production_checkBox.Name = "Production_checkBox";
            this.Production_checkBox.Size = new System.Drawing.Size(90, 17);
            this.Production_checkBox.TabIndex = 12;
            this.Production_checkBox.Text = "Год выпуска";
            this.Production_checkBox.UseVisualStyleBackColor = true;
            this.Production_checkBox.CheckedChanged += new System.EventHandler(this.Production_checkBox_CheckedChanged);
            // 
            // YearForm_dateTimePicker
            // 
            this.YearForm_dateTimePicker.CustomFormat = "yyyy";
            this.YearForm_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.YearForm_dateTimePicker.Location = new System.Drawing.Point(434, 35);
            this.YearForm_dateTimePicker.Name = "YearForm_dateTimePicker";
            this.YearForm_dateTimePicker.Size = new System.Drawing.Size(67, 20);
            this.YearForm_dateTimePicker.TabIndex = 13;
            // 
            // YearTo_dateTimePicker
            // 
            this.YearTo_dateTimePicker.CustomFormat = "yyyy";
            this.YearTo_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.YearTo_dateTimePicker.Location = new System.Drawing.Point(540, 35);
            this.YearTo_dateTimePicker.Name = "YearTo_dateTimePicker";
            this.YearTo_dateTimePicker.Size = new System.Drawing.Size(67, 20);
            this.YearTo_dateTimePicker.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(414, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "c";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(511, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "по";
            // 
            // Countries_checkedListBox
            // 
            this.Countries_checkedListBox.CheckOnClick = true;
            this.Countries_checkedListBox.FormattingEnabled = true;
            this.Countries_checkedListBox.HorizontalScrollbar = true;
            this.Countries_checkedListBox.Location = new System.Drawing.Point(34, 203);
            this.Countries_checkedListBox.MultiColumn = true;
            this.Countries_checkedListBox.Name = "Countries_checkedListBox";
            this.Countries_checkedListBox.Size = new System.Drawing.Size(293, 64);
            this.Countries_checkedListBox.TabIndex = 28;
            // 
            // Genres_checkedListBox
            // 
            this.Genres_checkedListBox.CheckOnClick = true;
            this.Genres_checkedListBox.FormattingEnabled = true;
            this.Genres_checkedListBox.HorizontalScrollbar = true;
            this.Genres_checkedListBox.Location = new System.Drawing.Point(33, 96);
            this.Genres_checkedListBox.MultiColumn = true;
            this.Genres_checkedListBox.Name = "Genres_checkedListBox";
            this.Genres_checkedListBox.Size = new System.Drawing.Size(293, 64);
            this.Genres_checkedListBox.TabIndex = 26;
            // 
            // Genres_checkBox
            // 
            this.Genres_checkBox.AutoSize = true;
            this.Genres_checkBox.Location = new System.Drawing.Point(11, 73);
            this.Genres_checkBox.Name = "Genres_checkBox";
            this.Genres_checkBox.Size = new System.Drawing.Size(316, 17);
            this.Genres_checkBox.TabIndex = 30;
            this.Genres_checkBox.Text = "Жанр (вывод всех совпадение хотя бы по одному жанру)";
            this.Genres_checkBox.UseVisualStyleBackColor = true;
            this.Genres_checkBox.CheckedChanged += new System.EventHandler(this.Genres_checkBox_CheckedChanged);
            // 
            // Countries_checkBox
            // 
            this.Countries_checkBox.AutoSize = true;
            this.Countries_checkBox.Location = new System.Drawing.Point(12, 180);
            this.Countries_checkBox.Name = "Countries_checkBox";
            this.Countries_checkBox.Size = new System.Drawing.Size(62, 17);
            this.Countries_checkBox.TabIndex = 31;
            this.Countries_checkBox.Text = "Страна";
            this.Countries_checkBox.UseVisualStyleBackColor = true;
            this.Countries_checkBox.CheckedChanged += new System.EventHandler(this.Countries_checkBox_CheckedChanged);
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
            this.AgeLimit_comboBox.Location = new System.Drawing.Point(417, 84);
            this.AgeLimit_comboBox.Name = "AgeLimit_comboBox";
            this.AgeLimit_comboBox.Size = new System.Drawing.Size(245, 21);
            this.AgeLimit_comboBox.TabIndex = 33;
            // 
            // AgeLimit_checkBox
            // 
            this.AgeLimit_checkBox.AutoSize = true;
            this.AgeLimit_checkBox.Location = new System.Drawing.Point(389, 61);
            this.AgeLimit_checkBox.Name = "AgeLimit_checkBox";
            this.AgeLimit_checkBox.Size = new System.Drawing.Size(153, 17);
            this.AgeLimit_checkBox.TabIndex = 34;
            this.AgeLimit_checkBox.Text = "Возрастное ограничение";
            this.AgeLimit_checkBox.UseVisualStyleBackColor = true;
            this.AgeLimit_checkBox.CheckedChanged += new System.EventHandler(this.AgeLimit_checkBox_CheckedChanged);
            // 
            // FeesFrom_numericUpDown
            // 
            this.FeesFrom_numericUpDown.Location = new System.Drawing.Point(566, 148);
            this.FeesFrom_numericUpDown.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.FeesFrom_numericUpDown.Name = "FeesFrom_numericUpDown";
            this.FeesFrom_numericUpDown.Size = new System.Drawing.Size(96, 20);
            this.FeesFrom_numericUpDown.TabIndex = 35;
            // 
            // FeesTo_numericUpDown
            // 
            this.FeesTo_numericUpDown.Location = new System.Drawing.Point(438, 144);
            this.FeesTo_numericUpDown.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.FeesTo_numericUpDown.Name = "FeesTo_numericUpDown";
            this.FeesTo_numericUpDown.Size = new System.Drawing.Size(96, 20);
            this.FeesTo_numericUpDown.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(410, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "от";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(537, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "до";
            // 
            // Fees_checkBox
            // 
            this.Fees_checkBox.AutoSize = true;
            this.Fees_checkBox.Location = new System.Drawing.Point(389, 121);
            this.Fees_checkBox.Name = "Fees_checkBox";
            this.Fees_checkBox.Size = new System.Drawing.Size(109, 17);
            this.Fees_checkBox.TabIndex = 40;
            this.Fees_checkBox.Text = "Бюджет фильма";
            this.Fees_checkBox.UseVisualStyleBackColor = true;
            this.Fees_checkBox.CheckedChanged += new System.EventHandler(this.Fees_checkBox_CheckedChanged);
            // 
            // AddPerson_button
            // 
            this.AddPerson_button.Location = new System.Drawing.Point(444, 317);
            this.AddPerson_button.Name = "AddPerson_button";
            this.AddPerson_button.Size = new System.Drawing.Size(187, 26);
            this.AddPerson_button.TabIndex = 43;
            this.AddPerson_button.Text = "Добавить создателя / актера";
            this.AddPerson_button.UseVisualStyleBackColor = true;
            this.AddPerson_button.Click += new System.EventHandler(this.AddPerson_button_Click);
            // 
            // Persons_listBox
            // 
            this.Persons_listBox.FormattingEnabled = true;
            this.Persons_listBox.HorizontalScrollbar = true;
            this.Persons_listBox.Location = new System.Drawing.Point(417, 203);
            this.Persons_listBox.Name = "Persons_listBox";
            this.Persons_listBox.Size = new System.Drawing.Size(245, 108);
            this.Persons_listBox.TabIndex = 41;
            // 
            // Persons_checkBox
            // 
            this.Persons_checkBox.AutoSize = true;
            this.Persons_checkBox.Location = new System.Drawing.Point(389, 180);
            this.Persons_checkBox.Name = "Persons_checkBox";
            this.Persons_checkBox.Size = new System.Drawing.Size(128, 17);
            this.Persons_checkBox.TabIndex = 44;
            this.Persons_checkBox.Text = "Создатели / актеры";
            this.Persons_checkBox.UseVisualStyleBackColor = true;
            this.Persons_checkBox.CheckedChanged += new System.EventHandler(this.Persons_checkBox_CheckedChanged);
            // 
            // StartSearch_button
            // 
            this.StartSearch_button.Location = new System.Drawing.Point(250, 407);
            this.StartSearch_button.Name = "StartSearch_button";
            this.StartSearch_button.Size = new System.Drawing.Size(205, 47);
            this.StartSearch_button.TabIndex = 45;
            this.StartSearch_button.Text = "ПОИСК";
            this.StartSearch_button.UseVisualStyleBackColor = true;
            this.StartSearch_button.Click += new System.EventHandler(this.StartSearch_button_Click);
            // 
            // IMDb_checkBox
            // 
            this.IMDb_checkBox.AutoSize = true;
            this.IMDb_checkBox.Location = new System.Drawing.Point(12, 294);
            this.IMDb_checkBox.Name = "IMDb_checkBox";
            this.IMDb_checkBox.Size = new System.Drawing.Size(110, 17);
            this.IMDb_checkBox.TabIndex = 50;
            this.IMDb_checkBox.Text = "Рейтинг фильма";
            this.IMDb_checkBox.UseVisualStyleBackColor = true;
            this.IMDb_checkBox.CheckedChanged += new System.EventHandler(this.IMDb_checkBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(160, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 49;
            this.label5.Text = "до";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(33, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 48;
            this.label6.Text = "от";
            // 
            // IMDbFrom_numericUpDown
            // 
            this.IMDbFrom_numericUpDown.DecimalPlaces = 1;
            this.IMDbFrom_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.IMDbFrom_numericUpDown.Location = new System.Drawing.Point(61, 317);
            this.IMDbFrom_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.IMDbFrom_numericUpDown.Name = "IMDbFrom_numericUpDown";
            this.IMDbFrom_numericUpDown.Size = new System.Drawing.Size(96, 20);
            this.IMDbFrom_numericUpDown.TabIndex = 47;
            // 
            // IMDbTo_numericUpDown
            // 
            this.IMDbTo_numericUpDown.DecimalPlaces = 1;
            this.IMDbTo_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.IMDbTo_numericUpDown.Location = new System.Drawing.Point(189, 317);
            this.IMDbTo_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.IMDbTo_numericUpDown.Name = "IMDbTo_numericUpDown";
            this.IMDbTo_numericUpDown.Size = new System.Drawing.Size(96, 20);
            this.IMDbTo_numericUpDown.TabIndex = 51;
            // 
            // FilmSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(695, 480);
            this.Controls.Add(this.IMDbTo_numericUpDown);
            this.Controls.Add(this.IMDb_checkBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IMDbFrom_numericUpDown);
            this.Controls.Add(this.StartSearch_button);
            this.Controls.Add(this.Persons_checkBox);
            this.Controls.Add(this.AddPerson_button);
            this.Controls.Add(this.Persons_listBox);
            this.Controls.Add(this.Fees_checkBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FeesTo_numericUpDown);
            this.Controls.Add(this.FeesFrom_numericUpDown);
            this.Controls.Add(this.AgeLimit_checkBox);
            this.Controls.Add(this.AgeLimit_comboBox);
            this.Controls.Add(this.Countries_checkBox);
            this.Controls.Add(this.Genres_checkBox);
            this.Controls.Add(this.Countries_checkedListBox);
            this.Controls.Add(this.Genres_checkedListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YearTo_dateTimePicker);
            this.Controls.Add(this.YearForm_dateTimePicker);
            this.Controls.Add(this.Production_checkBox);
            this.Controls.Add(this.Name_checkBox);
            this.Controls.Add(this.Name_textBox);
            this.Name = "FilmSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расширенный поиск";
            ((System.ComponentModel.ISupportInitialize)(this.FeesFrom_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeesTo_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMDbFrom_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMDbTo_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.CheckBox Name_checkBox;
        private System.Windows.Forms.CheckBox Production_checkBox;
        private System.Windows.Forms.DateTimePicker YearForm_dateTimePicker;
        private System.Windows.Forms.DateTimePicker YearTo_dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox Countries_checkedListBox;
        private System.Windows.Forms.CheckedListBox Genres_checkedListBox;
        private System.Windows.Forms.CheckBox Genres_checkBox;
        private System.Windows.Forms.CheckBox Countries_checkBox;
        private System.Windows.Forms.ComboBox AgeLimit_comboBox;
        private System.Windows.Forms.CheckBox AgeLimit_checkBox;
        private System.Windows.Forms.NumericUpDown FeesFrom_numericUpDown;
        private System.Windows.Forms.NumericUpDown FeesTo_numericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Fees_checkBox;
        private System.Windows.Forms.Button AddPerson_button;
        private System.Windows.Forms.ListBox Persons_listBox;
        private System.Windows.Forms.CheckBox Persons_checkBox;
        private System.Windows.Forms.Button StartSearch_button;
        private System.Windows.Forms.CheckBox IMDb_checkBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown IMDbFrom_numericUpDown;
        private System.Windows.Forms.NumericUpDown IMDbTo_numericUpDown;
    }
}