namespace HelloWinform02
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_num1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_gawi = new System.Windows.Forms.Button();
            this.button_bawi = new System.Windows.Forms.Button();
            this.button_bo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label_num3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "문제 맞추기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_num1
            // 
            this.textBox_num1.Location = new System.Drawing.Point(117, 68);
            this.textBox_num1.Name = "textBox_num1";
            this.textBox_num1.Size = new System.Drawing.Size(100, 21);
            this.textBox_num1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("D2Coding", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "1번 문제";
            // 
            // button_gawi
            // 
            this.button_gawi.Location = new System.Drawing.Point(12, 134);
            this.button_gawi.Name = "button_gawi";
            this.button_gawi.Size = new System.Drawing.Size(99, 70);
            this.button_gawi.TabIndex = 3;
            this.button_gawi.Text = "가위";
            this.button_gawi.UseVisualStyleBackColor = true;
            this.button_gawi.Click += new System.EventHandler(this.button_gawi_Click);
            // 
            // button_bawi
            // 
            this.button_bawi.Location = new System.Drawing.Point(142, 134);
            this.button_bawi.Name = "button_bawi";
            this.button_bawi.Size = new System.Drawing.Size(99, 70);
            this.button_bawi.TabIndex = 4;
            this.button_bawi.Text = "바위";
            this.button_bawi.UseVisualStyleBackColor = true;
            this.button_bawi.Click += new System.EventHandler(this.button_bawi_Click);
            // 
            // button_bo
            // 
            this.button_bo.Location = new System.Drawing.Point(277, 134);
            this.button_bo.Name = "button_bo";
            this.button_bo.Size = new System.Drawing.Size(99, 70);
            this.button_bo.TabIndex = 5;
            this.button_bo.Text = "보";
            this.button_bo.UseVisualStyleBackColor = true;
            this.button_bo.Click += new System.EventHandler(this.button_bo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("D2Coding", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "2번 문제";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("D2Coding", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(13, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "3번 문제";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "문장 아무거나 출력";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_num3
            // 
            this.label_num3.AutoSize = true;
            this.label_num3.Font = new System.Drawing.Font("D2Coding", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_num3.Location = new System.Drawing.Point(26, 360);
            this.label_num3.Name = "label_num3";
            this.label_num3.Size = new System.Drawing.Size(27, 31);
            this.label_num3.TabIndex = 9;
            this.label_num3.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_num3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_bo);
            this.Controls.Add(this.button_bawi);
            this.Controls.Add(this.button_gawi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_num1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_num1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_gawi;
        private System.Windows.Forms.Button button_bawi;
        private System.Windows.Forms.Button button_bo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_num3;
    }
}

