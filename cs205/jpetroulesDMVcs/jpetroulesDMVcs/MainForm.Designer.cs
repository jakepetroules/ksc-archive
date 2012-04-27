namespace jpetroulesDMVcs
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label middle_InitialLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zIPLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label totalBookValueLabel;
            System.Windows.Forms.Label totalOtherFeesLabel;
            System.Windows.Forms.Label grandTotalLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dMVDataSet = new jpetroulesDMVcs.DMVDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new jpetroulesDMVcs.DMVDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new jpetroulesDMVcs.DMVDataSetTableAdapters.TableAdapterManager();
            this.customersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.customersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDLabel1 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middle_InitialTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zIPTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.totalBookValueMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.totalOtherFeesMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.grandTotalMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiclesTableAdapter = new jpetroulesDMVcs.DMVDataSetTableAdapters.VehiclesTableAdapter();
            this.vehiclesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptsTableAdapter = new jpetroulesDMVcs.DMVDataSetTableAdapters.ReceiptsTableAdapter();
            this.receiptsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiclesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.receiptsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
            iDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            middle_InitialLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zIPLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            totalBookValueLabel = new System.Windows.Forms.Label();
            totalOtherFeesLabel = new System.Windows.Forms.Label();
            grandTotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dMVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
            this.customersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingNavigator)).BeginInit();
            this.vehiclesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsBindingNavigator)).BeginInit();
            this.receiptsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dMVDataSet
            // 
            this.dMVDataSet.DataSetName = "DMVDataSet";
            this.dMVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.dMVDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.ReceiptsTableAdapter = this.receiptsTableAdapter;
            this.tableAdapterManager.UpdateOrder = jpetroulesDMVcs.DMVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclesTableAdapter = this.vehiclesTableAdapter;
            // 
            // customersBindingNavigator
            // 
            this.customersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customersBindingNavigator.BindingSource = this.customersBindingSource;
            this.customersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.customersBindingNavigatorSaveItem});
            this.customersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customersBindingNavigator.Name = "customersBindingNavigator";
            this.customersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customersBindingNavigator.Size = new System.Drawing.Size(832, 25);
            this.customersBindingNavigator.TabIndex = 0;
            this.customersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // customersBindingNavigatorSaveItem
            // 
            this.customersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customersBindingNavigatorSaveItem.Image")));
            this.customersBindingNavigatorSaveItem.Name = "customersBindingNavigatorSaveItem";
            this.customersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.customersBindingNavigatorSaveItem.Text = "Save Data";
            this.customersBindingNavigatorSaveItem.Click += new System.EventHandler(this.customersBindingNavigatorSaveItem_Click_1);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(7, 25);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDLabel1
            // 
            this.iDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ID", true));
            this.iDLabel1.Location = new System.Drawing.Point(105, 25);
            this.iDLabel1.Name = "iDLabel1";
            this.iDLabel1.Size = new System.Drawing.Size(100, 23);
            this.iDLabel1.TabIndex = 2;
            this.iDLabel1.Text = "label1";
            this.iDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(7, 54);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(105, 51);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // middle_InitialLabel
            // 
            middle_InitialLabel.AutoSize = true;
            middle_InitialLabel.Location = new System.Drawing.Point(7, 80);
            middle_InitialLabel.Name = "middle_InitialLabel";
            middle_InitialLabel.Size = new System.Drawing.Size(68, 13);
            middle_InitialLabel.TabIndex = 5;
            middle_InitialLabel.Text = "Middle Initial:";
            // 
            // middle_InitialTextBox
            // 
            this.middle_InitialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Middle Initial", true));
            this.middle_InitialTextBox.Location = new System.Drawing.Point(105, 77);
            this.middle_InitialTextBox.Name = "middle_InitialTextBox";
            this.middle_InitialTextBox.Size = new System.Drawing.Size(100, 20);
            this.middle_InitialTextBox.TabIndex = 6;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(7, 106);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 7;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(105, 103);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 8;
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(7, 132);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(54, 13);
            address1Label.TabIndex = 9;
            address1Label.Text = "Address1:";
            // 
            // address1TextBox
            // 
            this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address1", true));
            this.address1TextBox.Location = new System.Drawing.Point(105, 129);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(100, 20);
            this.address1TextBox.TabIndex = 10;
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Location = new System.Drawing.Point(7, 158);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(54, 13);
            address2Label.TabIndex = 11;
            address2Label.Text = "Address2:";
            // 
            // address2TextBox
            // 
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address2", true));
            this.address2TextBox.Location = new System.Drawing.Point(105, 155);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(100, 20);
            this.address2TextBox.TabIndex = 12;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(7, 184);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 13;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(105, 181);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 14;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(7, 210);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 15;
            stateLabel.Text = "State:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(105, 207);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.stateTextBox.TabIndex = 16;
            // 
            // zIPLabel
            // 
            zIPLabel.AutoSize = true;
            zIPLabel.Location = new System.Drawing.Point(7, 236);
            zIPLabel.Name = "zIPLabel";
            zIPLabel.Size = new System.Drawing.Size(27, 13);
            zIPLabel.TabIndex = 17;
            zIPLabel.Text = "ZIP:";
            // 
            // zIPTextBox
            // 
            this.zIPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ZIP", true));
            this.zIPTextBox.Location = new System.Drawing.Point(105, 233);
            this.zIPTextBox.Name = "zIPTextBox";
            this.zIPTextBox.Size = new System.Drawing.Size(100, 20);
            this.zIPTextBox.TabIndex = 18;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(7, 262);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 19;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(105, 259);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 20;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(7, 288);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 21;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(105, 285);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 22;
            // 
            // totalBookValueLabel
            // 
            totalBookValueLabel.AutoSize = true;
            totalBookValueLabel.Location = new System.Drawing.Point(7, 314);
            totalBookValueLabel.Name = "totalBookValueLabel";
            totalBookValueLabel.Size = new System.Drawing.Size(92, 13);
            totalBookValueLabel.TabIndex = 23;
            totalBookValueLabel.Text = "Total Book Value:";
            // 
            // totalBookValueMaskedTextBox
            // 
            this.totalBookValueMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "TotalBookValue", true));
            this.totalBookValueMaskedTextBox.Location = new System.Drawing.Point(105, 311);
            this.totalBookValueMaskedTextBox.Name = "totalBookValueMaskedTextBox";
            this.totalBookValueMaskedTextBox.ReadOnly = true;
            this.totalBookValueMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalBookValueMaskedTextBox.TabIndex = 24;
            // 
            // totalOtherFeesLabel
            // 
            totalOtherFeesLabel.AutoSize = true;
            totalOtherFeesLabel.Location = new System.Drawing.Point(7, 340);
            totalOtherFeesLabel.Name = "totalOtherFeesLabel";
            totalOtherFeesLabel.Size = new System.Drawing.Size(89, 13);
            totalOtherFeesLabel.TabIndex = 25;
            totalOtherFeesLabel.Text = "Total Other Fees:";
            // 
            // totalOtherFeesMaskedTextBox
            // 
            this.totalOtherFeesMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "TotalOtherFees", true));
            this.totalOtherFeesMaskedTextBox.Location = new System.Drawing.Point(105, 337);
            this.totalOtherFeesMaskedTextBox.Name = "totalOtherFeesMaskedTextBox";
            this.totalOtherFeesMaskedTextBox.ReadOnly = true;
            this.totalOtherFeesMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalOtherFeesMaskedTextBox.TabIndex = 26;
            // 
            // grandTotalLabel
            // 
            grandTotalLabel.AutoSize = true;
            grandTotalLabel.Location = new System.Drawing.Point(7, 366);
            grandTotalLabel.Name = "grandTotalLabel";
            grandTotalLabel.Size = new System.Drawing.Size(66, 13);
            grandTotalLabel.TabIndex = 27;
            grandTotalLabel.Text = "Grand Total:";
            // 
            // grandTotalMaskedTextBox
            // 
            this.grandTotalMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "GrandTotal", true));
            this.grandTotalMaskedTextBox.Location = new System.Drawing.Point(105, 363);
            this.grandTotalMaskedTextBox.Name = "grandTotalMaskedTextBox";
            this.grandTotalMaskedTextBox.ReadOnly = true;
            this.grandTotalMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.grandTotalMaskedTextBox.TabIndex = 28;
            // 
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataMember = "VEHICLES_CUSTOMERS_FK";
            this.vehiclesBindingSource.DataSource = this.customersBindingSource;
            // 
            // vehiclesTableAdapter
            // 
            this.vehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // vehiclesDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.vehiclesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.vehiclesDataGridView.AutoGenerateColumns = false;
            this.vehiclesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiclesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.vehiclesDataGridView.DataSource = this.vehiclesBindingSource;
            this.vehiclesDataGridView.Location = new System.Drawing.Point(211, 51);
            this.vehiclesDataGridView.Name = "vehiclesDataGridView";
            this.vehiclesDataGridView.Size = new System.Drawing.Size(601, 173);
            this.vehiclesDataGridView.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn2.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Make";
            this.dataGridViewTextBoxColumn4.HeaderText = "Make";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn5.HeaderText = "Model";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn6.HeaderText = "Year";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn7.HeaderText = "Color";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "VIN";
            this.dataGridViewTextBoxColumn8.HeaderText = "VIN";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "GVW";
            this.dataGridViewTextBoxColumn9.HeaderText = "GVW";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PlateNumber";
            this.dataGridViewTextBoxColumn10.HeaderText = "PlateNumber";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // receiptsBindingSource
            // 
            this.receiptsBindingSource.DataMember = "RECEIPTS_VEHICLES_FK";
            this.receiptsBindingSource.DataSource = this.vehiclesBindingSource;
            // 
            // receiptsTableAdapter
            // 
            this.receiptsTableAdapter.ClearBeforeFill = true;
            // 
            // receiptsDataGridView
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.receiptsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.receiptsDataGridView.AutoGenerateColumns = false;
            this.receiptsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receiptsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.receiptsDataGridView.DataSource = this.receiptsBindingSource;
            this.receiptsDataGridView.Location = new System.Drawing.Point(211, 256);
            this.receiptsDataGridView.Name = "receiptsDataGridView";
            this.receiptsDataGridView.Size = new System.Drawing.Size(601, 176);
            this.receiptsDataGridView.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn11.HeaderText = "ID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "BookValue";
            this.dataGridViewTextBoxColumn12.HeaderText = "BookValue";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "VanityFee";
            this.dataGridViewTextBoxColumn13.HeaderText = "VanityFee";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "OtherFees";
            this.dataGridViewTextBoxColumn14.HeaderText = "OtherFees";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "RegistrationFee";
            this.dataGridViewTextBoxColumn15.HeaderText = "RegistrationFee";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn16.HeaderText = "Total";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "VehicleID";
            this.dataGridViewTextBoxColumn17.HeaderText = "VehicleID";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // vehiclesBindingNavigator
            // 
            this.vehiclesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.vehiclesBindingNavigator.BindingSource = this.vehiclesBindingSource;
            this.vehiclesBindingNavigator.CountItem = this.bindingNavigatorCountItem1;
            this.vehiclesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.vehiclesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.vehiclesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.vehiclesBindingNavigator.Location = new System.Drawing.Point(211, 23);
            this.vehiclesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.vehiclesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.vehiclesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.vehiclesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.vehiclesBindingNavigator.Name = "vehiclesBindingNavigator";
            this.vehiclesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem1;
            this.vehiclesBindingNavigator.Size = new System.Drawing.Size(255, 25);
            this.vehiclesBindingNavigator.TabIndex = 31;
            this.vehiclesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            // 
            // receiptsBindingNavigator
            // 
            this.receiptsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem2;
            this.receiptsBindingNavigator.BindingSource = this.receiptsBindingSource;
            this.receiptsBindingNavigator.CountItem = this.bindingNavigatorCountItem2;
            this.receiptsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem2;
            this.receiptsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.receiptsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.bindingNavigatorAddNewItem2,
            this.bindingNavigatorDeleteItem2});
            this.receiptsBindingNavigator.Location = new System.Drawing.Point(211, 228);
            this.receiptsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.receiptsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.receiptsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.receiptsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.receiptsBindingNavigator.Name = "receiptsBindingNavigator";
            this.receiptsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem2;
            this.receiptsBindingNavigator.Size = new System.Drawing.Size(255, 25);
            this.receiptsBindingNavigator.TabIndex = 32;
            this.receiptsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem2
            // 
            this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
            this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem2.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem2
            // 
            this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
            this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem2.Text = "Move previous";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem2
            // 
            this.bindingNavigatorPositionItem2.AccessibleName = "Position";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem2.Text = "of {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem2
            // 
            this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
            this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem2.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem2
            // 
            this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
            this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem2.Text = "Move last";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem2
            // 
            this.bindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem2.Image")));
            this.bindingNavigatorAddNewItem2.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem2.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem2
            // 
            this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem2.Image")));
            this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem2.Text = "Delete";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.receiptsBindingNavigator);
            this.Controls.Add(this.vehiclesBindingNavigator);
            this.Controls.Add(this.receiptsDataGridView);
            this.Controls.Add(this.vehiclesDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDLabel1);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(middle_InitialLabel);
            this.Controls.Add(this.middle_InitialTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(address2Label);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(zIPLabel);
            this.Controls.Add(this.zIPTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(totalBookValueLabel);
            this.Controls.Add(this.totalBookValueMaskedTextBox);
            this.Controls.Add(totalOtherFeesLabel);
            this.Controls.Add(this.totalOtherFeesMaskedTextBox);
            this.Controls.Add(grandTotalLabel);
            this.Controls.Add(this.grandTotalMaskedTextBox);
            this.Controls.Add(this.customersBindingNavigator);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DMV";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dMVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
            this.customersBindingNavigator.ResumeLayout(false);
            this.customersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingNavigator)).EndInit();
            this.vehiclesBindingNavigator.ResumeLayout(false);
            this.vehiclesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsBindingNavigator)).EndInit();
            this.receiptsBindingNavigator.ResumeLayout(false);
            this.receiptsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DMVDataSet dMVDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private DMVDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private DMVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton customersBindingNavigatorSaveItem;
        private DMVDataSetTableAdapters.VehiclesTableAdapter vehiclesTableAdapter;
        private System.Windows.Forms.Label iDLabel1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middle_InitialTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zIPTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.MaskedTextBox totalBookValueMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox totalOtherFeesMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox grandTotalMaskedTextBox;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private DMVDataSetTableAdapters.ReceiptsTableAdapter receiptsTableAdapter;
        private System.Windows.Forms.DataGridView vehiclesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource receiptsBindingSource;
        private System.Windows.Forms.DataGridView receiptsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.BindingNavigator vehiclesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.BindingNavigator receiptsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;



    }
}

