namespace FilmCataloger.View.AdminForms.CreateFilmForms
{
    partial class AddRelatedFilmForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Films_listView = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(161, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Название фильма";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(164, 67);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(237, 20);
            this.Name_textBox.TabIndex = 25;
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(302, 98);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(72, 29);
            this.Cancel_button.TabIndex = 24;
            this.Cancel_button.Text = "Отменить";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(191, 98);
            this.Add_button.Margin = new System.Windows.Forms.Padding(2);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(72, 29);
            this.Add_button.TabIndex = 23;
            this.Add_button.Text = "Применить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 200);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Add_button);
            this.tabPage1.Controls.Add(this.Name_textBox);
            this.tabPage1.Controls.Add(this.Cancel_button);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 174);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Поиск по названию";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Films_listView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 174);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Выбор вручную";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Films_listView
            // 
            this.Films_listView.HideSelection = false;
            this.Films_listView.Location = new System.Drawing.Point(6, 6);
            this.Films_listView.Name = "Films_listView";
            this.Films_listView.Size = new System.Drawing.Size(580, 162);
            this.Films_listView.TabIndex = 4;
            this.Films_listView.UseCompatibleStateImageBehavior = false;
            // 
            // AddRelatedFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(618, 225);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddRelatedFilmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить связанный фильм";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView Films_listView;
    }
}