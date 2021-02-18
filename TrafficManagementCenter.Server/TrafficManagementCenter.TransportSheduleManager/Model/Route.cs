namespace TrafficManagementCenter.TransportSheduleManager.Model
{
    public class Route
    {
        public long Key { get; set; }
        
        public TransportStop StartTransportStop { get; set; }
        
        public TransportStop EndTransportStop { get; set; }
        
        public string Name { get; set; }
        
        public TransportType TransportType { get; set; }

        public string GetFullRoute() => $"{StartTransportStop} - {EndTransportStop}";
    }
}