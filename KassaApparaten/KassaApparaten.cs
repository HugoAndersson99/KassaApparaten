using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KassaApparaten
{
    public partial class KassaApparaten : Form
    {

        public Form1 form1;
        public AdminForm adminForm;
        public List<Vara> varaList = new List<Vara>();
        public List<Vara> buyList = new List<Vara>();
        public int soldTotal = 0;
        public int costTotal = 0;
        public string path = "Varor.csv";

        public KassaApparaten()
        {

            InitializeComponent();
            
           using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    try
                    {
                        string[] strings = line.Split(";");
                        string name = strings[0];
                        int price = Convert.ToInt32(strings[1]);
                        int amountSold = Convert.ToInt32(strings[2]);
                        int totalMoneySold = Convert.ToInt32(strings[3]);
                        varaList.Add(new Vara(name, price, amountSold, totalMoneySold));
                        varoBox.Items.Add(name + " " + price + "kr");
                        line = reader.ReadLine();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        public void WriteText()
        {
            varoBox.Items.Clear();
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    try
                    {
                        string[] strings = line.Split(";");
                        string name = strings[0];
                        int price = Convert.ToInt32(strings[1]);
                        varoBox.Items.Add(name + " " + price + "kr");
                        line = reader.ReadLine();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
        private void LeaveShopButton_Click(object sender, EventArgs e)
        {
            form1.Show();
            Hide();
        }
        public void SetList(List<Vara> list)
        {
            varaList = list;
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            if (varoBox.SelectedItem != null)
            {
                köpBox.Items.Add(varoBox.SelectedItem);
                buyList.Add(varaList[varoBox.SelectedIndex]);
                int totalCost = 0;
                int totalSold = 0;
                
                string selectedItem = varoBox.SelectedItem.ToString();
                foreach (Vara vara in varaList)
                {
                    string var = vara.Name + " " + vara.Value + "kr";
                    if (var == selectedItem)
                    {
                        vara.TotalAmountOfMoneySold += vara.Value;
                        vara.TotalAmountSold++;
                    }
                }
                foreach (Vara köptVara in buyList)
                {
                    totalCost += köptVara.Value;
                    totalSold += 1;
                    soldTotal = totalSold;
                    costTotal = totalCost;
                }

                kundvagnTotalLabel.Text = costTotal + " KR";
                kundvagnAmountLabel.Text = soldTotal + " ST";
                if (buyList.Count == 0)
                {
                    kundvagnTotalLabel.Text = "0 KR";
                    kundvagnAmountLabel.Text = "0 ST";
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                köpBox.Hide();
                RemoveFromCartButton.Hide();
            }
            else if (checkBox1.Checked)
            {
                köpBox.Show();
                RemoveFromCartButton.Show();
            }
        }

        private void RemoveFromCartButton_Click(object sender, EventArgs e)
        {
            if (köpBox.SelectedItem != null)
            {
                string item = köpBox.SelectedItem.ToString();

                foreach (Vara vara in buyList)
                {
                    string var = vara.Name + " " + vara.Value + "kr";
                    if (item == var)
                    {
                        buyList.Remove(vara);
                        break;
                    }
                }
                int totalCost = 0;
                int totalSold = 0;
                foreach (Vara köptVara in buyList)
                {
                    totalCost += köptVara.Value;
                    totalSold += 1;
                    soldTotal = totalSold;
                    costTotal = totalCost;
                }

                kundvagnTotalLabel.Text = costTotal + " KR";
                kundvagnAmountLabel.Text = soldTotal + " ST";
                köpBox.Items.Remove(köpBox.SelectedItem);

                if (buyList.Count == 0)
                {
                    kundvagnTotalLabel.Text = "0 KR";
                    kundvagnAmountLabel.Text = "0 ST";
                }

            }
        }


        private void payButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tack för ditt köp!");
            
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (Vara vara in varaList)
                {
                    writer.WriteLine(vara.GetCSV());
                }
            }
            buyList.Clear();
            köpBox.Items.Clear();
            kundvagnTotalLabel.Text = "0 KR";
            kundvagnAmountLabel.Text = "0 ST";
            adminForm.SetList(varaList);
            adminForm.LoadText();
            form1.Show();
            Hide();
        }
    }
}
