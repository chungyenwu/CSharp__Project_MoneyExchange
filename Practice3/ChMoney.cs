using System;
using System.Collections.Generic;
using System.Text;

namespace Practice3
{
	class ChMoney
	{
		public bool InputMoney( string szMoney, ref int nMoney )
		{
			bool bResult = Int32.TryParse( szMoney, out nMoney );
			if( bResult != true ) {
				return false;
			}
			if( nMoney >= 0 ) {
				return true;
			}
			return false;
		}

		public int[] DiffMoney( int nResMoney, bool[] bMoneyTypeArray )
		{
			int[] nMoneyNumberArray = new int[ 5 ];
			bool bFifty = bMoneyTypeArray[ 0 ];
			bool bTwenty = bMoneyTypeArray[ 1 ];
			bool bTen = bMoneyTypeArray[ 2 ];
			bool bFive = bMoneyTypeArray[ 3 ];

			//if Fifty was checked
			if( bFifty == true ) {
				nMoneyNumberArray[ 0 ] = nResMoney / 50;
				nResMoney = nResMoney - nMoneyNumberArray[ 0 ] * 50;
			}
			//if Twenty was checked
			if( bTwenty == true ) {
				nMoneyNumberArray[ 1 ] = nResMoney / 20;
				nResMoney = nResMoney - nMoneyNumberArray[ 1 ] * 20;
			}
			//if Ten was checked
			if( bTen == true ) {
				nMoneyNumberArray[ 2 ] = nResMoney / 10;
				nResMoney = nResMoney - nMoneyNumberArray[ 2 ] * 10;
			}
			//if Five was checked
			if( bFive == true ) {
				nMoneyNumberArray[ 3 ] = nResMoney / 5;
				nResMoney = nResMoney - nMoneyNumberArray[ 3 ] * 5;
			}

			nMoneyNumberArray[ 4 ] = nResMoney;
			return nMoneyNumberArray;
		}
	}
}
