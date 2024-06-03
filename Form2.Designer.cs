namespace LaboratoryWork4
{
    partial class Form2
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
            nameLabel = new Label();
            nameTextBox = new TextBox();
            infoLabel = new Label();
            infoTextBox = new TextBox();
            closeButton = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(126, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Имя директории";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(144, 6);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.ReadOnly = true;
            nameTextBox.Size = new Size(250, 27);
            nameTextBox.TabIndex = 1;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(12, 60);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(102, 20);
            infoLabel.TabIndex = 2;
            infoLabel.Text = "Информация";
            // 
            // infoTextBox
            // 
            infoTextBox.Location = new Point(144, 57);
            infoTextBox.Name = "infoTextBox";
            infoTextBox.ReadOnly = true;
            infoTextBox.Size = new Size(250, 27);
            infoTextBox.TabIndex = 3;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(108, 136);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(187, 34);
            closeButton.TabIndex = 4;
            closeButton.Text = "Ну тип всё";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 227);
            Controls.Add(closeButton);
            Controls.Add(infoTextBox);
            Controls.Add(infoLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private Label infoLabel;
        private TextBox infoTextBox;
        private Button closeButton;
    }
}