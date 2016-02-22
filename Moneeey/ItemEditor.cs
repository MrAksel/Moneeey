using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Person = Money.Calculator.Person;
using Payment = Money.Calculator.Payment;
using Product = Money.Calculator.Product;
using System.Linq;

namespace Money
{
    internal class ItemEditor : Form
    {
        #region Designer 
        protected Button btnOk;
        protected Button btnCancel;
        private IContainer components;
        private NumericUpDown nProductPrice;
        private Label label3;
        private TextBox tbProductName;
        private Label label2;
        private TextBox tbTransactionName;
        private Label label1;
        private GroupBox gbConsumers;
        private CheckBox cbAll;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTransactionName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nProductPrice = new System.Windows.Forms.NumericUpDown();
            this.gbConsumers = new System.Windows.Forms.GroupBox();
            this.cbAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nProductPrice)).BeginInit();
            this.gbConsumers.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(108, 292);
            this.btnOk.Name = "buttonOK";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9999999;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // buttonCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(196, 292);
            this.btnCancel.Name = "buttonCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 99999999;
            this.btnCancel.Text = "Cancel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Transaction";
            // 
            // tbTransactionName
            // 
            this.tbTransactionName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbTransactionName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbTransactionName.Location = new System.Drawing.Point(15, 84);
            this.tbTransactionName.Name = "tbTransactionName";
            this.tbTransactionName.Size = new System.Drawing.Size(171, 20);
            this.tbTransactionName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product name";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(15, 31);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(171, 20);
            this.tbProductName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price";
            // 
            // nProductPrice
            // 
            this.nProductPrice.DecimalPlaces = 2;
            this.nProductPrice.Location = new System.Drawing.Point(16, 132);
            this.nProductPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nProductPrice.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.nProductPrice.Name = "nProductPrice";
            this.nProductPrice.Size = new System.Drawing.Size(170, 20);
            this.nProductPrice.TabIndex = 2;
            this.nProductPrice.ThousandsSeparator = true;
            this.nProductPrice.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // gbConsumers
            // 
            this.gbConsumers.Controls.Add(this.cbAll);
            this.gbConsumers.Location = new System.Drawing.Point(16, 159);
            this.gbConsumers.Name = "gbConsumers";
            this.gbConsumers.Size = new System.Drawing.Size(200, 47);
            this.gbConsumers.TabIndex = 10;
            this.gbConsumers.TabStop = false;
            this.gbConsumers.Text = "Consumers";
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(7, 20);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(71, 17);
            this.cbAll.TabIndex = 3;
            this.cbAll.Text = "Everyone";
            this.cbAll.UseVisualStyleBackColor = true;
            // 
            // ItemEditor
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 324);
            this.Controls.Add(this.gbConsumers);
            this.Controls.Add(this.nProductPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTransactionName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemEditor";
            this.Text = "Edit Item";
            this.Load += new System.EventHandler(this.ItemEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nProductPrice)).EndInit();
            this.gbConsumers.ResumeLayout(false);
            this.gbConsumers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        Product template;
        List<Person> persons;
        List<Payment> transactions;

        private ItemEditor(Product initial, List<Person> data)
        {
            InitializeComponent();

            template = initial;
            persons = data;
            transactions = persons.SelectMany(person => person.Payments).Where(t => t.Byer == initial.Transaction.Byer).Distinct().ToList();

            tbTransactionName.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            foreach (Payment pay in transactions)
                tbTransactionName.AutoCompleteCustomSource.Add(pay.Name);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cbAll.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("There must be at least one consumer");
                DialogResult = DialogResult.None;
            }
        }

        private void ItemEditor_Load(object sender, EventArgs e)
        {
            tbProductName.Focus();
        }


        internal static Product Edit(Product p, List<Person> persons)
        {
            using (ItemEditor form = new ItemEditor(p, persons))
            {
                form.tbTransactionName.Text = p.Transaction.Name;
                form.tbProductName.Text = p.Name;
                form.nProductPrice.Value = p.Price;

                bool all = true;
                bool any = false;
                int tabIndex = 4;
                Point initial = new Point(16, 43);
                foreach (Person person in persons)
                {
                    CheckBox cb = new CheckBox();
                    cb.Location = initial;
                    cb.Text = person.Name;
                    cb.TabIndex = tabIndex++;
                    cb.Checked = p.Receivers.Contains(person);
                    cb.Tag = person;
                    cb.CheckedChanged += cb_CheckedChanged;
                    form.gbConsumers.Controls.Add(cb);

                    initial = new Point(initial.X, initial.Y + 23);
                    form.gbConsumers.Height += 23;
                    form.Height += 23;

                    all &= cb.Checked;
                    any |= cb.Checked;
                }

                form.cbAll.CheckedChanged -= cbAll_CheckedChanged;
                if (all)
                    form.cbAll.Checked = true;
                else if (any)
                    form.cbAll.CheckState = CheckState.Indeterminate;
                else
                    form.cbAll.Checked = false;
                form.cbAll.CheckedChanged += cbAll_CheckedChanged;


                DialogResult result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    p.Name = form.tbProductName.Text;
                    p.Price = form.nProductPrice.Value;
                    
                    p.Receivers.Clear();
                    if (form.cbAll.CheckState == CheckState.Checked)
                        p.Receivers.AddRange(persons);
                    else
                        foreach (CheckBox cb in form.gbConsumers.Controls)
                            if (cb != form.cbAll && cb.CheckState == CheckState.Checked)
                                if (cb.Tag as Person != null)
                                    p.Receivers.Add(cb.Tag as Person);

                    if (form.transactions.Any(t => t.Name == form.tbTransactionName.Text))
                        p.Transaction = form.transactions.First(t => t.Name == form.tbTransactionName.Text);
                    else
                        p.Transaction = new Payment(form.tbTransactionName.Text, p.Transaction.Byer);

                    return p;
                }
                else
                {
                    return null;
                }
            }
        }


        private static void cb_CheckedChanged(object sender, EventArgs e)
        {
            ItemEditor form = (sender as CheckBox).FindForm() as ItemEditor;
            bool all = true;
            bool any = false;

            foreach (CheckBox cb in form.gbConsumers.Controls)
            {
                if (cb != form.cbAll)
                {
                    all &= cb.Checked;
                    any |= cb.Checked;
                }
            }

            form.cbAll.CheckedChanged -= cbAll_CheckedChanged;
            if (all)
                form.cbAll.CheckState = CheckState.Checked;
            else if (any)
                form.cbAll.CheckState = CheckState.Indeterminate;
            else
                form.cbAll.CheckState = CheckState.Unchecked;
            form.cbAll.CheckedChanged += cbAll_CheckedChanged;
        }

        private static void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            ItemEditor form = (sender as CheckBox).FindForm() as ItemEditor;
            foreach (CheckBox cb in form.gbConsumers.Controls)
            {
                if (cb != form.cbAll)
                {
                    cb.CheckedChanged -= cb_CheckedChanged;
                    cb.Checked = form.cbAll.Checked;
                    cb.CheckedChanged += cb_CheckedChanged;
                }
            }
        }
    }
}
