namespace CalculateDXFs
{
    partial class PartForm
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
            this.labelNamePart = new System.Windows.Forms.Label();
            this.textBoxNamePart = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.labelArea = new System.Windows.Forms.Label();
            this.textBoxMaterialName = new System.Windows.Forms.TextBox();
            this.labelMaterialName = new System.Windows.Forms.Label();
            this.textBoxThikness = new System.Windows.Forms.TextBox();
            this.labelThikness = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNamePart
            // 
            this.labelNamePart.AutoSize = true;
            this.labelNamePart.Location = new System.Drawing.Point(12, 39);
            this.labelNamePart.Name = "labelNamePart";
            this.labelNamePart.Size = new System.Drawing.Size(90, 15);
            this.labelNamePart.TabIndex = 0;
            this.labelNamePart.Text = "Наименование";
            // 
            // textBoxNamePart
            // 
            this.textBoxNamePart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNamePart.Location = new System.Drawing.Point(162, 39);
            this.textBoxNamePart.Name = "textBoxNamePart";
            this.textBoxNamePart.Size = new System.Drawing.Size(210, 23);
            this.textBoxNamePart.TabIndex = 1;
            this.textBoxNamePart.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(297, 326);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxArea
            // 
            this.textBoxArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxArea.Location = new System.Drawing.Point(162, 126);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(210, 23);
            this.textBoxArea.TabIndex = 4;
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(12, 129);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(137, 15);
            this.labelArea.TabIndex = 3;
            this.labelArea.Text = "Площадь развртки,м^2";
            // 
            // textBoxMaterialName
            // 
            this.textBoxMaterialName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMaterialName.Location = new System.Drawing.Point(162, 68);
            this.textBoxMaterialName.Name = "textBoxMaterialName";
            this.textBoxMaterialName.Size = new System.Drawing.Size(210, 23);
            this.textBoxMaterialName.TabIndex = 6;
            // 
            // labelMaterialName
            // 
            this.labelMaterialName.AutoSize = true;
            this.labelMaterialName.Location = new System.Drawing.Point(12, 71);
            this.labelMaterialName.Name = "labelMaterialName";
            this.labelMaterialName.Size = new System.Drawing.Size(62, 15);
            this.labelMaterialName.TabIndex = 5;
            this.labelMaterialName.Text = "Материал";
            // 
            // textBoxThikness
            // 
            this.textBoxThikness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxThikness.Location = new System.Drawing.Point(162, 97);
            this.textBoxThikness.Name = "textBoxThikness";
            this.textBoxThikness.Size = new System.Drawing.Size(210, 23);
            this.textBoxThikness.TabIndex = 8;
            // 
            // labelThikness
            // 
            this.labelThikness.AutoSize = true;
            this.labelThikness.Location = new System.Drawing.Point(12, 100);
            this.labelThikness.Name = "labelThikness";
            this.labelThikness.Size = new System.Drawing.Size(79, 15);
            this.labelThikness.TabIndex = 7;
            this.labelThikness.Text = "Толщина,мм";
            // 
            // EditPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.textBoxThikness);
            this.Controls.Add(this.labelThikness);
            this.Controls.Add(this.textBoxMaterialName);
            this.Controls.Add(this.labelMaterialName);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxNamePart);
            this.Controls.Add(this.labelNamePart);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "EditPartForm";
            this.Text = "EditPartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNamePart;
        private TextBox textBoxNamePart;
        private Button buttonSave;
        private TextBox textBoxArea;
        private Label labelArea;
        private TextBox textBoxMaterialName;
        private Label labelMaterialName;
        private TextBox textBoxThikness;
        private Label labelThikness;
    }
}