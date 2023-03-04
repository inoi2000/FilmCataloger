namespace FilmCataloger.View.AdminForms
{
    partial class CreatePersonForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.FirstName_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Professions_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BirthDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.LastName_textBox = new System.Windows.Forms.TextBox();
            this.Gender_groupBox = new System.Windows.Forms.GroupBox();
            this.FGender_radioButton = new System.Windows.Forms.RadioButton();
            this.MGender_radioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.PictureRef_textBox = new System.Windows.Forms.TextBox();
            this.Create_button = new System.Windows.Forms.Button();
            this.Countries_comboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Gender_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Имя";
            // 
            // FirstName_textBox
            // 
            this.FirstName_textBox.Location = new System.Drawing.Point(37, 42);
            this.FirstName_textBox.Name = "FirstName_textBox";
            this.FirstName_textBox.Size = new System.Drawing.Size(237, 20);
            this.FirstName_textBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(34, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Профессии";
            // 
            // Professions_checkedListBox
            // 
            this.Professions_checkedListBox.CheckOnClick = true;
            this.Professions_checkedListBox.FormattingEnabled = true;
            this.Professions_checkedListBox.HorizontalScrollbar = true;
            this.Professions_checkedListBox.Location = new System.Drawing.Point(37, 355);
            this.Professions_checkedListBox.MultiColumn = true;
            this.Professions_checkedListBox.Name = "Professions_checkedListBox";
            this.Professions_checkedListBox.Size = new System.Drawing.Size(237, 109);
            this.Professions_checkedListBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(34, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Дата рождения";
            // 
            // BirthDate_dateTimePicker
            // 
            this.BirthDate_dateTimePicker.CustomFormat = "";
            this.BirthDate_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDate_dateTimePicker.Location = new System.Drawing.Point(37, 259);
            this.BirthDate_dateTimePicker.Name = "BirthDate_dateTimePicker";
            this.BirthDate_dateTimePicker.Size = new System.Drawing.Size(237, 20);
            this.BirthDate_dateTimePicker.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(34, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Фамилия";
            // 
            // LastName_textBox
            // 
            this.LastName_textBox.Location = new System.Drawing.Point(37, 81);
            this.LastName_textBox.Name = "LastName_textBox";
            this.LastName_textBox.Size = new System.Drawing.Size(237, 20);
            this.LastName_textBox.TabIndex = 17;
            // 
            // Gender_groupBox
            // 
            this.Gender_groupBox.Controls.Add(this.FGender_radioButton);
            this.Gender_groupBox.Controls.Add(this.MGender_radioButton);
            this.Gender_groupBox.Location = new System.Drawing.Point(37, 167);
            this.Gender_groupBox.Name = "Gender_groupBox";
            this.Gender_groupBox.Size = new System.Drawing.Size(237, 59);
            this.Gender_groupBox.TabIndex = 19;
            this.Gender_groupBox.TabStop = false;
            this.Gender_groupBox.Text = "Пол";
            // 
            // FGender_radioButton
            // 
            this.FGender_radioButton.AutoSize = true;
            this.FGender_radioButton.Location = new System.Drawing.Point(123, 23);
            this.FGender_radioButton.Name = "FGender_radioButton";
            this.FGender_radioButton.Size = new System.Drawing.Size(72, 17);
            this.FGender_radioButton.TabIndex = 1;
            this.FGender_radioButton.Text = "Женский";
            this.FGender_radioButton.UseVisualStyleBackColor = true;
            // 
            // MGender_radioButton
            // 
            this.MGender_radioButton.AutoSize = true;
            this.MGender_radioButton.Checked = true;
            this.MGender_radioButton.Location = new System.Drawing.Point(23, 23);
            this.MGender_radioButton.Name = "MGender_radioButton";
            this.MGender_radioButton.Size = new System.Drawing.Size(71, 17);
            this.MGender_radioButton.TabIndex = 0;
            this.MGender_radioButton.TabStop = true;
            this.MGender_radioButton.Text = "Мужской";
            this.MGender_radioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(34, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ссылка на изображение";
            // 
            // PictureRef_textBox
            // 
            this.PictureRef_textBox.Location = new System.Drawing.Point(37, 130);
            this.PictureRef_textBox.Name = "PictureRef_textBox";
            this.PictureRef_textBox.Size = new System.Drawing.Size(237, 20);
            this.PictureRef_textBox.TabIndex = 20;
            // 
            // Create_button
            // 
            this.Create_button.Location = new System.Drawing.Point(70, 492);
            this.Create_button.Name = "Create_button";
            this.Create_button.Size = new System.Drawing.Size(172, 48);
            this.Create_button.TabIndex = 22;
            this.Create_button.Text = "Создать";
            this.Create_button.UseVisualStyleBackColor = true;
            this.Create_button.Click += new System.EventHandler(this.Create_button_Click);
            // 
            // Countries_comboBox
            // 
            this.Countries_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Countries_comboBox.FormattingEnabled = true;
            this.Countries_comboBox.Location = new System.Drawing.Point(35, 301);
            this.Countries_comboBox.Name = "Countries_comboBox";
            this.Countries_comboBox.Size = new System.Drawing.Size(237, 21);
            this.Countries_comboBox.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(32, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Место рождения";
            // 
            // CreatePersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(305, 562);
            this.Controls.Add(this.Countries_comboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Create_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PictureRef_textBox);
            this.Controls.Add(this.Gender_groupBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastName_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BirthDate_dateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Professions_checkedListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstName_textBox);
            this.Name = "CreatePersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление деятеля кино";
            this.Gender_groupBox.ResumeLayout(false);
            this.Gender_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstName_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox Professions_checkedListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker BirthDate_dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LastName_textBox;
        private System.Windows.Forms.GroupBox Gender_groupBox;
        private System.Windows.Forms.RadioButton FGender_radioButton;
        private System.Windows.Forms.RadioButton MGender_radioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PictureRef_textBox;
        private System.Windows.Forms.Button Create_button;
        private System.Windows.Forms.ComboBox Countries_comboBox;
        private System.Windows.Forms.Label label9;
    }
}