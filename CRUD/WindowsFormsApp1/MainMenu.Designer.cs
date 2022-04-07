
namespace WindowsFormsApp1
{
    partial class MainMenu
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
            this.UserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserButton
            // 
            this.UserButton.Location = new System.Drawing.Point(39, 60);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(75, 23);
            this.UserButton.TabIndex = 0;
            this.UserButton.Text = "User";
            this.UserButton.UseVisualStyleBackColor = true;
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 660);
            this.Controls.Add(this.UserButton);
            this.Name = "MainMenu";
            this.Text = "CRUD_SYSTEEM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UserButton;
    }
}

