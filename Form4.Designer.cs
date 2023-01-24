namespace Student_Menagment
{
    partial class Form4
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
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label phone_NumberLabel;
            System.Windows.Forms.Label iD_Card_NumberLabel;
            System.Windows.Forms.Label material_StatusLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label religionLabel;
            System.Windows.Forms.Label nationalityLabel;
            System.Windows.Forms.Label email_AddressLabel;
            System.Windows.Forms.Label father_NameLabel;
            System.Windows.Forms.Label father_Phone_numberLabel;
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label father_ID_Card_NumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_InfoDataSet = new Student_Menagment.Student_InfoDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.phone_NumberTextBox = new System.Windows.Forms.TextBox();
            this.iD_Card_NumberTextBox = new System.Windows.Forms.TextBox();
            this.material_StatusTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.religionTextBox = new System.Windows.Forms.TextBox();
            this.nationalityTextBox = new System.Windows.Forms.TextBox();
            this.email_AddressTextBox = new System.Windows.Forms.TextBox();
            this.father_NameTextBox = new System.Windows.Forms.TextBox();
            this.father_Phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.father_ID_Card_NumberTextBox = new System.Windows.Forms.TextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.tableTableAdapter = new Student_Menagment.Student_InfoDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Student_Menagment.Student_InfoDataSetTableAdapters.TableAdapterManager();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            phone_NumberLabel = new System.Windows.Forms.Label();
            iD_Card_NumberLabel = new System.Windows.Forms.Label();
            material_StatusLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            religionLabel = new System.Windows.Forms.Label();
            nationalityLabel = new System.Windows.Forms.Label();
            email_AddressLabel = new System.Windows.Forms.Label();
            father_NameLabel = new System.Windows.Forms.Label();
            father_Phone_numberLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            father_ID_Card_NumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_InfoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(38, 180);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(75, 16);
            first_NameLabel.TabIndex = 3;
            first_NameLabel.Text = "First Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(591, 183);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(75, 16);
            last_NameLabel.TabIndex = 5;
            last_NameLabel.Text = "Last Name:";
            // 
            // phone_NumberLabel
            // 
            phone_NumberLabel.AutoSize = true;
            phone_NumberLabel.Location = new System.Drawing.Point(38, 237);
            phone_NumberLabel.Name = "phone_NumberLabel";
            phone_NumberLabel.Size = new System.Drawing.Size(99, 16);
            phone_NumberLabel.TabIndex = 7;
            phone_NumberLabel.Text = "phone Number:";
            // 
            // iD_Card_NumberLabel
            // 
            iD_Card_NumberLabel.AutoSize = true;
            iD_Card_NumberLabel.Location = new System.Drawing.Point(591, 240);
            iD_Card_NumberLabel.Name = "iD_Card_NumberLabel";
            iD_Card_NumberLabel.Size = new System.Drawing.Size(106, 16);
            iD_Card_NumberLabel.TabIndex = 9;
            iD_Card_NumberLabel.Text = "ID Card Number:";
            // 
            // material_StatusLabel
            // 
            material_StatusLabel.AutoSize = true;
            material_StatusLabel.Location = new System.Drawing.Point(38, 287);
            material_StatusLabel.Name = "material_StatusLabel";
            material_StatusLabel.Size = new System.Drawing.Size(98, 16);
            material_StatusLabel.TabIndex = 11;
            material_StatusLabel.Text = "Material Status:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(591, 290);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(55, 16);
            genderLabel.TabIndex = 13;
            genderLabel.Text = "Gender:";
            // 
            // religionLabel
            // 
            religionLabel.AutoSize = true;
            religionLabel.Location = new System.Drawing.Point(38, 354);
            religionLabel.Name = "religionLabel";
            religionLabel.Size = new System.Drawing.Size(60, 16);
            religionLabel.TabIndex = 15;
            religionLabel.Text = "Religion:";
            // 
            // nationalityLabel
            // 
            nationalityLabel.AutoSize = true;
            nationalityLabel.Location = new System.Drawing.Point(591, 357);
            nationalityLabel.Name = "nationalityLabel";
            nationalityLabel.Size = new System.Drawing.Size(73, 16);
            nationalityLabel.TabIndex = 17;
            nationalityLabel.Text = "Nationality:";
            // 
            // email_AddressLabel
            // 
            email_AddressLabel.AutoSize = true;
            email_AddressLabel.Location = new System.Drawing.Point(38, 415);
            email_AddressLabel.Name = "email_AddressLabel";
            email_AddressLabel.Size = new System.Drawing.Size(98, 16);
            email_AddressLabel.TabIndex = 19;
            email_AddressLabel.Text = "Email Address:";
            // 
            // father_NameLabel
            // 
            father_NameLabel.AutoSize = true;
            father_NameLabel.Location = new System.Drawing.Point(591, 500);
            father_NameLabel.Name = "father_NameLabel";
            father_NameLabel.Size = new System.Drawing.Size(88, 16);
            father_NameLabel.TabIndex = 21;
            father_NameLabel.Text = "Father Name:";
            // 
            // father_Phone_numberLabel
            // 
            father_Phone_numberLabel.AutoSize = true;
            father_Phone_numberLabel.Location = new System.Drawing.Point(38, 503);
            father_Phone_numberLabel.Name = "father_Phone_numberLabel";
            father_Phone_numberLabel.Size = new System.Drawing.Size(138, 16);
            father_Phone_numberLabel.TabIndex = 23;
            father_Phone_numberLabel.Text = "Father Phone number:";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(597, 557);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(49, 16);
            salaryLabel.TabIndex = 25;
            salaryLabel.Text = "Salary:";
            // 
            // father_ID_Card_NumberLabel
            // 
            father_ID_Card_NumberLabel.AutoSize = true;
            father_ID_Card_NumberLabel.Location = new System.Drawing.Point(38, 560);
            father_ID_Card_NumberLabel.Name = "father_ID_Card_NumberLabel";
            father_ID_Card_NumberLabel.Size = new System.Drawing.Size(147, 16);
            father_ID_Card_NumberLabel.TabIndex = 27;
            father_ID_Card_NumberLabel.Text = "Father ID Card Number:";
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableBindingNavigator.BindingSource = this.tableBindingSource;
            this.tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tableBindingNavigatorSaveItem});
            this.tableBindingNavigator.Location = new System.Drawing.Point(3, 64);
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableBindingNavigator.Size = new System.Drawing.Size(1028, 31);
            this.tableBindingNavigator.TabIndex = 0;
            this.tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.student_InfoDataSet;
            // 
            // student_InfoDataSet
            // 
            this.student_InfoDataSet.DataSetName = "Student_InfoDataSet";
            this.student_InfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingNavigatorSaveItem.Image")));
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.tableBindingNavigatorSaveItem.Text = "Save Data";
            this.tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBindingNavigatorSaveItem_Click);
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "First_Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(191, 177);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(356, 22);
            this.first_NameTextBox.TabIndex = 4;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Last_Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(715, 180);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(259, 22);
            this.last_NameTextBox.TabIndex = 6;
            // 
            // phone_NumberTextBox
            // 
            this.phone_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "phone_Number", true));
            this.phone_NumberTextBox.Location = new System.Drawing.Point(191, 234);
            this.phone_NumberTextBox.Name = "phone_NumberTextBox";
            this.phone_NumberTextBox.Size = new System.Drawing.Size(356, 22);
            this.phone_NumberTextBox.TabIndex = 8;
            // 
            // iD_Card_NumberTextBox
            // 
            this.iD_Card_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "ID_Card_Number", true));
            this.iD_Card_NumberTextBox.Location = new System.Drawing.Point(715, 234);
            this.iD_Card_NumberTextBox.Name = "iD_Card_NumberTextBox";
            this.iD_Card_NumberTextBox.Size = new System.Drawing.Size(259, 22);
            this.iD_Card_NumberTextBox.TabIndex = 10;
            // 
            // material_StatusTextBox
            // 
            this.material_StatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Material_Status", true));
            this.material_StatusTextBox.Location = new System.Drawing.Point(191, 284);
            this.material_StatusTextBox.Name = "material_StatusTextBox";
            this.material_StatusTextBox.Size = new System.Drawing.Size(356, 22);
            this.material_StatusTextBox.TabIndex = 12;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(715, 287);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(259, 22);
            this.genderTextBox.TabIndex = 14;
            // 
            // religionTextBox
            // 
            this.religionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Religion", true));
            this.religionTextBox.Location = new System.Drawing.Point(191, 351);
            this.religionTextBox.Name = "religionTextBox";
            this.religionTextBox.Size = new System.Drawing.Size(356, 22);
            this.religionTextBox.TabIndex = 16;
            // 
            // nationalityTextBox
            // 
            this.nationalityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Nationality", true));
            this.nationalityTextBox.Location = new System.Drawing.Point(715, 357);
            this.nationalityTextBox.Name = "nationalityTextBox";
            this.nationalityTextBox.Size = new System.Drawing.Size(259, 22);
            this.nationalityTextBox.TabIndex = 18;
            // 
            // email_AddressTextBox
            // 
            this.email_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Email_Address", true));
            this.email_AddressTextBox.Location = new System.Drawing.Point(191, 412);
            this.email_AddressTextBox.Name = "email_AddressTextBox";
            this.email_AddressTextBox.Size = new System.Drawing.Size(356, 22);
            this.email_AddressTextBox.TabIndex = 20;
            // 
            // father_NameTextBox
            // 
            this.father_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Father_Name", true));
            this.father_NameTextBox.Location = new System.Drawing.Point(725, 497);
            this.father_NameTextBox.Name = "father_NameTextBox";
            this.father_NameTextBox.Size = new System.Drawing.Size(259, 22);
            this.father_NameTextBox.TabIndex = 22;
            // 
            // father_Phone_numberTextBox
            // 
            this.father_Phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Father_Phone_number", true));
            this.father_Phone_numberTextBox.Location = new System.Drawing.Point(191, 500);
            this.father_Phone_numberTextBox.Name = "father_Phone_numberTextBox";
            this.father_Phone_numberTextBox.Size = new System.Drawing.Size(356, 22);
            this.father_Phone_numberTextBox.TabIndex = 24;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Salary", true));
            this.salaryTextBox.Location = new System.Drawing.Point(725, 554);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(259, 22);
            this.salaryTextBox.TabIndex = 26;
            // 
            // father_ID_Card_NumberTextBox
            // 
            this.father_ID_Card_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Father_ID_Card_Number", true));
            this.father_ID_Card_NumberTextBox.Location = new System.Drawing.Point(191, 557);
            this.father_ID_Card_NumberTextBox.Name = "father_ID_Card_NumberTextBox";
            this.father_ID_Card_NumberTextBox.Size = new System.Drawing.Size(356, 22);
            this.father_ID_Card_NumberTextBox.TabIndex = 28;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(489, 666);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(93, 36);
            this.materialButton1.TabIndex = 29;
            this.materialButton1.Text = "Sumitted";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Student_Menagment.Student_InfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 771);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(phone_NumberLabel);
            this.Controls.Add(this.phone_NumberTextBox);
            this.Controls.Add(iD_Card_NumberLabel);
            this.Controls.Add(this.iD_Card_NumberTextBox);
            this.Controls.Add(material_StatusLabel);
            this.Controls.Add(this.material_StatusTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(religionLabel);
            this.Controls.Add(this.religionTextBox);
            this.Controls.Add(nationalityLabel);
            this.Controls.Add(this.nationalityTextBox);
            this.Controls.Add(email_AddressLabel);
            this.Controls.Add(this.email_AddressTextBox);
            this.Controls.Add(father_NameLabel);
            this.Controls.Add(this.father_NameTextBox);
            this.Controls.Add(father_Phone_numberLabel);
            this.Controls.Add(this.father_Phone_numberTextBox);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(father_ID_Card_NumberLabel);
            this.Controls.Add(this.father_ID_Card_NumberTextBox);
            this.Controls.Add(this.tableBindingNavigator);
            this.Name = "Form4";
            this.Text = "Admission Form";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_InfoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Student_InfoDataSet student_InfoDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Student_InfoDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private Student_InfoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox phone_NumberTextBox;
        private System.Windows.Forms.TextBox iD_Card_NumberTextBox;
        private System.Windows.Forms.TextBox material_StatusTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox religionTextBox;
        private System.Windows.Forms.TextBox nationalityTextBox;
        private System.Windows.Forms.TextBox email_AddressTextBox;
        private System.Windows.Forms.TextBox father_NameTextBox;
        private System.Windows.Forms.TextBox father_Phone_numberTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox father_ID_Card_NumberTextBox;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}