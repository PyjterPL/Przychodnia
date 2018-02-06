using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia.Grafik_formy
{
    public partial class Grafik_glowna_forma : Form
    {
        public Grafik_glowna_forma()
        {
            InitializeComponent();
            var data = this.dateTimePicker1.Value;
            var ts = new TimeSpan(0, 0, 0);
            data = data.Date + ts;
            var dzien = this.dateTimePicker1.Value.Day;
            int i = 0;
            while (data.Day == dzien)
            {
                Tabela.Rows.Insert(i, null, data.TimeOfDay,null,null,null);
                data=data.AddMinutes(15);
                i++;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
