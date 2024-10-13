namespace Supermarket_mvp.Views
{
    partial class ProductsView
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
			panel1 = new Panel();
			pictureBox1 = new PictureBox();
			label1 = new Label();
			tabControl1 = new TabControl();
			tabPageProductsList = new TabPage();
			BtnClose = new Button();
			DgProducts = new DataGridView();
			BtnDelete = new Button();
			TxtSearch = new TextBox();
			BtnEdit = new Button();
			label2 = new Label();
			BtnNew = new Button();
			BtnSearch = new Button();
			tabPageProductsDetail = new TabPage();
			TxtProductsStock = new TextBox();
			label7 = new Label();
			TxtProductsPrice = new TextBox();
			label6 = new Label();
			BtnCancel = new Button();
			BtnSave = new Button();
			TxtProductsCategory = new TextBox();
			label5 = new Label();
			TxtProductsName = new TextBox();
			label4 = new Label();
			TxtProductsId = new TextBox();
			label3 = new Label();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			tabControl1.SuspendLayout();
			tabPageProductsList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)DgProducts).BeginInit();
			tabPageProductsDetail.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(855, 125);
			panel1.TabIndex = 3;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = supermarket_mvp.Properties.Resources.products;
			pictureBox1.Location = new Point(12, 13);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(143, 109);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
			label1.Location = new Point(161, 50);
			label1.Name = "label1";
			label1.Size = new Size(116, 32);
			label1.TabIndex = 0;
			label1.Text = "Products";
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPageProductsList);
			tabControl1.Controls.Add(tabPageProductsDetail);
			tabControl1.Location = new Point(12, 131);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(842, 467);
			tabControl1.TabIndex = 4;
			// 
			// tabPageProductsList
			// 
			tabPageProductsList.Controls.Add(BtnClose);
			tabPageProductsList.Controls.Add(DgProducts);
			tabPageProductsList.Controls.Add(BtnDelete);
			tabPageProductsList.Controls.Add(TxtSearch);
			tabPageProductsList.Controls.Add(BtnEdit);
			tabPageProductsList.Controls.Add(label2);
			tabPageProductsList.Controls.Add(BtnNew);
			tabPageProductsList.Controls.Add(BtnSearch);
			tabPageProductsList.Location = new Point(4, 29);
			tabPageProductsList.Name = "tabPageProductsList";
			tabPageProductsList.Padding = new Padding(3);
			tabPageProductsList.Size = new Size(834, 434);
			tabPageProductsList.TabIndex = 0;
			tabPageProductsList.Text = "Products List";
			tabPageProductsList.UseVisualStyleBackColor = true;
			// 
			// BtnClose
			// 
			BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			BtnClose.BackgroundImageLayout = ImageLayout.Zoom;
			BtnClose.Image = supermarket_mvp.Properties.Resources.cerrar;
			BtnClose.Location = new Point(687, 303);
			BtnClose.Name = "BtnClose";
			BtnClose.Size = new Size(94, 38);
			BtnClose.TabIndex = 20;
			BtnClose.UseVisualStyleBackColor = true;
			// 
			// DgProducts
			// 
			DgProducts.AllowUserToAddRows = false;
			DgProducts.AllowUserToDeleteRows = false;
			DgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			DgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			DgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DgProducts.Location = new Point(20, 89);
			DgProducts.Name = "DgProducts";
			DgProducts.ReadOnly = true;
			DgProducts.RowHeadersWidth = 51;
			DgProducts.Size = new Size(549, 304);
			DgProducts.TabIndex = 15;
			// 
			// BtnDelete
			// 
			BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			BtnDelete.BackgroundImageLayout = ImageLayout.Zoom;
			BtnDelete.Image = supermarket_mvp.Properties.Resources.delete;
			BtnDelete.Location = new Point(687, 238);
			BtnDelete.Name = "BtnDelete";
			BtnDelete.Size = new Size(94, 39);
			BtnDelete.TabIndex = 19;
			BtnDelete.UseVisualStyleBackColor = true;
			// 
			// TxtSearch
			// 
			TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			TxtSearch.Location = new Point(20, 46);
			TxtSearch.Name = "TxtSearch";
			TxtSearch.PlaceholderText = "Data to search";
			TxtSearch.Size = new Size(549, 27);
			TxtSearch.TabIndex = 14;
			// 
			// BtnEdit
			// 
			BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			BtnEdit.BackgroundImageLayout = ImageLayout.Zoom;
			BtnEdit.Image = supermarket_mvp.Properties.Resources.edit;
			BtnEdit.Location = new Point(687, 177);
			BtnEdit.Name = "BtnEdit";
			BtnEdit.Size = new Size(94, 38);
			BtnEdit.TabIndex = 18;
			BtnEdit.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label2.Location = new Point(20, 6);
			label2.Name = "label2";
			label2.Size = new Size(121, 20);
			label2.TabIndex = 13;
			label2.Text = "Search Products";
			// 
			// BtnNew
			// 
			BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			BtnNew.BackgroundImageLayout = ImageLayout.Zoom;
			BtnNew.Image = supermarket_mvp.Properties.Resources._new;
			BtnNew.Location = new Point(687, 115);
			BtnNew.Name = "BtnNew";
			BtnNew.Size = new Size(94, 40);
			BtnNew.TabIndex = 17;
			BtnNew.UseVisualStyleBackColor = true;
			// 
			// BtnSearch
			// 
			BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			BtnSearch.BackgroundImageLayout = ImageLayout.Zoom;
			BtnSearch.Image = supermarket_mvp.Properties.Resources.search_small;
			BtnSearch.Location = new Point(597, 46);
			BtnSearch.Name = "BtnSearch";
			BtnSearch.Size = new Size(50, 48);
			BtnSearch.TabIndex = 16;
			BtnSearch.UseVisualStyleBackColor = true;
			// 
			// tabPageProductsDetail
			// 
			tabPageProductsDetail.Controls.Add(TxtProductsStock);
			tabPageProductsDetail.Controls.Add(label7);
			tabPageProductsDetail.Controls.Add(TxtProductsPrice);
			tabPageProductsDetail.Controls.Add(label6);
			tabPageProductsDetail.Controls.Add(BtnCancel);
			tabPageProductsDetail.Controls.Add(BtnSave);
			tabPageProductsDetail.Controls.Add(TxtProductsCategory);
			tabPageProductsDetail.Controls.Add(label5);
			tabPageProductsDetail.Controls.Add(TxtProductsName);
			tabPageProductsDetail.Controls.Add(label4);
			tabPageProductsDetail.Controls.Add(TxtProductsId);
			tabPageProductsDetail.Controls.Add(label3);
			tabPageProductsDetail.Location = new Point(4, 29);
			tabPageProductsDetail.Name = "tabPageProductsDetail";
			tabPageProductsDetail.Padding = new Padding(3);
			tabPageProductsDetail.Size = new Size(834, 434);
			tabPageProductsDetail.TabIndex = 1;
			tabPageProductsDetail.Text = "Products Detail";
			tabPageProductsDetail.UseVisualStyleBackColor = true;
			// 
			// TxtProductsStock
			// 
			TxtProductsStock.Location = new Point(16, 236);
			TxtProductsStock.Name = "TxtProductsStock";
			TxtProductsStock.PlaceholderText = "Providers Name";
			TxtProductsStock.Size = new Size(367, 27);
			TxtProductsStock.TabIndex = 19;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(16, 213);
			label7.Name = "label7";
			label7.Size = new Size(100, 20);
			label7.TabIndex = 18;
			label7.Text = "Product Stock";
			// 
			// TxtProductsPrice
			// 
			TxtProductsPrice.Location = new Point(14, 174);
			TxtProductsPrice.Name = "TxtProductsPrice";
			TxtProductsPrice.PlaceholderText = "Providers Name";
			TxtProductsPrice.Size = new Size(367, 27);
			TxtProductsPrice.TabIndex = 17;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(14, 151);
			label6.Name = "label6";
			label6.Size = new Size(96, 20);
			label6.TabIndex = 16;
			label6.Text = "Product Price";
			// 
			// BtnCancel
			// 
			BtnCancel.BackgroundImageLayout = ImageLayout.Zoom;
			BtnCancel.Image = supermarket_mvp.Properties.Resources.cancel;
			BtnCancel.Location = new Point(157, 381);
			BtnCancel.Name = "BtnCancel";
			BtnCancel.Size = new Size(94, 47);
			BtnCancel.TabIndex = 15;
			BtnCancel.UseVisualStyleBackColor = true;
			// 
			// BtnSave
			// 
			BtnSave.BackgroundImageLayout = ImageLayout.Zoom;
			BtnSave.Image = supermarket_mvp.Properties.Resources.save;
			BtnSave.Location = new Point(34, 381);
			BtnSave.Name = "BtnSave";
			BtnSave.Size = new Size(94, 47);
			BtnSave.TabIndex = 14;
			BtnSave.UseVisualStyleBackColor = true;
			// 
			// TxtProductsCategory
			// 
			TxtProductsCategory.Location = new Point(15, 284);
			TxtProductsCategory.Multiline = true;
			TxtProductsCategory.Name = "TxtProductsCategory";
			TxtProductsCategory.PlaceholderText = "Observation";
			TxtProductsCategory.Size = new Size(366, 77);
			TxtProductsCategory.TabIndex = 13;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(16, 261);
			label5.Name = "label5";
			label5.Size = new Size(69, 20);
			label5.TabIndex = 12;
			label5.Text = "Category";
			// 
			// TxtProductsName
			// 
			TxtProductsName.Location = new Point(16, 108);
			TxtProductsName.Name = "TxtProductsName";
			TxtProductsName.PlaceholderText = "Providers Name";
			TxtProductsName.Size = new Size(367, 27);
			TxtProductsName.TabIndex = 11;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(16, 85);
			label4.Name = "label4";
			label4.Size = new Size(104, 20);
			label4.TabIndex = 10;
			label4.Text = "Product Name";
			// 
			// TxtProductsId
			// 
			TxtProductsId.Location = new Point(14, 45);
			TxtProductsId.Name = "TxtProductsId";
			TxtProductsId.ReadOnly = true;
			TxtProductsId.Size = new Size(168, 27);
			TxtProductsId.TabIndex = 9;
			TxtProductsId.Text = "0";
			TxtProductsId.TextAlign = HorizontalAlignment.Right;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(20, 28);
			label3.Name = "label3";
			label3.Size = new Size(81, 20);
			label3.TabIndex = 8;
			label3.Text = "Provider Id";
			// 
			// ProductsView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(855, 602);
			Controls.Add(tabControl1);
			Controls.Add(panel1);
			Name = "ProductsView";
			Text = "ProductsView";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			tabControl1.ResumeLayout(false);
			tabPageProductsList.ResumeLayout(false);
			tabPageProductsList.PerformLayout();
			((System.ComponentModel.ISupportInitialize)DgProducts).EndInit();
			tabPageProductsDetail.ResumeLayout(false);
			tabPageProductsDetail.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProductsList;
        private DataGridView DgProducts;
        private TextBox TxtSearch;
        private Label label2;
        private TabPage tabPageProductsDetail;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProductsCategory;
        private Label label5;
        private TextBox TxtProductsName;
        private Label label4;
        private TextBox TxtProductsId;
        private Label label3;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSearch;
        private TextBox TxtProductsPrice;
        private Label label6;
        private TextBox TxtProductsStock;
        private Label label7;
    }
}