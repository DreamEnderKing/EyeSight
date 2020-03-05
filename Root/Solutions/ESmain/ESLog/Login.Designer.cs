/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/1/28
 * 时间: 14:07
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace ESLog
{
	partial class Login
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.UserIcon = new System.Windows.Forms.PictureBox();
			this.BackBtn = new System.Windows.Forms.PictureBox();
			this.ForeBtn = new System.Windows.Forms.PictureBox();
			this.SubmitBtn = new System.Windows.Forms.PictureBox();
			this.KeyField = new System.Windows.Forms.TextBox();
			this.WaitImg = new System.Windows.Forms.PictureBox();
			this.WelText = new System.Windows.Forms.Label();
			this.NameText = new System.Windows.Forms.Label();
			this.BackimgPan = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ForeBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SubmitBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WaitImg)).BeginInit();
			this.SuspendLayout();
			// 
			// UserIcon
			// 
			this.UserIcon.BackColor = System.Drawing.Color.Transparent;
			this.UserIcon.Image = ((System.Drawing.Image)(resources.GetObject("UserIcon.Image")));
			this.UserIcon.Location = new System.Drawing.Point(107, 29);
			this.UserIcon.Name = "UserIcon";
			this.UserIcon.Size = new System.Drawing.Size(84, 72);
			this.UserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.UserIcon.TabIndex = 0;
			this.UserIcon.TabStop = false;
			// 
			// BackBtn
			// 
			this.BackBtn.BackColor = System.Drawing.Color.Transparent;
			this.BackBtn.Image = ((System.Drawing.Image)(resources.GetObject("BackBtn.Image")));
			this.BackBtn.Location = new System.Drawing.Point(62, 153);
			this.BackBtn.Name = "BackBtn";
			this.BackBtn.Size = new System.Drawing.Size(36, 31);
			this.BackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.BackBtn.TabIndex = 1;
			this.BackBtn.TabStop = false;
			// 
			// ForeBtn
			// 
			this.ForeBtn.BackColor = System.Drawing.Color.Transparent;
			this.ForeBtn.Image = ((System.Drawing.Image)(resources.GetObject("ForeBtn.Image")));
			this.ForeBtn.Location = new System.Drawing.Point(153, 154);
			this.ForeBtn.Name = "ForeBtn";
			this.ForeBtn.Size = new System.Drawing.Size(37, 29);
			this.ForeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ForeBtn.TabIndex = 2;
			this.ForeBtn.TabStop = false;
			// 
			// SubmitBtn
			// 
			this.SubmitBtn.BackColor = System.Drawing.Color.Transparent;
			this.SubmitBtn.Image = ((System.Drawing.Image)(resources.GetObject("SubmitBtn.Image")));
			this.SubmitBtn.Location = new System.Drawing.Point(124, 201);
			this.SubmitBtn.Name = "SubmitBtn";
			this.SubmitBtn.Size = new System.Drawing.Size(55, 53);
			this.SubmitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.SubmitBtn.TabIndex = 3;
			this.SubmitBtn.TabStop = false;
			// 
			// KeyField
			// 
			this.KeyField.Location = new System.Drawing.Point(265, 94);
			this.KeyField.Name = "KeyField";
			this.KeyField.Size = new System.Drawing.Size(132, 21);
			this.KeyField.TabIndex = 4;
			// 
			// WaitImg
			// 
			this.WaitImg.BackColor = System.Drawing.Color.Transparent;
			this.WaitImg.Image = ((System.Drawing.Image)(resources.GetObject("WaitImg.Image")));
			this.WaitImg.Location = new System.Drawing.Point(59, 284);
			this.WaitImg.Name = "WaitImg";
			this.WaitImg.Size = new System.Drawing.Size(74, 66);
			this.WaitImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.WaitImg.TabIndex = 5;
			this.WaitImg.TabStop = false;
			// 
			// WelText
			// 
			this.WelText.BackColor = System.Drawing.Color.Transparent;
			this.WelText.Location = new System.Drawing.Point(158, 279);
			this.WelText.Name = "WelText";
			this.WelText.Size = new System.Drawing.Size(164, 40);
			this.WelText.TabIndex = 6;
			this.WelText.Text = "label1";
			// 
			// NameText
			// 
			this.NameText.BackColor = System.Drawing.Color.Transparent;
			this.NameText.Font = new System.Drawing.Font("宋体", 30.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)8));
			this.NameText.Location = new System.Drawing.Point(243, 215);
			this.NameText.Name = "NameText";
			this.NameText.Size = new System.Drawing.Size(333, 38);
			this.NameText.TabIndex = 7;
			this.NameText.Text = "Username";
			// 
			// BackimgPan
			// 
			this.BackimgPan.BackColor = System.Drawing.Color.LightGray;
			this.BackimgPan.Location = new System.Drawing.Point(568, 29);
			this.BackimgPan.Name = "BackimgPan";
			this.BackimgPan.Size = new System.Drawing.Size(270, 153);
			this.BackimgPan.TabIndex = 8;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(841, 579);
			this.Controls.Add(this.BackimgPan);
			this.Controls.Add(this.NameText);
			this.Controls.Add(this.WelText);
			this.Controls.Add(this.WaitImg);
			this.Controls.Add(this.KeyField);
			this.Controls.Add(this.SubmitBtn);
			this.Controls.Add(this.ForeBtn);
			this.Controls.Add(this.BackBtn);
			this.Controls.Add(this.UserIcon);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.SizeChanged += new System.EventHandler(this.LoginSizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.UserIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ForeBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SubmitBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WaitImg)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Panel BackimgPan;
		private System.Windows.Forms.Label NameText;
		private System.Windows.Forms.Label WelText;
		private System.Windows.Forms.PictureBox WaitImg;
		private System.Windows.Forms.TextBox KeyField;
		private System.Windows.Forms.PictureBox SubmitBtn;
		private System.Windows.Forms.PictureBox ForeBtn;
		private System.Windows.Forms.PictureBox BackBtn;
		private System.Windows.Forms.PictureBox UserIcon;
	}
}
