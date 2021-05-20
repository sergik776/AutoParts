
namespace AutoParts
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TP_Clients = new System.Windows.Forms.TabPage();
            this.btn_cancel_filter = new System.Windows.Forms.Button();
            this.btn_cl_find = new System.Windows.Forms.Button();
            this.tb_cl_fam_find = new System.Windows.Forms.TextBox();
            this.DGV_Client = new System.Windows.Forms.DataGridView();
            this.TP_Auto = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_cancel_find_product = new System.Windows.Forms.Button();
            this.cb_country = new System.Windows.Forms.ComboBox();
            this.DGV_product = new System.Windows.Forms.DataGridView();
            this.TP_Country = new System.Windows.Forms.TabPage();
            this.DGV_country = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.TP_Order = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DGV_order = new System.Windows.Forms.DataGridView();
            this.DGV_checkList = new System.Windows.Forms.DataGridView();
            this.tb_orderID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cl_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_Country_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_sYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.or_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.or_ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.or_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.or_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.or_CheckLists = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.or_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.or_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_l_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_l_OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_l_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_l_ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_l_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_l_Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_l_Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_l_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.TP_Clients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Client)).BeginInit();
            this.TP_Auto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_product)).BeginInit();
            this.TP_Country.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_country)).BeginInit();
            this.TP_Order.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_checkList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.TP_Clients);
            this.tabControl1.Controls.Add(this.TP_Auto);
            this.tabControl1.Controls.Add(this.TP_Order);
            this.tabControl1.Controls.Add(this.TP_Country);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(914, 522);
            this.tabControl1.TabIndex = 0;
            // 
            // TP_Clients
            // 
            this.TP_Clients.Controls.Add(this.btn_cancel_filter);
            this.TP_Clients.Controls.Add(this.btn_cl_find);
            this.TP_Clients.Controls.Add(this.tb_cl_fam_find);
            this.TP_Clients.Controls.Add(this.DGV_Client);
            this.TP_Clients.Location = new System.Drawing.Point(4, 22);
            this.TP_Clients.Name = "TP_Clients";
            this.TP_Clients.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Clients.Size = new System.Drawing.Size(906, 496);
            this.TP_Clients.TabIndex = 0;
            this.TP_Clients.Text = "Кліенти";
            this.TP_Clients.UseVisualStyleBackColor = true;
            // 
            // btn_cancel_filter
            // 
            this.btn_cancel_filter.Location = new System.Drawing.Point(593, 4);
            this.btn_cancel_filter.Name = "btn_cancel_filter";
            this.btn_cancel_filter.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel_filter.TabIndex = 3;
            this.btn_cancel_filter.Text = "Скидання";
            this.btn_cancel_filter.UseVisualStyleBackColor = true;
            this.btn_cancel_filter.Click += new System.EventHandler(this.btn_cancel_filter_Click);
            // 
            // btn_cl_find
            // 
            this.btn_cl_find.Location = new System.Drawing.Point(512, 4);
            this.btn_cl_find.Name = "btn_cl_find";
            this.btn_cl_find.Size = new System.Drawing.Size(75, 23);
            this.btn_cl_find.TabIndex = 2;
            this.btn_cl_find.Text = "Пошук";
            this.btn_cl_find.UseVisualStyleBackColor = true;
            this.btn_cl_find.Click += new System.EventHandler(this.btn_cl_find_Click);
            // 
            // tb_cl_fam_find
            // 
            this.tb_cl_fam_find.Location = new System.Drawing.Point(106, 6);
            this.tb_cl_fam_find.Name = "tb_cl_fam_find";
            this.tb_cl_fam_find.Size = new System.Drawing.Size(96, 20);
            this.tb_cl_fam_find.TabIndex = 1;
            this.tb_cl_fam_find.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_cl_fam_find_KeyDown);
            // 
            // DGV_Client
            // 
            this.DGV_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_id,
            this.cl_Name,
            this.cl_Family,
            this.cl_LastName,
            this.cl_Phone,
            this.cl_Email});
            this.DGV_Client.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV_Client.Location = new System.Drawing.Point(3, 32);
            this.DGV_Client.Name = "DGV_Client";
            this.DGV_Client.ReadOnly = true;
            this.DGV_Client.RowHeadersVisible = false;
            this.DGV_Client.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Client.Size = new System.Drawing.Size(900, 461);
            this.DGV_Client.TabIndex = 0;
            // 
            // TP_Auto
            // 
            this.TP_Auto.Controls.Add(this.button1);
            this.TP_Auto.Controls.Add(this.btn_cancel_find_product);
            this.TP_Auto.Controls.Add(this.cb_country);
            this.TP_Auto.Controls.Add(this.DGV_product);
            this.TP_Auto.Location = new System.Drawing.Point(4, 22);
            this.TP_Auto.Name = "TP_Auto";
            this.TP_Auto.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Auto.Size = new System.Drawing.Size(906, 496);
            this.TP_Auto.TabIndex = 1;
            this.TP_Auto.Text = "Товар";
            this.TP_Auto.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Пошук";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_cancel_find_product
            // 
            this.btn_cancel_find_product.Location = new System.Drawing.Point(527, 4);
            this.btn_cancel_find_product.Name = "btn_cancel_find_product";
            this.btn_cancel_find_product.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel_find_product.TabIndex = 2;
            this.btn_cancel_find_product.Text = "Скидання";
            this.btn_cancel_find_product.UseVisualStyleBackColor = true;
            this.btn_cancel_find_product.Click += new System.EventHandler(this.btn_cancel_find_product_Click);
            // 
            // cb_country
            // 
            this.cb_country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_country.FormattingEnabled = true;
            this.cb_country.Location = new System.Drawing.Point(48, 6);
            this.cb_country.Name = "cb_country";
            this.cb_country.Size = new System.Drawing.Size(94, 21);
            this.cb_country.TabIndex = 1;
            this.cb_country.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_country_KeyDown);
            // 
            // DGV_product
            // 
            this.DGV_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pr_ID,
            this.pr_Country_ID,
            this.pr_Name,
            this.pr_Country,
            this.pr_sYear,
            this.pr_Price,
            this.pr_Count,
            this.Year});
            this.DGV_product.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV_product.Location = new System.Drawing.Point(3, 33);
            this.DGV_product.Name = "DGV_product";
            this.DGV_product.ReadOnly = true;
            this.DGV_product.RowHeadersVisible = false;
            this.DGV_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_product.Size = new System.Drawing.Size(900, 460);
            this.DGV_product.TabIndex = 0;
            // 
            // TP_Country
            // 
            this.TP_Country.Controls.Add(this.DGV_country);
            this.TP_Country.Location = new System.Drawing.Point(4, 22);
            this.TP_Country.Name = "TP_Country";
            this.TP_Country.Size = new System.Drawing.Size(906, 496);
            this.TP_Country.TabIndex = 3;
            this.TP_Country.Text = "Країни";
            this.TP_Country.UseVisualStyleBackColor = true;
            // 
            // DGV_country
            // 
            this.DGV_country.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_country.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameCountry,
            this.Products});
            this.DGV_country.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_country.Location = new System.Drawing.Point(0, 0);
            this.DGV_country.Name = "DGV_country";
            this.DGV_country.ReadOnly = true;
            this.DGV_country.RowHeadersVisible = false;
            this.DGV_country.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_country.Size = new System.Drawing.Size(906, 496);
            this.DGV_country.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Додати";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(93, 12);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 23);
            this.btn_change.TabIndex = 2;
            this.btn_change.Text = "Редагувати";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(174, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Видалити";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // TP_Order
            // 
            this.TP_Order.Controls.Add(this.cb1);
            this.TP_Order.Controls.Add(this.button3);
            this.TP_Order.Controls.Add(this.button2);
            this.TP_Order.Controls.Add(this.tb_orderID);
            this.TP_Order.Controls.Add(this.dateTimePicker1);
            this.TP_Order.Controls.Add(this.panel1);
            this.TP_Order.Location = new System.Drawing.Point(4, 22);
            this.TP_Order.Name = "TP_Order";
            this.TP_Order.Size = new System.Drawing.Size(906, 496);
            this.TP_Order.TabIndex = 4;
            this.TP_Order.Text = "Замовлення";
            this.TP_Order.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 467);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DGV_order);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DGV_checkList);
            this.splitContainer1.Size = new System.Drawing.Size(906, 467);
            this.splitContainer1.SplitterDistance = 308;
            this.splitContainer1.TabIndex = 0;
            // 
            // DGV_order
            // 
            this.DGV_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.or_ID,
            this.or_ClientID,
            this.or_Client,
            this.or_Date,
            this.or_CheckLists,
            this.or_Phone,
            this.or_Email});
            this.DGV_order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_order.Location = new System.Drawing.Point(0, 0);
            this.DGV_order.MultiSelect = false;
            this.DGV_order.Name = "DGV_order";
            this.DGV_order.ReadOnly = true;
            this.DGV_order.RowHeadersVisible = false;
            this.DGV_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_order.Size = new System.Drawing.Size(906, 308);
            this.DGV_order.TabIndex = 0;
            this.DGV_order.SelectionChanged += new System.EventHandler(this.DGV_order_SelectionChanged);
            // 
            // DGV_checkList
            // 
            this.DGV_checkList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_checkList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ch_l_ID,
            this.ch_l_OrderID,
            this.ch_l_Order,
            this.ch_l_ProductID,
            this.ch_l_Product,
            this.ch_l_Country,
            this.ch_l_Year,
            this.ch_l_Count});
            this.DGV_checkList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_checkList.Location = new System.Drawing.Point(0, 0);
            this.DGV_checkList.Name = "DGV_checkList";
            this.DGV_checkList.ReadOnly = true;
            this.DGV_checkList.RowHeadersVisible = false;
            this.DGV_checkList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_checkList.Size = new System.Drawing.Size(906, 155);
            this.DGV_checkList.TabIndex = 0;
            // 
            // tb_orderID
            // 
            this.tb_orderID.Location = new System.Drawing.Point(4, 3);
            this.tb_orderID.Name = "tb_orderID";
            this.tb_orderID.Size = new System.Drawing.Size(67, 20);
            this.tb_orderID.TabIndex = 3;
            this.tb_orderID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_orderID_KeyDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Пошук";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(387, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Скидання";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(77, 6);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(15, 14);
            this.cb1.TabIndex = 6;
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // cl_id
            // 
            this.cl_id.DataPropertyName = "ID";
            this.cl_id.HeaderText = "cl_id";
            this.cl_id.Name = "cl_id";
            this.cl_id.Visible = false;
            // 
            // cl_Name
            // 
            this.cl_Name.DataPropertyName = "Name";
            this.cl_Name.HeaderText = "Ім\'я";
            this.cl_Name.Name = "cl_Name";
            // 
            // cl_Family
            // 
            this.cl_Family.DataPropertyName = "Family";
            this.cl_Family.HeaderText = "Прізвище";
            this.cl_Family.Name = "cl_Family";
            // 
            // cl_LastName
            // 
            this.cl_LastName.DataPropertyName = "LastName";
            this.cl_LastName.HeaderText = "По батькові";
            this.cl_LastName.Name = "cl_LastName";
            // 
            // cl_Phone
            // 
            this.cl_Phone.DataPropertyName = "Phone";
            this.cl_Phone.HeaderText = "Телефон";
            this.cl_Phone.Name = "cl_Phone";
            // 
            // cl_Email
            // 
            this.cl_Email.DataPropertyName = "Email";
            this.cl_Email.HeaderText = "Эмейл";
            this.cl_Email.Name = "cl_Email";
            this.cl_Email.Width = 200;
            // 
            // pr_ID
            // 
            this.pr_ID.DataPropertyName = "ID";
            this.pr_ID.HeaderText = "ID";
            this.pr_ID.Name = "pr_ID";
            this.pr_ID.Visible = false;
            // 
            // pr_Country_ID
            // 
            this.pr_Country_ID.DataPropertyName = "CountryID";
            this.pr_Country_ID.HeaderText = "CountryID";
            this.pr_Country_ID.Name = "pr_Country_ID";
            this.pr_Country_ID.Visible = false;
            // 
            // pr_Name
            // 
            this.pr_Name.DataPropertyName = "Name";
            this.pr_Name.HeaderText = "Назва";
            this.pr_Name.Name = "pr_Name";
            // 
            // pr_Country
            // 
            this.pr_Country.DataPropertyName = "Country";
            this.pr_Country.HeaderText = "Країна";
            this.pr_Country.Name = "pr_Country";
            // 
            // pr_sYear
            // 
            this.pr_sYear.DataPropertyName = "sYear";
            this.pr_sYear.HeaderText = "Рік";
            this.pr_sYear.Name = "pr_sYear";
            // 
            // pr_Price
            // 
            this.pr_Price.DataPropertyName = "Price";
            this.pr_Price.HeaderText = "Вартість";
            this.pr_Price.Name = "pr_Price";
            // 
            // pr_Count
            // 
            this.pr_Count.DataPropertyName = "Count";
            this.pr_Count.HeaderText = "Кількість на складі";
            this.pr_Count.Name = "pr_Count";
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Рік";
            this.Year.Name = "Year";
            this.Year.Visible = false;
            // 
            // or_ID
            // 
            this.or_ID.DataPropertyName = "ID";
            this.or_ID.HeaderText = "ID";
            this.or_ID.Name = "or_ID";
            this.or_ID.ReadOnly = true;
            this.or_ID.Width = 70;
            // 
            // or_ClientID
            // 
            this.or_ClientID.DataPropertyName = "ClientID";
            this.or_ClientID.HeaderText = "ClientID";
            this.or_ClientID.Name = "or_ClientID";
            this.or_ClientID.ReadOnly = true;
            this.or_ClientID.Visible = false;
            // 
            // or_Client
            // 
            this.or_Client.DataPropertyName = "Client";
            this.or_Client.HeaderText = "Кліент";
            this.or_Client.Name = "or_Client";
            this.or_Client.ReadOnly = true;
            this.or_Client.Width = 150;
            // 
            // or_Date
            // 
            this.or_Date.DataPropertyName = "Date";
            this.or_Date.HeaderText = "Дата";
            this.or_Date.Name = "or_Date";
            this.or_Date.ReadOnly = true;
            // 
            // or_CheckLists
            // 
            this.or_CheckLists.DataPropertyName = "CheckLists";
            this.or_CheckLists.HeaderText = "Список товаров";
            this.or_CheckLists.Name = "or_CheckLists";
            this.or_CheckLists.ReadOnly = true;
            this.or_CheckLists.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.or_CheckLists.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.or_CheckLists.Visible = false;
            // 
            // or_Phone
            // 
            this.or_Phone.DataPropertyName = "Phone";
            this.or_Phone.HeaderText = "Телефон";
            this.or_Phone.Name = "or_Phone";
            this.or_Phone.ReadOnly = true;
            // 
            // or_Email
            // 
            this.or_Email.DataPropertyName = "Email";
            this.or_Email.HeaderText = "Эмейл";
            this.or_Email.Name = "or_Email";
            this.or_Email.ReadOnly = true;
            this.or_Email.Width = 200;
            // 
            // ch_l_ID
            // 
            this.ch_l_ID.DataPropertyName = "ID";
            this.ch_l_ID.HeaderText = "ID";
            this.ch_l_ID.Name = "ch_l_ID";
            this.ch_l_ID.Visible = false;
            // 
            // ch_l_OrderID
            // 
            this.ch_l_OrderID.DataPropertyName = "OrderID";
            this.ch_l_OrderID.HeaderText = "OrderID";
            this.ch_l_OrderID.Name = "ch_l_OrderID";
            this.ch_l_OrderID.Visible = false;
            // 
            // ch_l_Order
            // 
            this.ch_l_Order.DataPropertyName = "Order";
            this.ch_l_Order.HeaderText = "Order";
            this.ch_l_Order.Name = "ch_l_Order";
            this.ch_l_Order.Visible = false;
            // 
            // ch_l_ProductID
            // 
            this.ch_l_ProductID.DataPropertyName = "ProductID";
            this.ch_l_ProductID.HeaderText = "ProductID";
            this.ch_l_ProductID.Name = "ch_l_ProductID";
            this.ch_l_ProductID.Visible = false;
            // 
            // ch_l_Product
            // 
            this.ch_l_Product.DataPropertyName = "Product";
            this.ch_l_Product.HeaderText = "Товар";
            this.ch_l_Product.Name = "ch_l_Product";
            // 
            // ch_l_Country
            // 
            this.ch_l_Country.DataPropertyName = "Country";
            this.ch_l_Country.HeaderText = "Країна";
            this.ch_l_Country.Name = "ch_l_Country";
            // 
            // ch_l_Year
            // 
            this.ch_l_Year.DataPropertyName = "ProductYear";
            this.ch_l_Year.HeaderText = "Рік випуску";
            this.ch_l_Year.Name = "ch_l_Year";
            // 
            // ch_l_Count
            // 
            this.ch_l_Count.DataPropertyName = "Count";
            this.ch_l_Count.HeaderText = "Кількість";
            this.ch_l_Count.Name = "ch_l_Count";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // NameCountry
            // 
            this.NameCountry.DataPropertyName = "Name";
            this.NameCountry.HeaderText = "Назва";
            this.NameCountry.Name = "NameCountry";
            this.NameCountry.ReadOnly = true;
            // 
            // Products
            // 
            this.Products.DataPropertyName = "Products";
            this.Products.HeaderText = "Товары";
            this.Products.Name = "Products";
            this.Products.ReadOnly = true;
            this.Products.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 575);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Автотовари";
            this.tabControl1.ResumeLayout(false);
            this.TP_Clients.ResumeLayout(false);
            this.TP_Clients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Client)).EndInit();
            this.TP_Auto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_product)).EndInit();
            this.TP_Country.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_country)).EndInit();
            this.TP_Order.ResumeLayout(false);
            this.TP_Order.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_checkList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TP_Clients;
        private System.Windows.Forms.TabPage TP_Auto;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TabPage TP_Country;
        private System.Windows.Forms.DataGridView DGV_country;
        private System.Windows.Forms.DataGridView DGV_Client;
        private System.Windows.Forms.Button btn_cl_find;
        private System.Windows.Forms.TextBox tb_cl_fam_find;
        private System.Windows.Forms.Button btn_cancel_filter;
        private System.Windows.Forms.DataGridView DGV_product;
        private System.Windows.Forms.Button btn_cancel_find_product;
        private System.Windows.Forms.ComboBox cb_country;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage TP_Order;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DGV_order;
        private System.Windows.Forms.DataGridView DGV_checkList;
        private System.Windows.Forms.TextBox tb_orderID;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Family;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_Country_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_sYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn or_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn or_ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn or_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn or_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn or_CheckLists;
        private System.Windows.Forms.DataGridViewTextBoxColumn or_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn or_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_l_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_l_OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_l_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_l_ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_l_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_l_Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_l_Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_l_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Products;
    }
}

