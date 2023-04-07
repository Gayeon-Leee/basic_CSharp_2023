using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf05_login
{
    
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private TextBox GetTxtPw()
        {
            return TxtPw;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtId.Text == "abcd" && TxtPw.Text == "1234")
            {
                MessageBox.Show("로그인 성공");
            }
            else
            {
                MessageBox.Show("로그인 실패");
            }
           
        }
    }
}
