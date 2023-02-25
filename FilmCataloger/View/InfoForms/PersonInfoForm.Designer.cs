namespace FilmCataloger.View.InfoForms
{
    partial class PersonInfoForm
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
            this.Country_label = new System.Windows.Forms.Label();
            this.BirthDate_label = new System.Windows.Forms.Label();
            this.Professions_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Films_listView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.Person_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Person_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Country_label
            // 
            this.Country_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Country_label.Location = new System.Drawing.Point(354, 145);
            this.Country_label.Name = "Country_label";
            this.Country_label.Size = new System.Drawing.Size(334, 22);
            this.Country_label.TabIndex = 31;
            // 
            // BirthDate_label
            // 
            this.BirthDate_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BirthDate_label.Location = new System.Drawing.Point(354, 113);
            this.BirthDate_label.Name = "BirthDate_label";
            this.BirthDate_label.Size = new System.Drawing.Size(334, 22);
            this.BirthDate_label.TabIndex = 30;
            // 
            // Professions_label
            // 
            this.Professions_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Professions_label.Location = new System.Drawing.Point(354, 82);
            this.Professions_label.Name = "Professions_label";
            this.Professions_label.Size = new System.Drawing.Size(334, 22);
            this.Professions_label.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(244, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 22);
            this.label7.TabIndex = 27;
            this.label7.Text = "Место рождения";
            // 
            // Films_listView
            // 
            this.Films_listView.HideSelection = false;
            this.Films_listView.Location = new System.Drawing.Point(244, 179);
            this.Films_listView.Name = "Films_listView";
            this.Films_listView.Size = new System.Drawing.Size(444, 144);
            this.Films_listView.TabIndex = 24;
            this.Films_listView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(244, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Карьера";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(244, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Дата рождения";
            // 
            // Name_label
            // 
            this.Name_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_label.Location = new System.Drawing.Point(244, 12);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(444, 61);
            this.Name_label.TabIndex = 19;
            // 
            // Person_pictureBox
            // 
            this.Person_pictureBox.Location = new System.Drawing.Point(12, 12);
            this.Person_pictureBox.Name = "Person_pictureBox";
            this.Person_pictureBox.Size = new System.Drawing.Size(216, 311);
            this.Person_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Person_pictureBox.TabIndex = 18;
            this.Person_pictureBox.TabStop = false;
            // 
            // PersonInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 335);
            this.Controls.Add(this.Country_label);
            this.Controls.Add(this.BirthDate_label);
            this.Controls.Add(this.Professions_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Films_listView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Person_pictureBox);
            this.Name = "PersonInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.Person_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Country_label;
        private System.Windows.Forms.Label BirthDate_label;
        private System.Windows.Forms.Label Professions_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView Films_listView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.PictureBox Person_pictureBox;
    }
}