namespace MediatorDesignPattern
{
    public class Component1 : BaseComponent
    {
        public void DoAlpha()
        {
            Console.WriteLine("Component 1 runs Alpha.");

            _mediator.Notify(
                this, 
                "Alpha");
        }

        public void DoBeta()
        {
            Console.WriteLine("Component 1 runs Beta.");

            _mediator.Notify(
                this, 
                "Beta");
        }
    }
}
