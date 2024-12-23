using Tyuiu.BaldinAA.Sprint7.Project.V14.Lib;
namespace Tyuiu.BaldinAA.Sprint7.Project.V14
{
    public partial class FormMain : Form
    {
        public string? openFilePath;

        public List<string[]>? items;

        int rows;
        const int COLUMNS = 6;

        int rowFocusIndex;

        DataService dataService = new DataService();
        public FormMain()
        {
            InitializeComponent();

            saveFileDialog_BAA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*\";";
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                buttonOpenFile_BAA.Focus();
            }));

            dataGridViewRoutes_BAA.RowCount = 14;
            dataGridViewFeatures_BAA.RowCount = 14;
        }

        private void ToolStripMenuAbout_BAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void ToolStripMenuExit_BAA_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void buttonOpenFile_BAA_Click(object sender, EventArgs e)
        {
            openFileDialog_BAA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*\";";
            openFileDialog_BAA.ShowDialog();
            if (File.Exists(openFileDialog_BAA.FileName))
            {
                openFilePath = openFileDialog_BAA.FileName;
                items = dataService.ParseRouteItems(openFilePath);

                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].Length < 4 || !int.TryParse(items[i][0], out _))
                    {
                        MessageBox.Show("Неверные данные в файле", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                SetItemsToGrid(items);

                for (int i = 0; i < rows; i++)
                {
                    if (items[i].Count() == 5)
                    {
                        try
                        {
                            if (Convert.ToBoolean(items[i][4])) AddRowToFeature(i);
                        }
                        catch
                        {
                            MessageBox.Show("Неверные данные в файле (опция \"Избранное\n не является логическим значением)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                buttonSaveFile_BAA.Enabled = true;
                buttonUpdateFile_BAA.Enabled = true;

                ToolStripMenuOpenNewFileTool_BAA.Enabled = true;
                ToolStripMenuOpenFile_BAA.Enabled = true;
                ToolStripMenuRefresh_BAA.Enabled = true;
                ToolStripMenuSaveFile_BAA.Enabled = true;
            }

        }

        private void SetItemsToGrid(List<string[]> items)
        {
            rows = items.Count;

            dataGridViewRoutes_BAA.RowCount = rows;
            dataGridViewRoutes_BAA.ColumnCount = COLUMNS - 2;

            dataGridViewFeatures_BAA.RowCount = 0;

            for (int i = 0; i < rows; i++)
            {
                string[] routes = items[i][1].Split('|');
                dataGridViewRoutes_BAA.Rows[i].Cells[0].Value = items[i][0];
                dataGridViewRoutes_BAA.Rows[i].Cells[1].Value = routes[0];
                dataGridViewRoutes_BAA.Rows[i].Cells[2].Value = routes[^1];
                dataGridViewRoutes_BAA.Rows[i].Cells[3].Value = items[i][2];
            }
        }

        private void buttonSaveFile_BAA_Click(object sender, EventArgs e)
        {
            saveFileDialog_BAA.FileName = "file.csv";
            saveFileDialog_BAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_BAA.ShowDialog();

            string path = saveFileDialog_BAA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    if (j != COLUMNS - 1)
                    {
                        str += dataGridViewRoutes_BAA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewRoutes_BAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonUpdateFile_BAA_Click(object sender, EventArgs e)
        {
            items = dataService.ParseRouteItems(openFilePath);
            SetItemsToGrid(items);
        }

        private void buttonSetFeature_BAA_Click(object sender, EventArgs e)
        {
            if (dataGridViewFeatures_BAA.RowCount != 0)
            {
                for (int i = 0; i < dataGridViewFeatures_BAA.RowCount; i++)
                {
                    if ((string)dataGridViewFeatures_BAA.Rows[i].Cells[0].Value == items[rowFocusIndex][0]) return;
                }
            }

            AddRowToFeature(rowFocusIndex);

            buttonSetFeature_BAA.Enabled = false;
        }
        private void AddRowToFeature(int index)
        {
            int indexRow = dataGridViewFeatures_BAA.RowCount;
            dataGridViewFeatures_BAA.RowCount += 1;
            dataGridViewFeatures_BAA.Rows[indexRow].Cells[0].Value = dataGridViewRoutes_BAA.Rows[index].Cells[0].Value;
            dataGridViewFeatures_BAA.Rows[indexRow].Cells[1].Value = dataGridViewRoutes_BAA.Rows[index].Cells[1].Value;
            dataGridViewFeatures_BAA.Rows[indexRow].Cells[2].Value = dataGridViewRoutes_BAA.Rows[index].Cells[2].Value;
            dataGridViewFeatures_BAA.Rows[indexRow].Cells[3].Value = dataGridViewRoutes_BAA.Rows[index].Cells[3].Value;
        }

        private void dataGridViewRoutes_BAA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowFocusIndex = e.RowIndex;

                buttonSetFeature_BAA.Enabled = true;
                buttonOpenRoute_BAA.Enabled = true;
            }
        }

        private void tabControlRoutes_BAA_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControlRoutes_BAA.SelectedIndex == 0)
            {
                dataGridViewRoutes_BAA.Sort(dataGridViewRoutes_BAA.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            }
            else dataGridViewFeatures_BAA.Sort(dataGridViewFeatures_BAA.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }
        private void buttonSearch_BAA_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxSearch_BAA.Text, out int number))
            {
                DataGridView dataGrid = tabControlRoutes_BAA.SelectedIndex == 0 ? dataGridViewRoutes_BAA : dataGridViewFeatures_BAA;
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) != number)
                    {
                        dataGrid.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ToolStripMenuOpenFile_BAA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = openFilePath;
            txt.Start();
        }

        private void buttonOpenRoute_BAA_Click(object sender, EventArgs e)
        {
            FormRoute formRoute = new FormRoute(items[rowFocusIndex]);
            formRoute.Text = "Маршрут " + GetCurrentDataGridView().CurrentRow.Cells[0].Value;
            formRoute.ShowDialog();
        }

        private DataGridView GetCurrentDataGridView()
        {
            if (tabControlRoutes_BAA.SelectedIndex == 0) return dataGridViewRoutes_BAA;
            else return dataGridViewFeatures_BAA;
        }
        private void ToolStripMenuImages_BAA_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(dialog.SelectedPath))
                {
                    DataService.imagesFolder = dialog.SelectedPath;
                }
            }
        }
        private void buttonHelpImages_BAA_Click(object sender, EventArgs e)
        {
            FormGuideImage formGuideImage = new FormGuideImage();
            formGuideImage.ShowDialog();
        }

        private void buttonHelp_BAA_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }

        #region MouseEnterTips
        private void buttonOpenFile_BAA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_BAA.ToolTipTitle = "Открытие";
        }

        private void buttonSaveFile_BAA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_BAA.ToolTipTitle = "Экспорт";
        }

        private void buttonUpdateFile_BAA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_BAA.ToolTipTitle = "Обновить";
        }

        private void buttonHelp_BAA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_BAA.ToolTipTitle = "Руководство";
        }

        private void textBoxSearch_BAA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_BAA.ToolTipTitle = "Поиск";
        }

        private void buttonOpenRoute_BAA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_BAA.ToolTipTitle = "Открыть";
        }

        private void buttonSetFeature_BAA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_BAA.ToolTipTitle = "Избранное";
        }
        private void buttonHelpImages_BAA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_BAA.ToolTipTitle = "Руководство";
        }
        #endregion

        private void textBoxSearch_BAA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}