using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udemy.Doviz.WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Json_Kurgu_Click(object sender, EventArgs e)
        {
            Udemy.Doviz.Core.BusinessLogicLayer BLL = new Core.BusinessLogicLayer();
            BLL.KurBilgileriniGuncelle();
        }
    }
}
