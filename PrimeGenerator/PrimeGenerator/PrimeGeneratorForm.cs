using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeGenerator
{
    public partial class PrimeNumbersGenerator : Form
    {
        private List<long> listOfPrimes = new List<long>();
        private readonly Program _program = new Program();

        public PrimeNumbersGenerator()
        {
            InitializeComponent();
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            primeNumbersListBox.Items.Clear();
            endRangeBox.Value = 0;
            startRangeBox.Value = 0;
            image.Visible = true;
            timeUsedLabel.Visible = false;
        }

        private void parallelButton_Click(object sender, EventArgs e)
        {
            if (startRangeBox.Value >= 0 && endRangeBox.Value > startRangeBox.Value)
            {
                image.Visible = false;
                var startRange = Convert.ToInt64(startRangeBox.Value);
                var endRange = Convert.ToInt64(endRangeBox.Value);
                var primes = _program.GetPrimesParallel(startRange, endRange);
            }
        }
        private void sequentialButton_Click(object sender, EventArgs e)
        {
            long[] primes;

            if (startRangeBox.Value >= 0 && endRangeBox.Value > startRangeBox.Value)
            {
                image.Visible = false;
                var startRange = Convert.ToInt64(startRangeBox.Value);
                var endRange = Convert.ToInt64(endRangeBox.Value);
                listOfPrimes = _program.GetPrimesSequential(startRange, endRange);
                primes = listOfPrimes.Cast<long>().ToArray();

            }

            // primeNumbersListBox.Items.AddRange(primes);
        }
        private void primeNumbersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO
        }

        private void timeUsedLabel_Click(object sender, EventArgs e)
        {
            // TODO
        }

    }
}
