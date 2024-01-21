namespace AlexGann_CPT_206_Lab_1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.productNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsOnHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productDBDataSet = new AlexGann_CPT_206_Lab_1.ProductDBDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new AlexGann_CPT_206_Lab_1.ProductDBDataSetTableAdapters.ProductTableAdapter();
            this.ItemSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.ItemSearchButton = new System.Windows.Forms.Button();
            this.SearchDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SearchProductNumTextBox = new System.Windows.Forms.TextBox();
            this.SearchDescriptionRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchProductNumRadioButton = new System.Windows.Forms.RadioButton();
            this.UniversalToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.QuantitySearchGroupBox = new System.Windows.Forms.GroupBox();
            this.QuantitySearchButton = new System.Windows.Forms.Button();
            this.QuantityLessThanTextBox = new System.Windows.Forms.TextBox();
            this.QuantityMoreThanTextBox = new System.Windows.Forms.TextBox();
            this.QuantityLessThanRadioButton = new System.Windows.Forms.RadioButton();
            this.QuantityMoreThanRadioButton = new System.Windows.Forms.RadioButton();
            this.PriceSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.PriceSearchButton = new System.Windows.Forms.Button();
            this.PriceLessThanTextBox = new System.Windows.Forms.TextBox();
            this.PriceMoreThanTextBox = new System.Windows.Forms.TextBox();
            this.PriceLessThanRadioButton = new System.Windows.Forms.RadioButton();
            this.PriceMoreThanRadioButton = new System.Windows.Forms.RadioButton();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.ItemSearchGroupBox.SuspendLayout();
            this.QuantitySearchGroupBox.SuspendLayout();
            this.PriceSearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.AllowUserToAddRows = false;
            this.ProductDataGridView.AllowUserToDeleteRows = false;
            this.ProductDataGridView.AutoGenerateColumns = false;
            this.ProductDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductDataGridView.BackgroundColor = System.Drawing.Color.Firebrick;
            this.ProductDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.ProductDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNumberDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.unitsOnHandDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.ProductDataGridView.DataSource = this.productBindingSource1;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductDataGridView.DefaultCellStyle = dataGridViewCellStyle26;
            this.ProductDataGridView.EnableHeadersVisualStyles = false;
            this.ProductDataGridView.GridColor = System.Drawing.Color.SaddleBrown;
            this.ProductDataGridView.Location = new System.Drawing.Point(13, 13);
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.ReadOnly = true;
            this.ProductDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.ProductDataGridView.Size = new System.Drawing.Size(855, 150);
            this.ProductDataGridView.TabIndex = 0;
            // 
            // productNumberDataGridViewTextBoxColumn
            // 
            this.productNumberDataGridViewTextBoxColumn.DataPropertyName = "Product_Number";
            this.productNumberDataGridViewTextBoxColumn.HeaderText = "Product_Number";
            this.productNumberDataGridViewTextBoxColumn.Name = "productNumberDataGridViewTextBoxColumn";
            this.productNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitsOnHandDataGridViewTextBoxColumn
            // 
            this.unitsOnHandDataGridViewTextBoxColumn.DataPropertyName = "Units_On_Hand";
            this.unitsOnHandDataGridViewTextBoxColumn.HeaderText = "Units_On_Hand";
            this.unitsOnHandDataGridViewTextBoxColumn.Name = "unitsOnHandDataGridViewTextBoxColumn";
            this.unitsOnHandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.productDBDataSet;
            // 
            // productDBDataSet
            // 
            this.productDBDataSet.DataSetName = "ProductDBDataSet";
            this.productDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.productDBDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // ItemSearchGroupBox
            // 
            this.ItemSearchGroupBox.Controls.Add(this.ItemSearchButton);
            this.ItemSearchGroupBox.Controls.Add(this.SearchDescriptionTextBox);
            this.ItemSearchGroupBox.Controls.Add(this.SearchProductNumTextBox);
            this.ItemSearchGroupBox.Controls.Add(this.SearchDescriptionRadioButton);
            this.ItemSearchGroupBox.Controls.Add(this.SearchProductNumRadioButton);
            this.ItemSearchGroupBox.ForeColor = System.Drawing.Color.Moccasin;
            this.ItemSearchGroupBox.Location = new System.Drawing.Point(13, 169);
            this.ItemSearchGroupBox.Name = "ItemSearchGroupBox";
            this.ItemSearchGroupBox.Size = new System.Drawing.Size(250, 185);
            this.ItemSearchGroupBox.TabIndex = 1;
            this.ItemSearchGroupBox.TabStop = false;
            this.ItemSearchGroupBox.Text = "Item Search";
            // 
            // ItemSearchButton
            // 
            this.ItemSearchButton.BackColor = System.Drawing.Color.Firebrick;
            this.ItemSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemSearchButton.Location = new System.Drawing.Point(88, 147);
            this.ItemSearchButton.Name = "ItemSearchButton";
            this.ItemSearchButton.Size = new System.Drawing.Size(75, 27);
            this.ItemSearchButton.TabIndex = 4;
            this.ItemSearchButton.Text = "Search";
            this.UniversalToolTip.SetToolTip(this.ItemSearchButton, "Search by item number or description");
            this.ItemSearchButton.UseVisualStyleBackColor = false;
            this.ItemSearchButton.Click += new System.EventHandler(this.ItemSearchButton_Click);
            // 
            // SearchDescriptionTextBox
            // 
            this.SearchDescriptionTextBox.BackColor = System.Drawing.Color.Brown;
            this.SearchDescriptionTextBox.ForeColor = System.Drawing.Color.Moccasin;
            this.SearchDescriptionTextBox.Location = new System.Drawing.Point(6, 115);
            this.SearchDescriptionTextBox.Name = "SearchDescriptionTextBox";
            this.SearchDescriptionTextBox.ReadOnly = true;
            this.SearchDescriptionTextBox.Size = new System.Drawing.Size(238, 26);
            this.SearchDescriptionTextBox.TabIndex = 3;
            this.UniversalToolTip.SetToolTip(this.SearchDescriptionTextBox, "Capitalization must match. Leave empty to see all items.");
            // 
            // SearchProductNumTextBox
            // 
            this.SearchProductNumTextBox.BackColor = System.Drawing.Color.IndianRed;
            this.SearchProductNumTextBox.ForeColor = System.Drawing.Color.Moccasin;
            this.SearchProductNumTextBox.Location = new System.Drawing.Point(6, 54);
            this.SearchProductNumTextBox.Name = "SearchProductNumTextBox";
            this.SearchProductNumTextBox.Size = new System.Drawing.Size(238, 26);
            this.SearchProductNumTextBox.TabIndex = 2;
            this.UniversalToolTip.SetToolTip(this.SearchProductNumTextBox, "Product numbers have the pattern \'X0-0X\' where the first set dictates type (shirt" +
        ", pants, other) and the second designates the specific item.\r\nLeave empty to see" +
        " all entries.");
            this.SearchProductNumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchProductNumTextBox_KeyPress);
            // 
            // SearchDescriptionRadioButton
            // 
            this.SearchDescriptionRadioButton.AutoSize = true;
            this.SearchDescriptionRadioButton.Location = new System.Drawing.Point(6, 86);
            this.SearchDescriptionRadioButton.Name = "SearchDescriptionRadioButton";
            this.SearchDescriptionRadioButton.Size = new System.Drawing.Size(177, 23);
            this.SearchDescriptionRadioButton.TabIndex = 1;
            this.SearchDescriptionRadioButton.Text = "Search By Description";
            this.UniversalToolTip.SetToolTip(this.SearchDescriptionRadioButton, "Click to search by description.");
            this.SearchDescriptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchProductNumRadioButton
            // 
            this.SearchProductNumRadioButton.AutoSize = true;
            this.SearchProductNumRadioButton.Checked = true;
            this.SearchProductNumRadioButton.Location = new System.Drawing.Point(6, 25);
            this.SearchProductNumRadioButton.Name = "SearchProductNumRadioButton";
            this.SearchProductNumRadioButton.Size = new System.Drawing.Size(209, 23);
            this.SearchProductNumRadioButton.TabIndex = 0;
            this.SearchProductNumRadioButton.TabStop = true;
            this.SearchProductNumRadioButton.Text = "Search By Product Number";
            this.UniversalToolTip.SetToolTip(this.SearchProductNumRadioButton, "Click to search by product number.");
            this.SearchProductNumRadioButton.UseVisualStyleBackColor = true;
            this.SearchProductNumRadioButton.CheckedChanged += new System.EventHandler(this.SearchProductNumRadioButton_CheckedChanged);
            // 
            // QuantitySearchGroupBox
            // 
            this.QuantitySearchGroupBox.Controls.Add(this.QuantitySearchButton);
            this.QuantitySearchGroupBox.Controls.Add(this.QuantityLessThanTextBox);
            this.QuantitySearchGroupBox.Controls.Add(this.QuantityMoreThanTextBox);
            this.QuantitySearchGroupBox.Controls.Add(this.QuantityLessThanRadioButton);
            this.QuantitySearchGroupBox.Controls.Add(this.QuantityMoreThanRadioButton);
            this.QuantitySearchGroupBox.ForeColor = System.Drawing.Color.Moccasin;
            this.QuantitySearchGroupBox.Location = new System.Drawing.Point(315, 169);
            this.QuantitySearchGroupBox.Name = "QuantitySearchGroupBox";
            this.QuantitySearchGroupBox.Size = new System.Drawing.Size(250, 185);
            this.QuantitySearchGroupBox.TabIndex = 2;
            this.QuantitySearchGroupBox.TabStop = false;
            this.QuantitySearchGroupBox.Text = "Quantity Search";
            // 
            // QuantitySearchButton
            // 
            this.QuantitySearchButton.BackColor = System.Drawing.Color.Firebrick;
            this.QuantitySearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuantitySearchButton.Location = new System.Drawing.Point(88, 147);
            this.QuantitySearchButton.Name = "QuantitySearchButton";
            this.QuantitySearchButton.Size = new System.Drawing.Size(75, 27);
            this.QuantitySearchButton.TabIndex = 4;
            this.QuantitySearchButton.Text = "Search";
            this.UniversalToolTip.SetToolTip(this.QuantitySearchButton, "Search by units on hand");
            this.QuantitySearchButton.UseVisualStyleBackColor = false;
            this.QuantitySearchButton.Click += new System.EventHandler(this.QuantitySearchButton_Click);
            // 
            // QuantityLessThanTextBox
            // 
            this.QuantityLessThanTextBox.BackColor = System.Drawing.Color.Brown;
            this.QuantityLessThanTextBox.ForeColor = System.Drawing.Color.Moccasin;
            this.QuantityLessThanTextBox.Location = new System.Drawing.Point(6, 115);
            this.QuantityLessThanTextBox.Name = "QuantityLessThanTextBox";
            this.QuantityLessThanTextBox.ReadOnly = true;
            this.QuantityLessThanTextBox.Size = new System.Drawing.Size(238, 26);
            this.QuantityLessThanTextBox.TabIndex = 3;
            this.UniversalToolTip.SetToolTip(this.QuantityLessThanTextBox, "Enter a number. Leaving this blank will present no results (defaults to zero, can" +
        "not have negative items)");
            this.QuantityLessThanTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LessThanSearchTextBox_KeyPress);
            // 
            // QuantityMoreThanTextBox
            // 
            this.QuantityMoreThanTextBox.BackColor = System.Drawing.Color.IndianRed;
            this.QuantityMoreThanTextBox.ForeColor = System.Drawing.Color.Moccasin;
            this.QuantityMoreThanTextBox.Location = new System.Drawing.Point(6, 54);
            this.QuantityMoreThanTextBox.Name = "QuantityMoreThanTextBox";
            this.QuantityMoreThanTextBox.Size = new System.Drawing.Size(238, 26);
            this.QuantityMoreThanTextBox.TabIndex = 2;
            this.UniversalToolTip.SetToolTip(this.QuantityMoreThanTextBox, "Enter a number or leave blank to see all entries");
            this.QuantityMoreThanTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MoreThanSearchTextBox_KeyPress);
            // 
            // QuantityLessThanRadioButton
            // 
            this.QuantityLessThanRadioButton.AutoSize = true;
            this.QuantityLessThanRadioButton.Location = new System.Drawing.Point(6, 86);
            this.QuantityLessThanRadioButton.Name = "QuantityLessThanRadioButton";
            this.QuantityLessThanRadioButton.Size = new System.Drawing.Size(97, 23);
            this.QuantityLessThanRadioButton.TabIndex = 1;
            this.QuantityLessThanRadioButton.Text = "Less Than";
            this.UniversalToolTip.SetToolTip(this.QuantityLessThanRadioButton, "Click to search for quantities less than your entry");
            this.QuantityLessThanRadioButton.UseVisualStyleBackColor = true;
            // 
            // QuantityMoreThanRadioButton
            // 
            this.QuantityMoreThanRadioButton.AutoSize = true;
            this.QuantityMoreThanRadioButton.Checked = true;
            this.QuantityMoreThanRadioButton.Location = new System.Drawing.Point(6, 25);
            this.QuantityMoreThanRadioButton.Name = "QuantityMoreThanRadioButton";
            this.QuantityMoreThanRadioButton.Size = new System.Drawing.Size(103, 23);
            this.QuantityMoreThanRadioButton.TabIndex = 0;
            this.QuantityMoreThanRadioButton.TabStop = true;
            this.QuantityMoreThanRadioButton.Text = "More Than";
            this.UniversalToolTip.SetToolTip(this.QuantityMoreThanRadioButton, "Click to search for quantities greater than your entry");
            this.QuantityMoreThanRadioButton.UseVisualStyleBackColor = true;
            this.QuantityMoreThanRadioButton.CheckedChanged += new System.EventHandler(this.QuantityMoreThanRadioButton_CheckedChanged);
            // 
            // PriceSearchGroupBox
            // 
            this.PriceSearchGroupBox.Controls.Add(this.PriceSearchButton);
            this.PriceSearchGroupBox.Controls.Add(this.PriceLessThanTextBox);
            this.PriceSearchGroupBox.Controls.Add(this.PriceMoreThanTextBox);
            this.PriceSearchGroupBox.Controls.Add(this.PriceLessThanRadioButton);
            this.PriceSearchGroupBox.Controls.Add(this.PriceMoreThanRadioButton);
            this.PriceSearchGroupBox.ForeColor = System.Drawing.Color.Moccasin;
            this.PriceSearchGroupBox.Location = new System.Drawing.Point(618, 169);
            this.PriceSearchGroupBox.Name = "PriceSearchGroupBox";
            this.PriceSearchGroupBox.Size = new System.Drawing.Size(250, 185);
            this.PriceSearchGroupBox.TabIndex = 3;
            this.PriceSearchGroupBox.TabStop = false;
            this.PriceSearchGroupBox.Text = "Price Search";
            // 
            // PriceSearchButton
            // 
            this.PriceSearchButton.BackColor = System.Drawing.Color.Firebrick;
            this.PriceSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PriceSearchButton.Location = new System.Drawing.Point(88, 147);
            this.PriceSearchButton.Name = "PriceSearchButton";
            this.PriceSearchButton.Size = new System.Drawing.Size(75, 27);
            this.PriceSearchButton.TabIndex = 4;
            this.PriceSearchButton.Text = "Search";
            this.UniversalToolTip.SetToolTip(this.PriceSearchButton, "Search by price");
            this.PriceSearchButton.UseVisualStyleBackColor = false;
            this.PriceSearchButton.Click += new System.EventHandler(this.PriceSearchButton_Click);
            // 
            // PriceLessThanTextBox
            // 
            this.PriceLessThanTextBox.BackColor = System.Drawing.Color.Brown;
            this.PriceLessThanTextBox.ForeColor = System.Drawing.Color.Moccasin;
            this.PriceLessThanTextBox.Location = new System.Drawing.Point(6, 115);
            this.PriceLessThanTextBox.Name = "PriceLessThanTextBox";
            this.PriceLessThanTextBox.ReadOnly = true;
            this.PriceLessThanTextBox.Size = new System.Drawing.Size(238, 26);
            this.PriceLessThanTextBox.TabIndex = 3;
            this.UniversalToolTip.SetToolTip(this.PriceLessThanTextBox, "Enter a number. Leaving this blank will present no results (defaults to zero, can" +
        "not have negative price)");
            this.PriceLessThanTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceLessThanTextBox_KeyPress);
            // 
            // PriceMoreThanTextBox
            // 
            this.PriceMoreThanTextBox.BackColor = System.Drawing.Color.IndianRed;
            this.PriceMoreThanTextBox.ForeColor = System.Drawing.Color.Moccasin;
            this.PriceMoreThanTextBox.Location = new System.Drawing.Point(6, 54);
            this.PriceMoreThanTextBox.Name = "PriceMoreThanTextBox";
            this.PriceMoreThanTextBox.Size = new System.Drawing.Size(238, 26);
            this.PriceMoreThanTextBox.TabIndex = 2;
            this.UniversalToolTip.SetToolTip(this.PriceMoreThanTextBox, "Enter a number or leave blank to see all entries");
            this.PriceMoreThanTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceMoreThanTextBox_KeyPress);
            // 
            // PriceLessThanRadioButton
            // 
            this.PriceLessThanRadioButton.AutoSize = true;
            this.PriceLessThanRadioButton.Location = new System.Drawing.Point(6, 86);
            this.PriceLessThanRadioButton.Name = "PriceLessThanRadioButton";
            this.PriceLessThanRadioButton.Size = new System.Drawing.Size(97, 23);
            this.PriceLessThanRadioButton.TabIndex = 1;
            this.PriceLessThanRadioButton.Text = "Less Than";
            this.UniversalToolTip.SetToolTip(this.PriceLessThanRadioButton, "Click to search for prices less than your entry");
            this.PriceLessThanRadioButton.UseVisualStyleBackColor = true;
            // 
            // PriceMoreThanRadioButton
            // 
            this.PriceMoreThanRadioButton.AutoSize = true;
            this.PriceMoreThanRadioButton.Checked = true;
            this.PriceMoreThanRadioButton.Location = new System.Drawing.Point(6, 25);
            this.PriceMoreThanRadioButton.Name = "PriceMoreThanRadioButton";
            this.PriceMoreThanRadioButton.Size = new System.Drawing.Size(103, 23);
            this.PriceMoreThanRadioButton.TabIndex = 0;
            this.PriceMoreThanRadioButton.TabStop = true;
            this.PriceMoreThanRadioButton.Text = "More Than";
            this.UniversalToolTip.SetToolTip(this.PriceMoreThanRadioButton, "Click to search for prices greater than your entry");
            this.PriceMoreThanRadioButton.UseVisualStyleBackColor = true;
            this.PriceMoreThanRadioButton.CheckedChanged += new System.EventHandler(this.PriceMoreThanRadioButton_CheckedChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(403, 361);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 27);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "E&xit";
            this.UniversalToolTip.SetToolTip(this.ExitButton, "Exit the program");
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(880, 400);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PriceSearchGroupBox);
            this.Controls.Add(this.QuantitySearchGroupBox);
            this.Controls.Add(this.ItemSearchGroupBox);
            this.Controls.Add(this.ProductDataGridView);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Moccasin;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlexGann-CPT-206-Lab-1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ItemSearchGroupBox.ResumeLayout(false);
            this.ItemSearchGroupBox.PerformLayout();
            this.QuantitySearchGroupBox.ResumeLayout(false);
            this.QuantitySearchGroupBox.PerformLayout();
            this.PriceSearchGroupBox.ResumeLayout(false);
            this.PriceSearchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductDataGridView;
        private ProductDBDataSet productDBDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private ProductDBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.GroupBox ItemSearchGroupBox;
        private System.Windows.Forms.ToolTip UniversalToolTip;
        private System.Windows.Forms.RadioButton SearchProductNumRadioButton;
        private System.Windows.Forms.TextBox SearchDescriptionTextBox;
        private System.Windows.Forms.TextBox SearchProductNumTextBox;
        private System.Windows.Forms.RadioButton SearchDescriptionRadioButton;
        private System.Windows.Forms.Button ItemSearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsOnHandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.GroupBox QuantitySearchGroupBox;
        private System.Windows.Forms.Button QuantitySearchButton;
        private System.Windows.Forms.TextBox QuantityLessThanTextBox;
        private System.Windows.Forms.TextBox QuantityMoreThanTextBox;
        private System.Windows.Forms.RadioButton QuantityLessThanRadioButton;
        private System.Windows.Forms.RadioButton QuantityMoreThanRadioButton;
        private System.Windows.Forms.GroupBox PriceSearchGroupBox;
        private System.Windows.Forms.Button PriceSearchButton;
        private System.Windows.Forms.TextBox PriceLessThanTextBox;
        private System.Windows.Forms.TextBox PriceMoreThanTextBox;
        private System.Windows.Forms.RadioButton PriceLessThanRadioButton;
        private System.Windows.Forms.RadioButton PriceMoreThanRadioButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

