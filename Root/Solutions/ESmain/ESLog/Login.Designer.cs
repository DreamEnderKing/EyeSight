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
			this.KeyField = new System.Windows.Forms.TextBox();
			this.WaitImg = new System.Windows.Forms.PictureBox();
			this.WelText = new System.Windows.Forms.Label();
			this.NameText = new System.Windows.Forms.Label();
			this.BackimgPan = new MetroFramework.Controls.MetroPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.SubmitBtn = new System.Windows.Forms.Button();
			this.Timer1 = new UserCon.Timer_Clean();
			((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ForeBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WaitImg)).BeginInit();
			this.BackimgPan.SuspendLayout();
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
			// KeyField
			// 
			this.KeyField.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.KeyField.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.KeyField.Location = new System.Drawing.Point(265, 94);
			this.KeyField.Name = "KeyField";
			this.KeyField.PasswordChar = '*';
			this.KeyField.Size = new System.Drawing.Size(132, 39);
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
			this.WaitImg.Visible = false;
			// 
			// WelText
			// 
			this.WelText.BackColor = System.Drawing.Color.Transparent;
			this.WelText.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.WelText.ForeColor = System.Drawing.Color.Aqua;
			this.WelText.Location = new System.Drawing.Point(158, 279);
			this.WelText.Name = "WelText";
			this.WelText.Size = new System.Drawing.Size(164, 40);
			this.WelText.TabIndex = 6;
			this.WelText.Text = "Welcome";
			this.WelText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.WelText.Visible = false;
			// 
			// NameText
			// 
			this.NameText.BackColor = System.Drawing.Color.Transparent;
			this.NameText.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(8)));
			this.NameText.ForeColor = System.Drawing.Color.Aqua;
			this.NameText.Location = new System.Drawing.Point(243, 215);
			this.NameText.Name = "NameText";
			this.NameText.Size = new System.Drawing.Size(333, 38);
			this.NameText.TabIndex = 7;
			this.NameText.Text = "Username";
			this.NameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.NameText.Click += new System.EventHandler(this.InitColor);
			// 
			// BackimgPan
			// 
			this.BackimgPan.AutoScroll = true;
			this.BackimgPan.AutoScrollMargin = new System.Drawing.Size(5, 0);
			this.BackimgPan.BackColor = System.Drawing.Color.White;
			this.BackimgPan.Controls.Add(this.label1);
			this.BackimgPan.HorizontalScrollbarBarColor = true;
			this.BackimgPan.HorizontalScrollbarHighlightOnWheel = false;
			this.BackimgPan.HorizontalScrollbarSize = 0;
			this.BackimgPan.Location = new System.Drawing.Point(568, 29);
			this.BackimgPan.Name = "BackimgPan";
			this.BackimgPan.Size = new System.Drawing.Size(270, 153);
			this.BackimgPan.TabIndex = 8;
			this.BackimgPan.VerticalScrollbarBarColor = true;
			this.BackimgPan.VerticalScrollbarHighlightOnWheel = true;
			this.BackimgPan.VerticalScrollbarSize = 10;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(29, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(227, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "Select your image here:";
			// 
			// SubmitBtn
			// 
			this.SubmitBtn.BackColor = System.Drawing.Color.Transparent;
			this.SubmitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SubmitBtn.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.SubmitBtn.ForeColor = System.Drawing.Color.Aqua;
			this.SubmitBtn.Location = new System.Drawing.Point(249, 343);
			this.SubmitBtn.Name = "SubmitBtn";
			this.SubmitBtn.Size = new System.Drawing.Size(130, 50);
			this.SubmitBtn.TabIndex = 9;
			this.SubmitBtn.Text = "Go";
			this.SubmitBtn.UseVisualStyleBackColor = false;
			// 
			// Timer1
			// 
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 120000;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(947, 579);
			this.Controls.Add(this.SubmitBtn);
			this.Controls.Add(this.BackimgPan);
			this.Controls.Add(this.NameText);
			this.Controls.Add(this.WelText);
			this.Controls.Add(this.WaitImg);
			this.Controls.Add(this.KeyField);
			this.Controls.Add(this.ForeBtn);
			this.Controls.Add(this.BackBtn);
			this.Controls.Add(this.UserIcon);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.InitColor);
			this.BackColorChanged += new System.EventHandler(this.InitColor);
			this.SizeChanged += new System.EventHandler(this.LoginSizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.UserIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ForeBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WaitImg)).EndInit();
			this.BackimgPan.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private MetroFramework.Controls.MetroPanel BackimgPan;
		private System.Windows.Forms.Label NameText;
		private System.Windows.Forms.Label WelText;
		private System.Windows.Forms.PictureBox WaitImg;
		private System.Windows.Forms.TextBox KeyField;
		private System.Windows.Forms.Button SubmitBtn;
		private System.Windows.Forms.PictureBox ForeBtn;
		private System.Windows.Forms.PictureBox BackBtn;
		private System.Windows.Forms.PictureBox UserIcon;
		private UserCon.Timer_Clean Timer1;
		
	}
}
