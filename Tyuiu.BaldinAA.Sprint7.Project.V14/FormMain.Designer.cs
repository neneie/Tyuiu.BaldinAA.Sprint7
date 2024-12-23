namespace Tyuiu.BaldinAA.Sprint7.Project.V14
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            menuStrip_BAA = new MenuStrip();
            ToolStripMenuItemProgramm_BAA = new ToolStripMenuItem();
            ToolStripMenuAbout_BAA = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            ToolStripMenuExit_BAA = new ToolStripMenuItem();
            ToolStripMenuItemFile_BAA = new ToolStripMenuItem();
            ToolStripMenuOpenNewFileTool_BAA = new ToolStripMenuItem();
            ToolStripMenuOpenNewFile_BAA = new ToolStripMenuItem();
            ToolStripMenuImages_BAA = new ToolStripMenuItem();
            ToolStripMenuSaveFile_BAA = new ToolStripMenuItem();
            ToolStripMenuRefresh_BAA = new ToolStripMenuItem();
            ToolStripMenuOpenFile_BAA = new ToolStripMenuItem();
            tableLayoutPanel_BAA = new TableLayoutPanel();
            panelControl_BAA = new Panel();
            groupBoxEdit_BAA = new GroupBox();
            buttonSetFeature_BAA = new Button();
            buttonOpenRoute_BAA = new Button();
            groupBoxGuide_BAA = new GroupBox();
            buttonHelpImages_BAA = new Button();
            buttonHelp_BAA = new Button();
            groupBoxFile_BAA = new GroupBox();
            buttonUpdateFile_BAA = new Button();
            buttonSaveFile_BAA = new Button();
            buttonOpenFile_BAA = new Button();
            groupBoxSearch_BAA = new GroupBox();
            buttonSearch_BAA = new Button();
            textBoxSearch_BAA = new TextBox();
            tabControlRoutes_BAA = new TabControl();
            tabPageRoutes = new TabPage();
            dataGridViewRoutes_BAA = new DataGridView();
            ColumnNumber = new DataGridViewTextBoxColumn();
            ColumnStart = new DataGridViewTextBoxColumn();
            ColumnEnd = new DataGridViewTextBoxColumn();
            ColumnType = new DataGridViewTextBoxColumn();
            tabPageFeatures = new TabPage();
            dataGridViewFeatures_BAA = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            toolTip_BAA = new ToolTip(components);
            openFileDialog_BAA = new OpenFileDialog();
            saveFileDialog_BAA = new SaveFileDialog();
            menuStrip_BAA.SuspendLayout();
            tableLayoutPanel_BAA.SuspendLayout();
            panelControl_BAA.SuspendLayout();
            groupBoxEdit_BAA.SuspendLayout();
            groupBoxGuide_BAA.SuspendLayout();
            groupBoxFile_BAA.SuspendLayout();
            groupBoxSearch_BAA.SuspendLayout();
            tabControlRoutes_BAA.SuspendLayout();
            tabPageRoutes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoutes_BAA).BeginInit();
            tabPageFeatures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFeatures_BAA).BeginInit();
            SuspendLayout();
            // 
            // menuStrip_BAA
            // 
            menuStrip_BAA.BackColor = Color.Azure;
            menuStrip_BAA.ImageScalingSize = new Size(20, 20);
            menuStrip_BAA.Items.AddRange(new ToolStripItem[] { ToolStripMenuItemProgramm_BAA, ToolStripMenuItemFile_BAA });
            menuStrip_BAA.Location = new Point(0, 0);
            menuStrip_BAA.Name = "menuStrip_BAA";
            menuStrip_BAA.Padding = new Padding(7, 3, 0, 3);
            menuStrip_BAA.RenderMode = ToolStripRenderMode.System;
            menuStrip_BAA.Size = new Size(962, 30);
            menuStrip_BAA.TabIndex = 0;
            menuStrip_BAA.Text = "menuStrip1";
            // 
            // ToolStripMenuItemProgramm_BAA
            // 
            ToolStripMenuItemProgramm_BAA.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuAbout_BAA, toolStripSeparator1, ToolStripMenuExit_BAA });
            ToolStripMenuItemProgramm_BAA.Name = "ToolStripMenuItemProgramm_BAA";
            ToolStripMenuItemProgramm_BAA.Size = new Size(105, 24);
            ToolStripMenuItemProgramm_BAA.Text = "Программа";
            // 
            // ToolStripMenuAbout_BAA
            // 
            ToolStripMenuAbout_BAA.Name = "ToolStripMenuAbout_BAA";
            ToolStripMenuAbout_BAA.Size = new Size(224, 26);
            ToolStripMenuAbout_BAA.Text = "О программе";
            ToolStripMenuAbout_BAA.Click += ToolStripMenuAbout_BAA_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // ToolStripMenuExit_BAA
            // 
            ToolStripMenuExit_BAA.Name = "ToolStripMenuExit_BAA";
            ToolStripMenuExit_BAA.Size = new Size(224, 26);
            ToolStripMenuExit_BAA.Text = "Выход";
            ToolStripMenuExit_BAA.Click += ToolStripMenuExit_BAA_Click;
            // 
            // ToolStripMenuItemFile_BAA
            // 
            ToolStripMenuItemFile_BAA.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuOpenNewFileTool_BAA, ToolStripMenuSaveFile_BAA, ToolStripMenuRefresh_BAA, ToolStripMenuOpenFile_BAA });
            ToolStripMenuItemFile_BAA.Name = "ToolStripMenuItemFile_BAA";
            ToolStripMenuItemFile_BAA.Size = new Size(59, 24);
            ToolStripMenuItemFile_BAA.Text = "Файл";
            // 
            // ToolStripMenuOpenNewFileTool_BAA
            // 
            ToolStripMenuOpenNewFileTool_BAA.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuOpenNewFile_BAA, ToolStripMenuImages_BAA });
            ToolStripMenuOpenNewFileTool_BAA.Name = "ToolStripMenuOpenNewFileTool_BAA";
            ToolStripMenuOpenNewFileTool_BAA.Size = new Size(247, 26);
            ToolStripMenuOpenNewFileTool_BAA.Text = "Открыть новый файл";
            ToolStripMenuOpenNewFileTool_BAA.Click += buttonOpenFile_BAA_Click;
            // 
            // ToolStripMenuOpenNewFile_BAA
            // 
            ToolStripMenuOpenNewFile_BAA.Name = "ToolStripMenuOpenNewFile_BAA";
            ToolStripMenuOpenNewFile_BAA.Size = new Size(327, 26);
            ToolStripMenuOpenNewFile_BAA.Text = "Открыть файл машрутов";
            ToolStripMenuOpenNewFile_BAA.Click += buttonOpenFile_BAA_Click;
            // 
            // ToolStripMenuImages_BAA
            // 
            ToolStripMenuImages_BAA.Name = "ToolStripMenuImages_BAA";
            ToolStripMenuImages_BAA.Size = new Size(327, 26);
            ToolStripMenuImages_BAA.Text = "Выбрать папку с изображениями";
            ToolStripMenuImages_BAA.Click += ToolStripMenuImages_BAA_Click;
            // 
            // ToolStripMenuSaveFile_BAA
            // 
            ToolStripMenuSaveFile_BAA.Enabled = false;
            ToolStripMenuSaveFile_BAA.Name = "ToolStripMenuSaveFile_BAA";
            ToolStripMenuSaveFile_BAA.Size = new Size(247, 26);
            ToolStripMenuSaveFile_BAA.Text = "Сохранить как";
            ToolStripMenuSaveFile_BAA.Click += buttonSaveFile_BAA_Click;
            // 
            // ToolStripMenuRefresh_BAA
            // 
            ToolStripMenuRefresh_BAA.Enabled = false;
            ToolStripMenuRefresh_BAA.Name = "ToolStripMenuRefresh_BAA";
            ToolStripMenuRefresh_BAA.Size = new Size(247, 26);
            ToolStripMenuRefresh_BAA.Text = "Обновить";
            ToolStripMenuRefresh_BAA.Click += buttonUpdateFile_BAA_Click;
            // 
            // ToolStripMenuOpenFile_BAA
            // 
            ToolStripMenuOpenFile_BAA.Enabled = false;
            ToolStripMenuOpenFile_BAA.Name = "ToolStripMenuOpenFile_BAA";
            ToolStripMenuOpenFile_BAA.Size = new Size(247, 26);
            ToolStripMenuOpenFile_BAA.Text = "Открыть данный файл";
            ToolStripMenuOpenFile_BAA.Click += ToolStripMenuOpenFile_BAA_Click;
            // 
            // tableLayoutPanel_BAA
            // 
            tableLayoutPanel_BAA.ColumnCount = 2;
            tableLayoutPanel_BAA.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel_BAA.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel_BAA.Controls.Add(panelControl_BAA, 0, 0);
            tableLayoutPanel_BAA.Controls.Add(tabControlRoutes_BAA, 1, 0);
            tableLayoutPanel_BAA.Dock = DockStyle.Fill;
            tableLayoutPanel_BAA.Location = new Point(0, 30);
            tableLayoutPanel_BAA.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel_BAA.Name = "tableLayoutPanel_BAA";
            tableLayoutPanel_BAA.Padding = new Padding(6, 7, 6, 7);
            tableLayoutPanel_BAA.RowCount = 1;
            tableLayoutPanel_BAA.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_BAA.Size = new Size(962, 570);
            tableLayoutPanel_BAA.TabIndex = 1;
            // 
            // panelControl_BAA
            // 
            panelControl_BAA.Controls.Add(groupBoxEdit_BAA);
            panelControl_BAA.Controls.Add(groupBoxGuide_BAA);
            panelControl_BAA.Controls.Add(groupBoxFile_BAA);
            panelControl_BAA.Controls.Add(groupBoxSearch_BAA);
            panelControl_BAA.Dock = DockStyle.Fill;
            panelControl_BAA.Location = new Point(9, 11);
            panelControl_BAA.Margin = new Padding(3, 4, 3, 4);
            panelControl_BAA.Name = "panelControl_BAA";
            panelControl_BAA.Padding = new Padding(6, 0, 6, 7);
            panelControl_BAA.Size = new Size(279, 548);
            panelControl_BAA.TabIndex = 1;
            // 
            // groupBoxEdit_BAA
            // 
            groupBoxEdit_BAA.Controls.Add(buttonSetFeature_BAA);
            groupBoxEdit_BAA.Controls.Add(buttonOpenRoute_BAA);
            groupBoxEdit_BAA.Location = new Point(9, 195);
            groupBoxEdit_BAA.Margin = new Padding(3, 4, 3, 4);
            groupBoxEdit_BAA.Name = "groupBoxEdit_BAA";
            groupBoxEdit_BAA.Padding = new Padding(3, 4, 3, 4);
            groupBoxEdit_BAA.Size = new Size(249, 121);
            groupBoxEdit_BAA.TabIndex = 4;
            groupBoxEdit_BAA.TabStop = false;
            groupBoxEdit_BAA.Text = "Работа с маршрутами";
            // 
            // buttonSetFeature_BAA
            // 
            buttonSetFeature_BAA.BackColor = Color.PaleTurquoise;
            buttonSetFeature_BAA.BackgroundImage = (Image)resources.GetObject("buttonSetFeature_BAA.BackgroundImage");
            buttonSetFeature_BAA.BackgroundImageLayout = ImageLayout.Center;
            buttonSetFeature_BAA.Enabled = false;
            buttonSetFeature_BAA.Location = new Point(118, 26);
            buttonSetFeature_BAA.Margin = new Padding(3, 4, 3, 4);
            buttonSetFeature_BAA.Name = "buttonSetFeature_BAA";
            buttonSetFeature_BAA.Size = new Size(74, 87);
            buttonSetFeature_BAA.TabIndex = 3;
            toolTip_BAA.SetToolTip(buttonSetFeature_BAA, "Добавить маршрут в избранное");
            buttonSetFeature_BAA.UseVisualStyleBackColor = false;
            buttonSetFeature_BAA.Click += buttonSetFeature_BAA_Click;
            buttonSetFeature_BAA.MouseEnter += buttonSetFeature_BAA_MouseEnter;
            // 
            // buttonOpenRoute_BAA
            // 
            buttonOpenRoute_BAA.BackColor = Color.PaleTurquoise;
            buttonOpenRoute_BAA.BackgroundImage = (Image)resources.GetObject("buttonOpenRoute_BAA.BackgroundImage");
            buttonOpenRoute_BAA.BackgroundImageLayout = ImageLayout.Center;
            buttonOpenRoute_BAA.Enabled = false;
            buttonOpenRoute_BAA.Location = new Point(36, 26);
            buttonOpenRoute_BAA.Margin = new Padding(3, 4, 3, 4);
            buttonOpenRoute_BAA.Name = "buttonOpenRoute_BAA";
            buttonOpenRoute_BAA.Size = new Size(74, 87);
            buttonOpenRoute_BAA.TabIndex = 3;
            toolTip_BAA.SetToolTip(buttonOpenRoute_BAA, "Посмотреть карту маршрута");
            buttonOpenRoute_BAA.UseVisualStyleBackColor = false;
            buttonOpenRoute_BAA.Click += buttonOpenRoute_BAA_Click;
            buttonOpenRoute_BAA.MouseEnter += buttonOpenRoute_BAA_MouseEnter;
            // 
            // groupBoxGuide_BAA
            // 
            groupBoxGuide_BAA.Controls.Add(buttonHelpImages_BAA);
            groupBoxGuide_BAA.Controls.Add(buttonHelp_BAA);
            groupBoxGuide_BAA.Location = new Point(6, 324);
            groupBoxGuide_BAA.Margin = new Padding(3, 4, 3, 4);
            groupBoxGuide_BAA.Name = "groupBoxGuide_BAA";
            groupBoxGuide_BAA.Padding = new Padding(3, 4, 3, 4);
            groupBoxGuide_BAA.Size = new Size(253, 125);
            groupBoxGuide_BAA.TabIndex = 3;
            groupBoxGuide_BAA.TabStop = false;
            groupBoxGuide_BAA.Text = "Руководство";
            // 
            // buttonHelpImages_BAA
            // 
            buttonHelpImages_BAA.BackColor = Color.PaleTurquoise;
            buttonHelpImages_BAA.BackgroundImage = Properties.Resources.photos;
            buttonHelpImages_BAA.BackgroundImageLayout = ImageLayout.Center;
            buttonHelpImages_BAA.Location = new Point(128, 28);
            buttonHelpImages_BAA.Margin = new Padding(3, 4, 3, 4);
            buttonHelpImages_BAA.Name = "buttonHelpImages_BAA";
            buttonHelpImages_BAA.Size = new Size(74, 87);
            buttonHelpImages_BAA.TabIndex = 4;
            toolTip_BAA.SetToolTip(buttonHelpImages_BAA, "Как сделать отображение фото остановок\r\n");
            buttonHelpImages_BAA.UseVisualStyleBackColor = false;
            buttonHelpImages_BAA.Click += buttonHelpImages_BAA_Click;
            buttonHelpImages_BAA.MouseEnter += buttonHelpImages_BAA_MouseEnter;
            // 
            // buttonHelp_BAA
            // 
            buttonHelp_BAA.BackColor = Color.PaleTurquoise;
            buttonHelp_BAA.BackgroundImage = (Image)resources.GetObject("buttonHelp_BAA.BackgroundImage");
            buttonHelp_BAA.BackgroundImageLayout = ImageLayout.Center;
            buttonHelp_BAA.Location = new Point(39, 28);
            buttonHelp_BAA.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_BAA.Name = "buttonHelp_BAA";
            buttonHelp_BAA.Size = new Size(74, 87);
            buttonHelp_BAA.TabIndex = 3;
            toolTip_BAA.SetToolTip(buttonHelp_BAA, "Как создать свой файл маршрутов");
            buttonHelp_BAA.UseVisualStyleBackColor = false;
            buttonHelp_BAA.Click += buttonHelp_BAA_Click;
            buttonHelp_BAA.MouseEnter += buttonHelp_BAA_MouseEnter;
            // 
            // groupBoxFile_BAA
            // 
            groupBoxFile_BAA.Controls.Add(buttonUpdateFile_BAA);
            groupBoxFile_BAA.Controls.Add(buttonSaveFile_BAA);
            groupBoxFile_BAA.Controls.Add(buttonOpenFile_BAA);
            groupBoxFile_BAA.Dock = DockStyle.Top;
            groupBoxFile_BAA.Location = new Point(6, 71);
            groupBoxFile_BAA.Margin = new Padding(3, 4, 3, 4);
            groupBoxFile_BAA.Name = "groupBoxFile_BAA";
            groupBoxFile_BAA.Padding = new Padding(3, 4, 3, 4);
            groupBoxFile_BAA.Size = new Size(267, 116);
            groupBoxFile_BAA.TabIndex = 1;
            groupBoxFile_BAA.TabStop = false;
            groupBoxFile_BAA.Text = "Файл";
            // 
            // buttonUpdateFile_BAA
            // 
            buttonUpdateFile_BAA.BackColor = Color.PaleTurquoise;
            buttonUpdateFile_BAA.BackgroundImage = (Image)resources.GetObject("buttonUpdateFile_BAA.BackgroundImage");
            buttonUpdateFile_BAA.BackgroundImageLayout = ImageLayout.Center;
            buttonUpdateFile_BAA.Enabled = false;
            buttonUpdateFile_BAA.Location = new Point(169, 21);
            buttonUpdateFile_BAA.Margin = new Padding(3, 4, 3, 4);
            buttonUpdateFile_BAA.Name = "buttonUpdateFile_BAA";
            buttonUpdateFile_BAA.Size = new Size(74, 87);
            buttonUpdateFile_BAA.TabIndex = 2;
            toolTip_BAA.SetToolTip(buttonUpdateFile_BAA, "Обновить содержимое файла");
            buttonUpdateFile_BAA.UseVisualStyleBackColor = false;
            buttonUpdateFile_BAA.Click += buttonUpdateFile_BAA_Click;
            buttonUpdateFile_BAA.MouseEnter += buttonUpdateFile_BAA_MouseEnter;
            // 
            // buttonSaveFile_BAA
            // 
            buttonSaveFile_BAA.BackColor = Color.PaleTurquoise;
            buttonSaveFile_BAA.BackgroundImage = (Image)resources.GetObject("buttonSaveFile_BAA.BackgroundImage");
            buttonSaveFile_BAA.BackgroundImageLayout = ImageLayout.Center;
            buttonSaveFile_BAA.Enabled = false;
            buttonSaveFile_BAA.Location = new Point(88, 21);
            buttonSaveFile_BAA.Margin = new Padding(3, 4, 3, 4);
            buttonSaveFile_BAA.Name = "buttonSaveFile_BAA";
            buttonSaveFile_BAA.Size = new Size(74, 87);
            buttonSaveFile_BAA.TabIndex = 1;
            toolTip_BAA.SetToolTip(buttonSaveFile_BAA, "Сохранить файл");
            buttonSaveFile_BAA.UseVisualStyleBackColor = false;
            buttonSaveFile_BAA.Click += buttonSaveFile_BAA_Click;
            buttonSaveFile_BAA.MouseEnter += buttonSaveFile_BAA_MouseEnter;
            // 
            // buttonOpenFile_BAA
            // 
            buttonOpenFile_BAA.BackColor = Color.PaleTurquoise;
            buttonOpenFile_BAA.BackgroundImageLayout = ImageLayout.Center;
            buttonOpenFile_BAA.Location = new Point(7, 21);
            buttonOpenFile_BAA.Margin = new Padding(3, 4, 3, 4);
            buttonOpenFile_BAA.Name = "buttonOpenFile_BAA";
            buttonOpenFile_BAA.Size = new Size(74, 87);
            buttonOpenFile_BAA.TabIndex = 0;
            toolTip_BAA.SetToolTip(buttonOpenFile_BAA, "Открыть файл маршрутов (.csv)");
            buttonOpenFile_BAA.UseVisualStyleBackColor = false;
            buttonOpenFile_BAA.Click += buttonOpenFile_BAA_Click;
            buttonOpenFile_BAA.MouseEnter += buttonOpenFile_BAA_MouseEnter;
            // 
            // groupBoxSearch_BAA
            // 
            groupBoxSearch_BAA.Controls.Add(buttonSearch_BAA);
            groupBoxSearch_BAA.Controls.Add(textBoxSearch_BAA);
            groupBoxSearch_BAA.Dock = DockStyle.Top;
            groupBoxSearch_BAA.Location = new Point(6, 0);
            groupBoxSearch_BAA.Margin = new Padding(3, 4, 3, 4);
            groupBoxSearch_BAA.Name = "groupBoxSearch_BAA";
            groupBoxSearch_BAA.Padding = new Padding(3, 4, 3, 4);
            groupBoxSearch_BAA.Size = new Size(267, 71);
            groupBoxSearch_BAA.TabIndex = 0;
            groupBoxSearch_BAA.TabStop = false;
            groupBoxSearch_BAA.Text = "Поиск";
            // 
            // buttonSearch_BAA
            // 
            buttonSearch_BAA.BackColor = Color.PaleTurquoise;
            buttonSearch_BAA.BackgroundImage = Properties.Resources.zoom;
            buttonSearch_BAA.BackgroundImageLayout = ImageLayout.Center;
            buttonSearch_BAA.Location = new Point(200, 15);
            buttonSearch_BAA.Margin = new Padding(3, 4, 3, 4);
            buttonSearch_BAA.Name = "buttonSearch_BAA";
            buttonSearch_BAA.Size = new Size(46, 51);
            buttonSearch_BAA.TabIndex = 4;
            toolTip_BAA.SetToolTip(buttonSearch_BAA, "Выполнить поиск");
            buttonSearch_BAA.UseVisualStyleBackColor = false;
            buttonSearch_BAA.Click += buttonSearch_BAA_Click;
            // 
            // textBoxSearch_BAA
            // 
            textBoxSearch_BAA.BackColor = Color.Azure;
            textBoxSearch_BAA.Location = new Point(7, 32);
            textBoxSearch_BAA.Margin = new Padding(3, 4, 3, 4);
            textBoxSearch_BAA.Name = "textBoxSearch_BAA";
            textBoxSearch_BAA.Size = new Size(186, 27);
            textBoxSearch_BAA.TabIndex = 3;
            toolTip_BAA.SetToolTip(textBoxSearch_BAA, "Введите номер маршрута");
            textBoxSearch_BAA.TextChanged += textBoxSearch_BAA_TextChanged;
            textBoxSearch_BAA.MouseEnter += textBoxSearch_BAA_MouseEnter;
            // 
            // tabControlRoutes_BAA
            // 
            tabControlRoutes_BAA.Controls.Add(tabPageRoutes);
            tabControlRoutes_BAA.Controls.Add(tabPageFeatures);
            tabControlRoutes_BAA.Dock = DockStyle.Fill;
            tabControlRoutes_BAA.Location = new Point(294, 11);
            tabControlRoutes_BAA.Margin = new Padding(3, 4, 3, 4);
            tabControlRoutes_BAA.Name = "tabControlRoutes_BAA";
            tabControlRoutes_BAA.SelectedIndex = 0;
            tabControlRoutes_BAA.Size = new Size(659, 548);
            tabControlRoutes_BAA.TabIndex = 2;
            tabControlRoutes_BAA.Selected += tabControlRoutes_BAA_Selected;
            // 
            // tabPageRoutes
            // 
            tabPageRoutes.Controls.Add(dataGridViewRoutes_BAA);
            tabPageRoutes.Location = new Point(4, 29);
            tabPageRoutes.Margin = new Padding(3, 4, 3, 4);
            tabPageRoutes.Name = "tabPageRoutes";
            tabPageRoutes.Padding = new Padding(3, 4, 3, 4);
            tabPageRoutes.Size = new Size(651, 515);
            tabPageRoutes.TabIndex = 0;
            tabPageRoutes.Text = "Список маршрутов";
            tabPageRoutes.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRoutes_BAA
            // 
            dataGridViewRoutes_BAA.AllowUserToAddRows = false;
            dataGridViewRoutes_BAA.AllowUserToDeleteRows = false;
            dataGridViewRoutes_BAA.BackgroundColor = Color.Azure;
            dataGridViewRoutes_BAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoutes_BAA.Columns.AddRange(new DataGridViewColumn[] { ColumnNumber, ColumnStart, ColumnEnd, ColumnType });
            dataGridViewRoutes_BAA.Dock = DockStyle.Fill;
            dataGridViewRoutes_BAA.Location = new Point(3, 4);
            dataGridViewRoutes_BAA.Margin = new Padding(3, 4, 3, 4);
            dataGridViewRoutes_BAA.Name = "dataGridViewRoutes_BAA";
            dataGridViewRoutes_BAA.ReadOnly = true;
            dataGridViewRoutes_BAA.RowHeadersVisible = false;
            dataGridViewRoutes_BAA.RowHeadersWidth = 51;
            dataGridViewRoutes_BAA.Size = new Size(645, 507);
            dataGridViewRoutes_BAA.TabIndex = 0;
            dataGridViewRoutes_BAA.CellContentClick += dataGridViewRoutes_BAA_CellClick;
            // 
            // ColumnNumber
            // 
            ColumnNumber.HeaderText = "№";
            ColumnNumber.MinimumWidth = 6;
            ColumnNumber.Name = "ColumnNumber";
            ColumnNumber.ReadOnly = true;
            ColumnNumber.ToolTipText = "Номер маршрута";
            ColumnNumber.Width = 30;
            // 
            // ColumnStart
            // 
            ColumnStart.HeaderText = "Начальная остановка";
            ColumnStart.MinimumWidth = 6;
            ColumnStart.Name = "ColumnStart";
            ColumnStart.ReadOnly = true;
            ColumnStart.ToolTipText = "Первая остановка";
            ColumnStart.Width = 200;
            // 
            // ColumnEnd
            // 
            ColumnEnd.HeaderText = "Конечная остановка";
            ColumnEnd.MinimumWidth = 6;
            ColumnEnd.Name = "ColumnEnd";
            ColumnEnd.ReadOnly = true;
            ColumnEnd.ToolTipText = "Последняя остановка";
            ColumnEnd.Width = 200;
            // 
            // ColumnType
            // 
            ColumnType.HeaderText = "Тип";
            ColumnType.MinimumWidth = 6;
            ColumnType.Name = "ColumnType";
            ColumnType.ReadOnly = true;
            ColumnType.ToolTipText = "Вид транспорта";
            ColumnType.Width = 125;
            // 
            // tabPageFeatures
            // 
            tabPageFeatures.Controls.Add(dataGridViewFeatures_BAA);
            tabPageFeatures.Location = new Point(4, 29);
            tabPageFeatures.Margin = new Padding(3, 4, 3, 4);
            tabPageFeatures.Name = "tabPageFeatures";
            tabPageFeatures.Padding = new Padding(3, 4, 3, 4);
            tabPageFeatures.Size = new Size(651, 515);
            tabPageFeatures.TabIndex = 1;
            tabPageFeatures.Text = "Избранные";
            tabPageFeatures.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFeatures_BAA
            // 
            dataGridViewFeatures_BAA.AllowUserToAddRows = false;
            dataGridViewFeatures_BAA.AllowUserToDeleteRows = false;
            dataGridViewFeatures_BAA.BackgroundColor = Color.Azure;
            dataGridViewFeatures_BAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFeatures_BAA.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewFeatures_BAA.Dock = DockStyle.Fill;
            dataGridViewFeatures_BAA.Location = new Point(3, 4);
            dataGridViewFeatures_BAA.Margin = new Padding(3, 4, 3, 4);
            dataGridViewFeatures_BAA.MinimumSize = new Size(609, 501);
            dataGridViewFeatures_BAA.Name = "dataGridViewFeatures_BAA";
            dataGridViewFeatures_BAA.ReadOnly = true;
            dataGridViewFeatures_BAA.RowHeadersVisible = false;
            dataGridViewFeatures_BAA.RowHeadersWidth = 51;
            dataGridViewFeatures_BAA.Size = new Size(645, 507);
            dataGridViewFeatures_BAA.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "№";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.ToolTipText = "Номер маршрута";
            dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Начальная остановка";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.ToolTipText = "Первая остановка";
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Конечная остановка";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.ToolTipText = "Последняя остановка";
            dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Тип";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.ToolTipText = "Вид транспорта";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // toolTip_BAA
            // 
            toolTip_BAA.IsBalloon = true;
            toolTip_BAA.ToolTipIcon = ToolTipIcon.Info;
            // 
            // openFileDialog_BAA
            // 
            openFileDialog_BAA.FileName = "Routes.csv";
            // 
            // saveFileDialog_BAA
            // 
            saveFileDialog_BAA.FileName = "file.csv";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Azure;
            ClientSize = new Size(962, 600);
            Controls.Add(tableLayoutPanel_BAA);
            Controls.Add(menuStrip_BAA);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip_BAA;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(934, 640);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Транспортные маршруты";
            Load += FormMain_Load;
            menuStrip_BAA.ResumeLayout(false);
            menuStrip_BAA.PerformLayout();
            tableLayoutPanel_BAA.ResumeLayout(false);
            panelControl_BAA.ResumeLayout(false);
            groupBoxEdit_BAA.ResumeLayout(false);
            groupBoxGuide_BAA.ResumeLayout(false);
            groupBoxFile_BAA.ResumeLayout(false);
            groupBoxSearch_BAA.ResumeLayout(false);
            groupBoxSearch_BAA.PerformLayout();
            tabControlRoutes_BAA.ResumeLayout(false);
            tabPageRoutes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoutes_BAA).EndInit();
            tabPageFeatures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFeatures_BAA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip_BAA;
        private ToolStripMenuItem ToolStripMenuItemProgramm_BAA;
        private ToolStripMenuItem ToolStripMenuAbout_BAA;
        private ToolStripMenuItem ToolStripMenuItemFile_BAA;
        private TableLayoutPanel tableLayoutPanel_BAA;
        private Panel panelControl_BAA;
        private TabControl tabControlRoutes_BAA;
        private TabPage tabPageRoutes;
        private TabPage tabPageFeatures;
        private DataGridView dataGridViewRoutes_BAA;
        private GroupBox groupBoxSearch_BAA;
        private Button buttonSearch_BAA;
        private TextBox textBoxSearch_BAA;
        private ToolTip toolTip_BAA;
        private DataGridViewTextBoxColumn ColumnNumber;
        private DataGridViewTextBoxColumn ColumnStart;
        private DataGridViewTextBoxColumn ColumnEnd;
        private DataGridViewTextBoxColumn ColumnType;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ToolStripMenuExit_BAA;
        private GroupBox groupBoxFile_BAA;
        private Button buttonUpdateFile_BAA;
        private Button buttonSaveFile_BAA;
        private Button buttonOpenFile_BAA;
        private GroupBox groupBoxGuide_BAA;
        private Button buttonHelp_BAA;
        private ToolStripMenuItem ToolStripMenuOpenNewFileTool_BAA;
        private ToolStripMenuItem ToolStripMenuSaveFile_BAA;
        private ToolStripMenuItem ToolStripMenuRefresh_BAA;
        private ToolStripMenuItem ToolStripMenuOpenFile_BAA;
        private GroupBox groupBoxEdit_BAA;
        private Button buttonSetFeature_BAA;
        private Button buttonOpenRoute_BAA;
        private Button buttonHelpImages_BAA;
        private OpenFileDialog openFileDialog_BAA;
        private DataGridView dataGridViewFeatures_BAA;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private SaveFileDialog saveFileDialog_BAA;
        private ToolStripMenuItem ToolStripMenuOpenNewFile_BAA;
        private ToolStripMenuItem ToolStripMenuImages_BAA;
    }
}