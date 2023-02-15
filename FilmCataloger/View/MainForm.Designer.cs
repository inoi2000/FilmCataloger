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
            this.Admin_button = new System.Windows.Forms.Button();
            this.User_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Admin_button
            // 
            this.Admin_button.Location = new System.Drawing.Point(44, 40);
            this.Admin_button.Name = "Admin_button";
            this.Admin_button.Size = new System.Drawing.Size(118, 45);
            this.Admin_button.TabIndex = 0;
            this.Admin_button.Text = "Admin";
            this.Admin_button.UseVisualStyleBackColor = true;
            this.Admin_button.Click += new System.EventHandler(this.Admin_button_Click);
            // 
            // User_button
            // 
            this.User_button.Location = new System.Drawing.Point(230, 40);
            this.User_button.Name = "User_button";
            this.User_button.Size = new System.Drawing.Size(118, 45);
            this.User_button.TabIndex = 1;
            this.User_button.Text = "User";
            this.User_button.UseVisualStyleBackColor = true;
            this.User_button.Click += new System.EventHandler(this.User_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 150);
            this.Controls.Add(this.User_button);
            this.Controls.Add(this.Admin_button);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Admin_button;
        private System.Windows.Forms.Button User_button;
    }
}