using System;
using System.Text;

namespace TemplateMethodPattern.Domain
{
	public abstract class OrderShipment
	{
		public string ShippingAddress { get; set; }
		public string Label { get; set; }

		public void Ship(StringBuilder stringBuilder)
		{
			VerifyShippingData();
			GetShippingLabelFromCarrier();
			PrintLabel(stringBuilder);
		}

		public virtual void VerifyShippingData()
		{
			if (string.IsNullOrWhiteSpace(ShippingAddress))
			{
				throw new ApplicationException("Invalid address");
			}
		}

		public abstract void GetShippingLabelFromCarrier();

		public virtual void PrintLabel(StringBuilder stringBuilder)
		{
			string label = string.Format("Label: {0}", Label);
			stringBuilder.AppendLine(label);
		}
	}
}