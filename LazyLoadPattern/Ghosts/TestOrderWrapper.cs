using System.Collections;
using LazyLoadPattern.Ghosts.Domain;

namespace LazyLoadPattern.Ghosts
{
	public class TestOrderWrapper : Order
	{
		public bool WasLoadCalled;
		public int GetDataRowCount;

		public TestOrderWrapper(int id)
			: base(id)
		{
		}

		public override void Load()
		{
			WasLoadCalled = true;
			base.Load();
		}

		protected override ArrayList GetDataRow()
		{
			GetDataRowCount++;
			return base.GetDataRow();
		}
	}
}