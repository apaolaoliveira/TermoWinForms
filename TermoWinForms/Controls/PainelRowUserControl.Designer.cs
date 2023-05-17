namespace TermoWinForms.Controls
{
    partial class PainelRowUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblColumns = new TableLayoutPanel();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            tblColumns.SuspendLayout();
            SuspendLayout();
            // 
            // tblColumns
            // 
            tblColumns.ColumnCount = 5;
            tblColumns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblColumns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblColumns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblColumns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblColumns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblColumns.Controls.Add(label4, 0, 0);
            tblColumns.Controls.Add(label5, 0, 0);
            tblColumns.Controls.Add(label3, 0, 0);
            tblColumns.Controls.Add(label1, 0, 0);
            tblColumns.Controls.Add(label2, 0, 0);
            tblColumns.Dock = DockStyle.Fill;
            tblColumns.Location = new Point(0, 0);
            tblColumns.Name = "tblColumns";
            tblColumns.RowCount = 1;
            tblColumns.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblColumns.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblColumns.Size = new Size(492, 101);
            tblColumns.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(97, 84, 88);
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Arial Rounded MT Bold", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(298, 4);
            label4.Margin = new Padding(4);
            label4.Name = "label4";
            label4.Size = new Size(90, 93);
            label4.TabIndex = 3;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(97, 84, 88);
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Arial Rounded MT Bold", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(396, 4);
            label5.Margin = new Padding(4);
            label5.Name = "label5";
            label5.Size = new Size(92, 93);
            label5.TabIndex = 4;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(97, 84, 88);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Arial Rounded MT Bold", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(200, 4);
            label3.Margin = new Padding(4);
            label3.Name = "label3";
            label3.Size = new Size(90, 93);
            label3.TabIndex = 2;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(97, 84, 88);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial Rounded MT Bold", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(4, 4);
            label1.Margin = new Padding(4);
            label1.Name = "label1";
            label1.Size = new Size(90, 93);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(97, 84, 88);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Arial Rounded MT Bold", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(102, 4);
            label2.Margin = new Padding(4);
            label2.Name = "label2";
            label2.Size = new Size(90, 93);
            label2.TabIndex = 1;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PainelRowUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblColumns);
            Name = "PainelRowUserControl";
            Size = new Size(492, 101);
            tblColumns.ResumeLayout(false);
            tblColumns.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblColumns;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label1;
    }
}
