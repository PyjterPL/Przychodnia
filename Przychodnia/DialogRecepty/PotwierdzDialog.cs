using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia.DialogRecepty
{
    public partial class PotwierdzDialog : Form
    {
        int generated;
        Random rand;
      
        public PotwierdzDialog()
        {
            InitializeComponent();
            rand = new Random();
            generated = rand.Next(10, 100);
        }
    }
}
