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
            bool isOut = false;
            int ballCount = 0;
            int strikeCount = 0;

            string inputNumber = TbxInput.Text;
            string hiddenNumber = baseBallObject.GetHiddenNumber();

            bool isValidNumber = BaseBallClass.CheckValidNumber(inputNumber);


            if (isValidNumber == true)
            {
                isOut = baseBallObject.CheckIsOut(hiddenNumber, inputNumber);
                ballCount = baseBallObject.GetBallCount(hiddenNumber, inputNumber);
                strikeCount = baseBallObject.GetStrikeCount(hiddenNumber, inputNumber);



                if (isOut == true)
                {
                    tbxOut.Text = "1";
                    tbxBall.Text = "0";
                    tbxStrike.Text = "0";
                    MessageBox.Show("아웃~");
                    tbxOut.Text = "0";
                }
                else
                {

                    if(strikeCount == 3)
                    {
                        MessageBox.Show("이겼습니다.");

                        baseBallObject.ResetTryCount();
                        ResetView();
                    }

                    tbxBall.Text = ballCount.ToString();
                    tbxStrike.Text = strikeCount.ToString();


                }

                baseBallObject.IncreaseTryCount();
                ShowTryCount(baseBallObject.GetTryCount());

            }


        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            baseBallObject.ResetTryCount();
            ResetView();
        }


        private void ShowTryCount(int tryCount)
        {
            lblTryCount.Text = tryCount.ToString();


        }

        private void ResetView()
        {
            tbxBall.Text = "0";
            tbxStrike.Text = "0";
            TbxInput.Text = "0";
            lblTryCount.Text = "0";
        }
    }
}
