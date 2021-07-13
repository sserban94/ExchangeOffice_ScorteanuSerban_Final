
namespace ExchangeOffice_ScorteanuSerban
{
    partial class MainForm
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
            this.btnMakeTransaction = new System.Windows.Forms.Button();
            this.btnCheckPrevious = new System.Windows.Forms.Button();
            this.btnCheckRates = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMakeTransaction
            // 
            this.btnMakeTransaction.Location = new System.Drawing.Point(409, 262);
            this.btnMakeTransaction.Name = "btnMakeTransaction";
            this.btnMakeTransaction.Size = new System.Drawing.Size(728, 167);
            this.btnMakeTransaction.TabIndex = 0;
            this.btnMakeTransaction.Text = "&Make New Transaction";
            this.btnMakeTransaction.UseVisualStyleBackColor = true;
            this.btnMakeTransaction.Click += new System.EventHandler(this.btnMakeTransaction_Click);
            // 
            // btnCheckPrevious
            // 
            this.btnCheckPrevious.Location = new System.Drawing.Point(409, 516);
            this.btnCheckPrevious.Name = "btnCheckPrevious";
            this.btnCheckPrevious.Size = new System.Drawing.Size(728, 167);
            this.btnCheckPrevious.TabIndex = 1;
            this.btnCheckPrevious.Text = "&Check Previous Transactions";
            this.btnCheckPrevious.UseVisualStyleBackColor = true;
            this.btnCheckPrevious.Click += new System.EventHandler(this.btnCheckPrevious_Click);
            // 
            // btnCheckRates
            // 
            this.btnCheckRates.Location = new System.Drawing.Point(409, 770);
            this.btnCheckRates.Name = "btnCheckRates";
            this.btnCheckRates.Size = new System.Drawing.Size(728, 167);
            this.btnCheckRates.TabIndex = 2;
            this.btnCheckRates.Text = "&Check Exchange Rates";
            this.btnCheckRates.UseVisualStyleBackColor = true;
            this.btnCheckRates.Click += new System.EventHandler(this.btnCheckRates_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExchangeOffice_ScorteanuSerban.Properties.Resources.wallet_money_logo_icon_design_vector_22901328__2_;
            this.pictureBox1.Location = new System.Drawing.Point(620, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 1113);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCheckRates);
            this.Controls.Add(this.btnCheckPrevious);
            this.Controls.Add(this.btnMakeTransaction);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exchange Office App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMakeTransaction;
        private System.Windows.Forms.Button btnCheckPrevious;
        private System.Windows.Forms.Button btnCheckRates;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

