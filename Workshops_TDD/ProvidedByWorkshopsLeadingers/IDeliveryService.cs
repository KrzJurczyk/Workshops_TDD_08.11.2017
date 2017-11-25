namespace Workshops_TDD
{
    public interface IDeliveryService
    {
        int GenerateShipmentReferenceNumber(int numberOfItemsToDeliver);
        void RequestDelivery(string shipmentReferenceNumber, OrderModel order);
    }
}