
namespace CurrencyConverterApp
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.convertBtn = new System.Windows.Forms.Button();
            this.eurLbl = new System.Windows.Forms.Label();
            this.eurValueTxt = new System.Windows.Forms.TextBox();
            this.toLbl = new System.Windows.Forms.Label();
            this.currencyCmb = new System.Windows.Forms.ComboBox();
            this.resultLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.validNumberLbl = new System.Windows.Forms.Label();
            this.chooseCurrLbl = new System.Windows.Forms.Label();
            this.fromLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertBtn
            // 
            this.convertBtn.AutoSize = true;
            this.convertBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.convertBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertBtn.Location = new System.Drawing.Point(229, 160);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(123, 35);
            this.convertBtn.TabIndex = 0;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = false;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // eurLbl
            // 
            this.eurLbl.AutoSize = true;
            this.eurLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eurLbl.Location = new System.Drawing.Point(128, 79);
            this.eurLbl.Name = "eurLbl";
            this.eurLbl.Size = new System.Drawing.Size(52, 23);
            this.eurLbl.TabIndex = 1;
            this.eurLbl.Text = "EUR";
            // 
            // eurValueTxt
            // 
            this.eurValueTxt.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eurValueTxt.Location = new System.Drawing.Point(100, 165);
            this.eurValueTxt.Name = "eurValueTxt";
            this.eurValueTxt.Size = new System.Drawing.Size(100, 27);
            this.eurValueTxt.TabIndex = 2;
            // 
            // toLbl
            // 
            this.toLbl.AutoSize = true;
            this.toLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toLbl.Location = new System.Drawing.Point(248, 49);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(23, 17);
            this.toLbl.TabIndex = 3;
            this.toLbl.Text = "To";
            // 
            // currencyCmb
            // 
            this.currencyCmb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyCmb.FormattingEnabled = true;
            this.currencyCmb.Location = new System.Drawing.Point(250, 75);
            this.currencyCmb.Name = "currencyCmb";
            this.currencyCmb.Size = new System.Drawing.Size(78, 28);
            this.currencyCmb.Sorted = true;
            this.currencyCmb.TabIndex = 4;
            this.currencyCmb.SelectedIndexChanged += new System.EventHandler(this.currencyCmb_SelectedIndexChanged);
            // 
            // resultLbl
            // 
            this.resultLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.resultLbl.AutoSize = true;
            this.resultLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLbl.Location = new System.Drawing.Point(146, 255);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(148, 23);
            this.resultLbl.TabIndex = 5;
            this.resultLbl.Text = "x EUR = y ABC";
            this.resultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resultLbl.Visible = false;
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(129, 305);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(193, 17);
            this.dateLbl.TabIndex = 6;
            this.dateLbl.Text = "Exchange rate of 05-05-1995";
            this.dateLbl.Visible = false;
            // 
            // validNumberLbl
            // 
            this.validNumberLbl.AutoSize = true;
            this.validNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.validNumberLbl.ForeColor = System.Drawing.Color.Red;
            this.validNumberLbl.Location = new System.Drawing.Point(32, 198);
            this.validNumberLbl.Name = "validNumberLbl";
            this.validNumberLbl.Size = new System.Drawing.Size(228, 17);
            this.validNumberLbl.TabIndex = 7;
            this.validNumberLbl.Text = "Please provide a valid number";
            this.validNumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.validNumberLbl.Visible = false;
            // 
            // chooseCurrLbl
            // 
            this.chooseCurrLbl.AutoSize = true;
            this.chooseCurrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chooseCurrLbl.ForeColor = System.Drawing.Color.Red;
            this.chooseCurrLbl.Location = new System.Drawing.Point(209, 109);
            this.chooseCurrLbl.Name = "chooseCurrLbl";
            this.chooseCurrLbl.Size = new System.Drawing.Size(196, 17);
            this.chooseCurrLbl.TabIndex = 9;
            this.chooseCurrLbl.Text = "Please choose a currency";
            this.chooseCurrLbl.Visible = false;
            // 
            // fromLbl
            // 
            this.fromLbl.AutoSize = true;
            this.fromLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fromLbl.Location = new System.Drawing.Point(129, 49);
            this.fromLbl.Name = "fromLbl";
            this.fromLbl.Size = new System.Drawing.Size(43, 17);
            this.fromLbl.TabIndex = 10;
            this.fromLbl.Text = "From";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(465, 373);
            this.Controls.Add(this.fromLbl);
            this.Controls.Add(this.chooseCurrLbl);
            this.Controls.Add(this.validNumberLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.currencyCmb);
            this.Controls.Add(this.toLbl);
            this.Controls.Add(this.eurValueTxt);
            this.Controls.Add(this.eurLbl);
            this.Controls.Add(this.convertBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculatorForm";
            this.Text = "Currency converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.Label eurLbl;
        private System.Windows.Forms.TextBox eurValueTxt;
        private System.Windows.Forms.Label toLbl;
        private System.Windows.Forms.ComboBox currencyCmb;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label validNumberLbl;
        private System.Windows.Forms.Label chooseCurrLbl;
        private System.Windows.Forms.Label fromLbl;
    }
}

