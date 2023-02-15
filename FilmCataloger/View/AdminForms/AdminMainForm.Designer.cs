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
            this.SuspendLayout();
            // 
            // CreatePerson_button
            // 
            this.CreatePerson_button.Location = new System.Drawing.Point(227, 30);
            this.CreatePerson_button.Name = "CreatePerson_button";
            this.CreatePerson_button.Size = new System.Drawing.Size(118, 45);
            this.CreatePerson_button.TabIndex = 3;
            this.CreatePerson_button.Text = "CreatePerson";
            this.CreatePerson_button.UseVisualStyleBackColor = true;
            this.CreatePerson_button.Click += new System.EventHandler(this.CreatePerson_button_Click);
            // 
            // CreateFilm_button
            // 
            this.CreateFilm_button.Location = new System.Drawing.Point(41, 30);
            this.CreateFilm_button.Name = "CreateFilm_button";
            this.CreateFilm_button.Size = new System.Drawing.Size(118, 45);
            this.CreateFilm_button.TabIndex = 2;
            this.CreateFilm_button.Text = "CreateFilm";
            this.CreateFilm_button.UseVisualStyleBackColor = true;
            this.CreateFilm_button.Click += new System.EventHandler(this.CreateFilm_button_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 121);
            this.Controls.Add(this.CreatePerson_button);
            this.Controls.Add(this.CreateFilm_button);
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreatePerson_button;
        private System.Windows.Forms.Button CreateFilm_button;
    }
}