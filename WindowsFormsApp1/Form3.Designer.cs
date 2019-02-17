namespace WindowsFormsApp1
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddMarka = new MetroFramework.Controls.MetroButton();
            this.btnAddModel = new MetroFramework.Controls.MetroButton();
            this.btnAddCategory = new MetroFramework.Controls.MetroButton();
            this.Panel_1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddSubCategory = new MetroFramework.Controls.MetroButton();
            this.btnAddEngine = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackToAddPanel = new MetroFramework.Controls.MetroButton();
            this.addMarkaPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveMark = new MetroFramework.Controls.MetroButton();
            this.addMarkTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addModelPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cmbMarka = new MetroFramework.Controls.MetroComboBox();
            this.addModelTextBox = new MetroFramework.Controls.MetroTextBox();
            this.addOtTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveModel = new MetroFramework.Controls.MetroButton();
            this.addDoTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addCategoryPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveCategory = new MetroFramework.Controls.MetroButton();
            this.addCategoryTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addSubCategoryPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cmbCategory = new MetroFramework.Controls.MetroComboBox();
            this.addSubCategoryTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSaveSubCategory = new MetroFramework.Controls.MetroButton();
            this.label9 = new System.Windows.Forms.Label();
            this.addEnginePanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveEngine = new MetroFramework.Controls.MetroButton();
            this.addEngineTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AddPage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelUpdateDB = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdateMarka = new MetroFramework.Controls.MetroButton();
            this.btnUpdateModel = new MetroFramework.Controls.MetroButton();
            this.btnUpdateCategory = new MetroFramework.Controls.MetroButton();
            this.btnUpdateSubCategory = new MetroFramework.Controls.MetroButton();
            this.btnUpdateEngine = new MetroFramework.Controls.MetroButton();
            this.metroGridUpdateDB = new MetroFramework.Controls.MetroGrid();
            this.ForDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изтриванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.label11 = new System.Windows.Forms.Label();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.Panel_1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.addMarkaPanel.SuspendLayout();
            this.addModelPanel.SuspendLayout();
            this.addCategoryPanel.SuspendLayout();
            this.addSubCategoryPanel.SuspendLayout();
            this.addEnginePanel.SuspendLayout();
            this.AddPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelUpdateDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridUpdateDB)).BeginInit();
            this.ForDelete.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddMarka
            // 
            this.btnAddMarka.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAddMarka.Location = new System.Drawing.Point(3, 3);
            this.btnAddMarka.Name = "btnAddMarka";
            this.btnAddMarka.Size = new System.Drawing.Size(160, 55);
            this.btnAddMarka.TabIndex = 1;
            this.btnAddMarka.Text = "Марка";
            this.btnAddMarka.UseSelectable = true;
            this.btnAddMarka.Click += new System.EventHandler(this.btnAddMarka_Click);
            // 
            // btnAddModel
            // 
            this.btnAddModel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAddModel.Location = new System.Drawing.Point(221, 3);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(160, 55);
            this.btnAddModel.TabIndex = 2;
            this.btnAddModel.Text = "Модел";
            this.btnAddModel.UseSelectable = true;
            this.btnAddModel.Click += new System.EventHandler(this.btnAddModel_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAddCategory.Location = new System.Drawing.Point(3, 88);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(160, 55);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Категория";
            this.btnAddCategory.UseSelectable = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // Panel_1
            // 
            this.Panel_1.ColumnCount = 2;
            this.Panel_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Panel_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Panel_1.Controls.Add(this.btnAddMarka, 0, 0);
            this.Panel_1.Controls.Add(this.btnAddModel, 1, 0);
            this.Panel_1.Controls.Add(this.btnAddCategory, 0, 1);
            this.Panel_1.Controls.Add(this.btnAddSubCategory, 1, 1);
            this.Panel_1.Controls.Add(this.btnAddEngine, 0, 2);
            this.Panel_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Panel_1.Location = new System.Drawing.Point(6, 43);
            this.Panel_1.Name = "Panel_1";
            this.Panel_1.RowCount = 3;
            this.Panel_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Panel_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Panel_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Panel_1.Size = new System.Drawing.Size(436, 257);
            this.Panel_1.TabIndex = 3;
            // 
            // btnAddSubCategory
            // 
            this.btnAddSubCategory.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAddSubCategory.Location = new System.Drawing.Point(221, 88);
            this.btnAddSubCategory.Name = "btnAddSubCategory";
            this.btnAddSubCategory.Size = new System.Drawing.Size(160, 55);
            this.btnAddSubCategory.TabIndex = 3;
            this.btnAddSubCategory.Text = "Подкатегория";
            this.btnAddSubCategory.UseSelectable = true;
            this.btnAddSubCategory.Click += new System.EventHandler(this.btnAddSubCategory_Click);
            // 
            // btnAddEngine
            // 
            this.btnAddEngine.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAddEngine.Location = new System.Drawing.Point(3, 173);
            this.btnAddEngine.Name = "btnAddEngine";
            this.btnAddEngine.Size = new System.Drawing.Size(160, 55);
            this.btnAddEngine.TabIndex = 4;
            this.btnAddEngine.Text = "Двигател";
            this.btnAddEngine.UseSelectable = true;
            this.btnAddEngine.Click += new System.EventHandler(this.btnAddEngine_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(104, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(841, 31);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(835, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добави";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBackToAddPanel
            // 
            this.btnBackToAddPanel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBackToAddPanel.Location = new System.Drawing.Point(452, 43);
            this.btnBackToAddPanel.Name = "btnBackToAddPanel";
            this.btnBackToAddPanel.Size = new System.Drawing.Size(160, 43);
            this.btnBackToAddPanel.TabIndex = 0;
            this.btnBackToAddPanel.Text = "Назад";
            this.btnBackToAddPanel.UseSelectable = true;
            this.btnBackToAddPanel.Visible = false;
            this.btnBackToAddPanel.Click += new System.EventHandler(this.btnBackToAddPanel_Click);
            // 
            // addMarkaPanel
            // 
            this.addMarkaPanel.ColumnCount = 2;
            this.addMarkaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.addMarkaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addMarkaPanel.Controls.Add(this.btnSaveMark, 1, 1);
            this.addMarkaPanel.Controls.Add(this.addMarkTextBox, 1, 0);
            this.addMarkaPanel.Controls.Add(this.label6, 0, 0);
            this.addMarkaPanel.Location = new System.Drawing.Point(6, 307);
            this.addMarkaPanel.Name = "addMarkaPanel";
            this.addMarkaPanel.RowCount = 2;
            this.addMarkaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addMarkaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addMarkaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.addMarkaPanel.Size = new System.Drawing.Size(433, 103);
            this.addMarkaPanel.TabIndex = 5;
            this.addMarkaPanel.Visible = false;
            // 
            // btnSaveMark
            // 
            this.btnSaveMark.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveMark.Location = new System.Drawing.Point(177, 54);
            this.btnSaveMark.Name = "btnSaveMark";
            this.btnSaveMark.Size = new System.Drawing.Size(160, 46);
            this.btnSaveMark.TabIndex = 2;
            this.btnSaveMark.Text = "Запиши";
            this.btnSaveMark.UseSelectable = true;
            this.btnSaveMark.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // addMarkTextBox
            // 
            this.addMarkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addMarkTextBox.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.addMarkTextBox.CustomButton.Image = null;
            this.addMarkTextBox.CustomButton.Location = new System.Drawing.Point(314, 1);
            this.addMarkTextBox.CustomButton.Name = "";
            this.addMarkTextBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.addMarkTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.addMarkTextBox.CustomButton.TabIndex = 1;
            this.addMarkTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.addMarkTextBox.CustomButton.UseSelectable = true;
            this.addMarkTextBox.CustomButton.Visible = false;
            this.addMarkTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.addMarkTextBox.Lines = new string[0];
            this.addMarkTextBox.Location = new System.Drawing.Point(84, 9);
            this.addMarkTextBox.MaxLength = 32767;
            this.addMarkTextBox.Name = "addMarkTextBox";
            this.addMarkTextBox.PasswordChar = '\0';
            this.addMarkTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addMarkTextBox.SelectedText = "";
            this.addMarkTextBox.SelectionLength = 0;
            this.addMarkTextBox.SelectionStart = 0;
            this.addMarkTextBox.ShortcutsEnabled = true;
            this.addMarkTextBox.Size = new System.Drawing.Size(346, 33);
            this.addMarkTextBox.TabIndex = 1;
            this.addMarkTextBox.UseSelectable = true;
            this.addMarkTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.addMarkTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Марка";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addModelPanel
            // 
            this.addModelPanel.ColumnCount = 2;
            this.addModelPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.addModelPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addModelPanel.Controls.Add(this.cmbMarka, 1, 0);
            this.addModelPanel.Controls.Add(this.addModelTextBox, 1, 1);
            this.addModelPanel.Controls.Add(this.addOtTextBox, 1, 2);
            this.addModelPanel.Controls.Add(this.label3, 0, 1);
            this.addModelPanel.Controls.Add(this.label4, 0, 2);
            this.addModelPanel.Controls.Add(this.btnSaveModel, 1, 4);
            this.addModelPanel.Controls.Add(this.addDoTextBox, 1, 3);
            this.addModelPanel.Controls.Add(this.label5, 0, 3);
            this.addModelPanel.Controls.Add(this.label2, 0, 0);
            this.addModelPanel.Location = new System.Drawing.Point(6, 416);
            this.addModelPanel.Name = "addModelPanel";
            this.addModelPanel.RowCount = 5;
            this.addModelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.addModelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.addModelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.addModelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.addModelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.addModelPanel.Size = new System.Drawing.Size(433, 263);
            this.addModelPanel.TabIndex = 6;
            this.addModelPanel.Visible = false;
            // 
            // cmbMarka
            // 
            this.cmbMarka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMarka.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.ItemHeight = 29;
            this.cmbMarka.Location = new System.Drawing.Point(98, 8);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(332, 35);
            this.cmbMarka.TabIndex = 0;
            this.cmbMarka.UseSelectable = true;
            // 
            // addModelTextBox
            // 
            this.addModelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addModelTextBox.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.addModelTextBox.CustomButton.Image = null;
            this.addModelTextBox.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.addModelTextBox.CustomButton.Name = "";
            this.addModelTextBox.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.addModelTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.addModelTextBox.CustomButton.TabIndex = 1;
            this.addModelTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.addModelTextBox.CustomButton.UseSelectable = true;
            this.addModelTextBox.CustomButton.Visible = false;
            this.addModelTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.addModelTextBox.Lines = new string[0];
            this.addModelTextBox.Location = new System.Drawing.Point(98, 62);
            this.addModelTextBox.MaxLength = 32767;
            this.addModelTextBox.Name = "addModelTextBox";
            this.addModelTextBox.PasswordChar = '\0';
            this.addModelTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addModelTextBox.SelectedText = "";
            this.addModelTextBox.SelectionLength = 0;
            this.addModelTextBox.SelectionStart = 0;
            this.addModelTextBox.ShortcutsEnabled = true;
            this.addModelTextBox.Size = new System.Drawing.Size(332, 31);
            this.addModelTextBox.TabIndex = 1;
            this.addModelTextBox.UseSelectable = true;
            this.addModelTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.addModelTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addOtTextBox
            // 
            this.addOtTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addOtTextBox.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.addOtTextBox.CustomButton.Image = null;
            this.addOtTextBox.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.addOtTextBox.CustomButton.Name = "";
            this.addOtTextBox.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.addOtTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.addOtTextBox.CustomButton.TabIndex = 1;
            this.addOtTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.addOtTextBox.CustomButton.UseSelectable = true;
            this.addOtTextBox.CustomButton.Visible = false;
            this.addOtTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.addOtTextBox.Lines = new string[0];
            this.addOtTextBox.Location = new System.Drawing.Point(98, 114);
            this.addOtTextBox.MaxLength = 32767;
            this.addOtTextBox.Name = "addOtTextBox";
            this.addOtTextBox.PasswordChar = '\0';
            this.addOtTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addOtTextBox.SelectedText = "";
            this.addOtTextBox.SelectionLength = 0;
            this.addOtTextBox.SelectionStart = 0;
            this.addOtTextBox.ShortcutsEnabled = true;
            this.addOtTextBox.Size = new System.Drawing.Size(332, 31);
            this.addOtTextBox.TabIndex = 2;
            this.addOtTextBox.UseSelectable = true;
            this.addOtTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.addOtTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Модел";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "От";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveModel
            // 
            this.btnSaveModel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveModel.Location = new System.Drawing.Point(184, 211);
            this.btnSaveModel.Name = "btnSaveModel";
            this.btnSaveModel.Size = new System.Drawing.Size(160, 46);
            this.btnSaveModel.TabIndex = 4;
            this.btnSaveModel.Text = "Запиши";
            this.btnSaveModel.UseSelectable = true;
            this.btnSaveModel.Click += new System.EventHandler(this.btnSaveModel_Click);
            // 
            // addDoTextBox
            // 
            this.addDoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addDoTextBox.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.addDoTextBox.CustomButton.Image = null;
            this.addDoTextBox.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.addDoTextBox.CustomButton.Name = "";
            this.addDoTextBox.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.addDoTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.addDoTextBox.CustomButton.TabIndex = 1;
            this.addDoTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.addDoTextBox.CustomButton.UseSelectable = true;
            this.addDoTextBox.CustomButton.Visible = false;
            this.addDoTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.addDoTextBox.Lines = new string[0];
            this.addDoTextBox.Location = new System.Drawing.Point(98, 166);
            this.addDoTextBox.MaxLength = 32767;
            this.addDoTextBox.Name = "addDoTextBox";
            this.addDoTextBox.PasswordChar = '\0';
            this.addDoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addDoTextBox.SelectedText = "";
            this.addDoTextBox.SelectionLength = 0;
            this.addDoTextBox.SelectionStart = 0;
            this.addDoTextBox.ShortcutsEnabled = true;
            this.addDoTextBox.Size = new System.Drawing.Size(332, 31);
            this.addDoTextBox.TabIndex = 3;
            this.addDoTextBox.UseSelectable = true;
            this.addDoTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.addDoTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "До";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Марка";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addCategoryPanel
            // 
            this.addCategoryPanel.ColumnCount = 2;
            this.addCategoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.addCategoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addCategoryPanel.Controls.Add(this.btnSaveCategory, 1, 1);
            this.addCategoryPanel.Controls.Add(this.addCategoryTextBox, 1, 0);
            this.addCategoryPanel.Controls.Add(this.label7, 0, 0);
            this.addCategoryPanel.Location = new System.Drawing.Point(445, 416);
            this.addCategoryPanel.Name = "addCategoryPanel";
            this.addCategoryPanel.RowCount = 2;
            this.addCategoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addCategoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addCategoryPanel.Size = new System.Drawing.Size(433, 103);
            this.addCategoryPanel.TabIndex = 7;
            this.addCategoryPanel.Visible = false;
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveCategory.Location = new System.Drawing.Point(198, 54);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(160, 46);
            this.btnSaveCategory.TabIndex = 1;
            this.btnSaveCategory.Text = "Запиши";
            this.btnSaveCategory.UseSelectable = true;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // addCategoryTextBox
            // 
            this.addCategoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addCategoryTextBox.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.addCategoryTextBox.CustomButton.Image = null;
            this.addCategoryTextBox.CustomButton.Location = new System.Drawing.Point(272, 1);
            this.addCategoryTextBox.CustomButton.Name = "";
            this.addCategoryTextBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.addCategoryTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.addCategoryTextBox.CustomButton.TabIndex = 1;
            this.addCategoryTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.addCategoryTextBox.CustomButton.UseSelectable = true;
            this.addCategoryTextBox.CustomButton.Visible = false;
            this.addCategoryTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.addCategoryTextBox.Lines = new string[0];
            this.addCategoryTextBox.Location = new System.Drawing.Point(126, 9);
            this.addCategoryTextBox.MaxLength = 32767;
            this.addCategoryTextBox.Name = "addCategoryTextBox";
            this.addCategoryTextBox.PasswordChar = '\0';
            this.addCategoryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addCategoryTextBox.SelectedText = "";
            this.addCategoryTextBox.SelectionLength = 0;
            this.addCategoryTextBox.SelectionStart = 0;
            this.addCategoryTextBox.ShortcutsEnabled = true;
            this.addCategoryTextBox.Size = new System.Drawing.Size(304, 33);
            this.addCategoryTextBox.TabIndex = 2;
            this.addCategoryTextBox.UseSelectable = true;
            this.addCategoryTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.addCategoryTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Категория";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addSubCategoryPanel
            // 
            this.addSubCategoryPanel.ColumnCount = 2;
            this.addSubCategoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.addSubCategoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addSubCategoryPanel.Controls.Add(this.cmbCategory, 1, 0);
            this.addSubCategoryPanel.Controls.Add(this.addSubCategoryTextBox, 1, 1);
            this.addSubCategoryPanel.Controls.Add(this.label8, 0, 1);
            this.addSubCategoryPanel.Controls.Add(this.btnSaveSubCategory, 1, 2);
            this.addSubCategoryPanel.Controls.Add(this.label9, 0, 0);
            this.addSubCategoryPanel.Location = new System.Drawing.Point(445, 525);
            this.addSubCategoryPanel.Name = "addSubCategoryPanel";
            this.addSubCategoryPanel.RowCount = 3;
            this.addSubCategoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addSubCategoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addSubCategoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.addSubCategoryPanel.Size = new System.Drawing.Size(433, 136);
            this.addSubCategoryPanel.TabIndex = 8;
            this.addSubCategoryPanel.Visible = false;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategory.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.ItemHeight = 29;
            this.cmbCategory.Location = new System.Drawing.Point(130, 3);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(300, 35);
            this.cmbCategory.TabIndex = 0;
            this.cmbCategory.UseSelectable = true;
            // 
            // addSubCategoryTextBox
            // 
            this.addSubCategoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addSubCategoryTextBox.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.addSubCategoryTextBox.CustomButton.Image = null;
            this.addSubCategoryTextBox.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.addSubCategoryTextBox.CustomButton.Name = "";
            this.addSubCategoryTextBox.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.addSubCategoryTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.addSubCategoryTextBox.CustomButton.TabIndex = 1;
            this.addSubCategoryTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.addSubCategoryTextBox.CustomButton.UseSelectable = true;
            this.addSubCategoryTextBox.CustomButton.Visible = false;
            this.addSubCategoryTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.addSubCategoryTextBox.Lines = new string[0];
            this.addSubCategoryTextBox.Location = new System.Drawing.Point(130, 47);
            this.addSubCategoryTextBox.MaxLength = 32767;
            this.addSubCategoryTextBox.Name = "addSubCategoryTextBox";
            this.addSubCategoryTextBox.PasswordChar = '\0';
            this.addSubCategoryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addSubCategoryTextBox.SelectedText = "";
            this.addSubCategoryTextBox.SelectionLength = 0;
            this.addSubCategoryTextBox.SelectionStart = 0;
            this.addSubCategoryTextBox.ShortcutsEnabled = true;
            this.addSubCategoryTextBox.Size = new System.Drawing.Size(300, 31);
            this.addSubCategoryTextBox.TabIndex = 1;
            this.addSubCategoryTextBox.UseSelectable = true;
            this.addSubCategoryTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.addSubCategoryTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Подкатегория";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveSubCategory
            // 
            this.btnSaveSubCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveSubCategory.Location = new System.Drawing.Point(200, 87);
            this.btnSaveSubCategory.Name = "btnSaveSubCategory";
            this.btnSaveSubCategory.Size = new System.Drawing.Size(160, 46);
            this.btnSaveSubCategory.TabIndex = 4;
            this.btnSaveSubCategory.Text = "Запиши";
            this.btnSaveSubCategory.UseSelectable = true;
            this.btnSaveSubCategory.Click += new System.EventHandler(this.btnSaveSubCategory_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "Категория";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addEnginePanel
            // 
            this.addEnginePanel.ColumnCount = 2;
            this.addEnginePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.addEnginePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addEnginePanel.Controls.Add(this.btnSaveEngine, 1, 1);
            this.addEnginePanel.Controls.Add(this.addEngineTextBox, 1, 0);
            this.addEnginePanel.Controls.Add(this.label10, 0, 0);
            this.addEnginePanel.Location = new System.Drawing.Point(445, 307);
            this.addEnginePanel.Name = "addEnginePanel";
            this.addEnginePanel.RowCount = 2;
            this.addEnginePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addEnginePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addEnginePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.addEnginePanel.Size = new System.Drawing.Size(433, 103);
            this.addEnginePanel.TabIndex = 9;
            this.addEnginePanel.Visible = false;
            // 
            // btnSaveEngine
            // 
            this.btnSaveEngine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveEngine.Location = new System.Drawing.Point(193, 54);
            this.btnSaveEngine.Name = "btnSaveEngine";
            this.btnSaveEngine.Size = new System.Drawing.Size(160, 46);
            this.btnSaveEngine.TabIndex = 1;
            this.btnSaveEngine.Text = "Запиши";
            this.btnSaveEngine.UseSelectable = true;
            this.btnSaveEngine.Click += new System.EventHandler(this.btnSaveEngine_Click);
            // 
            // addEngineTextBox
            // 
            this.addEngineTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addEngineTextBox.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.addEngineTextBox.CustomButton.Image = null;
            this.addEngineTextBox.CustomButton.Location = new System.Drawing.Point(281, 1);
            this.addEngineTextBox.CustomButton.Name = "";
            this.addEngineTextBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.addEngineTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.addEngineTextBox.CustomButton.TabIndex = 1;
            this.addEngineTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.addEngineTextBox.CustomButton.UseSelectable = true;
            this.addEngineTextBox.CustomButton.Visible = false;
            this.addEngineTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.addEngineTextBox.Lines = new string[0];
            this.addEngineTextBox.Location = new System.Drawing.Point(117, 9);
            this.addEngineTextBox.MaxLength = 32767;
            this.addEngineTextBox.Name = "addEngineTextBox";
            this.addEngineTextBox.PasswordChar = '\0';
            this.addEngineTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addEngineTextBox.SelectedText = "";
            this.addEngineTextBox.SelectionLength = 0;
            this.addEngineTextBox.SelectionStart = 0;
            this.addEngineTextBox.ShortcutsEnabled = true;
            this.addEngineTextBox.Size = new System.Drawing.Size(313, 33);
            this.addEngineTextBox.TabIndex = 2;
            this.addEngineTextBox.UseSelectable = true;
            this.addEngineTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.addEngineTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "Двигател";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddPage
            // 
            this.AddPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPage.Controls.Add(this.tabPage1);
            this.AddPage.Controls.Add(this.tabPage2);
            this.AddPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPage.Location = new System.Drawing.Point(12, 12);
            this.AddPage.Name = "AddPage";
            this.AddPage.SelectedIndex = 0;
            this.AddPage.Size = new System.Drawing.Size(1027, 712);
            this.AddPage.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.Panel_1);
            this.tabPage1.Controls.Add(this.addModelPanel);
            this.tabPage1.Controls.Add(this.addEnginePanel);
            this.tabPage1.Controls.Add(this.addMarkaPanel);
            this.tabPage1.Controls.Add(this.btnBackToAddPanel);
            this.tabPage1.Controls.Add(this.addSubCategoryPanel);
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Controls.Add(this.addCategoryPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1019, 675);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добави";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelUpdateDB);
            this.tabPage2.Controls.Add(this.metroGridUpdateDB);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1019, 675);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Обнови";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelUpdateDB
            // 
            this.panelUpdateDB.ColumnCount = 2;
            this.panelUpdateDB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelUpdateDB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelUpdateDB.Controls.Add(this.btnUpdateMarka, 0, 0);
            this.panelUpdateDB.Controls.Add(this.btnUpdateModel, 1, 0);
            this.panelUpdateDB.Controls.Add(this.btnUpdateCategory, 0, 1);
            this.panelUpdateDB.Controls.Add(this.btnUpdateSubCategory, 1, 1);
            this.panelUpdateDB.Controls.Add(this.btnUpdateEngine, 0, 2);
            this.panelUpdateDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelUpdateDB.Location = new System.Drawing.Point(6, 6);
            this.panelUpdateDB.Name = "panelUpdateDB";
            this.panelUpdateDB.RowCount = 3;
            this.panelUpdateDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelUpdateDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelUpdateDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelUpdateDB.Size = new System.Drawing.Size(436, 257);
            this.panelUpdateDB.TabIndex = 13;
            // 
            // btnUpdateMarka
            // 
            this.btnUpdateMarka.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUpdateMarka.Location = new System.Drawing.Point(3, 3);
            this.btnUpdateMarka.Name = "btnUpdateMarka";
            this.btnUpdateMarka.Size = new System.Drawing.Size(160, 55);
            this.btnUpdateMarka.TabIndex = 1;
            this.btnUpdateMarka.Text = "Марка";
            this.btnUpdateMarka.UseSelectable = true;
            this.btnUpdateMarka.Click += new System.EventHandler(this.btnUpdateMarka_Click);
            // 
            // btnUpdateModel
            // 
            this.btnUpdateModel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUpdateModel.Location = new System.Drawing.Point(221, 3);
            this.btnUpdateModel.Name = "btnUpdateModel";
            this.btnUpdateModel.Size = new System.Drawing.Size(160, 55);
            this.btnUpdateModel.TabIndex = 2;
            this.btnUpdateModel.Text = "Модел";
            this.btnUpdateModel.UseSelectable = true;
            this.btnUpdateModel.Click += new System.EventHandler(this.btnUpdateModel_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUpdateCategory.Location = new System.Drawing.Point(3, 88);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(160, 55);
            this.btnUpdateCategory.TabIndex = 2;
            this.btnUpdateCategory.Text = "Категория";
            this.btnUpdateCategory.UseSelectable = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnUpdateSubCategory
            // 
            this.btnUpdateSubCategory.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUpdateSubCategory.Location = new System.Drawing.Point(221, 88);
            this.btnUpdateSubCategory.Name = "btnUpdateSubCategory";
            this.btnUpdateSubCategory.Size = new System.Drawing.Size(160, 55);
            this.btnUpdateSubCategory.TabIndex = 3;
            this.btnUpdateSubCategory.Text = "Подкатегория";
            this.btnUpdateSubCategory.UseSelectable = true;
            this.btnUpdateSubCategory.Click += new System.EventHandler(this.btnUpdateSubCategory_Click);
            // 
            // btnUpdateEngine
            // 
            this.btnUpdateEngine.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUpdateEngine.Location = new System.Drawing.Point(3, 173);
            this.btnUpdateEngine.Name = "btnUpdateEngine";
            this.btnUpdateEngine.Size = new System.Drawing.Size(160, 55);
            this.btnUpdateEngine.TabIndex = 4;
            this.btnUpdateEngine.Text = "Двигател";
            this.btnUpdateEngine.UseSelectable = true;
            this.btnUpdateEngine.Click += new System.EventHandler(this.btnUpdateEngine_Click);
            // 
            // metroGridUpdateDB
            // 
            this.metroGridUpdateDB.AllowUserToAddRows = false;
            this.metroGridUpdateDB.AllowUserToResizeRows = false;
            this.metroGridUpdateDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGridUpdateDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGridUpdateDB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.metroGridUpdateDB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridUpdateDB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGridUpdateDB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.metroGridUpdateDB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridUpdateDB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridUpdateDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridUpdateDB.ContextMenuStrip = this.ForDelete;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridUpdateDB.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridUpdateDB.EnableHeadersVisualStyles = false;
            this.metroGridUpdateDB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridUpdateDB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridUpdateDB.Location = new System.Drawing.Point(3, 94);
            this.metroGridUpdateDB.MultiSelect = false;
            this.metroGridUpdateDB.Name = "metroGridUpdateDB";
            this.metroGridUpdateDB.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridUpdateDB.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridUpdateDB.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.metroGridUpdateDB.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGridUpdateDB.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.metroGridUpdateDB.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.metroGridUpdateDB.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroGridUpdateDB.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.metroGridUpdateDB.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Blue;
            this.metroGridUpdateDB.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.metroGridUpdateDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.metroGridUpdateDB.Size = new System.Drawing.Size(1010, 575);
            this.metroGridUpdateDB.TabIndex = 12;
            this.metroGridUpdateDB.TabStop = false;
            this.metroGridUpdateDB.Visible = false;
            this.metroGridUpdateDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridUpdateDB_CellContentClick);
            this.metroGridUpdateDB.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridUpdateDB_CellValueChanged);
            // 
            // ForDelete
            // 
            this.ForDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изтриванеToolStripMenuItem});
            this.ForDelete.Name = "ForDelete";
            this.ForDelete.Size = new System.Drawing.Size(133, 26);
            this.ForDelete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ForDelete_MouseClick);
            // 
            // изтриванеToolStripMenuItem
            // 
            this.изтриванеToolStripMenuItem.Name = "изтриванеToolStripMenuItem";
            this.изтриванеToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.изтриванеToolStripMenuItem.Text = "Изтриване";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroTile1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.metroTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(463, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 72);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(6, 17);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(90, 49);
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "Назад";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(131, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 24);
            this.label11.TabIndex = 2;
            this.label11.Text = "Търсене";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(281, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(224, 28);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(313, 33);
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 736);
            this.Controls.Add(this.AddPage);
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Panel_1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.addMarkaPanel.ResumeLayout(false);
            this.addMarkaPanel.PerformLayout();
            this.addModelPanel.ResumeLayout(false);
            this.addModelPanel.PerformLayout();
            this.addCategoryPanel.ResumeLayout(false);
            this.addCategoryPanel.PerformLayout();
            this.addSubCategoryPanel.ResumeLayout(false);
            this.addSubCategoryPanel.PerformLayout();
            this.addEnginePanel.ResumeLayout(false);
            this.addEnginePanel.PerformLayout();
            this.AddPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelUpdateDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridUpdateDB)).EndInit();
            this.ForDelete.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAddMarka;
        private MetroFramework.Controls.MetroButton btnAddModel;
        private MetroFramework.Controls.MetroButton btnAddCategory;
        private System.Windows.Forms.TableLayoutPanel Panel_1;
        private MetroFramework.Controls.MetroButton btnAddSubCategory;
        private MetroFramework.Controls.MetroButton btnAddEngine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnBackToAddPanel;
        private System.Windows.Forms.TableLayoutPanel addMarkaPanel;
        private MetroFramework.Controls.MetroButton btnSaveMark;
        private MetroFramework.Controls.MetroTextBox addMarkTextBox;
        private System.Windows.Forms.TableLayoutPanel addModelPanel;
        private MetroFramework.Controls.MetroComboBox cmbMarka;
        private MetroFramework.Controls.MetroButton btnSaveModel;
        private MetroFramework.Controls.MetroTextBox addModelTextBox;
        private MetroFramework.Controls.MetroTextBox addOtTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox addDoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel addCategoryPanel;
        private MetroFramework.Controls.MetroButton btnSaveCategory;
        private MetroFramework.Controls.MetroTextBox addCategoryTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel addSubCategoryPanel;
        private MetroFramework.Controls.MetroComboBox cmbCategory;
        private MetroFramework.Controls.MetroTextBox addSubCategoryTextBox;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroButton btnSaveSubCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel addEnginePanel;
        private MetroFramework.Controls.MetroButton btnSaveEngine;
        private MetroFramework.Controls.MetroTextBox addEngineTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl AddPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label11;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.TableLayoutPanel panelUpdateDB;
        private MetroFramework.Controls.MetroButton btnUpdateMarka;
        private MetroFramework.Controls.MetroButton btnUpdateModel;
        private MetroFramework.Controls.MetroButton btnUpdateCategory;
        private MetroFramework.Controls.MetroButton btnUpdateSubCategory;
        private MetroFramework.Controls.MetroButton btnUpdateEngine;
        private MetroFramework.Controls.MetroGrid metroGridUpdateDB;
        private System.Windows.Forms.ContextMenuStrip ForDelete;
        private System.Windows.Forms.ToolStripMenuItem изтриванеToolStripMenuItem;
    }
}