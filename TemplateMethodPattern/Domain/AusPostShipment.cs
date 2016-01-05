using System;
using System.Text;

namespace TemplateMethodPattern.Domain
{
	public class AusPostShipment : OrderShipment
	{
		public override void VerifyShippingData()
		{
			if (string.IsNullOrWhiteSpace(ShippingAddress) || !ShippingAddress.ToLower().Contains("australia"))
			{
				throw new ApplicationException("Invalid address");
			}
		}

		public override void GetShippingLabelFromCarrier()
		{
			Label = string.Format("AusPost: [{0}]", ShippingAddress);
		}

		public override void PrintLabel(StringBuilder stringBuilder)
		{
			string label = string.Format("Label: {0} (Australia)", Label);
			stringBuilder.AppendLine(label);
		}
	}
}