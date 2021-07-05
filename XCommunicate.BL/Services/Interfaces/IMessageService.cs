namespace Services.Interfaces
{
    public interface IMessageService
    {
        bool Post();
        void Delete(int messageId);
    }
}
