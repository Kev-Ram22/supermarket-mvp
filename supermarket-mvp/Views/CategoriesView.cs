using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class CategoriesView : Form, ICategoriesView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public CategoriesView()
        {
            InitializeComponent();
            AssociatedAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabCategoryDetail);
            BtnCloseCate.Click += delegate { this.Close(); };
        }

        private void AssociatedAndRaiseViewEvents()
        {
            BtnSearchCate.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            BtnNewCate.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabCategoryList);
                tabControl1.TabPages.Add(tabCategoryDetail);
                tabCategoryDetail.Text = "Add New Category";
            };
            BtnEditCate.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabCategoryList);
                tabControl1.TabPages.Add(tabCategoryDetail);
                tabCategoryDetail.Text = "Edit Pay Mode";
            };
            BtnDeleteCate.Click += delegate
            {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Pay Mode",
                    "Warning",
             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            BtnSaveCate.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {

                    tabControl1.TabPages.Remove(tabCategoryDetail);
                    tabControl1.TabPages.Add(tabCategoryList);

                }
                MessageBox.Show(Message);
            };
            BtnCancelCate.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabCategoryDetail);
                tabControl1.TabPages.Add(tabCategoryList);
            };
        }

        public string CategorieId
        {
            get { return TxtCategoryId.Text; }
            set { TxtCategoryId.Text = value; }
        }
        public string CategorieName
        {
            get { return TxtCategoryName.Text; }
            set { TxtCategoryName.Text = value; }
        }
        public string CategorieObservation
        {
            get { return TxtCategorieObservation.Text; }
            set { TxtCategorieObservation.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetCategorieListBildingSource(BindingSource categorieList)
        {
            DgCategories.DataSource = categorieList;
        }
        private static CategoriesView instance;
        public static CategoriesView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CategoriesView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

    }
}

