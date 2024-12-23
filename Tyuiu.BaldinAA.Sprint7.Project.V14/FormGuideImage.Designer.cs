namespace Tyuiu.BaldinAA.Sprint7.Project.V14
{
    partial class FormGuideImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuideImage));
            groupBoxGuideImageDescription_BAA = new GroupBox();
            textBoxGuideImage_BAA = new TextBox();
            panelGuideImageDescription_SBI = new Panel();
            panelGuideImage_BAA = new Panel();
            pictureBoxGuideImage_BAA = new PictureBox();
            groupBoxGuideImageDescription_BAA.SuspendLayout();
            panelGuideImageDescription_SBI.SuspendLayout();
            panelGuideImage_BAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGuideImage_BAA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxGuideImageDescription_BAA
            // 
            groupBoxGuideImageDescription_BAA.Controls.Add(textBoxGuideImage_BAA);
            groupBoxGuideImageDescription_BAA.Dock = DockStyle.Fill;
            groupBoxGuideImageDescription_BAA.Location = new Point(6, 7);
            groupBoxGuideImageDescription_BAA.Margin = new Padding(3, 4, 3, 4);
            groupBoxGuideImageDescription_BAA.Name = "groupBoxGuideImageDescription_BAA";
            groupBoxGuideImageDescription_BAA.Padding = new Padding(3, 4, 3, 4);
            groupBoxGuideImageDescription_BAA.Size = new Size(690, 91);
            groupBoxGuideImageDescription_BAA.TabIndex = 0;
            groupBoxGuideImageDescription_BAA.TabStop = false;
            groupBoxGuideImageDescription_BAA.Text = "Описание";
            groupBoxGuideImageDescription_BAA.Enter += groupBoxGuideImageDescription_SBI_Enter;
            // 
            // textBoxGuideImage_BAA
            // 
            textBoxGuideImage_BAA.BackColor = Color.Azure;
            textBoxGuideImage_BAA.BorderStyle = BorderStyle.None;
            textBoxGuideImage_BAA.Dock = DockStyle.Fill;
            textBoxGuideImage_BAA.Location = new Point(3, 24);
            textBoxGuideImage_BAA.Margin = new Padding(3, 4, 3, 4);
            textBoxGuideImage_BAA.Multiline = true;
            textBoxGuideImage_BAA.Name = "textBoxGuideImage_BAA";
            textBoxGuideImage_BAA.ReadOnly = true;
            textBoxGuideImage_BAA.Size = new Size(684, 63);
            textBoxGuideImage_BAA.TabIndex = 0;
            textBoxGuideImage_BAA.Text = "Тюменская Транспортная Система осуществляет контроль перевозок и построения маршрутов.\r\n Для справочной информации нужно позвонить по горячему телефону на изображении выше.";
            textBoxGuideImage_BAA.Enter += textBoxGuideImage_SBI_Enter;
            // 
            // panelGuideImageDescription_SBI
            // 
            panelGuideImageDescription_SBI.Controls.Add(groupBoxGuideImageDescription_BAA);
            panelGuideImageDescription_SBI.Dock = DockStyle.Bottom;
            panelGuideImageDescription_SBI.Location = new Point(0, 293);
            panelGuideImageDescription_SBI.Margin = new Padding(3, 4, 3, 4);
            panelGuideImageDescription_SBI.Name = "panelGuideImageDescription_SBI";
            panelGuideImageDescription_SBI.Padding = new Padding(6, 7, 6, 7);
            panelGuideImageDescription_SBI.Size = new Size(702, 105);
            panelGuideImageDescription_SBI.TabIndex = 3;
            // 
            // panelGuideImage_BAA
            // 
            panelGuideImage_BAA.Controls.Add(pictureBoxGuideImage_BAA);
            panelGuideImage_BAA.Dock = DockStyle.Top;
            panelGuideImage_BAA.Location = new Point(0, 0);
            panelGuideImage_BAA.Margin = new Padding(3, 4, 3, 4);
            panelGuideImage_BAA.Name = "panelGuideImage_BAA";
            panelGuideImage_BAA.Padding = new Padding(6, 7, 6, 7);
            panelGuideImage_BAA.Size = new Size(702, 300);
            panelGuideImage_BAA.TabIndex = 2;
            // 
            // pictureBoxGuideImage_BAA
            // 
            pictureBoxGuideImage_BAA.Dock = DockStyle.Fill;
            pictureBoxGuideImage_BAA.Image = (Image)resources.GetObject("pictureBoxGuideImage_BAA.Image");
            pictureBoxGuideImage_BAA.Location = new Point(6, 7);
            pictureBoxGuideImage_BAA.Margin = new Padding(3, 4, 3, 4);
            pictureBoxGuideImage_BAA.Name = "pictureBoxGuideImage_BAA";
            pictureBoxGuideImage_BAA.Size = new Size(690, 286);
            pictureBoxGuideImage_BAA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGuideImage_BAA.TabIndex = 0;
            pictureBoxGuideImage_BAA.TabStop = false;
            // 
            // FormGuideImage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(702, 398);
            Controls.Add(panelGuideImageDescription_SBI);
            Controls.Add(panelGuideImage_BAA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormGuideImage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Справка";
            groupBoxGuideImageDescription_BAA.ResumeLayout(false);
            groupBoxGuideImageDescription_BAA.PerformLayout();
            panelGuideImageDescription_SBI.ResumeLayout(false);
            panelGuideImage_BAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGuideImage_BAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxGuideImageDescription_BAA;
        private TextBox textBoxGuideImage_BAA;
        private Panel panelGuideImageDescription_SBI;
        private Panel panelGuideImage_BAA;
        private PictureBox pictureBoxGuideImage_BAA;
    }
}