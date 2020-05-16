namespace Kursach_15Variant
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bookRegistrationTabID = new System.Windows.Forms.TabPage();
            this.saveBookButton = new System.Windows.Forms.Button();
            this.diliveryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.bookDiliveryDateLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.bookPriceLabel = new System.Windows.Forms.Label();
            this.publishingTextBox = new System.Windows.Forms.TextBox();
            this.bookPublishingLabel = new System.Windows.Forms.Label();
            this.publicationsDatePicker = new System.Windows.Forms.DateTimePicker();
            this.bookPublicationsDateLabel = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.bookAuthorLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.bookTitleLabel = new System.Windows.Forms.Label();
            this.registrationsBookDataGrid = new System.Windows.Forms.DataGridView();
            this.bookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPublicationsDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPublishing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookExsist = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bookDilivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookEditTabID = new System.Windows.Forms.TabPage();
            this.changeExistToFalse = new System.Windows.Forms.Button();
            this.yearNumericPanel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.editBookDataGrid = new System.Windows.Forms.DataGridView();
            this.bookIDEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitleEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPublicationsEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPublishingEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPriceEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookExsistEdit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bookDiliveryEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeButtonEdit = new System.Windows.Forms.Button();
            this.bookSearchTabID = new System.Windows.Forms.TabPage();
            this.searchDilivery = new System.Windows.Forms.Button();
            this.searchAuthorBooksButton = new System.Windows.Forms.Button();
            this.searchAuthorTextBox = new System.Windows.Forms.TextBox();
            this.searchPriceGreaterThan = new System.Windows.Forms.Button();
            this.cachedRichTextBox = new System.Windows.Forms.RichTextBox();
            this.searchDataGrid = new System.Windows.Forms.DataGridView();
            this.bookIDSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitleSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPublicationsSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPublishingSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPriceSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookExsistSearch = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bookDiliverySearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.bookRegistrationTabID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrationsBookDataGrid)).BeginInit();
            this.bookEditTabID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editBookDataGrid)).BeginInit();
            this.bookSearchTabID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1204, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readFromToolStripMenuItem,
            this.saveToToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // readFromToolStripMenuItem
            // 
            this.readFromToolStripMenuItem.Name = "readFromToolStripMenuItem";
            this.readFromToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.readFromToolStripMenuItem.Text = "Read from";
            this.readFromToolStripMenuItem.Click += new System.EventHandler(this.readFromToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.bookRegistrationTabID);
            this.tabControl1.Controls.Add(this.bookEditTabID);
            this.tabControl1.Controls.Add(this.bookSearchTabID);
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1192, 532);
            this.tabControl1.TabIndex = 1;
            // 
            // bookRegistrationTabID
            // 
            this.bookRegistrationTabID.Controls.Add(this.saveBookButton);
            this.bookRegistrationTabID.Controls.Add(this.diliveryDatePicker);
            this.bookRegistrationTabID.Controls.Add(this.bookDiliveryDateLabel);
            this.bookRegistrationTabID.Controls.Add(this.priceTextBox);
            this.bookRegistrationTabID.Controls.Add(this.bookPriceLabel);
            this.bookRegistrationTabID.Controls.Add(this.publishingTextBox);
            this.bookRegistrationTabID.Controls.Add(this.bookPublishingLabel);
            this.bookRegistrationTabID.Controls.Add(this.publicationsDatePicker);
            this.bookRegistrationTabID.Controls.Add(this.bookPublicationsDateLabel);
            this.bookRegistrationTabID.Controls.Add(this.authorTextBox);
            this.bookRegistrationTabID.Controls.Add(this.bookAuthorLabel);
            this.bookRegistrationTabID.Controls.Add(this.titleTextBox);
            this.bookRegistrationTabID.Controls.Add(this.bookTitleLabel);
            this.bookRegistrationTabID.Controls.Add(this.registrationsBookDataGrid);
            this.bookRegistrationTabID.Location = new System.Drawing.Point(4, 25);
            this.bookRegistrationTabID.Name = "bookRegistrationTabID";
            this.bookRegistrationTabID.Padding = new System.Windows.Forms.Padding(3);
            this.bookRegistrationTabID.Size = new System.Drawing.Size(1184, 503);
            this.bookRegistrationTabID.TabIndex = 0;
            this.bookRegistrationTabID.Text = "BookRegistration";
            this.bookRegistrationTabID.UseVisualStyleBackColor = true;
            // 
            // saveBookButton
            // 
            this.saveBookButton.Location = new System.Drawing.Point(85, 418);
            this.saveBookButton.Name = "saveBookButton";
            this.saveBookButton.Size = new System.Drawing.Size(103, 43);
            this.saveBookButton.TabIndex = 13;
            this.saveBookButton.Text = "Save Button";
            this.saveBookButton.UseVisualStyleBackColor = true;
            this.saveBookButton.Click += new System.EventHandler(this.saveBookButton_Click);
            // 
            // diliveryDatePicker
            // 
            this.diliveryDatePicker.Location = new System.Drawing.Point(45, 326);
            this.diliveryDatePicker.Name = "diliveryDatePicker";
            this.diliveryDatePicker.Size = new System.Drawing.Size(200, 22);
            this.diliveryDatePicker.TabIndex = 12;
            // 
            // bookDiliveryDateLabel
            // 
            this.bookDiliveryDateLabel.AutoSize = true;
            this.bookDiliveryDateLabel.Location = new System.Drawing.Point(91, 306);
            this.bookDiliveryDateLabel.Name = "bookDiliveryDateLabel";
            this.bookDiliveryDateLabel.Size = new System.Drawing.Size(88, 17);
            this.bookDiliveryDateLabel.TabIndex = 11;
            this.bookDiliveryDateLabel.Text = "Dilivery Date";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(140, 260);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 22);
            this.priceTextBox.TabIndex = 10;
            // 
            // bookPriceLabel
            // 
            this.bookPriceLabel.AutoSize = true;
            this.bookPriceLabel.Location = new System.Drawing.Point(20, 260);
            this.bookPriceLabel.Name = "bookPriceLabel";
            this.bookPriceLabel.Size = new System.Drawing.Size(40, 17);
            this.bookPriceLabel.TabIndex = 9;
            this.bookPriceLabel.Text = "Price";
            // 
            // publishingTextBox
            // 
            this.publishingTextBox.Location = new System.Drawing.Point(140, 217);
            this.publishingTextBox.Name = "publishingTextBox";
            this.publishingTextBox.Size = new System.Drawing.Size(100, 22);
            this.publishingTextBox.TabIndex = 8;
            // 
            // bookPublishingLabel
            // 
            this.bookPublishingLabel.AutoSize = true;
            this.bookPublishingLabel.Location = new System.Drawing.Point(20, 217);
            this.bookPublishingLabel.Name = "bookPublishingLabel";
            this.bookPublishingLabel.Size = new System.Drawing.Size(73, 17);
            this.bookPublishingLabel.TabIndex = 7;
            this.bookPublishingLabel.Text = "Publishing";
            // 
            // publicationsDatePicker
            // 
            this.publicationsDatePicker.Location = new System.Drawing.Point(45, 156);
            this.publicationsDatePicker.Name = "publicationsDatePicker";
            this.publicationsDatePicker.Size = new System.Drawing.Size(200, 22);
            this.publicationsDatePicker.TabIndex = 6;
            // 
            // bookPublicationsDateLabel
            // 
            this.bookPublicationsDateLabel.AutoSize = true;
            this.bookPublicationsDateLabel.Location = new System.Drawing.Point(91, 136);
            this.bookPublicationsDateLabel.Name = "bookPublicationsDateLabel";
            this.bookPublicationsDateLabel.Size = new System.Drawing.Size(118, 17);
            this.bookPublicationsDateLabel.TabIndex = 5;
            this.bookPublicationsDateLabel.Text = "Publications Date";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(140, 90);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(100, 22);
            this.authorTextBox.TabIndex = 4;
            // 
            // bookAuthorLabel
            // 
            this.bookAuthorLabel.AutoSize = true;
            this.bookAuthorLabel.Location = new System.Drawing.Point(20, 90);
            this.bookAuthorLabel.Name = "bookAuthorLabel";
            this.bookAuthorLabel.Size = new System.Drawing.Size(50, 17);
            this.bookAuthorLabel.TabIndex = 3;
            this.bookAuthorLabel.Text = "Author";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(140, 39);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 22);
            this.titleTextBox.TabIndex = 2;
            // 
            // bookTitleLabel
            // 
            this.bookTitleLabel.AutoSize = true;
            this.bookTitleLabel.Location = new System.Drawing.Point(20, 39);
            this.bookTitleLabel.Name = "bookTitleLabel";
            this.bookTitleLabel.Size = new System.Drawing.Size(35, 17);
            this.bookTitleLabel.TabIndex = 1;
            this.bookTitleLabel.Text = "Title";
            // 
            // registrationsBookDataGrid
            // 
            this.registrationsBookDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.registrationsBookDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.registrationsBookDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registrationsBookDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookID,
            this.bookTitle,
            this.bookAuthor,
            this.bookPublicationsDate,
            this.bookPublishing,
            this.bookPrice,
            this.bookExsist,
            this.bookDilivery});
            this.registrationsBookDataGrid.Location = new System.Drawing.Point(291, 6);
            this.registrationsBookDataGrid.Name = "registrationsBookDataGrid";
            this.registrationsBookDataGrid.RowHeadersWidth = 51;
            this.registrationsBookDataGrid.Size = new System.Drawing.Size(890, 492);
            this.registrationsBookDataGrid.TabIndex = 0;
            // 
            // bookID
            // 
            this.bookID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bookID.Frozen = true;
            this.bookID.HeaderText = "Book_ID";
            this.bookID.MinimumWidth = 6;
            this.bookID.Name = "bookID";
            this.bookID.ReadOnly = true;
            this.bookID.Width = 90;
            // 
            // bookTitle
            // 
            this.bookTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bookTitle.Frozen = true;
            this.bookTitle.HeaderText = "Title";
            this.bookTitle.MinimumWidth = 6;
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.ReadOnly = true;
            this.bookTitle.Width = 64;
            // 
            // bookAuthor
            // 
            this.bookAuthor.Frozen = true;
            this.bookAuthor.HeaderText = "Author";
            this.bookAuthor.MinimumWidth = 6;
            this.bookAuthor.Name = "bookAuthor";
            this.bookAuthor.ReadOnly = true;
            this.bookAuthor.Width = 79;
            // 
            // bookPublicationsDate
            // 
            this.bookPublicationsDate.Frozen = true;
            this.bookPublicationsDate.HeaderText = "Publications Date";
            this.bookPublicationsDate.MinimumWidth = 6;
            this.bookPublicationsDate.Name = "bookPublicationsDate";
            this.bookPublicationsDate.ReadOnly = true;
            this.bookPublicationsDate.Width = 135;
            // 
            // bookPublishing
            // 
            this.bookPublishing.Frozen = true;
            this.bookPublishing.HeaderText = "Publishing";
            this.bookPublishing.MinimumWidth = 6;
            this.bookPublishing.Name = "bookPublishing";
            this.bookPublishing.ReadOnly = true;
            this.bookPublishing.Width = 102;
            // 
            // bookPrice
            // 
            this.bookPrice.Frozen = true;
            this.bookPrice.HeaderText = "Price";
            this.bookPrice.MinimumWidth = 6;
            this.bookPrice.Name = "bookPrice";
            this.bookPrice.ReadOnly = true;
            this.bookPrice.Width = 69;
            // 
            // bookExsist
            // 
            this.bookExsist.Frozen = true;
            this.bookExsist.HeaderText = "Exsist";
            this.bookExsist.MinimumWidth = 6;
            this.bookExsist.Name = "bookExsist";
            this.bookExsist.ReadOnly = true;
            this.bookExsist.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bookExsist.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bookExsist.Width = 73;
            // 
            // bookDilivery
            // 
            this.bookDilivery.Frozen = true;
            this.bookDilivery.HeaderText = "Dilivery";
            this.bookDilivery.MinimumWidth = 6;
            this.bookDilivery.Name = "bookDilivery";
            this.bookDilivery.ReadOnly = true;
            this.bookDilivery.Width = 83;
            // 
            // bookEditTabID
            // 
            this.bookEditTabID.Controls.Add(this.changeExistToFalse);
            this.bookEditTabID.Controls.Add(this.yearNumericPanel);
            this.bookEditTabID.Controls.Add(this.label1);
            this.bookEditTabID.Controls.Add(this.editBookDataGrid);
            this.bookEditTabID.Controls.Add(this.changeButtonEdit);
            this.bookEditTabID.Location = new System.Drawing.Point(4, 25);
            this.bookEditTabID.Name = "bookEditTabID";
            this.bookEditTabID.Padding = new System.Windows.Forms.Padding(3);
            this.bookEditTabID.Size = new System.Drawing.Size(1184, 503);
            this.bookEditTabID.TabIndex = 1;
            this.bookEditTabID.Text = "BookEditInfo";
            this.bookEditTabID.UseVisualStyleBackColor = true;
            // 
            // changeExistToFalse
            // 
            this.changeExistToFalse.Location = new System.Drawing.Point(92, 143);
            this.changeExistToFalse.Name = "changeExistToFalse";
            this.changeExistToFalse.Size = new System.Drawing.Size(75, 32);
            this.changeExistToFalse.TabIndex = 6;
            this.changeExistToFalse.Text = "Change";
            this.changeExistToFalse.UseVisualStyleBackColor = true;
            this.changeExistToFalse.Click += new System.EventHandler(this.changeExistToFalse_Click);
            // 
            // yearNumericPanel
            // 
            this.yearNumericPanel.Location = new System.Drawing.Point(79, 115);
            this.yearNumericPanel.Name = "yearNumericPanel";
            this.yearNumericPanel.Size = new System.Drawing.Size(120, 22);
            this.yearNumericPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "If book > N year, change Exist to false";
            // 
            // editBookDataGrid
            // 
            this.editBookDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.editBookDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.editBookDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editBookDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDEdit,
            this.bookTitleEdit,
            this.bookAuthorEdit,
            this.bookPublicationsEdit,
            this.bookPublishingEdit,
            this.bookPriceEdit,
            this.bookExsistEdit,
            this.bookDiliveryEdit});
            this.editBookDataGrid.Location = new System.Drawing.Point(291, 6);
            this.editBookDataGrid.Name = "editBookDataGrid";
            this.editBookDataGrid.RowHeadersWidth = 51;
            this.editBookDataGrid.Size = new System.Drawing.Size(890, 492);
            this.editBookDataGrid.TabIndex = 3;
            // 
            // bookIDEdit
            // 
            this.bookIDEdit.Frozen = true;
            this.bookIDEdit.HeaderText = "Book_ID";
            this.bookIDEdit.MinimumWidth = 6;
            this.bookIDEdit.Name = "bookIDEdit";
            this.bookIDEdit.ReadOnly = true;
            this.bookIDEdit.Width = 90;
            // 
            // bookTitleEdit
            // 
            this.bookTitleEdit.Frozen = true;
            this.bookTitleEdit.HeaderText = "Title";
            this.bookTitleEdit.MinimumWidth = 6;
            this.bookTitleEdit.Name = "bookTitleEdit";
            this.bookTitleEdit.Width = 64;
            // 
            // bookAuthorEdit
            // 
            this.bookAuthorEdit.Frozen = true;
            this.bookAuthorEdit.HeaderText = "Author";
            this.bookAuthorEdit.MinimumWidth = 6;
            this.bookAuthorEdit.Name = "bookAuthorEdit";
            this.bookAuthorEdit.Width = 79;
            // 
            // bookPublicationsEdit
            // 
            this.bookPublicationsEdit.Frozen = true;
            this.bookPublicationsEdit.HeaderText = "Publications Date";
            this.bookPublicationsEdit.MinimumWidth = 6;
            this.bookPublicationsEdit.Name = "bookPublicationsEdit";
            this.bookPublicationsEdit.Width = 135;
            // 
            // bookPublishingEdit
            // 
            this.bookPublishingEdit.Frozen = true;
            this.bookPublishingEdit.HeaderText = "Publishing";
            this.bookPublishingEdit.MinimumWidth = 6;
            this.bookPublishingEdit.Name = "bookPublishingEdit";
            this.bookPublishingEdit.Width = 102;
            // 
            // bookPriceEdit
            // 
            this.bookPriceEdit.Frozen = true;
            this.bookPriceEdit.HeaderText = "Price";
            this.bookPriceEdit.MinimumWidth = 6;
            this.bookPriceEdit.Name = "bookPriceEdit";
            this.bookPriceEdit.Width = 69;
            // 
            // bookExsistEdit
            // 
            this.bookExsistEdit.Frozen = true;
            this.bookExsistEdit.HeaderText = "Exsist";
            this.bookExsistEdit.MinimumWidth = 6;
            this.bookExsistEdit.Name = "bookExsistEdit";
            this.bookExsistEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bookExsistEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bookExsistEdit.Width = 73;
            // 
            // bookDiliveryEdit
            // 
            this.bookDiliveryEdit.Frozen = true;
            this.bookDiliveryEdit.HeaderText = "Dilivery";
            this.bookDiliveryEdit.MinimumWidth = 6;
            this.bookDiliveryEdit.Name = "bookDiliveryEdit";
            this.bookDiliveryEdit.Width = 83;
            // 
            // changeButtonEdit
            // 
            this.changeButtonEdit.Location = new System.Drawing.Point(92, 378);
            this.changeButtonEdit.Name = "changeButtonEdit";
            this.changeButtonEdit.Size = new System.Drawing.Size(107, 55);
            this.changeButtonEdit.TabIndex = 2;
            this.changeButtonEdit.Text = "Edit records";
            this.changeButtonEdit.UseVisualStyleBackColor = true;
            this.changeButtonEdit.Click += new System.EventHandler(this.changeButtonEdit_Click);
            // 
            // bookSearchTabID
            // 
            this.bookSearchTabID.Controls.Add(this.searchDilivery);
            this.bookSearchTabID.Controls.Add(this.searchAuthorBooksButton);
            this.bookSearchTabID.Controls.Add(this.searchAuthorTextBox);
            this.bookSearchTabID.Controls.Add(this.searchPriceGreaterThan);
            this.bookSearchTabID.Controls.Add(this.cachedRichTextBox);
            this.bookSearchTabID.Controls.Add(this.searchDataGrid);
            this.bookSearchTabID.Location = new System.Drawing.Point(4, 25);
            this.bookSearchTabID.Name = "bookSearchTabID";
            this.bookSearchTabID.Size = new System.Drawing.Size(1184, 503);
            this.bookSearchTabID.TabIndex = 2;
            this.bookSearchTabID.Text = "BookSearchSpecificInformation";
            this.bookSearchTabID.UseVisualStyleBackColor = true;
            // 
            // searchDilivery
            // 
            this.searchDilivery.Location = new System.Drawing.Point(93, 278);
            this.searchDilivery.Name = "searchDilivery";
            this.searchDilivery.Size = new System.Drawing.Size(110, 71);
            this.searchDilivery.TabIndex = 9;
            this.searchDilivery.Text = "Search Dilivery > 3 month";
            this.searchDilivery.UseVisualStyleBackColor = true;
            this.searchDilivery.Click += new System.EventHandler(this.searchDilivery_Click);
            // 
            // searchAuthorBooksButton
            // 
            this.searchAuthorBooksButton.Location = new System.Drawing.Point(103, 172);
            this.searchAuthorBooksButton.Name = "searchAuthorBooksButton";
            this.searchAuthorBooksButton.Size = new System.Drawing.Size(75, 64);
            this.searchAuthorBooksButton.TabIndex = 8;
            this.searchAuthorBooksButton.Text = "Search Author\'s Books";
            this.searchAuthorBooksButton.UseVisualStyleBackColor = true;
            this.searchAuthorBooksButton.Click += new System.EventHandler(this.searchAuthorBooksButton_Click);
            // 
            // searchAuthorTextBox
            // 
            this.searchAuthorTextBox.Location = new System.Drawing.Point(84, 144);
            this.searchAuthorTextBox.Name = "searchAuthorTextBox";
            this.searchAuthorTextBox.Size = new System.Drawing.Size(119, 22);
            this.searchAuthorTextBox.TabIndex = 7;
            // 
            // searchPriceGreaterThan
            // 
            this.searchPriceGreaterThan.Location = new System.Drawing.Point(93, 35);
            this.searchPriceGreaterThan.Name = "searchPriceGreaterThan";
            this.searchPriceGreaterThan.Size = new System.Drawing.Size(110, 67);
            this.searchPriceGreaterThan.TabIndex = 6;
            this.searchPriceGreaterThan.Text = "Search Price (great than 100)";
            this.searchPriceGreaterThan.UseVisualStyleBackColor = true;
            this.searchPriceGreaterThan.Click += new System.EventHandler(this.searchPriceGreaterThan_Click);
            // 
            // cachedRichTextBox
            // 
            this.cachedRichTextBox.Location = new System.Drawing.Point(3, 355);
            this.cachedRichTextBox.Name = "cachedRichTextBox";
            this.cachedRichTextBox.Size = new System.Drawing.Size(282, 145);
            this.cachedRichTextBox.TabIndex = 5;
            this.cachedRichTextBox.Text = "";
            // 
            // searchDataGrid
            // 
            this.searchDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.searchDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.searchDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDSearch,
            this.bookTitleSearch,
            this.bookAuthorSearch,
            this.bookPublicationsSearch,
            this.bookPublishingSearch,
            this.bookPriceSearch,
            this.bookExsistSearch,
            this.bookDiliverySearch});
            this.searchDataGrid.Location = new System.Drawing.Point(291, 6);
            this.searchDataGrid.Name = "searchDataGrid";
            this.searchDataGrid.RowHeadersWidth = 51;
            this.searchDataGrid.Size = new System.Drawing.Size(890, 492);
            this.searchDataGrid.TabIndex = 4;
            // 
            // bookIDSearch
            // 
            this.bookIDSearch.Frozen = true;
            this.bookIDSearch.HeaderText = "Book_ID";
            this.bookIDSearch.MinimumWidth = 6;
            this.bookIDSearch.Name = "bookIDSearch";
            this.bookIDSearch.ReadOnly = true;
            this.bookIDSearch.Width = 90;
            // 
            // bookTitleSearch
            // 
            this.bookTitleSearch.Frozen = true;
            this.bookTitleSearch.HeaderText = "Title";
            this.bookTitleSearch.MinimumWidth = 6;
            this.bookTitleSearch.Name = "bookTitleSearch";
            this.bookTitleSearch.ReadOnly = true;
            this.bookTitleSearch.Width = 64;
            // 
            // bookAuthorSearch
            // 
            this.bookAuthorSearch.Frozen = true;
            this.bookAuthorSearch.HeaderText = "Author";
            this.bookAuthorSearch.MinimumWidth = 6;
            this.bookAuthorSearch.Name = "bookAuthorSearch";
            this.bookAuthorSearch.ReadOnly = true;
            this.bookAuthorSearch.Width = 79;
            // 
            // bookPublicationsSearch
            // 
            this.bookPublicationsSearch.Frozen = true;
            this.bookPublicationsSearch.HeaderText = "Publications Date";
            this.bookPublicationsSearch.MinimumWidth = 6;
            this.bookPublicationsSearch.Name = "bookPublicationsSearch";
            this.bookPublicationsSearch.ReadOnly = true;
            this.bookPublicationsSearch.Width = 135;
            // 
            // bookPublishingSearch
            // 
            this.bookPublishingSearch.Frozen = true;
            this.bookPublishingSearch.HeaderText = "Publishing";
            this.bookPublishingSearch.MinimumWidth = 6;
            this.bookPublishingSearch.Name = "bookPublishingSearch";
            this.bookPublishingSearch.ReadOnly = true;
            this.bookPublishingSearch.Width = 102;
            // 
            // bookPriceSearch
            // 
            this.bookPriceSearch.Frozen = true;
            this.bookPriceSearch.HeaderText = "Price";
            this.bookPriceSearch.MinimumWidth = 6;
            this.bookPriceSearch.Name = "bookPriceSearch";
            this.bookPriceSearch.ReadOnly = true;
            this.bookPriceSearch.Width = 69;
            // 
            // bookExsistSearch
            // 
            this.bookExsistSearch.Frozen = true;
            this.bookExsistSearch.HeaderText = "Exsist";
            this.bookExsistSearch.MinimumWidth = 6;
            this.bookExsistSearch.Name = "bookExsistSearch";
            this.bookExsistSearch.ReadOnly = true;
            this.bookExsistSearch.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bookExsistSearch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bookExsistSearch.Width = 73;
            // 
            // bookDiliverySearch
            // 
            this.bookDiliverySearch.Frozen = true;
            this.bookDiliverySearch.HeaderText = "Dilivery";
            this.bookDiliverySearch.MinimumWidth = 6;
            this.bookDiliverySearch.Name = "bookDiliverySearch";
            this.bookDiliverySearch.ReadOnly = true;
            this.bookDiliverySearch.Width = 83;
            // 
            // saveToToolStripMenuItem
            // 
            this.saveToToolStripMenuItem.Name = "saveToToolStripMenuItem";
            this.saveToToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToToolStripMenuItem.Text = "Save to";
            this.saveToToolStripMenuItem.Click += new System.EventHandler(this.saveToToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 571);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.bookRegistrationTabID.ResumeLayout(false);
            this.bookRegistrationTabID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrationsBookDataGrid)).EndInit();
            this.bookEditTabID.ResumeLayout(false);
            this.bookEditTabID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editBookDataGrid)).EndInit();
            this.bookSearchTabID.ResumeLayout(false);
            this.bookSearchTabID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readFromToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage bookRegistrationTabID;
        private System.Windows.Forms.DataGridView registrationsBookDataGrid;
        private System.Windows.Forms.TabPage bookEditTabID;
        private System.Windows.Forms.TabPage bookSearchTabID;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label bookAuthorLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label bookTitleLabel;
        private System.Windows.Forms.DateTimePicker publicationsDatePicker;
        private System.Windows.Forms.Label bookPublicationsDateLabel;
        private System.Windows.Forms.DateTimePicker diliveryDatePicker;
        private System.Windows.Forms.Label bookDiliveryDateLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label bookPriceLabel;
        private System.Windows.Forms.TextBox publishingTextBox;
        private System.Windows.Forms.Label bookPublishingLabel;
        private System.Windows.Forms.Button saveBookButton;
        private System.Windows.Forms.Button changeButtonEdit;
        private System.Windows.Forms.DataGridView editBookDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPublicationsDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPublishing;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bookExsist;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDilivery;
        private System.Windows.Forms.DataGridView searchDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPublicationsSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPublishingSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPriceSearch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bookExsistSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDiliverySearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPublicationsEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPublishingEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPriceEdit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bookExsistEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDiliveryEdit;
        private System.Windows.Forms.RichTextBox cachedRichTextBox;
        private System.Windows.Forms.Button changeExistToFalse;
        private System.Windows.Forms.NumericUpDown yearNumericPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchPriceGreaterThan;
        private System.Windows.Forms.Button searchAuthorBooksButton;
        private System.Windows.Forms.TextBox searchAuthorTextBox;
        private System.Windows.Forms.Button searchDilivery;
        private System.Windows.Forms.ToolStripMenuItem saveToToolStripMenuItem;
    }
}

