
namespace ExchangeOffice_ScorteanuSerban
{
    partial class ExchangeRatesChartForm
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
            this.barChart1 = new ControlLibrary.BarChart();
            this.bntUpdateChart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // barChart1
            // 
            this.barChart1.Location = new System.Drawing.Point(384, 259);
            this.barChart1.Name = "barChart1";
            this.barChart1.Size = new System.Drawing.Size(977, 715);
            this.barChart1.TabIndex = 0;
            this.barChart1.Text = "barChart1";
            // 
            // bntUpdateChart
            // 
            this.bntUpdateChart.Location = new System.Drawing.Point(33, 904);
            this.bntUpdateChart.Name = "bntUpdateChart";
            this.bntUpdateChart.Size = new System.Drawing.Size(139, 70);
            this.bntUpdateChart.TabIndex = 1;
            this.bntUpdateChart.Text = "Update Chart";
            this.bntUpdateChart.UseVisualStyleBackColor = true;
            this.bntUpdateChart.Click += new System.EventHandler(this.bntUpdateChart_Click);
            // 
            // ExchangeRatesChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 1077);
            this.Controls.Add(this.bntUpdateChart);
            this.Controls.Add(this.barChart1);
            this.Name = "ExchangeRatesChartForm";
            this.Text = "ExchangeRatesChartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLibrary.BarChart barChart1;
        private System.Windows.Forms.Button bntUpdateChart;
    }
}