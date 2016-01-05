namespace TemplateMethodPattern.Domain
{
	public class DhlShipment : OrderShipment
	{
		public override void GetShippingLabelFromCarrier()
		{
			Label = string.Format("DHL: [{0}]", ShippingAddress);
		}
	}
}