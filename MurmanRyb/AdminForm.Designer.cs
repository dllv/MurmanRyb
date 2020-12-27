namespace MurmanRyb
{
    partial class AdminForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.userListButton = new System.Windows.Forms.Button();
            this.customerListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(768, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(20, 20);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // userListButton
            // 
            this.userListButton.Location = new System.Drawing.Point(12, 12);
            this.userListButton.Name = "userListButton";
            this.userListButton.Size = new System.Drawing.Size(150, 23);
            this.userListButton.TabIndex = 1;
            this.userListButton.Text = "Список пользователей";
            this.userListButton.UseVisualStyleBackColor = true;
            this.userListButton.Click += new System.EventHandler(this.userListButton_Click);
            // 
            // customerListButton
            // 
            this.customerListButton.Location = new System.Drawing.Point(176, 12);
            this.customerListButton.Name = "customerListButton";
            this.customerListButton.Size = new System.Drawing.Size(150, 23);
            this.customerListButton.TabIndex = 2;
            this.customerListButton.Text = "Список заказчиков";
            this.customerListButton.UseVisualStyleBackColor = true;
            this.customerListButton.Click += new System.EventHandler(this.customerListButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerListButton);
            this.Controls.Add(this.userListButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button userListButton;
        private System.Windows.Forms.Button customerListButton;
    }
}