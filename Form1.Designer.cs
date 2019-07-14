namespace ZapangiForm
{
    partial class Zapangi
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCoke = new System.Windows.Forms.Button();
            this.btnFanta = new System.Windows.Forms.Button();
            this.btnWater = new System.Windows.Forms.Button();
            this.btnCof = new System.Windows.Forms.Button();
            this.tbDrinks = new System.Windows.Forms.TextBox();
            this.tbMoney = new System.Windows.Forms.TextBox();
            this.btnMoney = new System.Windows.Forms.Button();
            this.tbChange = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCp
            // 
            this.btnCp.Location = new System.Drawing.Point(401, 147);
            this.btnCp.Name = "btnCp";
            this.btnCp.Size = new System.Drawing.Size(114, 28);
            this.btnCp.TabIndex = 0;
            this.btnCp.Text = "반환";
            this.btnCp.UseVisualStyleBackColor = true;
            this.btnCp.Click += new System.EventHandler(this.btnCp_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 57);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 139);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCoke
            // 
            this.btnCoke.Location = new System.Drawing.Point(12, 12);
            this.btnCoke.Name = "btnCoke";
            this.btnCoke.Size = new System.Drawing.Size(80, 34);
            this.btnCoke.TabIndex = 2;
            this.btnCoke.Text = "콜라\r\n600원";
            this.btnCoke.UseVisualStyleBackColor = true;
            this.btnCoke.Click += new System.EventHandler(this.btnCoke_Click);
            // 
            // btnFanta
            // 
            this.btnFanta.Location = new System.Drawing.Point(107, 12);
            this.btnFanta.Name = "btnFanta";
            this.btnFanta.Size = new System.Drawing.Size(80, 34);
            this.btnFanta.TabIndex = 3;
            this.btnFanta.Text = "환타\r\n550원";
            this.btnFanta.UseVisualStyleBackColor = true;
            this.btnFanta.Click += new System.EventHandler(this.btnFanta_Click);
            // 
            // btnWater
            // 
            this.btnWater.Location = new System.Drawing.Point(204, 12);
            this.btnWater.Name = "btnWater";
            this.btnWater.Size = new System.Drawing.Size(80, 34);
            this.btnWater.TabIndex = 4;
            this.btnWater.Text = "물\r\n300원";
            this.btnWater.UseVisualStyleBackColor = true;
            this.btnWater.Click += new System.EventHandler(this.btnWater_Click);
            // 
            // btnCof
            // 
            this.btnCof.Location = new System.Drawing.Point(303, 12);
            this.btnCof.Name = "btnCof";
            this.btnCof.Size = new System.Drawing.Size(80, 34);
            this.btnCof.TabIndex = 5;
            this.btnCof.Text = "커피\r\n450원";
            this.btnCof.UseVisualStyleBackColor = true;
            this.btnCof.Click += new System.EventHandler(this.btnCof_Click);
            // 
            // tbDrinks
            // 
            this.tbDrinks.Location = new System.Drawing.Point(12, 217);
            this.tbDrinks.Multiline = true;
            this.tbDrinks.Name = "tbDrinks";
            this.tbDrinks.Size = new System.Drawing.Size(371, 76);
            this.tbDrinks.TabIndex = 7;
            this.tbDrinks.TextChanged += new System.EventHandler(this.tbDrinks_TextChanged);
            // 
            // tbMoney
            // 
            this.tbMoney.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbMoney.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbMoney.Location = new System.Drawing.Point(401, 57);
            this.tbMoney.Multiline = true;
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.Size = new System.Drawing.Size(114, 50);
            this.tbMoney.TabIndex = 8;
            this.tbMoney.Text = "금액입력";
            this.tbMoney.TextChanged += new System.EventHandler(this.tbMoney_TextChanged);
            this.tbMoney.Enter += new System.EventHandler(this.tbMoney_Enter);
            this.tbMoney.Leave += new System.EventHandler(this.tbMoney_Leave);
            // 
            // btnMoney
            // 
            this.btnMoney.Location = new System.Drawing.Point(401, 113);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(114, 28);
            this.btnMoney.TabIndex = 9;
            this.btnMoney.Text = "투입";
            this.btnMoney.UseVisualStyleBackColor = true;
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // tbChange
            // 
            this.tbChange.Location = new System.Drawing.Point(401, 217);
            this.tbChange.Multiline = true;
            this.tbChange.Name = "tbChange";
            this.tbChange.Size = new System.Drawing.Size(114, 76);
            this.tbChange.TabIndex = 10;
            this.tbChange.TextChanged += new System.EventHandler(this.tbChange_TextChanged);
            // 
            // Zapangi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 336);
            this.Controls.Add(this.tbChange);
            this.Controls.Add(this.btnMoney);
            this.Controls.Add(this.tbMoney);
            this.Controls.Add(this.tbDrinks);
            this.Controls.Add(this.btnCof);
            this.Controls.Add(this.btnWater);
            this.Controls.Add(this.btnFanta);
            this.Controls.Add(this.btnCoke);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCp);
            this.Name = "Zapangi";
            this.Text = "자판기프로그램";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCoke;
        private System.Windows.Forms.Button btnFanta;
        private System.Windows.Forms.Button btnWater;
        private System.Windows.Forms.Button btnCof;
        private System.Windows.Forms.TextBox tbDrinks;
        private System.Windows.Forms.TextBox tbMoney;
        private System.Windows.Forms.Button btnMoney;
        private System.Windows.Forms.TextBox tbChange;
    }
}

