using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Practice3
{
	[TestFixture()]
	class MoneyTest
	{
		ChMoney m_TestMoney = new ChMoney();

		[TestCase( "1", Result = true )]
		[TestCase( "ten", Result = false )]
		[TestCase( "-526", Result = false )]
		[TestCase( "752", Result = true )]
		[TestCase( "+-*/", Result = false )]
		[TestCase( "-1", Result = false )]

		[Test()]
		public bool CheckInput( string szMoney )
		{
			int nMoney = 1;
			return m_TestMoney.InputMoney( szMoney, ref nMoney );
		}

		[TestCase( 78, new bool[] { true, true, true, true }, Result = new int[] { 1, 1, 0, 1, 3 } )]
		[TestCase( 123, new bool[] { false, true, false, false }, Result = new int[] { 0, 6, 0, 0, 3 } )]
		[TestCase( 85, new bool[] { true, false, false, false }, Result = new int[] { 1, 0, 0, 0, 35 } )]
		[TestCase( 15, new bool[] { true, true, false, false }, Result = new int[] { 0, 0, 0, 0, 15 } )]
		[TestCase( 936, new bool[] { false, true, true, true }, Result = new int[] { 0, 46, 1, 1, 1 } )]
		[TestCase( 35, new bool[] { false, false, true, true }, Result = new int[] { 0, 0, 3, 1, 0 } )]
		[TestCase( 0, new bool[] { false, false, false, false }, Result = new int[] { 0, 0, 0, 0, 0 } )]

		[Test()]
		public int[] CheckMoney( int nMoney, bool[] bTypenumberArray )
		{
			return m_TestMoney.DiffMoney( nMoney, bTypenumberArray );
		}
	}
}
