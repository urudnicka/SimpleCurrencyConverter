using System;
using System.Linq;
using System.Windows.Forms;

namespace CurrencyConverterApp
{
    public partial class CalculatorForm : Form
    {
        private string TargetCurrency { get; set; } 
        private double ValueInEur { get; set; }

        public CalculatorForm()
        {
            InitializeComponent();

            new Calculator();
            currencyCmb.Items.AddRange(Calculator.Rates.Keys.ToArray());

            chooseCurrLbl.Left = currencyCmb.Left + currencyCmb.Width / 2 - chooseCurrLbl.Width / 2;
        }

        private void currencyCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            TargetCurrency = (string)currencyCmb.SelectedItem;
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            validNumberLbl.Visible = false;
            chooseCurrLbl.Visible = false;

            if (!double.TryParse(eurValueTxt.Text, out double value))
            {
                validNumberLbl.Visible = true;
                validNumberLbl.Text = "Please provide a valid number";
                validNumberLbl.Left = eurValueTxt.Left + eurValueTxt.Width / 2 - validNumberLbl.Width / 2;
                return;
            }
            else
                ValueInEur = value;

            if (ValueInEur < 0)
            {
                validNumberLbl.Visible = true;
                validNumberLbl.Text = "Money value cannot be below 0";
                validNumberLbl.Left = eurValueTxt.Left + eurValueTxt.Width / 2 - validNumberLbl.Width / 2;
                return;
            }

            if (TargetCurrency == null)
            {
                chooseCurrLbl.Visible = true;
                return;
            }

            double result = Calculator.ConvertEUR(ValueInEur, TargetCurrency);

            resultLbl.Visible = true;
            resultLbl.Text = $"{ValueInEur} EUR = {result} {TargetCurrency}";
            resultLbl.Left = (this.Width - resultLbl.Width) / 2;

            dateLbl.Visible = true;
            dateLbl.Text = $"Exchange rate of {Calculator.Date}";
        }
    }
}
