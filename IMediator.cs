namespace MediatorDesignPattern
{
    public interface IMediator
    {
        void Notify(object sender, string value);
    }
}
