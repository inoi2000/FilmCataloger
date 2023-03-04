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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchPlus_button = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.MainManu_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Persons_listView
            // 
            this.Persons_listView.HideSelection = false;
            this.Persons_listView.Location = new System.Drawing.Point(12, 77);
            this.Persons_listView.Name = "Persons_listView";
            this.Persons_listView.Size = new System.Drawing.Size(751, 435);
            this.Persons_listView.TabIndex = 5;
            this.Persons_listView.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.SearchPlus_button);
            this.groupBox1.Controls.Add(this.Search_button);
            this.groupBox1.Controls.Add(this.MainManu_button);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 59);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(478, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 10;
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
            // 
            // PersonsCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 524);
            this.Controls.Add(this.Persons_listView);
            this.Controls.Add(this.groupBox1);
            this.Name = "PersonsCatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonsCatalogForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Persons_listView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchPlus_button;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button MainManu_button;
    }
}