namespace LaboratoryWork4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            doItButton = new Button();
            subDirsListBox = new ListBox();
            currentDirLabel = new Label();
            selectedDirTextBox = new TextBox();
            subDirsLabel = new Label();
            selectDirBrowserDialog = new FolderBrowserDialog();
            subFilesGridView = new DataGridView();
            nameColumn = new DataGridViewTextBoxColumn();
            sizeColumn = new DataGridViewTextBoxColumn();
            modifyTimeColumn = new DataGridViewTextBoxColumn();
            calcColumn = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            calcButton = new Button();
            ((System.ComponentModel.ISupportInitialize)subFilesGridView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // doItButton
            // 
            doItButton.Location = new Point(419, 498);
            doItButton.Name = "doItButton";
            doItButton.Size = new Size(246, 80);
            doItButton.TabIndex = 0;
            doItButton.Text = "Жмякни меня";
            doItButton.UseVisualStyleBackColor = true;
            doItButton.Click += doItButton_Click;
            // 
            // subDirsListBox
            // 
            subDirsListBox.FormattingEnabled = true;
            subDirsListBox.Location = new Point(12, 192);
            subDirsListBox.Name = "subDirsListBox";
            subDirsListBox.Size = new Size(252, 384);
            subDirsListBox.TabIndex = 1;
            // 
            // currentDirLabel
            // 
            currentDirLabel.AutoSize = true;
            currentDirLabel.Location = new Point(12, 25);
            currentDirLabel.Name = "currentDirLabel";
            currentDirLabel.Size = new Size(153, 20);
            currentDirLabel.TabIndex = 2;
            currentDirLabel.Text = "Текущая директория";
            // 
            // selectedDirTextBox
            // 
            selectedDirTextBox.Location = new Point(12, 58);
            selectedDirTextBox.Name = "selectedDirTextBox";
            selectedDirTextBox.Size = new Size(252, 27);
            selectedDirTextBox.TabIndex = 3;
            // 
            // subDirsLabel
            // 
            subDirsLabel.AutoSize = true;
            subDirsLabel.Location = new Point(12, 154);
            subDirsLabel.Name = "subDirsLabel";
            subDirsLabel.Size = new Size(120, 20);
            subDirsLabel.TabIndex = 4;
            subDirsLabel.Text = "Поддиректории";
            // 
            // subFilesGridView
            // 
            subFilesGridView.AllowUserToAddRows = false;
            subFilesGridView.AllowUserToDeleteRows = false;
            subFilesGridView.AllowUserToOrderColumns = true;
            subFilesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            subFilesGridView.Columns.AddRange(new DataGridViewColumn[] { nameColumn, sizeColumn, modifyTimeColumn, calcColumn });
            subFilesGridView.Location = new Point(419, 192);
            subFilesGridView.Name = "subFilesGridView";
            subFilesGridView.RowHeadersWidth = 51;
            subFilesGridView.Size = new Size(568, 258);
            subFilesGridView.TabIndex = 5;
            // 
            // nameColumn
            // 
            nameColumn.HeaderText = "Name";
            nameColumn.MinimumWidth = 6;
            nameColumn.Name = "nameColumn";
            nameColumn.Width = 125;
            // 
            // sizeColumn
            // 
            sizeColumn.HeaderText = "Size";
            sizeColumn.MinimumWidth = 6;
            sizeColumn.Name = "sizeColumn";
            sizeColumn.ReadOnly = true;
            sizeColumn.Width = 125;
            // 
            // modifyTimeColumn
            // 
            modifyTimeColumn.HeaderText = "Modification time";
            modifyTimeColumn.MinimumWidth = 6;
            modifyTimeColumn.Name = "modifyTimeColumn";
            modifyTimeColumn.ReadOnly = true;
            modifyTimeColumn.Width = 125;
            // 
            // calcColumn
            // 
            calcColumn.HeaderText = "Calc result";
            calcColumn.MinimumWidth = 6;
            calcColumn.Name = "calcColumn";
            calcColumn.ReadOnly = true;
            calcColumn.Width = 125;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1353, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // calcButton
            // 
            calcButton.Location = new Point(741, 498);
            calcButton.Name = "calcButton";
            calcButton.Size = new Size(246, 78);
            calcButton.TabIndex = 7;
            calcButton.Text = "Посчитай меня";
            calcButton.UseVisualStyleBackColor = true;
            calcButton.Visible = false;
            calcButton.Click += calcButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 616);
            Controls.Add(calcButton);
            Controls.Add(subFilesGridView);
            Controls.Add(subDirsLabel);
            Controls.Add(selectedDirTextBox);
            Controls.Add(currentDirLabel);
            Controls.Add(subDirsListBox);
            Controls.Add(doItButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)subFilesGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button doItButton;
        private ListBox subDirsListBox;
        private Label currentDirLabel;
        private TextBox selectedDirTextBox;
        private Label subDirsLabel;
        private FolderBrowserDialog selectDirBrowserDialog;
        private DataGridView subFilesGridView;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn sizeColumn;
        private DataGridViewTextBoxColumn modifyTimeColumn;
        private DataGridViewTextBoxColumn calcColumn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button calcButton;
    }
}
