
namespace ExchangeOffice_ScorteanuSerban
{
    partial class ExchangeRatesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lvCurrency = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnLargeIcon = new System.Windows.Forms.Button();
            this.btnSmallIcon = new System.Windows.Forms.Button();
            this.btnTile = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnChart = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Exchange Rates";
            // 
            // lvCurrency
            // 
            this.lvCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCurrency.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvCurrency.ContextMenuStrip = this.contextMenuStrip1;
            this.lvCurrency.GridLines = true;
            this.lvCurrency.HideSelection = false;
            this.lvCurrency.Location = new System.Drawing.Point(29, 159);
            this.lvCurrency.Name = "lvCurrency";
            this.lvCurrency.Size = new System.Drawing.Size(2138, 543);
            this.lvCurrency.TabIndex = 2;
            this.lvCurrency.UseCompatibleStateImageBehavior = false;
            this.lvCurrency.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Currency";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "In RON";
            this.columnHeader2.Width = 133;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 52);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(182, 48);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDetails.Location = new System.Drawing.Point(17, 737);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(149, 116);
            this.btnDetails.TabIndex = 3;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            this.btnDetails.MouseLeave += new System.EventHandler(this.btnDetails_MouseLeave);
            this.btnDetails.MouseHover += new System.EventHandler(this.btnDetails_MouseHover);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnList.Location = new System.Drawing.Point(347, 737);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(149, 116);
            this.btnList.TabIndex = 4;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            this.btnList.MouseLeave += new System.EventHandler(this.btnList_MouseLeave);
            this.btnList.MouseHover += new System.EventHandler(this.btnList_MouseHover);
            // 
            // btnLargeIcon
            // 
            this.btnLargeIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLargeIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLargeIcon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLargeIcon.Location = new System.Drawing.Point(677, 737);
            this.btnLargeIcon.Name = "btnLargeIcon";
            this.btnLargeIcon.Size = new System.Drawing.Size(149, 116);
            this.btnLargeIcon.TabIndex = 5;
            this.btnLargeIcon.Text = "Large Icon";
            this.btnLargeIcon.UseVisualStyleBackColor = false;
            this.btnLargeIcon.Click += new System.EventHandler(this.btnLargeIcon_Click);
            this.btnLargeIcon.MouseLeave += new System.EventHandler(this.btnLargeIcon_MouseLeave);
            this.btnLargeIcon.MouseHover += new System.EventHandler(this.btnLargeIcon_MouseHover);
            // 
            // btnSmallIcon
            // 
            this.btnSmallIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSmallIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmallIcon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSmallIcon.Location = new System.Drawing.Point(512, 737);
            this.btnSmallIcon.Name = "btnSmallIcon";
            this.btnSmallIcon.Size = new System.Drawing.Size(149, 116);
            this.btnSmallIcon.TabIndex = 6;
            this.btnSmallIcon.Text = "Small Icon";
            this.btnSmallIcon.UseVisualStyleBackColor = false;
            this.btnSmallIcon.Click += new System.EventHandler(this.btnSmallIcon_Click);
            this.btnSmallIcon.MouseLeave += new System.EventHandler(this.btnSmallIcon_MouseLeave);
            this.btnSmallIcon.MouseHover += new System.EventHandler(this.btnSmallIcon_MouseHover);
            // 
            // btnTile
            // 
            this.btnTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTile.Location = new System.Drawing.Point(182, 737);
            this.btnTile.Name = "btnTile";
            this.btnTile.Size = new System.Drawing.Size(149, 116);
            this.btnTile.TabIndex = 7;
            this.btnTile.Text = "Tile";
            this.btnTile.UseVisualStyleBackColor = false;
            this.btnTile.Click += new System.EventHandler(this.btnTile_Click);
            this.btnTile.MouseLeave += new System.EventHandler(this.btnTile_MouseLeave);
            this.btnTile.MouseHover += new System.EventHandler(this.btnTile_MouseHover);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(1736, 737);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(431, 116);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back to Main Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(1377, 739);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(206, 116);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            this.btnDelete.MouseHover += new System.EventHandler(this.btnDelete_MouseHover);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 944);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(2225, 22);
            this.statusStrip.TabIndex = 11;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 9);
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(973, 738);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(190, 117);
            this.btnChart.TabIndex = 12;
            this.btnChart.Text = "Chart";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            this.btnChart.MouseLeave += new System.EventHandler(this.btnChart_MouseLeave);
            this.btnChart.MouseHover += new System.EventHandler(this.btnChart_MouseHover);
            // 
            // ExchangeRatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2225, 966);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTile);
            this.Controls.Add(this.btnSmallIcon);
            this.Controls.Add(this.btnLargeIcon);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lvCurrency);
            this.Controls.Add(this.label1);
            this.Name = "ExchangeRatesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExchangeRatesForm";
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvCurrency;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnLargeIcon;
        private System.Windows.Forms.Button btnSmallIcon;
        private System.Windows.Forms.Button btnTile;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnChart;
    }
}