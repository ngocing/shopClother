namespace QL_ShopThoiTrang
{
    partial class ChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePass));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttom_cancel = new System.Windows.Forms.PictureBox();
            this.buttom_confirm = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newpass = new System.Windows.Forms.TextBox();
            this.confirmpass = new System.Windows.Forms.TextBox();
            this.account = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lgl3 = new System.Windows.Forms.Label();
            this.lgl2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_confirm)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(17, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            // 
            // buttom_cancel
            // 
            this.buttom_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttom_cancel.BackgroundImage")));
            this.buttom_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttom_cancel.Location = new System.Drawing.Point(254, 205);
            this.buttom_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttom_cancel.Name = "buttom_cancel";
            this.buttom_cancel.Size = new System.Drawing.Size(105, 36);
            this.buttom_cancel.TabIndex = 107;
            this.buttom_cancel.TabStop = false;
            this.buttom_cancel.Click += new System.EventHandler(this.buttom_cancel_Click);
            // 
            // buttom_confirm
            // 
            this.buttom_confirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttom_confirm.BackgroundImage")));
            this.buttom_confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttom_confirm.Location = new System.Drawing.Point(17, 205);
            this.buttom_confirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttom_confirm.Name = "buttom_confirm";
            this.buttom_confirm.Size = new System.Drawing.Size(105, 36);
            this.buttom_confirm.TabIndex = 106;
            this.buttom_confirm.TabStop = false;
            this.buttom_confirm.Click += new System.EventHandler(this.buttom_confirm_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(45, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 24);
            this.label1.TabIndex = 105;
            this.label1.Text = "Bạn phải được xác nhận bởi Master";
            // 
            // newpass
            // 
            this.newpass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpass.Location = new System.Drawing.Point(192, 114);
            this.newpass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newpass.Name = "newpass";
            this.newpass.PasswordChar = '*';
            this.newpass.Size = new System.Drawing.Size(167, 29);
            this.newpass.TabIndex = 98;
            this.newpass.TextChanged += new System.EventHandler(this.newpass_TextChanged);
            // 
            // confirmpass
            // 
            this.confirmpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpass.Location = new System.Drawing.Point(192, 152);
            this.confirmpass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmpass.Name = "confirmpass";
            this.confirmpass.PasswordChar = '*';
            this.confirmpass.Size = new System.Drawing.Size(167, 29);
            this.confirmpass.TabIndex = 99;
            this.confirmpass.TextChanged += new System.EventHandler(this.confirmpass_TextChanged);
            // 
            // account
            // 
            this.account.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.account.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.account.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.Location = new System.Drawing.Point(192, 41);
            this.account.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(167, 29);
            this.account.TabIndex = 97;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(13, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 104;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // pass
            // 
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(192, 76);
            this.pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(167, 29);
            this.pass.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 101;
            this.label2.Text = "Mật khẩu mới";
            // 
            // lgl3
            // 
            this.lgl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lgl3.AutoSize = true;
            this.lgl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgl3.ForeColor = System.Drawing.Color.Red;
            this.lgl3.Location = new System.Drawing.Point(13, 81);
            this.lgl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lgl3.Name = "lgl3";
            this.lgl3.Size = new System.Drawing.Size(86, 24);
            this.lgl3.TabIndex = 103;
            this.lgl3.Text = "Mật khẩu";
            // 
            // lgl2
            // 
            this.lgl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lgl2.AutoSize = true;
            this.lgl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgl2.ForeColor = System.Drawing.Color.Red;
            this.lgl2.Location = new System.Drawing.Point(13, 43);
            this.lgl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lgl2.Name = "lgl2";
            this.lgl2.Size = new System.Drawing.Size(93, 24);
            this.lgl2.TabIndex = 102;
            this.lgl2.Text = "Tài khoản";
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 252);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttom_cancel);
            this.Controls.Add(this.buttom_confirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.confirmpass);
            this.Controls.Add(this.account);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lgl3);
            this.Controls.Add(this.lgl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ChangePass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_confirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox buttom_cancel;
        private System.Windows.Forms.PictureBox buttom_confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.TextBox confirmpass;
        private System.Windows.Forms.TextBox account;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lgl3;
        private System.Windows.Forms.Label lgl2;

    }
}