namespace TDDwithBaseBallGame
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnPlayGame = new System.Windows.Forms.Button();
            this.TbxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.tbxStrike = new System.Windows.Forms.TextBox();
            this.tbxBall = new System.Windows.Forms.TextBox();
            this.tbxOut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTryCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnPlayGame
            // 
            this.BtnPlayGame.Location = new System.Drawing.Point(591, 8);
            this.BtnPlayGame.Name = "BtnPlayGame";
            this.BtnPlayGame.Size = new System.Drawing.Size(240, 156);
            this.BtnPlayGame.TabIndex = 0;
            this.BtnPlayGame.Text = "가즈아!";
            this.BtnPlayGame.UseVisualStyleBackColor = true;
            this.BtnPlayGame.Click += new System.EventHandler(this.BtnPlayGame_Click);
            // 
            // TbxInput
            // 
            this.TbxInput.Location = new System.Drawing.Point(376, 14);
            this.TbxInput.Name = "TbxInput";
            this.TbxInput.Size = new System.Drawing.Size(209, 21);
            this.TbxInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "3자리 숫자를 입력하세요";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "S";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "O";
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(837, 8);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(270, 156);
            this.BtnReset.TabIndex = 6;
            this.BtnReset.Text = "다시";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // tbxStrike
            // 
            this.tbxStrike.Location = new System.Drawing.Point(74, 23);
            this.tbxStrike.Name = "tbxStrike";
            this.tbxStrike.Size = new System.Drawing.Size(100, 21);
            this.tbxStrike.TabIndex = 7;
            // 
            // tbxBall
            // 
            this.tbxBall.Location = new System.Drawing.Point(74, 52);
            this.tbxBall.Name = "tbxBall";
            this.tbxBall.Size = new System.Drawing.Size(100, 21);
            this.tbxBall.TabIndex = 8;
            // 
            // tbxOut
            // 
            this.tbxOut.Location = new System.Drawing.Point(74, 85);
            this.tbxOut.Name = "tbxOut";
            this.tbxOut.Size = new System.Drawing.Size(100, 21);
            this.tbxOut.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "시도횟수";
            // 
            // lblTryCount
            // 
            this.lblTryCount.AutoSize = true;
            this.lblTryCount.Location = new System.Drawing.Point(285, 67);
            this.lblTryCount.Name = "lblTryCount";
            this.lblTryCount.Size = new System.Drawing.Size(11, 12);
            this.lblTryCount.TabIndex = 11;
            this.lblTryCount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 179);
            this.Controls.Add(this.lblTryCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxOut);
            this.Controls.Add(this.tbxBall);
            this.Controls.Add(this.tbxStrike);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxInput);
            this.Controls.Add(this.BtnPlayGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPlayGame;
        private System.Windows.Forms.TextBox TbxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.TextBox tbxStrike;
        private System.Windows.Forms.TextBox tbxBall;
        private System.Windows.Forms.TextBox tbxOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTryCount;
    }
}

