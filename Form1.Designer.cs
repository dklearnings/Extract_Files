namespace Extract_Files
{
    partial class frmExtract
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.fileOutputPath = new System.Windows.Forms.TextBox();
            this.cmbFileType = new System.Windows.Forms.ComboBox();
            this.lblFileType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(103, 207);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(241, 207);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 23);
            this.btnExtract.TabIndex = 1;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(120, 99);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(504, 25);
            this.filePathTextBox.TabIndex = 2;
            // 
            // fileOutputPath
            // 
            this.fileOutputPath.Location = new System.Drawing.Point(120, 135);
            this.fileOutputPath.Name = "fileOutputPath";
            this.fileOutputPath.Size = new System.Drawing.Size(504, 25);
            this.fileOutputPath.TabIndex = 3;
            // 
            // cmbFileType
            // 
            this.cmbFileType.FormattingEnabled = true;
            this.cmbFileType.Location = new System.Drawing.Point(120, 28);
            this.cmbFileType.Name = "cmbFileType";
            this.cmbFileType.Size = new System.Drawing.Size(146, 25);
            this.cmbFileType.TabIndex = 4;
            this.cmbFileType.SelectedValueChanged += new System.EventHandler(this.cmbFileType_SelectedValueChanged);
            // 
            // lblFileType
            // 
            this.lblFileType.AutoSize = true;
            this.lblFileType.Location = new System.Drawing.Point(16, 31);
            this.lblFileType.Name = "lblFileType";
            this.lblFileType.Size = new System.Drawing.Size(58, 17);
            this.lblFileType.TabIndex = 5;
            this.lblFileType.Text = "File Type";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblColumns);
            this.panel1.Controls.Add(this.txtColumns);
            this.panel1.Controls.Add(this.lblFileType);
            this.panel1.Controls.Add(this.fileOutputPath);
            this.panel1.Controls.Add(this.cmbFileType);
            this.panel1.Controls.Add(this.filePathTextBox);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 173);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Output Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Input Path";
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(16, 76);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(58, 17);
            this.lblColumns.TabIndex = 7;
            this.lblColumns.Text = "Columns";
            // 
            // txtColumns
            // 
            this.txtColumns.Location = new System.Drawing.Point(120, 67);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(504, 25);
            this.txtColumns.TabIndex = 6;
            // 
            // lstMessages
            // 
            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.ItemHeight = 17;
            this.lstMessages.Location = new System.Drawing.Point(23, 245);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(751, 123);
            this.lstMessages.TabIndex = 7;
            // 
            // frmExtract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 379);
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.btnBrowse);
            this.Name = "frmExtract";
            this.Text = "Extract - ANZA Technologies v1.0";
            this.Load += new System.EventHandler(this.frmExtract_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnBrowse;
        private Button btnExtract;
        private OpenFileDialog openFileDialog1;
        private TextBox filePathTextBox;
        private TextBox fileOutputPath;
        private ComboBox cmbFileType;
        private Label lblFileType;
        private Panel panel1;
        private TextBox txtColumns;
        private Label label2;
        private Label label1;
        private Label lblColumns;
        private ListBox listBox1;
        private ListBox lstMessages;
    }
}