using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDDwithBaseBallGame
{
    public partial class Form1 : Form
    {
        BaseBallClass baseBallObject;
        public Form1()
        {
            baseBallObject = new BaseBallClass();
            InitializeComponent();
        }

        private void BtnPlayGame_Click(object sender, EventArgs e)
        {
            BaseBallClass.CheckValidNumber(TbxInput.Text);
        }




    }
}
