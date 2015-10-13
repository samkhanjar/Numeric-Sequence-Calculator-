using System;
using System.Web.UI;
using NumricSequenceCalculator.Classes;
using System.Text;

namespace NumricSequenceCalculator
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HidingFields();

            if (IsPostBack)
            {
                if (IsValidEntry())
                {
                    SequenceGeneration();
                }
                else
                {
                    rev.IsValid = false;
                }
            }          
        }

        private void SequenceGeneration()
        {
            GenerateSequence gs = new GenerateSequence();

            StringBuilder sbSequence = new StringBuilder();

            // Generate all numbers up to and including the number entered
            foreach (int i in gs.AllNumbers(Convert.ToInt32(txtEnterData.Text)))
            {
                sbSequence.Append(i);
                sbSequence.Append(", ");
            }
            lblAllNumbers.Visible = true;
            lblAllNumberResults.Visible = true;
            lblAllNumberResults.Text = sbSequence.Remove(sbSequence.ToString().Length - 2, 2).ToString();

            sbSequence = new StringBuilder();

            // Generate all odd numbers up to and including the number entered
            foreach (int i in gs.OddSequence(Convert.ToInt32(txtEnterData.Text)))
            {
                sbSequence.Append(i);
                sbSequence.Append(", ");
            }
            lblOddNumbers.Visible = true;
            lblOddNumberResults.Visible = true;
            lblOddNumberResults.Text = sbSequence.Remove(sbSequence.ToString().Length - 2, 2).ToString();

            sbSequence = new StringBuilder();

            // Generate all even numbers up to and including the number entered
            foreach (int i in gs.EvenSequence(Convert.ToInt32(txtEnterData.Text)))
            {
                sbSequence.Append(i);
                sbSequence.Append(", ");
            }
            lblEvenNumbers.Visible = true;
            lblEvenNumberResults.Visible = true;
            lblEvenNumberResults.Text = sbSequence.Remove(sbSequence.ToString().Length - 2, 2).ToString();

            sbSequence = new StringBuilder();

            // Generate all numbers multiple of 3, 5 or both up to and including the number entered
            foreach (string i in gs.AllNumbersMultipleOf(Convert.ToInt32(txtEnterData.Text)))
            {
                sbSequence.Append(i);
                sbSequence.Append(", ");
            }
            lblAllNumbersMultipleOf.Visible = true;
            lblAllNumbersMultipleOfResults.Visible = true;
            lblAllNumbersMultipleOfResults.Text = sbSequence.Remove(sbSequence.ToString().Length - 2, 2).ToString();

            sbSequence = new StringBuilder();

            // Generate all fibonacci numbers up to and including the number entered
            foreach (int i in gs.FabonacciSequence(Convert.ToInt32(txtEnterData.Text)))
            {
                sbSequence.Append(i);
                sbSequence.Append(", ");
            }
            lblFibNumbers.Visible = true;
            lblFibNumberResults.Visible = true;
            lblFibNumberResults.Text = sbSequence.Remove(sbSequence.ToString().Length - 2, 2).ToString();
        }

        private void HidingFields()
        {
            // Hiding fields
            lblAllNumbers.Visible = false;
            lblAllNumberResults.Visible = false;
            lblAllNumbersMultipleOf.Visible = false;
            lblAllNumbersMultipleOfResults.Visible = false;
            lblEvenNumbers.Visible = false;
            lblEvenNumberResults.Visible = false;
            lblOddNumbers.Visible = false;
            lblOddNumberResults.Visible = false;
            lblFibNumbers.Visible = false;
            lblFibNumberResults.Visible = false;
        }

        // Validate your entry
        private bool IsValidEntry()
        {
            bool IsValid = false;

            int DataEntry;

            if (Int32.TryParse(txtEnterData.Text, out DataEntry))
            {
                if (DataEntry > 0)
                {
                    IsValid = true;                    
                }
                else
                {
                    IsValid = false;
                }
            }
            else
            {
                IsValid = false;
            }

            return IsValid;
        }
    }
}