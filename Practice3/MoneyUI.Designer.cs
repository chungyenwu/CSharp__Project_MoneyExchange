namespace Practice3
{
	partial class MoneyUI
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.m_lblMoney = new System.Windows.Forms.Label();
			this.m_txtTotalMoney = new System.Windows.Forms.TextBox();
			this.m_btnConfirm = new System.Windows.Forms.Button();
			this.m_chbFifty = new System.Windows.Forms.CheckBox();
			this.m_chbTwenty = new System.Windows.Forms.CheckBox();
			this.m_chbTen = new System.Windows.Forms.CheckBox();
			this.m_chbFive = new System.Windows.Forms.CheckBox();
			this.m_lblOne = new System.Windows.Forms.Label();
			this.m_txtFifty = new System.Windows.Forms.TextBox();
			this.m_txtTwenty = new System.Windows.Forms.TextBox();
			this.m_txtTen = new System.Windows.Forms.TextBox();
			this.m_txtFive = new System.Windows.Forms.TextBox();
			this.m_txtOne = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.m_lblMoney.AutoSize = true;
			this.m_lblMoney.Location = new System.Drawing.Point( 53, 67 );
			this.m_lblMoney.Name = "label2";
			this.m_lblMoney.Size = new System.Drawing.Size( 53, 12 );
			this.m_lblMoney.TabIndex = 1;
			this.m_lblMoney.Text = "兌換金額";
			// 
			// textBox1
			// 
			this.m_txtTotalMoney.Location = new System.Drawing.Point( 114, 64 );
			this.m_txtTotalMoney.Name = "textBox1";
			this.m_txtTotalMoney.Size = new System.Drawing.Size( 100, 22 );
			this.m_txtTotalMoney.TabIndex = 2;
			// 
			// confirm_exc
			// 
			this.m_btnConfirm.Location = new System.Drawing.Point( 301, 62 );
			this.m_btnConfirm.Name = "confirm_exc";
			this.m_btnConfirm.Size = new System.Drawing.Size( 75, 23 );
			this.m_btnConfirm.TabIndex = 3;
			this.m_btnConfirm.Text = "確認";
			this.m_btnConfirm.UseVisualStyleBackColor = true;
			this.m_btnConfirm.Click += new System.EventHandler( OnComfirmClick );
			// 
			// checkBox1
			// 
			this.m_chbFifty.AutoSize = true;
			this.m_chbFifty.Location = new System.Drawing.Point( 24, 161 );
			this.m_chbFifty.Name = "checkBox1";
			this.m_chbFifty.Size = new System.Drawing.Size( 36, 16 );
			this.m_chbFifty.TabIndex = 4;
			this.m_chbFifty.Text = "50";
			this.m_chbFifty.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.m_chbTwenty.AutoSize = true;
			this.m_chbTwenty.Location = new System.Drawing.Point( 104, 161 );
			this.m_chbTwenty.Name = "checkBox2";
			this.m_chbTwenty.Size = new System.Drawing.Size( 36, 16 );
			this.m_chbTwenty.TabIndex = 5;
			this.m_chbTwenty.Text = "20";
			this.m_chbTwenty.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.m_chbTen.AutoSize = true;
			this.m_chbTen.Location = new System.Drawing.Point( 193, 162 );
			this.m_chbTen.Name = "checkBox3";
			this.m_chbTen.Size = new System.Drawing.Size( 36, 16 );
			this.m_chbTen.TabIndex = 6;
			this.m_chbTen.Text = "10";
			this.m_chbTen.UseVisualStyleBackColor = true;
			// 
			// checkBox4
			// 
			this.m_chbFive.AutoSize = true;
			this.m_chbFive.Location = new System.Drawing.Point( 287, 162 );
			this.m_chbFive.Name = "checkBox4";
			this.m_chbFive.Size = new System.Drawing.Size( 30, 16 );
			this.m_chbFive.TabIndex = 7;
			this.m_chbFive.Text = "5";
			this.m_chbFive.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.m_lblOne.AutoSize = true;
			this.m_lblOne.Location = new System.Drawing.Point( 386, 165 );
			this.m_lblOne.Name = "label3";
			this.m_lblOne.Size = new System.Drawing.Size( 11, 12 );
			this.m_lblOne.TabIndex = 8;
			this.m_lblOne.Text = "1";
			// 
			// textBox2
			// 
			this.m_txtFifty.Location = new System.Drawing.Point( 12, 199 );
			this.m_txtFifty.Name = "textBox2";
			this.m_txtFifty.Size = new System.Drawing.Size( 61, 22 );
			this.m_txtFifty.TabIndex = 9;
			// 
			// textBox3
			// 
			this.m_txtTwenty.Location = new System.Drawing.Point( 92, 199 );
			this.m_txtTwenty.Name = "textBox3";
			this.m_txtTwenty.Size = new System.Drawing.Size( 63, 22 );
			this.m_txtTwenty.TabIndex = 10;
			// 
			// textBox4
			// 
			this.m_txtTen.Location = new System.Drawing.Point( 178, 199 );
			this.m_txtTen.Name = "textBox4";
			this.m_txtTen.Size = new System.Drawing.Size( 65, 22 );
			this.m_txtTen.TabIndex = 11;
			// 
			// textBox5
			// 
			this.m_txtFive.Location = new System.Drawing.Point( 271, 198 );
			this.m_txtFive.Name = "textBox5";
			this.m_txtFive.Size = new System.Drawing.Size( 64, 22 );
			this.m_txtFive.TabIndex = 12;
			// 
			// textBox6
			// 
			this.m_txtOne.Location = new System.Drawing.Point( 366, 198 );
			this.m_txtOne.Name = "textBox6";
			this.m_txtOne.Size = new System.Drawing.Size( 58, 22 );
			this.m_txtOne.TabIndex = 13;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 449, 346 );
			this.Controls.Add( this.m_txtOne );
			this.Controls.Add( this.m_txtFive );
			this.Controls.Add( this.m_txtTen );
			this.Controls.Add( this.m_txtTwenty );
			this.Controls.Add( this.m_txtFifty );
			this.Controls.Add( this.m_lblOne );
			this.Controls.Add( this.m_chbFive );
			this.Controls.Add( this.m_chbTen );
			this.Controls.Add( this.m_chbTwenty );
			this.Controls.Add( this.m_chbFifty );
			this.Controls.Add( this.m_btnConfirm );
			this.Controls.Add( this.m_txtTotalMoney );
			this.Controls.Add( this.m_lblMoney );
			this.Name = "MoneyUI";
			this.Text = "MoneyUI";
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label m_lblMoney;
		private System.Windows.Forms.TextBox m_txtTotalMoney;
		private System.Windows.Forms.Button m_btnConfirm;
		private System.Windows.Forms.CheckBox m_chbFifty;
		private System.Windows.Forms.CheckBox m_chbTwenty;
		private System.Windows.Forms.CheckBox m_chbTen;
		private System.Windows.Forms.CheckBox m_chbFive;
		private System.Windows.Forms.Label m_lblOne;
		private System.Windows.Forms.TextBox m_txtFifty;
		private System.Windows.Forms.TextBox m_txtTwenty;
		private System.Windows.Forms.TextBox m_txtTen;
		private System.Windows.Forms.TextBox m_txtFive;
		private System.Windows.Forms.TextBox m_txtOne;
	}
}

