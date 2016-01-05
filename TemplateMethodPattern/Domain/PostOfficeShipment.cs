namespace TemplateMethodPattern.Domain
{
	public class PostOfficeShipment : OrderShipment
	{
		public override void GetShippingLabelFromCarrier()
		{
			Label = string.Format("Post Office: [{0}]", ShippingAddress);
		}
	}
}