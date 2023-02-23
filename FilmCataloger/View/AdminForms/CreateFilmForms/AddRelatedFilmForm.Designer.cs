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
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Название фильма";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(19, 31);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(237, 20);
            this.Name_textBox.TabIndex = 25;
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(157, 62);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(72, 29);
            this.Cancel_button.TabIndex = 24;
            this.Cancel_button.Text = "Отменить";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(46, 62);
            this.Add_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(72, 29);
            this.Add_button.TabIndex = 23;
            this.Add_button.Text = "Применить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // AddRelatedFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 114);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Add_button);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddRelatedFilmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRelatedFilmForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Add_button;
    }
}