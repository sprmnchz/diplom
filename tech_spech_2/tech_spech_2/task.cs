using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tech_spech_2
{
    public partial class task : Form
    {
        public task()
        {
            InitializeComponent();
        }

        private void task_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_specDataSet11.DataTable2". При необходимости она может быть перемещена или удалена.
            this.dataTable2TableAdapter.Fill(this.tech_specDataSet11.DataTable2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_specDataSet1.task". При необходимости она может быть перемещена или удалена.
            this.taskTableAdapter.Fill(this.tech_specDataSet1.task);

        }
    }
}
