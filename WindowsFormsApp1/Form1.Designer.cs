namespace WindowsFormsApp1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialNumber = new System.Windows.Forms.TextBox();
            this.Nomer = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbMarka = new MetroFramework.Controls.MetroComboBox();
            this.cmbModel = new MetroFramework.Controls.MetroComboBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGoToAddForm3 = new MetroFramework.Controls.MetroTile();
            this.btnDeleteProduct = new MetroFramework.Controls.MetroButton();
            this.btnUpdateProduct = new MetroFramework.Controls.MetroButton();
            this.cmbCategorySort = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSubCategorySort = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searchProduct = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelSecondSearch = new System.Windows.Forms.TableLayoutPanel();
            this.btnSort = new System.Windows.Forms.Button();
            this.panelFirstSearch = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelSecondSearch.SuspendLayout();
            this.panelFirstSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Модел";
            // 
            // serialNumber
            // 
            this.serialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serialNumber.Location = new System.Drawing.Point(231, 16);
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.Size = new System.Drawing.Size(222, 31);
            this.serialNumber.TabIndex = 3;
            // 
            // Nomer
            // 
            this.Nomer.AutoSize = true;
            this.Nomer.Location = new System.Drawing.Point(231, 0);
            this.Nomer.Name = "Nomer";
            this.Nomer.Size = new System.Drawing.Size(41, 13);
            this.Nomer.TabIndex = 0;
            this.Nomer.Text = "Номер";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Image = global::WindowsFormsApp1.Properties.Resources.search_icon_png_02;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(231, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 47);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Търси";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbMarka
            // 
            this.cmbMarka.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.IntegralHeight = false;
            this.cmbMarka.ItemHeight = 29;
            this.cmbMarka.Location = new System.Drawing.Point(3, 16);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(203, 35);
            this.cmbMarka.TabIndex = 1;
            this.cmbMarka.UseSelectable = true;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // cmbModel
            // 
            this.cmbModel.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.ItemHeight = 29;
            this.cmbModel.Location = new System.Drawing.Point(3, 71);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(203, 35);
            this.cmbModel.TabIndex = 2;
            this.cmbModel.UseSelectable = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle10;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(12, 226);
            this.metroGrid1.MultiSelect = false;
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.metroGrid1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.metroGrid1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.metroGrid1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.metroGrid1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroGrid1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.metroGrid1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Blue;
            this.metroGrid1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1163, 577);
            this.metroGrid1.TabIndex = 11;
            this.metroGrid1.TabStop = false;
            this.metroGrid1.Visible = false;
            this.metroGrid1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.metroGrid1_CellMouseClick);
            this.metroGrid1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.metroGrid1_CellMouseDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnGoToAddForm3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1082, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(93, 42);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // btnGoToAddForm3
            // 
            this.btnGoToAddForm3.ActiveControl = null;
            this.btnGoToAddForm3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoToAddForm3.BackColor = System.Drawing.Color.Coral;
            this.btnGoToAddForm3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnGoToAddForm3.Location = new System.Drawing.Point(3, 3);
            this.btnGoToAddForm3.Name = "btnGoToAddForm3";
            this.btnGoToAddForm3.Size = new System.Drawing.Size(87, 36);
            this.btnGoToAddForm3.TabIndex = 13;
            this.btnGoToAddForm3.Text = "Добави";
            this.btnGoToAddForm3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoToAddForm3.TileImage = global::WindowsFormsApp1.Properties.Resources.Apps_Libreoffice_Base_icon11;
            this.btnGoToAddForm3.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoToAddForm3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnGoToAddForm3.UseCustomBackColor = true;
            this.btnGoToAddForm3.UseCustomForeColor = true;
            this.btnGoToAddForm3.UseSelectable = true;
            this.btnGoToAddForm3.UseTileImage = true;
            this.btnGoToAddForm3.Click += new System.EventHandler(this.btnGoToAddForm_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteProduct.Location = new System.Drawing.Point(613, 818);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(141, 49);
            this.btnDeleteProduct.TabIndex = 12;
            this.btnDeleteProduct.Text = "Изтриване";
            this.btnDeleteProduct.UseSelectable = true;
            this.btnDeleteProduct.Visible = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdateProduct.Location = new System.Drawing.Point(454, 818);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(141, 49);
            this.btnUpdateProduct.TabIndex = 11;
            this.btnUpdateProduct.Text = "Обнови";
            this.btnUpdateProduct.UseSelectable = true;
            this.btnUpdateProduct.Visible = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // cmbCategorySort
            // 
            this.cmbCategorySort.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbCategorySort.FormattingEnabled = true;
            this.cmbCategorySort.ItemHeight = 29;
            this.cmbCategorySort.Location = new System.Drawing.Point(277, 26);
            this.cmbCategorySort.Name = "cmbCategorySort";
            this.cmbCategorySort.Size = new System.Drawing.Size(275, 35);
            this.cmbCategorySort.TabIndex = 8;
            this.cmbCategorySort.UseSelectable = true;
            this.cmbCategorySort.SelectedIndexChanged += new System.EventHandler(this.cmbCategorySort_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Категория";
            // 
            // cmbSubCategorySort
            // 
            this.cmbSubCategorySort.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbSubCategorySort.FormattingEnabled = true;
            this.cmbSubCategorySort.ItemHeight = 29;
            this.cmbSubCategorySort.Location = new System.Drawing.Point(3, 89);
            this.cmbSubCategorySort.Name = "cmbSubCategorySort";
            this.cmbSubCategorySort.Size = new System.Drawing.Size(265, 35);
            this.cmbSubCategorySort.TabIndex = 9;
            this.cmbSubCategorySort.UseSelectable = true;
            this.cmbSubCategorySort.SelectedIndexChanged += new System.EventHandler(this.cmbSubCategorySort_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Подкатегория";
            // 
            // searchProduct
            // 
            // 
            // 
            // 
            this.searchProduct.CustomButton.Image = null;
            this.searchProduct.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.searchProduct.CustomButton.Name = "";
            this.searchProduct.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.searchProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchProduct.CustomButton.TabIndex = 1;
            this.searchProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchProduct.CustomButton.UseSelectable = true;
            this.searchProduct.CustomButton.Visible = false;
            this.searchProduct.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.searchProduct.Lines = new string[0];
            this.searchProduct.Location = new System.Drawing.Point(3, 26);
            this.searchProduct.MaxLength = 32767;
            this.searchProduct.Name = "searchProduct";
            this.searchProduct.PasswordChar = '\0';
            this.searchProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchProduct.SelectedText = "";
            this.searchProduct.SelectionLength = 0;
            this.searchProduct.SelectionStart = 0;
            this.searchProduct.ShortcutsEnabled = true;
            this.searchProduct.Size = new System.Drawing.Size(268, 29);
            this.searchProduct.TabIndex = 7;
            this.searchProduct.UseSelectable = true;
            this.searchProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ключова дума";
            // 
            // panelSecondSearch
            // 
            this.panelSecondSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSecondSearch.ColumnCount = 2;
            this.panelSecondSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelSecondSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelSecondSearch.Controls.Add(this.btnSort, 0, 3);
            this.panelSecondSearch.Controls.Add(this.searchProduct, 0, 1);
            this.panelSecondSearch.Controls.Add(this.label3, 1, 0);
            this.panelSecondSearch.Controls.Add(this.cmbCategorySort, 1, 1);
            this.panelSecondSearch.Controls.Add(this.label5, 0, 0);
            this.panelSecondSearch.Controls.Add(this.label4, 0, 2);
            this.panelSecondSearch.Controls.Add(this.cmbSubCategorySort, 0, 3);
            this.panelSecondSearch.Location = new System.Drawing.Point(12, 80);
            this.panelSecondSearch.Name = "panelSecondSearch";
            this.panelSecondSearch.RowCount = 4;
            this.panelSecondSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00625F));
            this.panelSecondSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelSecondSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.99375F));
            this.panelSecondSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelSecondSearch.Size = new System.Drawing.Size(583, 140);
            this.panelSecondSearch.TabIndex = 7;
            this.panelSecondSearch.Visible = false;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.White;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSort.Image = global::WindowsFormsApp1.Properties.Resources.search_icon_png_02;
            this.btnSort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSort.Location = new System.Drawing.Point(277, 89);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(150, 47);
            this.btnSort.TabIndex = 10;
            this.btnSort.Text = "Търси";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // panelFirstSearch
            // 
            this.panelFirstSearch.AutoSize = true;
            this.panelFirstSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelFirstSearch.ColumnCount = 2;
            this.panelFirstSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelFirstSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelFirstSearch.Controls.Add(this.label1, 0, 0);
            this.panelFirstSearch.Controls.Add(this.cmbMarka, 0, 1);
            this.panelFirstSearch.Controls.Add(this.Nomer, 1, 0);
            this.panelFirstSearch.Controls.Add(this.serialNumber, 1, 1);
            this.panelFirstSearch.Controls.Add(this.label2, 0, 2);
            this.panelFirstSearch.Controls.Add(this.cmbModel, 0, 3);
            this.panelFirstSearch.Controls.Add(this.btnSearch, 1, 3);
            this.panelFirstSearch.Location = new System.Drawing.Point(64, 67);
            this.panelFirstSearch.Name = "panelFirstSearch";
            this.panelFirstSearch.RowCount = 4;
            this.panelFirstSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.37725F));
            this.panelFirstSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.13174F));
            this.panelFirstSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.97605F));
            this.panelFirstSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.71257F));
            this.panelFirstSearch.Size = new System.Drawing.Size(456, 123);
            this.panelFirstSearch.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(741, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.White;
            this.search.Image = global::WindowsFormsApp1.Properties.Resources.search_icon_png_02;
            this.search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search.Location = new System.Drawing.Point(174, 12);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(126, 49);
            this.search.TabIndex = 6;
            this.search.Text = "Търси";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.SpringGreen;
            this.add.Image = global::WindowsFormsApp1.Properties.Resources.add_icon_22;
            this.add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add.Location = new System.Drawing.Point(12, 12);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(144, 49);
            this.add.TabIndex = 5;
            this.add.Text = "Добави нов запис";
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1198, 881);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelFirstSearch);
            this.Controls.Add(this.panelSecondSearch);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelSecondSearch.ResumeLayout(false);
            this.panelSecondSearch.PerformLayout();
            this.panelFirstSearch.ResumeLayout(false);
            this.panelFirstSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox serialNumber;
        private System.Windows.Forms.Label Nomer;
        private System.Windows.Forms.Button btnSearch;
        private MetroFramework.Controls.MetroComboBox cmbMarka;
        private MetroFramework.Controls.MetroComboBox cmbModel;
        public MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroButton btnDeleteProduct;
        private MetroFramework.Controls.MetroButton btnUpdateProduct;
        private MetroFramework.Controls.MetroComboBox cmbCategorySort;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox cmbSubCategorySort;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox searchProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel panelSecondSearch;
        private System.Windows.Forms.TableLayoutPanel panelFirstSearch;
        public System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile btnGoToAddForm3;
        private System.Windows.Forms.Button btnSort;
    }
}

