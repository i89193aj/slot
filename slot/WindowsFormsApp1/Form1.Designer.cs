namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PicBtn = new System.Windows.Forms.PictureBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.numqty = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numqty)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Image = global::WindowsFormsApp1.Properties.Resources._0;
            this.pic1.Location = new System.Drawing.Point(30, 35);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(86, 86);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Image = global::WindowsFormsApp1.Properties.Resources._01;
            this.pic2.Location = new System.Drawing.Point(136, 35);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(86, 86);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Image = global::WindowsFormsApp1.Properties.Resources._01;
            this.pic3.Location = new System.Drawing.Point(249, 35);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(86, 86);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic3.TabIndex = 2;
            this.pic3.TabStop = false;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.BackColor = System.Drawing.Color.Transparent;
            this.lb3.Font = new System.Drawing.Font("新細明體", 12F);
            this.lb3.Location = new System.Drawing.Point(169, 421);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(87, 16);
            this.lb3.TabIndex = 6;
            this.lb3.Text = "投注金額：";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PicBtn
            // 
            this.PicBtn.Image = global::WindowsFormsApp1.Properties.Resources.up;
            this.PicBtn.Location = new System.Drawing.Point(279, 147);
            this.PicBtn.Name = "PicBtn";
            this.PicBtn.Size = new System.Drawing.Size(81, 205);
            this.PicBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBtn.TabIndex = 3;
            this.PicBtn.TabStop = false;
            this.PicBtn.Click += new System.EventHandler(this.PicBtn_Click);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.BackColor = System.Drawing.Color.Transparent;
            this.lb2.Font = new System.Drawing.Font("新細明體", 12F);
            this.lb2.Location = new System.Drawing.Point(12, 421);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(87, 16);
            this.lb2.TabIndex = 7;
            this.lb2.Text = "目前金額：";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(91, 418);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(50, 22);
            this.txt1.TabIndex = 8;
            // 
            // numqty
            // 
            this.numqty.Location = new System.Drawing.Point(249, 421);
            this.numqty.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numqty.Name = "numqty";
            this.numqty.Size = new System.Drawing.Size(86, 22);
            this.numqty.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.拉霸背景;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.numqty);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.PicBtn);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "slot machine";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numqty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox PicBtn;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.NumericUpDown numqty;
    }
}

