namespace Tyuiu.BaldinAA.Sprint7.Project.V14
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            panelAboutText_SBI = new Panel();
            groupBoxAbout_BAA = new GroupBox();
            textBoxWho_BAA = new TextBox();
            pictureBoxAbout_BAA = new PictureBox();
            panelAboutText_SBI.SuspendLayout();
            groupBoxAbout_BAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_BAA).BeginInit();
            SuspendLayout();
            // 
            // panelAboutText_SBI
            // 
            panelAboutText_SBI.Controls.Add(groupBoxAbout_BAA);
            panelAboutText_SBI.Dock = DockStyle.Right;
            panelAboutText_SBI.Location = new Point(234, 0);
            panelAboutText_SBI.Margin = new Padding(3, 4, 3, 4);
            panelAboutText_SBI.Name = "panelAboutText_SBI";
            panelAboutText_SBI.Padding = new Padding(6, 0, 0, 0);
            panelAboutText_SBI.Size = new Size(404, 301);
            panelAboutText_SBI.TabIndex = 0;
            // 
            // groupBoxAbout_BAA
            // 
            groupBoxAbout_BAA.BackColor = Color.Azure;
            groupBoxAbout_BAA.Controls.Add(textBoxWho_BAA);
            groupBoxAbout_BAA.Dock = DockStyle.Fill;
            groupBoxAbout_BAA.Location = new Point(6, 0);
            groupBoxAbout_BAA.Margin = new Padding(3, 4, 3, 4);
            groupBoxAbout_BAA.Name = "groupBoxAbout_BAA";
            groupBoxAbout_BAA.Padding = new Padding(3, 4, 3, 4);
            groupBoxAbout_BAA.Size = new Size(398, 301);
            groupBoxAbout_BAA.TabIndex = 1;
            groupBoxAbout_BAA.TabStop = false;
            groupBoxAbout_BAA.Text = "Описание";
            // 
            // textBoxWho_BAA
            // 
            textBoxWho_BAA.BackColor = Color.Azure;
            textBoxWho_BAA.BorderStyle = BorderStyle.None;
            textBoxWho_BAA.Dock = DockStyle.Fill;
            textBoxWho_BAA.Location = new Point(3, 24);
            textBoxWho_BAA.Margin = new Padding(3, 4, 3, 4);
            textBoxWho_BAA.Multiline = true;
            textBoxWho_BAA.Name = "textBoxWho_BAA";
            textBoxWho_BAA.ReadOnly = true;
            textBoxWho_BAA.Size = new Size(392, 273);
            textBoxWho_BAA.TabIndex = 1;
            textBoxWho_BAA.Text = resources.GetString("textBoxWho_BAA.Text");
            // 
            // pictureBoxAbout_BAA
            // 
            pictureBoxAbout_BAA.BackColor = Color.Azure;
            pictureBoxAbout_BAA.Dock = DockStyle.Fill;
            pictureBoxAbout_BAA.Image = (Image)resources.GetObject("pictureBoxAbout_BAA.Image");
            pictureBoxAbout_BAA.Location = new Point(0, 0);
            pictureBoxAbout_BAA.Margin = new Padding(3, 4, 3, 4);
            pictureBoxAbout_BAA.Name = "pictureBoxAbout_BAA";
            pictureBoxAbout_BAA.Size = new Size(234, 301);
            pictureBoxAbout_BAA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAbout_BAA.TabIndex = 1;
            pictureBoxAbout_BAA.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(638, 301);
            Controls.Add(pictureBoxAbout_BAA);
            Controls.Add(panelAboutText_SBI);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(656, 348);
            MinimumSize = new Size(656, 348);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            Load += FormAbout_Load;
            panelAboutText_SBI.ResumeLayout(false);
            groupBoxAbout_BAA.ResumeLayout(false);
            groupBoxAbout_BAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_BAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAboutText_SBI;
        private PictureBox pictureBoxAbout_BAA;
        private GroupBox groupBoxAbout_BAA;
        private TextBox textBoxWho_BAA;
    }
}