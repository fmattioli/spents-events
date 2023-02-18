using Spents.Domain.Entities;
using Spents.Events.v1.ValueObjects;

namespace Spents.Events.v1
{
    public class ReceiptEventCreated : EventBody<Receipt>
    {
        public ReceiptEventCreated(Receipt Body)
        {
            Version = "V1";
            CreatedDate = DateTime.Now;
            MessageKey = Guid.NewGuid().ToString();
            ReceiptStatus = ReceiptEventType.ReceiptCreated;
            Name = ReceiptStatus.ToString() + "-" + Version;
            base.Body = Body;
        }

        public string Name { get; private set; }
        public ReceiptEventType ReceiptStatus { get; private set; }
        public string MessageKey { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public string Version { get; private set; }
    }
}
