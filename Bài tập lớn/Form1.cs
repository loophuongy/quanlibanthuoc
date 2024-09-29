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
    public partial class Form1 : Form
    {
        private Panel mainPanel;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomLayout();
            InitializeMainPanel();
        }

        private void InitializeCustomLayout()
        {
            // Create a new SplitContainer
            SplitContainer splitContainer = new SplitContainer
            {
                Dock = DockStyle.Fill,
                Orientation = Orientation.Horizontal,
                SplitterDistance = 150
            };

            // Create a TableLayoutPanel for the top panel
            TableLayoutPanel topTableLayoutPanel = new TableLayoutPanel
            {
                RowCount = 3,
                ColumnCount = 2,
                Dock = DockStyle.Fill,
                AutoSize = true
            };

            // Add rows and columns
            topTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            topTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            topTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            topTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            topTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));

            // Add controls to the top TableLayoutPanel
            Label lblProductName = new Label { Text = "Product Name:", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleRight };
            TextBox txtProductName = new TextBox { Dock = DockStyle.Fill };

            Label lblQuantity = new Label { Text = "Quantity:", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleRight };
            TextBox txtQuantity = new TextBox { Dock = DockStyle.Fill };

            Label lblPrice = new Label { Text = "Price:", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleRight };
            TextBox txtPrice = new TextBox { Dock = DockStyle.Fill };

            topTableLayoutPanel.Controls.Add(lblProductName, 0, 0);
            topTableLayoutPanel.Controls.Add(txtProductName, 1, 0);
            topTableLayoutPanel.Controls.Add(lblQuantity, 0, 1);
            topTableLayoutPanel.Controls.Add(txtQuantity, 1, 1);
            topTableLayoutPanel.Controls.Add(lblPrice, 0, 2);
            topTableLayoutPanel.Controls.Add(txtPrice, 1, 2);

            // Add the top TableLayoutPanel to the top panel of the SplitContainer
            splitContainer.Panel1.Controls.Add(topTableLayoutPanel);

            // Create a DataGridView for the bottom panel
            DataGridView dataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            // Add the DataGridView to the bottom panel of the SplitContainer
            splitContainer.Panel2.Controls.Add(dataGridView);

            // Add the SplitContainer to the form
            this.Controls.Add(splitContainer);
        }

        private void InitializeMainPanel()
        {
            // Create and configure the main panel
            mainPanel = new Panel
            {
                Dock = DockStyle.Fill
            };

            // Add the main panel to the form
            this.Controls.Add(mainPanel);
        }

        private void LoadFormIntoPanel(Form form)
        {
            // Clear the panel
            mainPanel.Controls.Clear();

            // Set the form's TopLevel property to false
            form.TopLevel = false;

            // Add the form to the panel
            mainPanel.Controls.Add(form);

            // Dock the form to fill the panel
            form.Dock = DockStyle.Fill;

            // Show the form
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Event handler code
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {
            // Event handler code
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {
            // Event handler code
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Event handler code
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Event handler code
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Event handler code
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Event handler code
        }

        private void grbThanhToan_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThanhtoanvaInhoadon_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form form2 = new Form2();
            //form2.Show();
        }
    }
}
