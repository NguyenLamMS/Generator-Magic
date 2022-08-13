using CreditCardValidator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generator_Magic
{
    public partial class Home : Form
    {
        Queue<string> queueData;
        string PATH = "RESULT.txt";
        public Home()
        {
            InitializeComponent();
        }
        void Run()
        {           
            if(queueData.Count == 0)
            {
                MessageBox.Show("Data Not Empty");
                return;
            }
            while(queueData.Count > 0)
            {
                string date = null;
                string number = null;
                string item = queueData.Dequeue();
                this.txtData.Invoke((Action)(() =>
                {
                    txtData.Lines = txtData.Lines.Where(s => s != item).ToArray();
                }));
                if (item.Contains("|"))
                {
                    if (item.Split("|").Length > 2)
                    {
                        number = item.Split('|')[0];
                        date = item.Split('|')[1] + "|" + item.Split("|")[2];
                    }
                }
                else
                {
                    number = item;
                }    
                int countStart = number.Count(s => s == '*');
                number = number.Replace("*", "0");
                number = number.Remove(number.Length - 1);
                var loop = 1;
                for(int i = 0; i < countStart - 1; i++)
                {
                    loop *= 10;
                }
                for(int i = 0; i < loop; i++)
                {                   
                    var x = Luhn.CreateCheckDigit(number);
                    var temp = number + x;
                    var luhn = Luhn.CheckLuhn(temp);
                    if (luhn)
                    {
                        this.txtResult.Invoke((Action)(() =>
                        {
                            if (string.IsNullOrEmpty(date))
                            {
                                txtResult.AppendText(temp + Environment.NewLine);
                                AppenFile(temp + Environment.NewLine);
                            }
                            else
                            {
                                txtResult.AppendText(temp + "|" + date + Environment.NewLine);
                                AppenFile(temp + "|" + date + Environment.NewLine);
                            }                          
                        }));                                            
                    }
                    number = (long.Parse(number) + 1).ToString();
                }
                
            }
        }
        
        private void btnRun_Click(object sender, EventArgs e)
        {
            queueData = new Queue<string>(txtData.Lines.Distinct());
            Task.Factory.StartNew(async () => {                 
                Run();
            });
            txtResult.Lines = txtResult.Lines.Distinct().ToArray();
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {
            countData.Text = "Data (" + txtData.Lines.Length + ")";
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            countResult.Text = "Result (" + txtResult.Lines.Length + ")";
        }
        private void btnMixData_Click(object sender, EventArgs e)
        {
            var random = new Random();
            string[] shuffleArrayData = txtResult.Lines.OrderBy(x => random.Next()).ToArray();
            txtResult.Lines = shuffleArrayData;
        }
        void AppenFile(string text)
        {
            File.AppendAllText(PATH, text);
        }
    }
}
