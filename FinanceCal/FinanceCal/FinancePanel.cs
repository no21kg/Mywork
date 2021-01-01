using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceCal
{
    public partial class FinancePanel : UserControl
    {
        private Tax[] _TaxKind = new Tax[4];

        private Rate[] _RateKind = new Rate[4];

        public FinancePanel()
        {
            InitializeComponent();
        }

        private void FinancePanel_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                _TaxKind[i] = Tax.Normal;
                _RateKind[i] = Rate.Simple;
            }
        }

        private void SavingBtn_Click(object sender, EventArgs e)
        {
            ExCal Saving = new ExCal();
            if (Check_Validation(SavingAmountText.Text, SavingRateText.Text, SavingPeriodText.Text))
            {
                Saving.CalSaving(int.Parse(SavingAmountText.Text), double.Parse(SavingRateText.Text), int.Parse(SavingPeriodText.Text), _TaxKind[0], _RateKind[0]);
                SavingResultText.Text = Saving.Result.ToString();
                SavingRRText.Text = Saving.Interest.ToString();
            }
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            ExCal Deposit = new ExCal();
            if (Check_Validation(DepositAmountText.Text, DepositRateText.Text, DepositPeriodText.Text))
            {
                Deposit.CalDeposit(int.Parse(DepositAmountText.Text), double.Parse(DepositRateText.Text), int.Parse(DepositPeriodText.Text), _TaxKind[1], _RateKind[1]);
                DepositResultText.Text = Deposit.Result.ToString();
                DepositRRText.Text = Deposit.Interest.ToString();
            }
        }

        private void GoalBtn_Click(object sender, EventArgs e)
        {
            ExCal Goal = new ExCal();
            if (Check_Validation(GoalAmountText.Text, GoalRateText.Text, GoalPeriodText.Text))
            {
                Goal.CalGoal(int.Parse(GoalAmountText.Text), double.Parse(GoalRateText.Text), int.Parse(GoalPeriodText.Text), _TaxKind[2], _RateKind[2]);
                GoalResultText.Text = Goal.Result.ToString();
            }
        }

        private bool Check_Validation(string Amount, string Rate, string Period)
        {
            int intCheck;
            double dblCheck;

            int.TryParse(Amount, out intCheck);

            if (intCheck == 0)
            {
                string msg = "금액을 다시 입력해 주세요.";
                MessageBox.Show(msg);
                return false;
            }
            else
            {
                int temp = int.Parse(Amount);
                if (temp < 0)
                {
                    string msg = "금액을 다시 입력해 주세요.";
                    MessageBox.Show(msg);
                    return false;
                }
            }

            double.TryParse(Rate, out dblCheck);

            if (dblCheck == 0)
            {
                string msg = "이율을 다시 입력해 주세요.";
                MessageBox.Show(msg);
                return false;
            }
            else
            {
                double Temp = double.Parse(Rate);
                if ((Temp < 0) || (Temp > 100))
                {
                    string msg = "이율을 다시 입력해 주세요.";
                    MessageBox.Show(msg);
                    return false;
                }
            }

            int.TryParse(Period, out intCheck);

            if (intCheck == 0)
            {
                string msg = "기간을 다시 입력해 주세요.";
                MessageBox.Show(msg);
                return false;
            }
            else
            {
                int temp = int.Parse(Amount);
                if (temp < 0)
                {
                    string msg = "기간을 다시 입력해 주세요.";
                    MessageBox.Show(msg);
                    return false;
                }
            }

            return true;
        }


        private void TaxRadio1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton RadioBtn = (RadioButton)sender;

            switch (RadioBtn.Name)
            {
                case "SavingRadio1":
                    _TaxKind[0] = Tax.Free;
                    break;

                case "DepositRadio1":
                    _TaxKind[1] = Tax.Free;
                    break;

                case "GoalRadio1":
                    _TaxKind[2] = Tax.Free;
                    break;

                case "LoanRadio1":
                    _TaxKind[3] = Tax.Free;
                    break;
            }

        }

        private void TaxRadio2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton RadioBtn = (RadioButton)sender;

            switch (RadioBtn.Name)
            {
                case "SavingRadio2":
                    _TaxKind[0] = Tax.Premium;
                    break;

                case "DepositRadio2":
                    _TaxKind[1] = Tax.Premium;
                    break;

                case "GoalRadio2":
                    _TaxKind[2] = Tax.Premium;
                    break;

                case "LoanRadio2":
                    _TaxKind[3] = Tax.Premium;
                    break;
            }
        }

        private void TaxRadio3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton RadioBtn = (RadioButton)sender;

            switch (RadioBtn.Name)
            {
                case "SavingRadio3":
                    _TaxKind[0] = Tax.Normal;
                    break;

                case "DepositRadio3":
                    _TaxKind[1] = Tax.Normal;
                    break;

                case "GoalRadio3":
                    _TaxKind[2] = Tax.Normal;
                    break;

                case "LoanRadio3":
                    _TaxKind[3] = Tax.Normal;
                    break;
            }
        }

        private void RateRadio1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton RadioBtn = (RadioButton)sender;

            switch (RadioBtn.Name)
            {
                case "SavingRateRadio1":
                    _RateKind[0] = Rate.Simple;
                    break;

                case "DepositRateRadio1":
                    _RateKind[1] = Rate.Simple;
                    break;

                case "GoalRateRadio1":
                    _RateKind[2] = Rate.Simple;
                    break;

                case "LoanRateRadio3":
                    _RateKind[3] = Rate.Simple;
                    break;
            }
        }

        private void RateRadio2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton RadioBtn = (RadioButton)sender;

            switch (RadioBtn.Name)
            {
                case "SavingRateRadio2":
                    _RateKind[0] = Rate.Compound;
                    break;

                case "DepositRateRadio2":
                    _RateKind[1] = Rate.Compound;
                    break;

                case "GoalRateRadio2":
                    _RateKind[2] = Rate.Compound;
                    break;

                case "LoanRateRadio2":
                    _RateKind[3] = Rate.Compound;
                    break;
            }
        }
    }
}
