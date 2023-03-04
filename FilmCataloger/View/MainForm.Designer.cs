namespace FilmCataloger.View
{
    partial class MainForm
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
            this.FilmsCatalog_button = new System.Windows.Forms.Button();
            this.PersonsCatalog_button = new System.Windows.Forms.Button();
            this.Persons_listView = new System.Windows.Forms.ListView();
            this.CategoriesCatalog_button = new System.Windows.Forms.Button();
            this.Category_listView = new System.Windows.Forms.ListView();
            this.Admin_linkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Films_listView
            // 
            this.Films_listView.HideSelection = false;
            this.Films_listView.Location = new System.Drawing.Point(12, 56);
            this.Films_listView.Name = "Films_listView";
            this.Films_listView.Size = new System.Drawing.Size(751, 149);
            this.Films_listView.TabIndex = 0;
            this.Films_listView.UseCompatibleStateImageBehavior = false;
            this.Films_listView.DoubleClick += new System.EventHandler(this.Films_listView_DoubleClick);
            // 
            // FilmsCatalog_button
            // 
            this.FilmsCatalog_button.Location = new System.Drawing.Point(262, 12);
            this.FilmsCatalog_button.Name = "FilmsCatalog_button";
            this.FilmsCatalog_button.Size = new System.Drawing.Size(236, 38);
            this.FilmsCatalog_button.TabIndex = 2;
            this.FilmsCatalog_button.Text = "ФИЛЬМЫ";
            this.FilmsCatalog_button.UseVisualStyleBackColor = true;
            this.FilmsCatalog_button.Click += new System.EventHandler(this.FilmsCatalog_button_Click);
            // 
            // PersonsCatalog_button
            // 
            this.PersonsCatalog_button.Location = new System.Drawing.Point(262, 211);
            this.PersonsCatalog_button.Name = "PersonsCatalog_button";
            this.PersonsCatalog_button.Size = new System.Drawing.Size(236, 38);
            this.PersonsCatalog_button.TabIndex = 4;
            this.PersonsCatalog_button.Text = "ДЕЯТЕЛИ КИНО";
            this.PersonsCatalog_button.UseVisualStyleBackColor = true;
            this.PersonsCatalog_button.Click += new System.EventHandler(this.PersonsCatalog_button_Click);
            // 
            // Persons_listView
            // 
            this.Persons_listView.HideSelection = false;
            this.Persons_listView.Location = new System.Drawing.Point(12, 255);
            this.Persons_listView.Name = "Persons_listView";
            this.Persons_listView.Size = new System.Drawing.Size(751, 138);
            this.Persons_listView.TabIndex = 3;
            this.Persons_listView.UseCompatibleStateImageBehavior = false;
            this.Persons_listView.DoubleClick += new System.EventHandler(this.Persons_listView_DoubleClick);
            // 
            // CategoriesCatalog_button
            // 
            this.CategoriesCatalog_button.Location = new System.Drawing.Point(262, 399);
            this.CategoriesCatalog_button.Name = "CategoriesCatalog_button";
            this.CategoriesCatalog_button.Size = new System.Drawing.Size(236, 38);
            this.CategoriesCatalog_button.TabIndex = 6;
            this.CategoriesCatalog_button.Text = "КАТЕГОРИИ";
            this.CategoriesCatalog_button.UseVisualStyleBackColor = true;
            this.CategoriesCatalog_button.Click += new System.EventHandler(this.CategoriesCatalog_button_Click);
            // 
            // Category_listView
            // 
            this.Category_listView.HideSelection = false;
            this.Category_listView.Location = new System.Drawing.Point(12, 443);
            this.Category_listView.Name = "Category_listView";
            this.Category_listView.Size = new System.Drawing.Size(751, 136);
            this.Category_listView.TabIndex = 5;
            this.Category_listView.UseCompatibleStateImageBehavior = false;
            this.Category_listView.DoubleClick += new System.EventHandler(this.Category_listView_DoubleClick);
            // 
            // Admin_linkLabel
            // 
            this.Admin_linkLabel.AutoSize = true;
            this.Admin_linkLabel.Location = new System.Drawing.Point(635, 595);
            this.Admin_linkLabel.Name = "Admin_linkLabel";
            this.Admin_linkLabel.Size = new System.Drawing.Size(107, 13);
            this.Admin_linkLabel.TabIndex = 7;
            this.Admin_linkLabel.TabStop = true;
            this.Admin_linkLabel.Text = "Панель управления";
            this.Admin_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Admin_linkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 616);
            this.Controls.Add(this.Admin_linkLabel);
            this.Controls.Add(this.CategoriesCatalog_button);
            this.Controls.Add(this.Category_listView);
            this.Controls.Add(this.PersonsCatalog_button);
            this.Controls.Add(this.Persons_listView);
            this.Controls.Add(this.FilmsCatalog_button);
            this.Controls.Add(this.Films_listView);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Films_listView;
        private System.Windows.Forms.Button FilmsCatalog_button;
        private System.Windows.Forms.Button PersonsCatalog_button;
        private System.Windows.Forms.ListView Persons_listView;
        private System.Windows.Forms.Button CategoriesCatalog_button;
        private System.Windows.Forms.ListView Category_listView;
        private System.Windows.Forms.LinkLabel Admin_linkLabel;
    }
}