using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void BAmount_Click(object sender, EventArgs e)
        {
            Form ifrm = new FCalc();
            ifrm.Text = "A + B";
            ifrm.Show(); // отображаем форму
            this.Hide(); // скрываем текущую форму
        }

        private void BDifference_Click(object sender, EventArgs e)
        {
            Form ifrm = new FCalc();
            ifrm.Text = "A - B";
            ifrm.Show(); // отображаем форму
            this.Hide(); // скрываем текущую форму
        }

        private void BProduct_Click(object sender, EventArgs e)
        {
            Form ifrm = new FCalc();
            ifrm.Text = "A * B";
            ifrm.Show(); // отображаем форму
            this.Hide(); // скрываем текущую форму
        }

        private void bDet_Click(object sender, EventArgs e)
        {
            Form ifrm = new FDet();
            ifrm.Text = "det|A|";
            ifrm.Show(); // отображаем форму
            this.Hide(); // скрываем текущую форму
        }
    }
}
