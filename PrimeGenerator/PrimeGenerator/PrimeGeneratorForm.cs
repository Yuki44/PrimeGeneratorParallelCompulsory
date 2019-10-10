using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;

namespace PrimeGenerator
{
    public partial class PrimeNumbersGenerator : Form
    {
        private readonly Program _program = new Program();

        public PrimeNumbersGenerator()
        {
            InitializeComponent();
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            clearAll();
            endRangeBox.Value = 0;
            startRangeBox.Value = 0;
        }

        private void clearAll()
        {
            primeNumbersListBox.DataSource = null;
            loadingRound.Visible = false;
            stickmanLoading.Visible = false;
            image.Visible = true;
            timeUsedLabel.Visible = false;
        }

        private void parallelButton_Click(object sender, EventArgs e)
        {
            if (startRangeBox.Value >= 0 && endRangeBox.Value > startRangeBox.Value)
            {
                clearAll();
                loadingRound.Visible = true;
                stickmanLoading.Visible = true;
                image.Visible = false;
                var startRange = Convert.ToInt64(startRangeBox.Value);
                var endRange = Convert.ToInt64(endRangeBox.Value);
                GetBigListAsync(startRange, endRange, "parallel").ContinueWith(r => {
                    List<long> list = (r.Result);
                    populateListBox(list);
                },
                    TaskScheduler.FromCurrentSynchronizationContext());
            }
        }
        private void sequentialButton_Click(object sender, EventArgs e)
        {
            if (startRangeBox.Value >= 0 && endRangeBox.Value > startRangeBox.Value)
            {
                clearAll();
                loadingRound.Visible = true;
                stickmanLoading.Visible = true;
                image.Visible = false;
                var startRange = Convert.ToInt64(startRangeBox.Value);
                var endRange = Convert.ToInt64(endRangeBox.Value);
                GetBigListAsync(startRange, endRange, "sequential").ContinueWith(r => {
                    List<long> list = (r.Result);
                    populateListBox(list);
                },
                   TaskScheduler.FromCurrentSynchronizationContext());
            }
        }

        private async Task<List<long>> GetBigListAsync(long startRange, long endRange, string method)
        {
            if (method == "sequential")
            {
                var myTask = Task.Run(() => _program.GetPrimesSequential(startRange, endRange));
                List<long> result = await myTask;
                return result;
            }
            else if(method == "parallel")
            {
                var myTask = Task.Run(() => _program.GetPrimesParallel(startRange, endRange));
                List<long> result = await myTask;
                return result;
            }
            return null;
        }


        private void populateListBox(List<long> list)
        {
            loadingRound.Visible = false;
            stickmanLoading.Visible = false;
            primeNumbersListBox.DataSource = list;
        }

    }
}
