using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Practice3
{
	public partial class MoneyUI : Form
	{
		public MoneyUI()
		{
			InitializeComponent();
			m_MoneyEXC = new ChMoney();
		}
	}

	public partial class MoneyUI : Form
	{
		ChMoney m_MoneyEXC;
		private void OnComfirmClick( object sender, EventArgs e )
		{
			int[] nMoneyArray = new int[ 5 ];
			bool[] bCheckMoneyArray = new bool[ 4 ];
			string szCash = m_txtTotalMoney.Text;

			// Step 1. Check all the input are N or not, and put the value into exchange sys
			int nCash = 0;
			if( m_MoneyEXC.InputMoney( szCash, ref nCash ) == false ) {
				MessageBox.Show( "Input the Positive Interger" );
				return;
			}

			//Check or not
			if( m_chbFifty.CheckState == CheckState.Checked ) {
				bCheckMoneyArray[ 0 ] = true;
			}
			if( m_chbTwenty.CheckState == CheckState.Checked ) {
				bCheckMoneyArray[ 1 ] = true;
			}
			if( m_chbTen.CheckState == CheckState.Checked ) {
				bCheckMoneyArray[ 2 ] = true;
			}
			if( m_chbFive.CheckState == CheckState.Checked ) {
				bCheckMoneyArray[ 3 ] = true;
			}

			// Step 2. Exchange the Money
			nMoneyArray = m_MoneyEXC.DiffMoney( nCash, bCheckMoneyArray );

			// Step 3. Put the excahge result back.
			m_txtFifty.Text = Convert.ToString( nMoneyArray[ 0 ] );
			m_txtTwenty.Text = Convert.ToString( nMoneyArray[ 1 ] );
			m_txtTen.Text = Convert.ToString( nMoneyArray[ 2 ] );
			m_txtFive.Text = Convert.ToString( nMoneyArray[ 3 ] );
			m_txtOne.Text = Convert.ToString( nMoneyArray[ 4 ] );
			return;
		}
	}
}