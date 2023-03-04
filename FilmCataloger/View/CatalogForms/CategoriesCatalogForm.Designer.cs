namespace FilmCataloger.View.CatalogForms
{
    partial class CategoriesCatalogForm
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
            this.Category_listView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Category_listView
            // 
            this.Category_listView.HideSelection = false;
            this.Category_listView.Location = new System.Drawing.Point(12, 12);
            this.Category_listView.Name = "Category_listView";
            this.Category_listView.Size = new System.Drawing.Size(543, 349);
            this.Category_listView.TabIndex = 3;
            this.Category_listView.UseCompatibleStateImageBehavior = false;
            // 
            // CategoriesCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(570, 376);
            this.Controls.Add(this.Category_listView);
            this.Name = "CategoriesCatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог категорий";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView Category_listView;
    }
}