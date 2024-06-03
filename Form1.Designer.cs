namespace Csharp_TINHTONGmoi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btntinhtong = new System.Windows.Forms.Button();
            this.lblso1 = new System.Windows.Forms.Label();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.txtso3 = new System.Windows.Forms.TextBox();
            this.lblkq = new System.Windows.Forms.Label();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.lblso2 = new System.Windows.Forms.Label();
            this.btntinhhieu = new System.Windows.Forms.Button();
            this.btntinhtich = new System.Windows.Forms.Button();
            this.btntinhthuong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btntinhtong
            // 
            this.btntinhtong.Location = new System.Drawing.Point(39, 287);
            this.btntinhtong.Name = "btntinhtong";
            this.btntinhtong.Size = new System.Drawing.Size(113, 46);
            this.btntinhtong.TabIndex = 0;
            this.btntinhtong.Text = "TÍNH TỔNG";
            this.btntinhtong.UseVisualStyleBackColor = true;
            this.btntinhtong.Click += new System.EventHandler(this.btntinhtong_Click);
            // 
            // lblso1
            // 
            this.lblso1.AutoSize = true;
            this.lblso1.Location = new System.Drawing.Point(87, 89);
            this.lblso1.Name = "lblso1";
            this.lblso1.Size = new System.Drawing.Size(31, 13);
            this.lblso1.TabIndex = 1;
            this.lblso1.Text = "SỐ 1";
            this.lblso1.MouseHover += new System.EventHandler(this.lblso1_MouseHover);
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(186, 86);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(100, 20);
            this.txtso1.TabIndex = 2;
            // 
            // txtso3
            // 
            this.txtso3.Location = new System.Drawing.Point(186, 191);
            this.txtso3.Name = "txtso3";
            this.txtso3.Size = new System.Drawing.Size(100, 20);
            this.txtso3.TabIndex = 4;
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(224, 251);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(43, 13);
            this.lblkq.TabIndex = 3;
            this.lblkq.Text = "kết quả";
            this.lblkq.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtso2
            // 
            this.txtso2.Location = new System.Drawing.Point(186, 135);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(100, 20);
            this.txtso2.TabIndex = 6;
            // 
            // lblso2
            // 
            this.lblso2.AutoSize = true;
            this.lblso2.Location = new System.Drawing.Point(87, 138);
            this.lblso2.Name = "lblso2";
            this.lblso2.Size = new System.Drawing.Size(31, 13);
            this.lblso2.TabIndex = 5;
            this.lblso2.Text = "SỐ 2";
            this.lblso2.MouseHover += new System.EventHandler(this.lblso2_MouseHover);
            // 
            // btntinhhieu
            // 
            this.btntinhhieu.Location = new System.Drawing.Point(214, 287);
            this.btntinhhieu.Name = "btntinhhieu";
            this.btntinhhieu.Size = new System.Drawing.Size(110, 46);
            this.btntinhhieu.TabIndex = 7;
            this.btntinhhieu.Text = "TÍNH HIỆU";
            this.btntinhhieu.UseVisualStyleBackColor = true;
            this.btntinhhieu.Click += new System.EventHandler(this.btntinhhieu_Click);
            // 
            // btntinhtich
            // 
            this.btntinhtich.Location = new System.Drawing.Point(426, 287);
            this.btntinhtich.Name = "btntinhtich";
            this.btntinhtich.Size = new System.Drawing.Size(110, 46);
            this.btntinhtich.TabIndex = 8;
            this.btntinhtich.Text = "TÍNH TÍCH";
            this.btntinhtich.UseVisualStyleBackColor = true;
            this.btntinhtich.Click += new System.EventHandler(this.btntinhtich_Click);
            // 
            // btntinhthuong
            // 
            this.btntinhthuong.Location = new System.Drawing.Point(617, 287);
            this.btntinhthuong.Name = "btntinhthuong";
            this.btntinhthuong.Size = new System.Drawing.Size(110, 46);
            this.btntinhthuong.TabIndex = 9;
            this.btntinhthuong.Text = "TÍNH THƯƠNG";
            this.btntinhthuong.UseVisualStyleBackColor = true;
            this.btntinhthuong.Click += new System.EventHandler(this.btntinhthuong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntinhthuong);
            this.Controls.Add(this.btntinhtich);
            this.Controls.Add(this.btntinhhieu);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.lblso2);
            this.Controls.Add(this.txtso3);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.txtso1);
            this.Controls.Add(this.lblso1);
            this.Controls.Add(this.btntinhtong);
            this.Name = "Form1";
            this.Text = "ỨNG DỤNG TÍNH TỔNG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntinhtong;
        private System.Windows.Forms.Label lblso1;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.TextBox txtso3;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.Label lblso2;
        private System.Windows.Forms.Button btntinhhieu;
        private System.Windows.Forms.Button btntinhtich;
        private System.Windows.Forms.Button btntinhthuong;
    }
}

