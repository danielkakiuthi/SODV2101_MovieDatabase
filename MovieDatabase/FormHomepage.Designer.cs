namespace MovieDatabase {
    partial class FormHomepage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            labelHeader_Homepage = new Label();
            listBoxTopRated_Homepage = new ListBox();
            labelTopRated_Homepage = new Label();
            tableLayoutPanelTopRated = new TableLayoutPanel();
            SuspendLayout();
            // 
            // labelHeader_Homepage
            // 
            labelHeader_Homepage.AutoSize = true;
            labelHeader_Homepage.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelHeader_Homepage.Location = new Point(12, 9);
            labelHeader_Homepage.Name = "labelHeader_Homepage";
            labelHeader_Homepage.Size = new Size(159, 37);
            labelHeader_Homepage.TabIndex = 23;
            labelHeader_Homepage.Text = "Homepage";
            // 
            // listBoxTopRated_Homepage
            // 
            listBoxTopRated_Homepage.FormattingEnabled = true;
            listBoxTopRated_Homepage.ItemHeight = 21;
            listBoxTopRated_Homepage.Location = new Point(12, 278);
            listBoxTopRated_Homepage.Name = "listBoxTopRated_Homepage";
            listBoxTopRated_Homepage.Size = new Size(599, 235);
            listBoxTopRated_Homepage.TabIndex = 24;
            // 
            // labelTopRated_Homepage
            // 
            labelTopRated_Homepage.AutoSize = true;
            labelTopRated_Homepage.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTopRated_Homepage.Location = new Point(12, 56);
            labelTopRated_Homepage.Name = "labelTopRated_Homepage";
            labelTopRated_Homepage.Size = new Size(111, 30);
            labelTopRated_Homepage.TabIndex = 25;
            labelTopRated_Homepage.Text = "Top Rated";
            // 
            // tableLayoutPanelTopRated
            // 
            tableLayoutPanelTopRated.AutoSize = true;
            tableLayoutPanelTopRated.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanelTopRated.ColumnCount = 5;
            tableLayoutPanelTopRated.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanelTopRated.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelTopRated.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelTopRated.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelTopRated.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelTopRated.Location = new Point(12, 89);
            tableLayoutPanelTopRated.Name = "tableLayoutPanelTopRated";
            tableLayoutPanelTopRated.RowCount = 1;
            tableLayoutPanelTopRated.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelTopRated.Size = new Size(1005, 127);
            tableLayoutPanelTopRated.TabIndex = 33;
            // 
            // FormHomepage
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(tableLayoutPanelTopRated);
            Controls.Add(labelTopRated_Homepage);
            Controls.Add(listBoxTopRated_Homepage);
            Controls.Add(labelHeader_Homepage);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormHomepage";
            Text = "[FormHomepage]";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeader_Homepage;
        private ListBox listBoxTopRated_Homepage;
        private Label labelTopRated_Homepage;
        private TableLayoutPanel tableLayoutPanelTopRated;
    }
}