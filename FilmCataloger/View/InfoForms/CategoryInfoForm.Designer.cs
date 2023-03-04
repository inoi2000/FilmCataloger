namespace FilmCataloger.View.InfoForms
{
    partial class CategoryInfoForm
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
            this.Category_pictureBox = new System.Windows.Forms.PictureBox();
            this.Description_label = new System.Windows.Forms.TextBox();
            this.Category_listView = new System.Windows.Forms.ListView();
            this.Name_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Category_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Category_pictureBox
            // 
            this.Category_pictureBox.Location = new System.Drawing.Point(12, 12);
            this.Category_pictureBox.Name = "Category_pictureBox";
            this.Category_pictureBox.Size = new System.Drawing.Size(138, 176);
            this.Category_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Category_pictureBox.TabIndex = 1;
            this.Category_pictureBox.TabStop = false;
            // 
            // Description_label
            // 
            this.Description_label.Location = new System.Drawing.Point(168, 76);
            this.Description_label.Multiline = true;
            this.Description_label.Name = "Description_label";
            this.Description_label.Size = new System.Drawing.Size(433, 112);
            this.Description_label.TabIndex = 20;
            // 
            // Category_listView
            // 
            this.Category_listView.HideSelection = false;
            this.Category_listView.Location = new System.Drawing.Point(12, 204);
            this.Category_listView.Name = "Category_listView";
            this.Category_listView.Size = new System.Drawing.Size(589, 314);
            this.Category_listView.TabIndex = 21;
            this.Category_listView.UseCompatibleStateImageBehavior = false;
            // 
            // Name_label
            // 
            this.Name_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_label.Location = new System.Drawing.Point(168, 12);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(433, 49);
            this.Name_label.TabIndex = 22;
            // 
            // CategoryInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 530);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Category_listView);
            this.Controls.Add(this.Description_label);
            this.Controls.Add(this.Category_pictureBox);
            this.Name = "CategoryInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Category_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Category_pictureBox;
        private System.Windows.Forms.TextBox Description_label;
        private System.Windows.Forms.ListView Category_listView;
        private System.Windows.Forms.Label Name_label;
    }
}