using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Cells : Form
    {
        public Cells()
        {
            InitializeComponent();
        }

        private void Cells_Load(object sender, EventArgs e)
        {

        }

        private void View_all_cells_Click(object sender, EventArgs e)
        {
            view_all_cells all_cells = new view_all_cells();
            all_cells.Show();
        }

        private void view_one_cell_Click(object sender, EventArgs e)
        {
            view_one_cell one_cell = new view_one_cell();
                 one_cell.Show();

        }

        private void insert_cell_Click(object sender, EventArgs e)
        {
            insert_cell insert_cell = new insert_cell();
            insert_cell.Show();
        }

        private void Delete_cell_Click(object sender, EventArgs e)
        {
            Delete_cell del_cell = new Delete_cell();
            del_cell.Show();

        }

        private void Update_cell_Click(object sender, EventArgs e)
        {
            update_cell upda_cell = new update_cell();
            upda_cell.Show();
        }
    }
}
