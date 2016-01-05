namespace TemplateMethodPattern.Domain
{
	public class TntShipment : OrderShipment
	{
		public override void GetShippingLabelFromCarrier()
		{
			Label = string.Format("TNT: [{0}]", ShippingAddress);
		}
	}
}