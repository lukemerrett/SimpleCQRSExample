using SimpleCQRS;

namespace CQRSGui
{
    using SimpleCQRS.Bus;

    public static class ServiceLocator
    {
        public static FakeBus Bus { get; set; }
       
    }
}