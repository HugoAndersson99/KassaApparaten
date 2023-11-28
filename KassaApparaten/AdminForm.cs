using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KassaApparaten
{
    public partial class AdminForm : Form
    {
        public KassaApparaten kassaApparaten;
        public List<Vara> varaList = new List<Vara>();
        public Form1 form1;
        public string path = "Varor.csv";
        public int amountTotal = 0;
        public int moneyTotal = 0;

        public AdminForm()
        {

            InitializeComponent();
            panel.Show();
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
                        int moneyGained = Convert.ToInt32(strings[3]);
                        namnBox.Items.Add(name);
                        priceBox.Items.Add(price + "kr");
                        amountBox.Items.Add(amountSold + "st");
                        moneyBox.Items.Add(moneyGained + "kr");
                        varaList.Add(new Vara(name, price, amountSold, moneyGained));
                        line = reader.ReadLine();


                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            UpdateLabels();
        }

        public void UpdateLabels()
        {
            moneyTotal = 0;
            amountTotal = 0;
            foreach (Vara vara in varaList)
            {
                moneyTotal += vara.TotalAmountOfMoneySold;
                amountTotal += vara.TotalAmountSold;

            }
            moneyLabel.Text = "Totalt: " + moneyTotal.ToString() + " KR";
            amountLabel.Text = "Totalt: " + amountTotal.ToString() + " ST";
        }

        public void SetList(List<Vara> list)
        {
            varaList = list;
        }

        private void addVaraButton_Click(object sender, EventArgs e)
        {
            try
            {


                if (varaNameTextBox != null && varaPriceTextBox != null)
                {
                    int price = Convert.ToInt32(varaPriceTextBox.Text);
                    //namnBox.Items.Add(varaNameTextBox.Text)
                    //prisBox.Items.Add(varaPriceTextBox + "kr");
                    //soldBox.Items.Add("0 st");
                    varaList.Add(new Vara(varaNameTextBox.Text, price));
                    // kassaApparaten.varaList.Add(new Vara(varaNameTextBox.Text, price));
                    SaveText();
                    LoadText();
                    varaNameTextBox.Clear();
                    varaPriceTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Du måste skriva in något på namn och pris!");
                }
            }
            catch
            {
                MessageBox.Show("Du måste skriva siffor på varans pris");
            }

        }
        public void LoadText()
        {
            namnBox.Items.Clear();
            priceBox.Items.Clear();
            amountBox.Items.Clear();
            moneyBox.Items.Clear();

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
                        int moneyGained = Convert.ToInt32(strings[3]);
                        namnBox.Items.Add(name);
                        priceBox.Items.Add(price + "kr");
                        amountBox.Items.Add(amountSold + "st");
                        moneyBox.Items.Add(moneyGained + "kr");
                        line = reader.ReadLine();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            UpdateLabels();
        }

        private void SaveText()
        {

            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (Vara vara in varaList)
                {
                    writer.WriteLine(vara.GetCSV());
                }
            }
        }

        private void removeVaraButton_Click(object sender, EventArgs e)
        {
            if (namnBox.SelectedItem != null)
            {
                string choosenNamnItem = namnBox.SelectedItem.ToString();
                string choosenPriceItem = priceBox.SelectedItem.ToString();
                string choosenAmountItem = amountBox.SelectedItem.ToString();
                string choosenMoneyItem = moneyBox.SelectedItem.ToString();

                foreach (Vara vara in varaList)
                {
                    string choosenPrice = vara.Value + "kr";
                    string choosenAmount = vara.TotalAmountSold + "st";
                    string choosenMoney = vara.TotalAmountOfMoneySold + "kr";
                    if (choosenNamnItem == vara.Name && choosenAmount == choosenAmountItem && choosenPriceItem == choosenPrice && choosenMoneyItem == choosenMoney)
                    {
                        varaList.Remove(vara);
                        SaveText();
                        priceBox.Items.RemoveAt(priceBox.SelectedIndex);
                        amountBox.Items.RemoveAt(amountBox.SelectedIndex);
                        moneyBox.Items.RemoveAt(moneyBox.SelectedIndex);
                        namnBox.Items.RemoveAt(namnBox.SelectedIndex);
                        break;
                    }
                }
            }
            UpdateLabels();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveText();
            Hide();
            panel.Show();
            kassaApparaten.WriteText();
            kassaApparaten.SetList(varaList);
            form1.Show();
        }

        private void namnBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = namnBox.SelectedIndex;

            priceBox.SelectedIndex = i;
            amountBox.SelectedIndex = i;
            moneyBox.SelectedIndex = i;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginBox.Text == "1234")
            {
                panel.Hide();
                loginBox.Clear();
            }
            else
            {
                MessageBox.Show("Fel kod! prova igen");
                loginBox.Clear();
            }
        }
    }
}
