namespace Money
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvPeople = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lvBoughtItems = new System.Windows.Forms.ListView();
            this.chProdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPersons = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lvOutcome = new System.Windows.Forms.ListView();
            this.chPersonOutcome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAmountOutcome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvIncome = new System.Windows.Forms.ListView();
            this.chPersonIncome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAmountIncome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotDebt = new System.Windows.Forms.Label();
            this.lblTotSpent = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnRemovePerson = new System.Windows.Forms.Button();
            this.btnClearPersons = new System.Windows.Forms.Button();
            this.btnClearItems = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvPeople
            // 
            this.lvPeople.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvPeople.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chTotal});
            this.lvPeople.FullRowSelect = true;
            this.lvPeople.HideSelection = false;
            this.lvPeople.Location = new System.Drawing.Point(13, 31);
            this.lvPeople.MultiSelect = false;
            this.lvPeople.Name = "lvPeople";
            this.lvPeople.ShowGroups = false;
            this.lvPeople.Size = new System.Drawing.Size(185, 268);
            this.lvPeople.TabIndex = 0;
            this.lvPeople.UseCompatibleStateImageBehavior = false;
            this.lvPeople.View = System.Windows.Forms.View.Details;
            this.lvPeople.SelectedIndexChanged += new System.EventHandler(this.lvPeople_SelectedIndexChanged);
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 81;
            // 
            // chTotal
            // 
            this.chTotal.Text = "Total spent";
            this.chTotal.Width = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "People";
            // 
            // lvBoughtItems
            // 
            this.lvBoughtItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvBoughtItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProdName,
            this.chPrice,
            this.chPersons});
            this.lvBoughtItems.FullRowSelect = true;
            this.lvBoughtItems.HideSelection = false;
            this.lvBoughtItems.Location = new System.Drawing.Point(204, 31);
            this.lvBoughtItems.Name = "lvBoughtItems";
            this.lvBoughtItems.Size = new System.Drawing.Size(379, 268);
            this.lvBoughtItems.TabIndex = 2;
            this.lvBoughtItems.UseCompatibleStateImageBehavior = false;
            this.lvBoughtItems.View = System.Windows.Forms.View.Details;
            this.lvBoughtItems.SelectedIndexChanged += new System.EventHandler(this.lvBoughtItems_SelectedIndexChanged);
            // 
            // chProdName
            // 
            this.chProdName.Text = "Product";
            this.chProdName.Width = 74;
            // 
            // chPrice
            // 
            this.chPrice.Text = "Price";
            // 
            // chPersons
            // 
            this.chPersons.Text = "Consumers";
            this.chPersons.Width = 191;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bought Items";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblSum);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lvOutcome);
            this.groupBox1.Controls.Add(this.lvIncome);
            this.groupBox1.Controls.Add(this.lblTotDebt);
            this.groupBox1.Controls.Add(this.lblTotSpent);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(589, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 295);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(232, 19);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(25, 13);
            this.lblSum.TabIndex = 7;
            this.lblSum.Text = "0 kr";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total sum:";
            // 
            // lvOutcome
            // 
            this.lvOutcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvOutcome.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPersonOutcome,
            this.chAmountOutcome});
            this.lvOutcome.Location = new System.Drawing.Point(6, 192);
            this.lvOutcome.Name = "lvOutcome";
            this.lvOutcome.Size = new System.Drawing.Size(284, 95);
            this.lvOutcome.TabIndex = 5;
            this.lvOutcome.UseCompatibleStateImageBehavior = false;
            this.lvOutcome.View = System.Windows.Forms.View.Details;
            // 
            // chPersonOutcome
            // 
            this.chPersonOutcome.Text = "Name";
            // 
            // chAmountOutcome
            // 
            this.chAmountOutcome.Text = "Amount";
            // 
            // lvIncome
            // 
            this.lvIncome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvIncome.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPersonIncome,
            this.chAmountIncome});
            this.lvIncome.Location = new System.Drawing.Point(6, 79);
            this.lvIncome.Name = "lvIncome";
            this.lvIncome.Size = new System.Drawing.Size(284, 95);
            this.lvIncome.TabIndex = 4;
            this.lvIncome.UseCompatibleStateImageBehavior = false;
            this.lvIncome.View = System.Windows.Forms.View.Details;
            // 
            // chPersonIncome
            // 
            this.chPersonIncome.Text = "Name";
            // 
            // chAmountIncome
            // 
            this.chAmountIncome.Text = "Amount";
            // 
            // lblTotDebt
            // 
            this.lblTotDebt.AutoSize = true;
            this.lblTotDebt.Location = new System.Drawing.Point(78, 40);
            this.lblTotDebt.Name = "lblTotDebt";
            this.lblTotDebt.Size = new System.Drawing.Size(25, 13);
            this.lblTotDebt.TabIndex = 3;
            this.lblTotDebt.Text = "0 kr";
            // 
            // lblTotSpent
            // 
            this.lblTotSpent.AutoSize = true;
            this.lblTotSpent.Location = new System.Drawing.Point(78, 19);
            this.lblTotSpent.Name = "lblTotSpent";
            this.lblTotSpent.Size = new System.Drawing.Size(25, 13);
            this.lblTotSpent.TabIndex = 2;
            this.lblTotSpent.Text = "0 kr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total debt:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "People you owe money:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "People owing you money:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total spent:";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddPerson.Location = new System.Drawing.Point(13, 305);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(37, 23);
            this.btnAddPerson.TabIndex = 5;
            this.btnAddPerson.Text = "+";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnRemovePerson
            // 
            this.btnRemovePerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemovePerson.Enabled = false;
            this.btnRemovePerson.Location = new System.Drawing.Point(54, 305);
            this.btnRemovePerson.Name = "btnRemovePerson";
            this.btnRemovePerson.Size = new System.Drawing.Size(37, 23);
            this.btnRemovePerson.TabIndex = 6;
            this.btnRemovePerson.Text = "-";
            this.btnRemovePerson.UseVisualStyleBackColor = true;
            this.btnRemovePerson.Click += new System.EventHandler(this.btnRemovePerson_Click);
            // 
            // btnClearPersons
            // 
            this.btnClearPersons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearPersons.Enabled = false;
            this.btnClearPersons.Location = new System.Drawing.Point(95, 305);
            this.btnClearPersons.Name = "btnClearPersons";
            this.btnClearPersons.Size = new System.Drawing.Size(71, 23);
            this.btnClearPersons.TabIndex = 7;
            this.btnClearPersons.Text = "Clear";
            this.btnClearPersons.UseVisualStyleBackColor = true;
            this.btnClearPersons.Click += new System.EventHandler(this.btnClearPersons_Click);
            // 
            // btnClearItems
            // 
            this.btnClearItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearItems.Enabled = false;
            this.btnClearItems.Location = new System.Drawing.Point(331, 305);
            this.btnClearItems.Name = "btnClearItems";
            this.btnClearItems.Size = new System.Drawing.Size(71, 23);
            this.btnClearItems.TabIndex = 10;
            this.btnClearItems.Text = "Clear";
            this.btnClearItems.UseVisualStyleBackColor = true;
            this.btnClearItems.Click += new System.EventHandler(this.btnClearItems_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveItem.Enabled = false;
            this.btnRemoveItem.Location = new System.Drawing.Point(245, 305);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(37, 23);
            this.btnRemoveItem.TabIndex = 9;
            this.btnRemoveItem.Text = "-";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddItem.Enabled = false;
            this.btnAddItem.Location = new System.Drawing.Point(204, 305);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(37, 23);
            this.btnAddItem.TabIndex = 8;
            this.btnAddItem.Text = "+";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditItem.Enabled = false;
            this.btnEditItem.Location = new System.Drawing.Point(288, 305);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(37, 23);
            this.btnEditItem.TabIndex = 11;
            this.btnEditItem.Text = "Edit";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 342);
            this.Controls.Add(this.btnEditItem);
            this.Controls.Add(this.btnClearItems);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnClearPersons);
            this.Controls.Add(this.btnRemovePerson);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvBoughtItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvPeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "Monnni";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvBoughtItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvOutcome;
        private System.Windows.Forms.ListView lvIncome;
        private System.Windows.Forms.Label lblTotDebt;
        private System.Windows.Forms.Label lblTotSpent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnRemovePerson;
        private System.Windows.Forms.Button btnClearPersons;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chTotal;
        private System.Windows.Forms.Button btnClearItems;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ColumnHeader chProdName;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.ColumnHeader chPersons;
        private System.Windows.Forms.ColumnHeader chPersonOutcome;
        private System.Windows.Forms.ColumnHeader chAmountOutcome;
        private System.Windows.Forms.ColumnHeader chPersonIncome;
        private System.Windows.Forms.ColumnHeader chAmountIncome;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label7;
    }
}

