namespace Supermarket_mvp.Views
{
    partial class ProvidersView
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
			tabPageProvidersList = new TabPage();
			BtnClose = new Button();
			BtnDelete = new Button();
			BtnEdit = new Button();
			BtnNew = new Button();
			BtnSearch = new Button();
			DgProviders = new DataGridView();
			TxtSearch = new TextBox();
			label2 = new Label();
			tabPageProvidersDetail = new TabPage();
			BtnCancel = new Button();
			BtnSave = new Button();
			TxtProvidersObservation = new TextBox();
			label5 = new Label();
			TxtProvidersName = new TextBox();
			label4 = new Label();
			TxtProviderId = new TextBox();
			label3 = new Label();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			tabControl1.SuspendLayout();
			tabPageProvidersList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)DgProviders).BeginInit();
			tabPageProvidersDetail.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(765, 125);
			panel1.TabIndex = 2;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = supermarket_mvp.Properties.Resources.providers;
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
			label1.Size = new Size(123, 32);
			label1.TabIndex = 0;
			label1.Text = "Providers";
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPageProvidersList);
			tabControl1.Controls.Add(tabPageProvidersDetail);
			tabControl1.Location = new Point(13, 148);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(716, 431);
			tabControl1.TabIndex = 3;
			// 
			// tabPageProvidersList
			// 
			tabPageProvidersList.Controls.Add(BtnClose);
			tabPageProvidersList.Controls.Add(BtnDelete);
			tabPageProvidersList.Controls.Add(BtnEdit);
			tabPageProvidersList.Controls.Add(BtnNew);
			tabPageProvidersList.Controls.Add(BtnSearch);
			tabPageProvidersList.Controls.Add(DgProviders);
			tabPageProvidersList.Controls.Add(TxtSearch);
			tabPageProvidersList.Controls.Add(label2);
			tabPageProvidersList.Location = new Point(4, 29);
			tabPageProvidersList.Name = "tabPageProvidersList";
			tabPageProvidersList.Padding = new Padding(3);
			tabPageProvidersList.Size = new Size(708, 398);
			tabPageProvidersList.TabIndex = 0;
			tabPageProvidersList.Text = "Providers List";
			tabPageProvidersList.UseVisualStyleBackColor = true;
			// 
			// BtnClose
			// 
			BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			BtnClose.BackgroundImageLayout = ImageLayout.Zoom;
			BtnClose.Image = supermarket_mvp.Properties.Resources.cerrar;
			BtnClose.Location = new Point(553, 272);
			BtnClose.Name = "BtnClose";
			BtnClose.Size = new Size(94, 38);
			BtnClose.TabIndex = 20;
			BtnClose.UseVisualStyleBackColor = true;
			// 
			// BtnDelete
			// 
			BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			BtnDelete.BackgroundImageLayout = ImageLayout.Zoom;
			BtnDelete.Image = supermarket_mvp.Properties.Resources.delete;
			BtnDelete.Location = new Point(553, 207);
			BtnDelete.Name = "BtnDelete";
			BtnDelete.Size = new Size(94, 39);
			BtnDelete.TabIndex = 19;
			BtnDelete.UseVisualStyleBackColor = true;
			// 
			// BtnEdit
			// 
			BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			BtnEdit.BackgroundImageLayout = ImageLayout.Zoom;
			BtnEdit.Image = supermarket_mvp.Properties.Resources.edit;
			BtnEdit.Location = new Point(553, 146);
			BtnEdit.Name = "BtnEdit";
			BtnEdit.Size = new Size(94, 38);
			BtnEdit.TabIndex = 18;
			BtnEdit.UseVisualStyleBackColor = true;
			// 
			// BtnNew
			// 
			BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			BtnNew.BackgroundImageLayout = ImageLayout.Zoom;
			BtnNew.Image = supermarket_mvp.Properties.Resources._new;
			BtnNew.Location = new Point(553, 84);
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
			BtnSearch.Location = new Point(463, 15);
			BtnSearch.Name = "BtnSearch";
			BtnSearch.Size = new Size(50, 48);
			BtnSearch.TabIndex = 16;
			BtnSearch.UseVisualStyleBackColor = true;
			// 
			// DgProviders
			// 
			DgProviders.AllowUserToAddRows = false;
			DgProviders.AllowUserToDeleteRows = false;
			DgProviders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			DgProviders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			DgProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DgProviders.Location = new Point(17, 84);
			DgProviders.Name = "DgProviders";
			DgProviders.ReadOnly = true;
			DgProviders.RowHeadersWidth = 51;
			DgProviders.Size = new Size(496, 289);
			DgProviders.TabIndex = 15;
			// 
			// TxtSearch
			// 
			TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			TxtSearch.Location = new Point(17, 26);
			TxtSearch.Name = "TxtSearch";
			TxtSearch.PlaceholderText = "Data to search";
			TxtSearch.Size = new Size(431, 27);
			TxtSearch.TabIndex = 14;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label2.Location = new Point(17, 3);
			label2.Name = "label2";
			label2.Size = new Size(125, 20);
			label2.TabIndex = 13;
			label2.Text = "Search Providers";
			// 
			// tabPageProvidersDetail
			// 
			tabPageProvidersDetail.Controls.Add(BtnCancel);
			tabPageProvidersDetail.Controls.Add(BtnSave);
			tabPageProvidersDetail.Controls.Add(TxtProvidersObservation);
			tabPageProvidersDetail.Controls.Add(label5);
			tabPageProvidersDetail.Controls.Add(TxtProvidersName);
			tabPageProvidersDetail.Controls.Add(label4);
			tabPageProvidersDetail.Controls.Add(TxtProviderId);
			tabPageProvidersDetail.Controls.Add(label3);
			tabPageProvidersDetail.Location = new Point(4, 29);
			tabPageProvidersDetail.Name = "tabPageProvidersDetail";
			tabPageProvidersDetail.Padding = new Padding(3);
			tabPageProvidersDetail.Size = new Size(708, 398);
			tabPageProvidersDetail.TabIndex = 1;
			tabPageProvidersDetail.Text = "Providers Detail,";
			tabPageProvidersDetail.UseVisualStyleBackColor = true;
			// 
			// BtnCancel
			// 
			BtnCancel.BackgroundImageLayout = ImageLayout.Zoom;
			BtnCancel.Image = supermarket_mvp.Properties.Resources.cancel;
			BtnCancel.Location = new Point(157, 299);
			BtnCancel.Name = "BtnCancel";
			BtnCancel.Size = new Size(94, 47);
			BtnCancel.TabIndex = 15;
			BtnCancel.UseVisualStyleBackColor = true;
			// 
			// BtnSave
			// 
			BtnSave.BackgroundImageLayout = ImageLayout.Zoom;
			BtnSave.Image = supermarket_mvp.Properties.Resources.save;
			BtnSave.Location = new Point(38, 299);
			BtnSave.Name = "BtnSave";
			BtnSave.Size = new Size(94, 47);
			BtnSave.TabIndex = 14;
			BtnSave.UseVisualStyleBackColor = true;
			// 
			// TxtProvidersObservation
			// 
			TxtProvidersObservation.Location = new Point(16, 205);
			TxtProvidersObservation.Multiline = true;
			TxtProvidersObservation.Name = "TxtProvidersObservation";
			TxtProvidersObservation.PlaceholderText = "Observation";
			TxtProvidersObservation.Size = new Size(366, 77);
			TxtProvidersObservation.TabIndex = 13;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(18, 185);
			label5.Name = "label5";
			label5.Size = new Size(89, 20);
			label5.TabIndex = 12;
			label5.Text = "Observation";
			// 
			// TxtProvidersName
			// 
			TxtProvidersName.Location = new Point(15, 123);
			TxtProvidersName.Name = "TxtProvidersName";
			TxtProvidersName.PlaceholderText = "Providers Name";
			TxtProvidersName.Size = new Size(367, 27);
			TxtProvidersName.TabIndex = 11;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(17, 103);
			label4.Name = "label4";
			label4.Size = new Size(108, 20);
			label4.TabIndex = 10;
			label4.Text = "Provider Name";
			// 
			// TxtProviderId
			// 
			TxtProviderId.Location = new Point(14, 45);
			TxtProviderId.Name = "TxtProviderId";
			TxtProviderId.ReadOnly = true;
			TxtProviderId.Size = new Size(168, 27);
			TxtProviderId.TabIndex = 9;
			TxtProviderId.Text = "0";
			TxtProviderId.TextAlign = HorizontalAlignment.Right;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(17, 25);
			label3.Name = "label3";
			label3.Size = new Size(81, 20);
			label3.TabIndex = 8;
			label3.Text = "Provider Id";
			// 
			// ProvidersView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(765, 591);
			Controls.Add(tabControl1);
			Controls.Add(panel1);
			Name = "ProvidersView";
			Text = "ProvidersView";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			tabControl1.ResumeLayout(false);
			tabPageProvidersList.ResumeLayout(false);
			tabPageProvidersList.PerformLayout();
			((System.ComponentModel.ISupportInitialize)DgProviders).EndInit();
			tabPageProvidersDetail.ResumeLayout(false);
			tabPageProvidersDetail.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProvidersList;
        private TabPage tabPageProvidersDetail;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSearch;
        private DataGridView DgProviders;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProvidersObservation;
        private Label label5;
        private TextBox TxtProvidersName;
        private Label label4;
        private TextBox TxtProviderId;
        private Label label3;
    }
}