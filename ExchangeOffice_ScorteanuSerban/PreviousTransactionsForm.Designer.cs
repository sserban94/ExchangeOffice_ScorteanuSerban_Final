
namespace ExchangeOffice_ScorteanuSerban
{
    partial class PreviousTransactionsForm
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
            this.components = new System.ComponentModel.Container();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.dataGridView = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.binarySerializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerializeBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeserealizeBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLSerializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerializeXML = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeserializeXML = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONSerializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerializeJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeserializeJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImport = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToSQLDbFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromdbFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initialSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromCoinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toCoinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransactions.AutoGenerateColumns = false;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.initialSumDataGridViewTextBoxColumn,
            this.finalSumDataGridViewTextBoxColumn,
            this.fromCoinDataGridViewTextBoxColumn,
            this.toCoinDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn});
            this.dgvTransactions.DataSource = this.dataGridView;
            this.dgvTransactions.Location = new System.Drawing.Point(75, 216);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.RowHeadersWidth = 102;
            this.dgvTransactions.RowTemplate.Height = 40;
            this.dgvTransactions.Size = new System.Drawing.Size(2305, 606);
            this.dgvTransactions.TabIndex = 0;
            this.dgvTransactions.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvTransactions_UserDeletingRow);
            // 
            // dataGridView
            // 
            this.dataGridView.DataSource = typeof(ExchangeOffice_ScorteanuSerban.Entities.Transaction);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1100, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaction History";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(1061, 828);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(435, 76);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back to Main Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binarySerializationToolStripMenuItem,
            this.xMLSerializationToolStripMenuItem,
            this.jSONSerializationToolStripMenuItem,
            this.btnExport,
            this.btnImport,
            this.exportToSQLDbFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2468, 49);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // binarySerializationToolStripMenuItem
            // 
            this.binarySerializationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSerializeBinary,
            this.btnDeserealizeBinary});
            this.binarySerializationToolStripMenuItem.Image = global::ExchangeOffice_ScorteanuSerban.Properties.Resources.binary_icon;
            this.binarySerializationToolStripMenuItem.Name = "binarySerializationToolStripMenuItem";
            this.binarySerializationToolStripMenuItem.Size = new System.Drawing.Size(330, 45);
            this.binarySerializationToolStripMenuItem.Text = "Binary Serialization";
            // 
            // btnSerializeBinary
            // 
            this.btnSerializeBinary.Image = global::ExchangeOffice_ScorteanuSerban.Properties.Resources.export_icon;
            this.btnSerializeBinary.Name = "btnSerializeBinary";
            this.btnSerializeBinary.Size = new System.Drawing.Size(326, 54);
            this.btnSerializeBinary.Text = "Serialize";
            this.btnSerializeBinary.Click += new System.EventHandler(this.btnSerializeBinary_Click);
            // 
            // btnDeserealizeBinary
            // 
            this.btnDeserealizeBinary.Image = global::ExchangeOffice_ScorteanuSerban.Properties.Resources.import_icon;
            this.btnDeserealizeBinary.Name = "btnDeserealizeBinary";
            this.btnDeserealizeBinary.Size = new System.Drawing.Size(326, 54);
            this.btnDeserealizeBinary.Text = "Deserialize";
            this.btnDeserealizeBinary.Click += new System.EventHandler(this.btnDeserealizeBinary_Click);
            // 
            // xMLSerializationToolStripMenuItem
            // 
            this.xMLSerializationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSerializeXML,
            this.btnDeserializeXML});
            this.xMLSerializationToolStripMenuItem.Image = global::ExchangeOffice_ScorteanuSerban.Properties.Resources.Programming_Xml_icon;
            this.xMLSerializationToolStripMenuItem.Name = "xMLSerializationToolStripMenuItem";
            this.xMLSerializationToolStripMenuItem.Size = new System.Drawing.Size(308, 45);
            this.xMLSerializationToolStripMenuItem.Text = "XML Serialization";
            // 
            // btnSerializeXML
            // 
            this.btnSerializeXML.Image = global::ExchangeOffice_ScorteanuSerban.Properties.Resources.export_icon;
            this.btnSerializeXML.Name = "btnSerializeXML";
            this.btnSerializeXML.Size = new System.Drawing.Size(335, 54);
            this.btnSerializeXML.Text = "Serialize";
            this.btnSerializeXML.Click += new System.EventHandler(this.btnSerializeXML_Click);
            // 
            // btnDeserializeXML
            // 
            this.btnDeserializeXML.Image = global::ExchangeOffice_ScorteanuSerban.Properties.Resources.import_icon;
            this.btnDeserializeXML.Name = "btnDeserializeXML";
            this.btnDeserializeXML.Size = new System.Drawing.Size(335, 54);
            this.btnDeserializeXML.Text = "Deserealize";
            this.btnDeserializeXML.Click += new System.EventHandler(this.btnDeserializeXML_Click);
            // 
            // jSONSerializationToolStripMenuItem
            // 
            this.jSONSerializationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSerializeJSON,
            this.btnDeserializeJSON});
            this.jSONSerializationToolStripMenuItem.Image = global::ExchangeOffice_ScorteanuSerban.Properties.Resources._136443;
            this.jSONSerializationToolStripMenuItem.Name = "jSONSerializationToolStripMenuItem";
            this.jSONSerializationToolStripMenuItem.Size = new System.Drawing.Size(321, 45);
            this.jSONSerializationToolStripMenuItem.Text = "JSON Serialization";
            // 
            // btnSerializeJSON
            // 
            this.btnSerializeJSON.Image = global::ExchangeOffice_ScorteanuSerban.Properties.Resources.export_icon;
            this.btnSerializeJSON.Name = "btnSerializeJSON";
            this.btnSerializeJSON.Size = new System.Drawing.Size(335, 54);
            this.btnSerializeJSON.Text = "Serialize";
            this.btnSerializeJSON.Click += new System.EventHandler(this.btnSerializeJSON_Click);
            // 
            // btnDeserializeJSON
            // 
            this.btnDeserializeJSON.Image = global::ExchangeOffice_ScorteanuSerban.Properties.Resources.import_icon;
            this.btnDeserializeJSON.Name = "btnDeserializeJSON";
            this.btnDeserializeJSON.Size = new System.Drawing.Size(335, 54);
            this.btnDeserializeJSON.Text = "Deserealize";
            this.btnDeserializeJSON.Click += new System.EventHandler(this.btnDeserializeJSON_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = global::ExchangeOffice_ScorteanuSerban.Properties.Resources.export_icon;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(256, 45);
            this.btnExport.Text = "Export to File";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Image = global::ExchangeOffice_ScorteanuSerban.Properties.Resources.import_icon;
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(302, 45);
            this.btnImport.Text = "Import From File";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // exportToSQLDbFileToolStripMenuItem
            // 
            this.exportToSQLDbFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFromdbFileToolStripMenuItem});
            this.exportToSQLDbFileToolStripMenuItem.Image = global::ExchangeOffice_ScorteanuSerban.Properties.Resources._29594;
            this.exportToSQLDbFileToolStripMenuItem.Name = "exportToSQLDbFileToolStripMenuItem";
            this.exportToSQLDbFileToolStripMenuItem.Size = new System.Drawing.Size(135, 45);
            this.exportToSQLDbFileToolStripMenuItem.Text = "SQL";
            // 
            // importFromdbFileToolStripMenuItem
            // 
            this.importFromdbFileToolStripMenuItem.Image = global::ExchangeOffice_ScorteanuSerban.Properties.Resources.import_icon;
            this.importFromdbFileToolStripMenuItem.Name = "importFromdbFileToolStripMenuItem";
            this.importFromdbFileToolStripMenuItem.Size = new System.Drawing.Size(443, 54);
            this.importFromdbFileToolStripMenuItem.Text = "Import from .db file";
            this.importFromdbFileToolStripMenuItem.Click += new System.EventHandler(this.importFromdbFileToolStripMenuItem_Click);
            // 
            // initialSumDataGridViewTextBoxColumn
            // 
            this.initialSumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.initialSumDataGridViewTextBoxColumn.DataPropertyName = "InitialSum";
            this.initialSumDataGridViewTextBoxColumn.HeaderText = "InitialSum";
            this.initialSumDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.initialSumDataGridViewTextBoxColumn.Name = "initialSumDataGridViewTextBoxColumn";
            this.initialSumDataGridViewTextBoxColumn.Width = 195;
            // 
            // finalSumDataGridViewTextBoxColumn
            // 
            this.finalSumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.finalSumDataGridViewTextBoxColumn.DataPropertyName = "FinalSum";
            this.finalSumDataGridViewTextBoxColumn.HeaderText = "FinalSum";
            this.finalSumDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.finalSumDataGridViewTextBoxColumn.Name = "finalSumDataGridViewTextBoxColumn";
            this.finalSumDataGridViewTextBoxColumn.Width = 190;
            // 
            // fromCoinDataGridViewTextBoxColumn
            // 
            this.fromCoinDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.fromCoinDataGridViewTextBoxColumn.DataPropertyName = "FromCoin";
            this.fromCoinDataGridViewTextBoxColumn.HeaderText = "FromCurrency";
            this.fromCoinDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.fromCoinDataGridViewTextBoxColumn.Name = "fromCoinDataGridViewTextBoxColumn";
            this.fromCoinDataGridViewTextBoxColumn.Width = 248;
            // 
            // toCoinDataGridViewTextBoxColumn
            // 
            this.toCoinDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.toCoinDataGridViewTextBoxColumn.DataPropertyName = "ToCoin";
            this.toCoinDataGridViewTextBoxColumn.HeaderText = "ToCurrency";
            this.toCoinDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.toCoinDataGridViewTextBoxColumn.Name = "toCoinDataGridViewTextBoxColumn";
            this.toCoinDataGridViewTextBoxColumn.Width = 216;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "ExchangeRate";
            this.rateDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.Width = 256;
            // 
            // PreviousTransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2468, 912);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PreviousTransactionsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreviousTransactionsForm";
            this.Load += new System.EventHandler(this.PreviousTransactionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dataGridView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem binarySerializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSerializeBinary;
        private System.Windows.Forms.ToolStripMenuItem btnDeserealizeBinary;
        private System.Windows.Forms.ToolStripMenuItem xMLSerializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSerializeXML;
        private System.Windows.Forms.ToolStripMenuItem btnDeserializeXML;
        private System.Windows.Forms.ToolStripMenuItem jSONSerializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSerializeJSON;
        private System.Windows.Forms.ToolStripMenuItem btnDeserializeJSON;
        private System.Windows.Forms.ToolStripMenuItem btnExport;
        private System.Windows.Forms.ToolStripMenuItem btnImport;
        private System.Windows.Forms.ToolStripMenuItem exportToSQLDbFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromdbFileToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromCoinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toCoinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
    }
}