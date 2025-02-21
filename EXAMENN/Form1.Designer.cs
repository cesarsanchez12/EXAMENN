namespace EXAMENN
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
            dtgview = new DataGridView();
            btnabrir = new Button();
            openFileDialog1 = new OpenFileDialog();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgview).BeginInit();
            SuspendLayout();
            // 
            // dtgview
            // 
            dtgview.BackgroundColor = SystemColors.ActiveCaption;
            dtgview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgview.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dtgview.Location = new Point(12, 3);
            dtgview.Name = "dtgview";
            dtgview.RowHeadersWidth = 51;
            dtgview.Size = new Size(776, 360);
            dtgview.TabIndex = 0;
            // 
            // btnabrir
            // 
            btnabrir.BackColor = SystemColors.ActiveCaption;
            btnabrir.Location = new Point(12, 369);
            btnabrir.Name = "btnabrir";
            btnabrir.Size = new Size(776, 56);
            btnabrir.TabIndex = 1;
            btnabrir.Text = "ABRIR";
            btnabrir.UseVisualStyleBackColor = false;
            btnabrir.Click += btnabrir_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Column1
            // 
            Column1.HeaderText = "CURP";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "PROMEDIO";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "EDAD";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "SEXO";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnabrir);
            Controls.Add(dtgview);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgview;
        private Button btnabrir;
        private OpenFileDialog openFileDialog1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
