using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stiig;

namespace ITMat_Scan
{
    public partial class LoanOutIn : Form
    {
        bool capture = false;
        StringBuilder builder = new StringBuilder();
        int orderID = 0;

        public LoanOutIn()
        {
            InitializeComponent();
            statusLineLabel.Text = "";
        }

        private void LoanOutIn_KeyDown(object sender, KeyEventArgs e)
        {
            #region Capture key
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.B)
            {
                capture = true;
                e.SuppressKeyPress = true;
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
            {
                capture = false;
                if (builder.ToString().StartsWith("ORDRE"))
                {
                    string orderIDstring = builder.ToString().Substring(5);

                    if (int.TryParse(orderIDstring, out orderID))
                        GetOrder();
                    else
                        SetMsg("Ikke et valid ordrenummer", true);
                }
                builder.Clear();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            #endregion
        }

        private void LoanOutIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (capture)
            {
                builder.Append(e.KeyChar);
                e.Handled = true;
            }
        }

        private void GetOrder()
        {
            txtOrderID.Text = "";
            txtOutlookName.Text = "";
            txtDatePickedUp.Text = "";
            txtDateReturned.Text = "";
            btnSetPickedUp.Enabled = false;
            btnSetReturned.Enabled = false;

            try
            {
                Loan loan = new Loan(orderID);
                txtOrderID.Text = loan.ID.ToString();
                txtOutlookName.Text = loan.Customer.OutlookName;
                
                if (loan.DatePickedUp != DateTime.MinValue)
                    txtDatePickedUp.Text = loan.DatePickedUp.ToShortDateString();
                else
                    btnSetPickedUp.Enabled = true;

                if (loan.DateReturned != DateTime.MinValue)
                    txtDateReturned.Text = loan.DateReturned.ToShortDateString();
                else
                    btnSetReturned.Enabled = true;
            }
            catch (Loan.LoanDoesntExistException)
            {
                SetMsg("Udlånet findes ikke", true);
            }
        }

        private void btnSetPickedUp_Click(object sender, EventArgs e)
        {
            DataAccessLayer dal = new DataAccessLayer();

            dal.AddParameter("@ID", orderID, DbType.Int32);
            string DatePickedUpSet = dal.ExecuteScalar("IF ((SELECT [DatePickedUp] FROM [Loans] WHERE [ID] = @ID) IS NULL) SELECT 0 ELSE SELECT 1").ToString();
            dal.ClearParameters();

            if (DatePickedUpSet == "1")
                SetMsg("Dato allerede sat", true);
            else
            {
                dal.AddParameter("@ID", orderID, DbType.Int32);
                dal.ExecuteNonQuery("UPDATE [Loans] SET [DatePickedUp] = GETDATE() WHERE [ID] = @ID;EXEC dbo.WriteLog 3, 10, @ID, '00000000-0000-0000-0000-000000000000', 'ITMat Edit - Afhentet'");
                dal.ClearParameters();
                SetMsg("Dato opdateret på ordre " + orderID);
                GetOrder();
            }
        }

        private void btnSetReturned_Click(object sender, EventArgs e)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.AddParameter("@ID", orderID, DbType.Int32);
            string DateReturnedSet = dal.ExecuteScalar("IF ((SELECT [DateReturned] FROM [Loans] WHERE [ID] = @ID) IS NULL) SELECT 0 ELSE SELECT 1").ToString();
            dal.ClearParameters();

            if (DateReturnedSet == "1")
            {
                SetMsg("Dato allerede sat", true);
            }
            else
            {
                dal.AddParameter("@ID", orderID, DbType.Int32);
                dal.ExecuteNonQuery("UPDATE [Loans] SET [DateReturned] = GETDATE() WHERE [ID] = @ID;EXEC dbo.WriteLog 3, 10, @ID, '00000000-0000-0000-0000-000000000000', 'ITMat Edit - Afleveret'");
                dal.ClearParameters();
                SetMsg("Dato opdateret på ordre " + orderID, false);
                GetOrder();
            }
        }

        private void SetMsg(string msg)
        {
            SetMsg(msg, false);
        }
        private void SetMsg(string msg, bool error)
        {
            statusLineLabel.Text = msg;
            statusLineLabel.ForeColor = error ? Color.Red : Color.Black;
            statusLineLabel.Visible = true;
        }
    }
}
