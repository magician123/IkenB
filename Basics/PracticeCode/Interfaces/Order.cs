using System;

namespace Interfaces
{
    internal class Order
    {
        public DateTime DatePlaced { get; set; }
        public float TotalPrice { get; set; }
        public bool IsShipped { get; internal set; }
        public Shipment Shipment { get; internal set; }
    }
}