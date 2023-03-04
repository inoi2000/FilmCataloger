namespace FilmCataloger.View.AdminForms
{
    partial class AdminMainForm
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
            this.CreatePerson_button = new System.Windows.Forms.Button();
            this.CreateFilm_button = new System.Windows.Forms.Button();
            this.ChangePersonInfo_button = new System.Windows.Forms.Button();
            this.ChangeFilmInfo_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreatePerson_button
            // 
            this.CreatePerson_button.Location = new System.Drawing.Point(218, 23);
            this.CreatePerson_button.Name = "CreatePerson_button";
            this.CreatePerson_button.Size = new System.Drawing.Size(135, 56);
            this.CreatePerson_button.TabIndex = 3;
            this.CreatePerson_button.Text = "Добавить деятеля кино";
            this.CreatePerson_button.UseVisualStyleBackColor = true;
            this.CreatePerson_button.Click += new System.EventHandler(this.CreatePerson_button_Click);
            // 
            // CreateFilm_button
            // 
            this.CreateFilm_button.Location = new System.Drawing.Point(32, 23);
            this.CreateFilm_button.Name = "CreateFilm_button";
            this.CreateFilm_button.Size = new System.Drawing.Size(135, 56);
            this.CreateFilm_button.TabIndex = 2;
            this.CreateFilm_button.Text = "Добавить фильм";
            this.CreateFilm_button.UseVisualStyleBackColor = true;
            this.CreateFilm_button.Click += new System.EventHandler(this.CreateFilm_button_Click);
            // 
            // ChangePersonInfo_button
            // 
            this.ChangePersonInfo_button.Location = new System.Drawing.Point(218, 96);
            this.ChangePersonInfo_button.Name = "ChangePersonInfo_button";
            this.ChangePersonInfo_button.Size = new System.Drawing.Size(135, 56);
            this.ChangePersonInfo_button.TabIndex = 5;
            this.ChangePersonInfo_button.Text = "Изменить информацию о деятеле кино";
            this.ChangePersonInfo_button.UseVisualStyleBackColor = true;
            this.ChangePersonInfo_button.Click += new System.EventHandler(this.ChangePersonInfo_button_Click);
            // 
            // ChangeFilmInfo_button
            // 
            this.ChangeFilmInfo_button.Location = new System.Drawing.Point(32, 96);
            this.ChangeFilmInfo_button.Name = "ChangeFilmInfo_button";
            this.ChangeFilmInfo_button.Size = new System.Drawing.Size(135, 56);
            this.ChangeFilmInfo_button.TabIndex = 4;
            this.ChangeFilmInfo_button.Text = "Изменить информацию о фильме";
            this.ChangeFilmInfo_button.UseVisualStyleBackColor = true;
            this.ChangeFilmInfo_button.Click += new System.EventHandler(this.ChangeFilmInfo_button_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(408, 170);
            this.Controls.Add(this.ChangePersonInfo_button);
            this.Controls.Add(this.ChangeFilmInfo_button);
            this.Controls.Add(this.CreatePerson_button);
            this.Controls.Add(this.CreateFilm_button);
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель управления";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreatePerson_button;
        private System.Windows.Forms.Button CreateFilm_button;
        private System.Windows.Forms.Button ChangePersonInfo_button;
        private System.Windows.Forms.Button ChangeFilmInfo_button;
    }
}