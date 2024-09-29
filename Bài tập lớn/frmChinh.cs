using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_tập_lớn
{
    public partial class frmChinh : Form
    {
        private TabControl tabControl;

        public frmChinh()
        {
            InitializeComponent();
            InitializeTabControl();
        }

        private void InitializeTabControl()
        {
            // Create and configure the TabControl
            tabControl = new TabControl
            {
                Dock = DockStyle.Fill
            };

            // Add the TabControl to the form
            this.Controls.Add(tabControl);

            // Create the first tab page (optional)
            TabPage tabPage1 = new TabPage("Home");
            tabControl.TabPages.Add(tabPage1);
        }

        private void LoadFormIntoTab(Form form, string tabTitle)
        {
            // Create a new tab page
            TabPage tabPage = new TabPage(tabTitle);

            // Set the form's TopLevel property to false
            form.TopLevel = false;

            // Add the form to the tab page
            tabPage.Controls.Add(form);

            // Dock the form to fill the tab page
            form.Dock = DockStyle.Fill;

            // Show the form
            form.Show();

            // Add the tab page to the TabControl
            tabControl.TabPages.Add(tabPage);

            // Select the new tab page
            tabControl.SelectedTab = tabPage;
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            LoadFormIntoTab(form2, "Form2");
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            LoadFormIntoTab(form1, "Form1");
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            // Event handler code
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Event handler code
        }

        private void kiểmKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            LoadFormIntoTab(form4, "Form4");
        }

        private void quảnLýKhoTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            LoadFormIntoTab(form3, "Form3");
        }
    }
}
