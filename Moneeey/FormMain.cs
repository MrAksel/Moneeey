using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using Person = Money.Calculator.Person;
using Payment = Money.Calculator.Payment;
using Product = Money.Calculator.Product;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;

namespace Money
{
    public partial class FormMain : Form
    {
        List<Person> persons;
        Results currentCalculation;

        public FormMain()
        {
            InitializeComponent();
            persons = new List<Calculator.Person>();

            LoadData();

            Recalculate();
            RefreshPersons();
            RefreshItems();
            RefreshSummary();
            RefreshButtons();
        }


        void RefreshPersons()
        {
            lvPeople.Items.Clear();

            foreach (Person p in persons)
            {
                ListViewItem lvi = new ListViewItem(p.Name);
                lvi.SubItems.Add(p.GetTotalSpent().ToString("C"));
                lvi.Tag = p;
                lvPeople.Items.Add(lvi);
            }
        }

        void RefreshItems()
        {
            lvBoughtItems.Items.Clear();
            lvBoughtItems.Groups.Clear();

            Person person = GetSelectedPerson();
            if (person != null)
            {
                foreach (Payment pay in person.Payments)
                {
                    ListViewGroup lvg = new ListViewGroup(pay.Name);
                    lvBoughtItems.Groups.Add(lvg);

                    foreach (Product p in pay.Products)
                    {
                        ListViewItem lvi = lvg.Items.Add(p.Name);
                        lvi.SubItems.Add(p.Price.ToString("C"));
                        lvi.Tag = p;

                        if (p.Receivers.Count == persons.Count)
                            lvi.SubItems.Add("Everyone");
                        else
                            lvi.SubItems.Add(string.Join(", ", p.Receivers));

                        lvBoughtItems.Items.Add(lvi);
                    }
                }
            }
        }

        void RefreshSummary()
        {
            lblTotDebt.Text = "";
            lblTotSpent.Text = "";
            lvIncome.Items.Clear();
            lvOutcome.Items.Clear();

            if (lvPeople.SelectedItems.Count > 0)
            {
                Person person = lvPeople.SelectedItems[0].Tag as Person;
                if (person != null)
                {
                    decimal totSpent = person.GetTotalSpent();
                    decimal totDebt = currentCalculation.GetDebt(person);
                    decimal totSum = totSpent + totDebt;

                    lblSum.Text = totSum.ToString("C");
                    lblTotSpent.Text = totSpent.ToString("C");
                    lblTotDebt.Text = Math.Abs(totDebt).ToString("C");
                    if (totDebt >= 0)
                    {
                        label5.Text = "Total debt:";
                        if (totDebt > 0)
                            lblTotDebt.ForeColor = Color.Red;
                        else
                            lblTotDebt.ForeColor = SystemColors.ControlText;
                    }
                    else
                    {
                        label5.Text = "Total income:";
                        lblTotDebt.ForeColor = Color.Green;
                    }


                    foreach (var debtGroup in currentCalculation.GetDebts(person).GroupBy(k => k.Item2))
                    {
                        decimal debt = debtGroup.Sum(g => g.Item3);
                        ListViewItem lvi = new ListViewItem(debtGroup.Key.Name);

                        if (debt > 0)
                        {
                            lvi.SubItems.Add(debt.ToString("C")).ForeColor = Color.Red;
                            lvOutcome.Items.Add(lvi);
                        }
                        else if (debt < 0)
                        {
                            lvi.SubItems.Add((-debt).ToString("C")).ForeColor = Color.Green;
                            lvIncome.Items.Add(lvi);
                        }
                    }
                }
            }
        }

        void RefreshButtons()
        {
            bool personSelected = lvPeople.SelectedItems.Count > 0 && (lvPeople.SelectedItems[0].Tag as Person) != null;
            bool itemSelected = lvBoughtItems.SelectedItems.Count > 0 && (lvBoughtItems.SelectedItems[0].Tag as Product) != null;

            btnAddItem.Enabled = personSelected;
            btnEditItem.Enabled = itemSelected;
            btnRemoveItem.Enabled = itemSelected;
            btnClearItems.Enabled = lvBoughtItems.Items.Count > 0;

            btnRemovePerson.Enabled = personSelected;
            btnClearPersons.Enabled = lvPeople.Items.Count > 0;
        }

        void Recalculate()
        {
            currentCalculation = Calculator.CalculateDebt(persons);
        }

        void SaveData()
        {
            using (FileStream fs = new FileStream("budget.txt", FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, persons);
            }
            Debug.WriteLine("Serialized data");
        }

        void LoadData()
        {
            try
            {
                using (FileStream fs = new FileStream("budget.txt", FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    persons = bf.Deserialize(fs) as List<Person>;
                }
                Debug.WriteLine("Deserialized data");
            }
            catch (FileNotFoundException fex)
            {
                Debug.WriteLine("No saved file");
            }
            catch (Exception ex)
            {

            }
        }


        Person GetSelectedPerson()
        {
            if (lvPeople.SelectedItems.Count == 0)
                return null;
            return lvPeople.SelectedItems[0].Tag as Person;
        }

        Payment GetDefaultTransaction(Person p)
        {
            Payment pay = p.Payments.FirstOrDefault(t => t.Name == "Default");
            if (pay == null)
            {
                pay = new Payment("Default", p);
            }
            return pay;
        }

        Product GetSelectedProduct()
        {
            if (lvBoughtItems.SelectedItems.Count == 0)
                return null;
            return lvBoughtItems.SelectedItems[0].Tag as Product;
        }


        void SelectPerson(Person p)
        {
            foreach (ListViewItem item in lvPeople.Items)
            {
                if (item.Tag == p)
                {
                    item.Selected = true;
                    break;
                }
            }
        }

        void SelectProduct(Product p)
        {
            foreach (ListViewItem item in lvBoughtItems.Items)
            {
                if (item.Tag == p)
                {
                    item.Selected = true;
                    break;
                }
            }
        }


        private void lvPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSummary();
            RefreshItems();
            RefreshButtons();
        }

        private void lvBoughtItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshButtons();
        }


        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            InputBoxResult ibr = InputBox.Show("Name", "New person", "");
            if (ibr.OK)
            {
                Person p = new Person(ibr.Text);
                persons.Add(p);
                RefreshPersons();
                RefreshButtons();
                SelectPerson(p);
                // No need for recalculations as this one doesn't contribute with any money yet
                SaveData();
            }
        }

        private void btnRemovePerson_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in lvPeople.SelectedItems)
            {
                Person p = itm.Tag as Person;
                if (p != null)
                    persons.Remove(p);
                itm.Remove();
            }
            Recalculate();
            RefreshButtons();
            RefreshSummary();
            SaveData();
        }

        private void btnClearPersons_Click(object sender, EventArgs e)
        {
            persons.Clear();

            RefreshPersons();
            RefreshItems();
            RefreshSummary();
            RefreshButtons();
        }


        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Person selected = GetSelectedPerson();
            Payment payment = GetDefaultTransaction(selected);
            Product product = new Product("New product", 100, payment, new List<Person>());
            Product edited = ItemEditor.Edit(product, persons);
            if (edited != null)
            {
                Recalculate();
                RefreshItems();
                RefreshPersons();
                RefreshButtons();
                RefreshSummary();
                SaveData();

                SelectPerson(selected);
                SelectProduct(edited);
            }
            else
            {
                product.Transaction = null;
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            Product item = GetSelectedProduct();
            Person selected = GetSelectedPerson();
            if (item != null)
            {
                item = ItemEditor.Edit(item, persons);
                if (item != null)
                {
                    Recalculate();
                    RefreshPersons();
                    RefreshItems();
                    RefreshSummary();
                    SaveData();

                    SelectPerson(selected);
                    SelectProduct(item);
                }
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvBoughtItems.SelectedItems)
            {
                Product prod = item.Tag as Product;
                if (prod != null)
                    prod.Transaction = null;

                item.Remove();
            }
            Recalculate();
            RefreshSummary();
            SaveData();
        }

        private void btnClearItems_Click(object sender, EventArgs e)
        {
            Person selected = GetSelectedPerson();
            selected.Payments.Clear();

            Recalculate();
            RefreshItems();
            RefreshPersons();
            RefreshButtons();
            RefreshSummary();
            SaveData();
        }
    }
}
