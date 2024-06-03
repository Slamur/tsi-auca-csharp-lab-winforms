namespace LaboratoryWork4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitializeForm();
        }

        void InitializeForm()
        {
            InitializeWindow();
            InitializeButton();
            InitializeDirControls();
        }

        private const double screenSizeCoeff = 0.9;

        void InitializeWindow()
        {
            var screenSize = Screen.FromControl(this).Bounds;

            this.Width = (int)(screenSize.Width * screenSizeCoeff);
            this.Height = (int)(screenSize.Height * screenSizeCoeff);
            this.CenterToScreen();
        }

        private const double buttonHeightCoeff = 0.8;

        void InitializeButton()
        {
            doItButton.Location = new Point(
                this.Width / 2 - doItButton.Width / 2,
                (int)(this.Height * buttonHeightCoeff)
            );

            doItButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        }

        void InitializeDirControls()
        {
            selectedDirTextBox.ReadOnly = true;

            InitializeSubDirsControls();
            InitializeSubFilesControls();
        }

        void InitializeSubDirsControls()
        {
            subDirsListBox.MouseDoubleClick += (sender, e) =>
            {
                var dir = subDirsListBox.SelectedItem as DirectoryInfo;
                if (dir != null)
                {
                    new Form2(dir).Show();
                }
            };
        }

        class FileHandler
        {
            public FileInfo? Handle { get; init; }
            public string Name
            {
                get { return Handle.Name; }
            }

            public long Length
            {
                get { return Handle.Length; }
            }

            public DateTime ModificationTime
            {
                get { return Handle.LastWriteTime; }
            }

            public int? CalcResult
            {
                get; set;
            }
        }

        void InitializeSubFilesControls()
        {
            subFilesGridView.AutoGenerateColumns = false;

            nameColumn.DataPropertyName = "Name";
            sizeColumn.DataPropertyName = "Length";
            modifyTimeColumn.DataPropertyName = "ModificationTime";

            calcColumn.DataPropertyName = "CalcResult";
            calcColumn.Visible = false;

            subFilesGridView.CellDoubleClick += async (object? sender, DataGridViewCellEventArgs e) =>
            {
                var file = (FileHandler)subFilesGridView.Rows[e.RowIndex].DataBoundItem;
                if (MessageBox.Show($"Duplicate file {file.Name}?", "Such wow", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    string newFileName = Path.GetFileNameWithoutExtension(file.Handle.FullName) + "_new" + Path.GetExtension(file.Name);
                    string newFilePath = Path.Combine(file.Handle.DirectoryName, newFileName);
                    using (var sourceStream = file.Handle.OpenRead())
                    {
                        using (var targetStream = File.OpenWrite(newFilePath))
                        {
                            await sourceStream.CopyToAsync(targetStream);
                        }
                    }
                    ShowSubFiles();
                }
            };
        }

        private void doItButton_Click(object sender, EventArgs e)
        {
            ProcessDirectory();
        }

        private DirectoryInfo selectedDir;

        private void ProcessDirectory()
        {
            if (selectDirBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var directory = new DirectoryInfo(selectDirBrowserDialog.SelectedPath);
                SelectDirectory(directory);
            }
        }

        private void SelectDirectory(DirectoryInfo directory)
        {
            selectedDir = directory;
            selectedDirTextBox.Text = directory.FullName;

            ShowSubDirs();
            ShowSubFiles();
        }

        private void ShowSubDirs()
        {
            var subDirs = selectedDir.GetDirectories();

            subDirsListBox.Items.Clear();
            subDirsListBox.Items.AddRange(subDirs);
            subDirsListBox.DisplayMember = "Name";
        }

        static Random random = new Random();

        private void ShowSubFiles()
        {
            var subFiles = selectedDir.GetFiles();

            var fileDataInfos = subFiles.Select(file => new FileHandler { Handle = file }).ToArray();
            subFilesGridView.DataSource = fileDataInfos;

            calcColumn.Visible = false;
            calcButton.Visible = true;
        }

        private async void calcButton_Click(object sender, EventArgs e)
        {
            await ProcessFiles();
        }

        private async Task ProcessFiles()
        {
            calcColumn.Visible = true;

            var subFiles = subFilesGridView.DataSource as FileHandler[];
            var calcTasks = subFiles.Select(async file =>
            {
                int delay = random.Next(1, subFiles.Length) * 1000;
                await Task.Delay(delay);
                file.CalcResult = delay;
            });

            await Task.WhenAll(calcTasks);

            subFilesGridView.Refresh();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My name is Giovanni Giorgio!");
        }
    }
}
