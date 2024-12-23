namespace Tyuiu.BaldinAA.Sprint7.Project.V14
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            labelGuide_BAA = new Label();
            pictureBoxCVS_BAA = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCVS_BAA).BeginInit();
            SuspendLayout();
            // 
            // labelGuide_BAA
            // 
            labelGuide_BAA.AutoSize = true;
            labelGuide_BAA.Location = new Point(12, 234);
            labelGuide_BAA.Name = "labelGuide_BAA";
            labelGuide_BAA.Size = new Size(776, 160);
            labelGuide_BAA.TabIndex = 0;
            labelGuide_BAA.Text = resources.GetString("labelGuide_BAA.Text");
            // 
            // pictureBoxCVS_BAA
            // 
            pictureBoxCVS_BAA.Image = (Image)resources.GetObject("pictureBoxCVS_BAA.Image");
            pictureBoxCVS_BAA.Location = new Point(27, 15);
            pictureBoxCVS_BAA.Name = "pictureBoxCVS_BAA";
            pictureBoxCVS_BAA.Size = new Size(752, 216);
            pictureBoxCVS_BAA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCVS_BAA.TabIndex = 1;
            pictureBoxCVS_BAA.TabStop = false;
            // 
            // FormGuide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 408);
            Controls.Add(pictureBoxCVS_BAA);
            Controls.Add(labelGuide_BAA);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormGuide";
            Text = "FormGuide";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCVS_BAA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGuide_BAA;
        private PictureBox pictureBoxCVS_BAA;
    }
}