namespace SeatChange
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTable = new SeatChange.ButtonTable();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rowNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.columnNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menCountLabel = new System.Windows.Forms.Label();
            this.womenCountLabel = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.saveTable = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.SaveOrRemoveButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.mainTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnNumber)).BeginInit();
            this.saveTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 397);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(693, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(66, 17);
            this.statusLabel.Text = "statusLabel";
            // 
            // mainTable
            // 
            this.mainTable.ColumnCount = 2;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.mainTable.Controls.Add(this.buttonTable, 0, 1);
            this.mainTable.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.mainTable.Controls.Add(this.saveTable, 0, 0);
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(0, 0);
            this.mainTable.Margin = new System.Windows.Forms.Padding(0);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 2;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.Size = new System.Drawing.Size(693, 397);
            this.mainTable.TabIndex = 2;
            // 
            // buttonTable
            // 
            this.buttonTable.Column = 1;
            this.buttonTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTable.Location = new System.Drawing.Point(3, 35);
            this.buttonTable.Name = "buttonTable";
            this.buttonTable.Row = 1;
            this.buttonTable.Size = new System.Drawing.Size(487, 359);
            this.buttonTable.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.rowNumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.columnNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.menCountLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.womenCountLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.runButton, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(493, 32);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 365);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // rowNumber
            // 
            this.rowNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rowNumber.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rowNumber.Location = new System.Drawing.Point(55, 28);
            this.rowNumber.Margin = new System.Windows.Forms.Padding(0);
            this.rowNumber.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.rowNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowNumber.Name = "rowNumber";
            this.rowNumber.Size = new System.Drawing.Size(140, 22);
            this.rowNumber.TabIndex = 4;
            this.rowNumber.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.rowNumber.ValueChanged += new System.EventHandler(this.rowNumber_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(5, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "行";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "列";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // columnNumber
            // 
            this.columnNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.columnNumber.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.columnNumber.Location = new System.Drawing.Point(55, 2);
            this.columnNumber.Margin = new System.Windows.Forms.Padding(0);
            this.columnNumber.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.columnNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.columnNumber.Name = "columnNumber";
            this.columnNumber.Size = new System.Drawing.Size(140, 22);
            this.columnNumber.TabIndex = 3;
            this.columnNumber.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.columnNumber.ValueChanged += new System.EventHandler(this.columnNumber_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "男";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(8, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "女";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menCountLabel
            // 
            this.menCountLabel.AutoSize = true;
            this.menCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menCountLabel.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.menCountLabel.Location = new System.Drawing.Point(58, 52);
            this.menCountLabel.Name = "menCountLabel";
            this.menCountLabel.Size = new System.Drawing.Size(134, 26);
            this.menCountLabel.TabIndex = 7;
            this.menCountLabel.Text = "menCountLabel";
            this.menCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // womenCountLabel
            // 
            this.womenCountLabel.AutoSize = true;
            this.womenCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.womenCountLabel.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.womenCountLabel.Location = new System.Drawing.Point(58, 78);
            this.womenCountLabel.Name = "womenCountLabel";
            this.womenCountLabel.Size = new System.Drawing.Size(134, 26);
            this.womenCountLabel.TabIndex = 8;
            this.womenCountLabel.Text = "womenCountLabel";
            this.womenCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // runButton
            // 
            this.runButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.runButton.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.runButton.Location = new System.Drawing.Point(58, 308);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(134, 54);
            this.runButton.TabIndex = 9;
            this.runButton.Text = "席替え";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // saveTable
            // 
            this.saveTable.ColumnCount = 3;
            this.mainTable.SetColumnSpan(this.saveTable, 2);
            this.saveTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.saveTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.saveTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.saveTable.Controls.Add(this.comboBox, 0, 0);
            this.saveTable.Controls.Add(this.SaveOrRemoveButton, 1, 0);
            this.saveTable.Controls.Add(this.NewButton, 2, 0);
            this.saveTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveTable.Location = new System.Drawing.Point(0, 0);
            this.saveTable.Margin = new System.Windows.Forms.Padding(0);
            this.saveTable.Name = "saveTable";
            this.saveTable.RowCount = 1;
            this.saveTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.saveTable.Size = new System.Drawing.Size(693, 32);
            this.saveTable.TabIndex = 3;
            // 
            // comboBox
            // 
            this.comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(3, 4);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(527, 23);
            this.comboBox.TabIndex = 0;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // SaveOrRemoveButton
            // 
            this.SaveOrRemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveOrRemoveButton.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SaveOrRemoveButton.Location = new System.Drawing.Point(536, 3);
            this.SaveOrRemoveButton.Name = "SaveOrRemoveButton";
            this.SaveOrRemoveButton.Size = new System.Drawing.Size(74, 26);
            this.SaveOrRemoveButton.TabIndex = 1;
            this.SaveOrRemoveButton.Text = "保存";
            this.SaveOrRemoveButton.UseVisualStyleBackColor = true;
            this.SaveOrRemoveButton.Click += new System.EventHandler(this.SaveOrRemoveButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NewButton.Location = new System.Drawing.Point(616, 3);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(74, 26);
            this.NewButton.TabIndex = 2;
            this.NewButton.Text = "新規";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.runButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 419);
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Text = "席替えソフト";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mainTable.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnNumber)).EndInit();
            this.saveTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.TableLayoutPanel mainTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown rowNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown columnNumber;
        private ButtonTable buttonTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label menCountLabel;
        private System.Windows.Forms.Label womenCountLabel;
        private System.Windows.Forms.TableLayoutPanel saveTable;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button SaveOrRemoveButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button runButton;
    }
}

