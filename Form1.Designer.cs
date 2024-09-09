namespace HaHuyHung_Buoi1_Bai4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txta = new TextBox();
            txtb = new TextBox();
            txtc = new TextBox();
            txtkq = new TextBox();
            btnth = new Button();
            btntt = new Button();
            btnthoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(296, 44);
            label1.Name = "label1";
            label1.Size = new Size(288, 27);
            label1.TabIndex = 0;
            label1.Text = "Tìm Số Lớn Nhất Trong 3 Số";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13F);
            label2.Location = new Point(99, 112);
            label2.Name = "label2";
            label2.Size = new Size(91, 27);
            label2.TabIndex = 1;
            label2.Text = "Nhập A:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13F);
            label3.Location = new Point(99, 178);
            label3.Name = "label3";
            label3.Size = new Size(91, 27);
            label3.TabIndex = 2;
            label3.Text = "Nhập B:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 13F);
            label4.Location = new Point(99, 245);
            label4.Name = "label4";
            label4.Size = new Size(91, 27);
            label4.TabIndex = 3;
            label4.Text = "Nhập C:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 13F);
            label5.Location = new Point(99, 307);
            label5.Name = "label5";
            label5.Size = new Size(99, 27);
            label5.TabIndex = 4;
            label5.Text = "Kết Quả:";
            // 
            // txta
            // 
            txta.Location = new Point(221, 112);
            txta.Name = "txta";
            txta.Size = new Size(182, 27);
            txta.TabIndex = 5;
            // 
            // txtb
            // 
            txtb.Location = new Point(221, 178);
            txtb.Name = "txtb";
            txtb.Size = new Size(182, 27);
            txtb.TabIndex = 6;
            // 
            // txtc
            // 
            txtc.Location = new Point(221, 245);
            txtc.Name = "txtc";
            txtc.Size = new Size(182, 27);
            txtc.TabIndex = 7;
            // 
            // txtkq
            // 
            txtkq.Location = new Point(221, 307);
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(182, 27);
            txtkq.TabIndex = 8;
            // 
            // btnth
            // 
            btnth.Font = new Font("Tahoma", 11F);
            btnth.Location = new Point(510, 110);
            btnth.Name = "btnth";
            btnth.Size = new Size(152, 38);
            btnth.TabIndex = 9;
            btnth.Text = "Thực Hiện";
            btnth.UseVisualStyleBackColor = true;
            btnth.Click += btnth_Click;
            // 
            // btntt
            // 
            btntt.Font = new Font("Tahoma", 11F);
            btntt.Location = new Point(510, 169);
            btntt.Name = "btntt";
            btntt.Size = new Size(152, 36);
            btntt.TabIndex = 10;
            btntt.Text = "Tiếp Tục";
            btntt.UseVisualStyleBackColor = true;
            btntt.Click += btntt_Click;
            // 
            // btnthoat
            // 
            btnthoat.Font = new Font("Tahoma", 11F);
            btnthoat.Location = new Point(510, 243);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(152, 38);
            btnthoat.TabIndex = 11;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 550);
            Controls.Add(btnthoat);
            Controls.Add(btntt);
            Controls.Add(btnth);
            Controls.Add(txtkq);
            Controls.Add(txtc);
            Controls.Add(txtb);
            Controls.Add(txta);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txta;
        private TextBox txtb;
        private TextBox txtc;
        private TextBox txtkq;
        private Button btnth;
        private Button btntt;
        private Button btnthoat;
    }
}
