using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreeTierLayer.BLL;

namespace ThreeTierLayer.PLL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProfileBLL objBll = new ProfileBLL();
            dataGridView1.DataSource = objBll.GetProfile(); 
        }
    }
}
