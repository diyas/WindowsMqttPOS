using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsMqttPOS
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void MenuConfig_Click(object sender, EventArgs e)
        {
            FormConfig formConfig = new FormConfig();
            formConfig.MdiParent = this;
            formConfig.Show();
        }

        private void MenuPayment_Click(object sender, EventArgs e)
        {
            FormPayment formPayment = new FormPayment();
            formPayment.MdiParent = this;
            formPayment.Show();
        }
    }
}
