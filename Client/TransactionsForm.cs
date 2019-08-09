using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class TransactionsForm : Form
    {

        public TransactionsForm(dynamic[] data)
        {
            InitializeComponent();

            fillGridView(data);
        }

        private void fillGridView(dynamic[] data)
        {
            DataTable table = new DataTable();

          
            table.Columns.Add("Type", typeof(string));
            table.Columns.Add("Amount", typeof(long));
            table.Columns.Add("Date", typeof(DateTime));

            foreach(dynamic item in data)
                table.Rows.Add(item.Type, item.Amount, item.Created_at);

            dataGridView1.DataSource = table;
        }
    }
}
