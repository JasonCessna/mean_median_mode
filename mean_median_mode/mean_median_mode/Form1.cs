/* CODE WRITTEN BY JASON CESSNA - FEEL FREE TO USE FOR ANY PURPOSES, PLEASE COMMENT CREDIT WHERE IT'S DUE! THANKS FOR CHECKING IT OUT*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mean_median_mode
{
    public partial class main : Form
    {
        double mean = 0;
        double median = 0;


        public main()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            clearList();
        }
        private void clearList()
        {

            listBox1.Items.Clear();
            mean = 0;
            median = 0;
            lblMedian.Text = "Median";
            lblMean.Text = "Mean";
            lblMode.Text = "Mode";
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            double[] mySet = { 0 };
            string[] oldString;
            List<string> myList = new List<string>();
            if (radioComma.Checked == true)
            {
                oldString = txtBoxSetInput.Text.Split(
                 new string[] { "," },
                 StringSplitOptions.RemoveEmptyEntries);
            }
            else if (radioSpace.Checked == true)
            {
                oldString = txtBoxSetInput.Text.Split(
                new string[] { " " },
                StringSplitOptions.RemoveEmptyEntries);
            }
            else
            {
                oldString = txtBoxSetInput.Text.Split(
                new string[] { " ", "," },
                StringSplitOptions.RemoveEmptyEntries);

            }
            foreach (string item in oldString)
            {
                myList.Add(item);
                listBox1.Items.Add(item);
            }
            if (myList.Count() > 1)
            {


                if (radioQuant.Checked == true)
                {

                    try
                    {
                        List<double> result = myList.Select(x => double.Parse(x)).ToList();
                        mySet = result.ToArray();

                        if (myList.Count() % 2 == 0)
                        {
                            int firstMid = myList.Count() / 2;
                            int secondMid = myList.Count() / 2;
                            secondMid += 1;
                            Array.Sort(mySet);
                            median = (mySet[firstMid - 1] + mySet[secondMid - 1]) / 2;
                        }
                        else
                        {
                            median = mySet[(myList.Count() / 2) - 1];
                        }

                        for (int i = 0; i < myList.Count(); i++)
                        {
                            mean += mySet[i];
                        }
                        mean = mean / myList.Count();

                        lblMean.Text = "Mean:\t " + mean.ToString();
                        lblMedian.Text = "Median:\t " + median.ToString();

                    }
                    catch (Exception h)
                    {
                        MessageBox.Show("Please provide numbers only when selecting Quantitative");
                        clearList();
                    }


                }
                else if (radioQual.Checked == true)
                {
                    lblMedian.Text = "Median:\t Not available";
                    lblMean.Text = "Mean:\t Not available";
                }

                int countModes = 1;
                int numGroups = myList
                   .GroupBy(i => i)
                   .Count();
                string[] modeValue = new string[numGroups];
                modeValue[0] =
                myList
                    .GroupBy(i => i)
                    .OrderByDescending(g => g.Count())
                    .Select(g => g.Key)
                    .First();
                if (numGroups >= 1)
                    for (int inc = 1; inc <= (numGroups - 1); inc++)
                    {

                        var group1 = myList.GroupBy(i => i).OrderByDescending(g => g.Count()).Skip(0).First().Select(p => p.Count()).Count();
                        var group2 = myList.GroupBy(i => i).OrderByDescending(g => g.Count()).Skip(inc).First().Select(p => p.Count()).Count();
                        if (group1 > group2)
                        {
                            break;
                        }
                        else
                        {
                            countModes++;
                            modeValue[inc] =
                                myList
                                .GroupBy(i => i)
                                .OrderByDescending(g => g.Count())
                                .Select(g => g.Key)
                                .Skip(inc).First();
                        }
                    }
                if (countModes == 1)
                {
                    lblMode.Text = "Mode:\t " + modeValue[0];
                }
                else if (countModes == 2)
                {
                    lblMode.Text = "Bimodal:\t " + modeValue[0] + " and " + modeValue[1];
                }
                else if (countModes > 2)
                {
                    lblMode.Text = "Multimodal:\t " + modeValue[0];
                    for (int inc = 1; inc < countModes; inc++)
                    {
                        lblMode.Text += " and " + modeValue[inc];
                    }
                }

                else
                {
                    MessageBox.Show("Please select a valid seperation or enter a valid element.");
                    clearList();
                }
            }
        }

        private void radioQual_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioQuant_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
