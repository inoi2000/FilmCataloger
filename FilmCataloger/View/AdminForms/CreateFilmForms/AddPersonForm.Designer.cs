namespace FilmCataloger.View.AdminForms.CreateFilmForms
{
    partial class AddPersonForm
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
            this.Add_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LastName_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstName_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(59, 109);
            this.Add_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(72, 29);
            this.Add_button.TabIndex = 1;
            this.Add_button.Text = "Применить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(170, 109);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(72, 29);
            this.Cancel_button.TabIndex = 2;
            this.Cancel_button.Text = "Отменить";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(29, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Фамилия";
            // 
            // LastName_textBox
            // 
            this.LastName_textBox.Location = new System.Drawing.Point(33, 78);
            this.LastName_textBox.Name = "LastName_textBox";
            this.LastName_textBox.Size = new System.Drawing.Size(237, 20);
            this.LastName_textBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Имя";
            // 
            // FirstName_textBox
            // 
            this.FirstName_textBox.Location = new System.Drawing.Point(33, 39);
            this.FirstName_textBox.Name = "FirstName_textBox";
            this.FirstName_textBox.Size = new System.Drawing.Size(237, 20);
            this.FirstName_textBox.TabIndex = 19;
            // 
            // AddPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 166);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastName_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstName_textBox);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Add_button);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddPersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPersonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LastName_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstName_textBox;
    }
}