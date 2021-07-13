
namespace ExchangeOffice_ScorteanuSerban.Entities
{
    partial class NewTransactionForm
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
            this.tbInitialSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFinalSum = new System.Windows.Forms.TextBox();
            this.cbFirstCurrency = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbSecondCurrency = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInitialSum
            // 
            this.tbInitialSum.Location = new System.Drawing.Point(167, 175);
            this.tbInitialSum.Name = "tbInitialSum";
            this.tbInitialSum.Size = new System.Drawing.Size(408, 38);
            this.tbInitialSum.TabIndex = 0;
            this.tbInitialSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbInitialSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInitialSum_KeyPress);
            this.tbInitialSum.Validating += new System.ComponentModel.CancelEventHandler(this.tbInitialSum_Validating);
            this.tbInitialSum.Validated += new System.EventHandler(this.tbInitialSum_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Initial Amount";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(361, 332);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(180, 113);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 598);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Amount ";
            // 
            // tbFinalSum
            // 
            this.tbFinalSum.Location = new System.Drawing.Point(235, 681);
            this.tbFinalSum.Name = "tbFinalSum";
            this.tbFinalSum.ReadOnly = true;
            this.tbFinalSum.Size = new System.Drawing.Size(408, 38);
            this.tbFinalSum.TabIndex = 4;
            this.tbFinalSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbFirstCurrency
            // 
            this.cbFirstCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFirstCurrency.FormattingEnabled = true;
            this.cbFirstCurrency.Location = new System.Drawing.Point(581, 174);
            this.cbFirstCurrency.Name = "cbFirstCurrency";
            this.cbFirstCurrency.Size = new System.Drawing.Size(152, 39);
            this.cbFirstCurrency.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(605, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Currency";
            // 
            // btnFinish
            // 
            this.btnFinish.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFinish.Location = new System.Drawing.Point(361, 803);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(180, 75);
            this.btnFinish.TabIndex = 4;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cbSecondCurrency
            // 
            this.cbSecondCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSecondCurrency.FormattingEnabled = true;
            this.cbSecondCurrency.Location = new System.Drawing.Point(582, 370);
            this.cbSecondCurrency.Name = "cbSecondCurrency";
            this.cbSecondCurrency.Size = new System.Drawing.Size(152, 39);
            this.cbSecondCurrency.TabIndex = 2;
            this.cbSecondCurrency.Validating += new System.ComponentModel.CancelEventHandler(this.cbSecondCurrency_Validating);
            this.cbSecondCurrency.Validated += new System.EventHandler(this.cbSecondCurrency_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(605, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "To";
            // 
            // NewTransactionForm
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.btnFinish;
            this.ClientSize = new System.Drawing.Size(902, 899);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSecondCurrency);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFirstCurrency);
            this.Controls.Add(this.tbFinalSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInitialSum);
            this.Name = "NewTransactionForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewTransactionForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInitialSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFinalSum;
        private System.Windows.Forms.ComboBox cbFirstCurrency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSecondCurrency;
    }
}