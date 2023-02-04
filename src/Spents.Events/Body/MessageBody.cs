namespace Spents.Events.Body
{
    public class MessageBody<T> where T : class
    {
        public MessageBody(T bodyValue)
        {
            this.Body = bodyValue;
        }
        public T Body { get; set; }
    }
}
