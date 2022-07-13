namespace MediatorDesignPattern
{
    public class Component2 : BaseComponent
    {
        public void DoGamma()
        {
            Console.WriteLine("Component 2 runs Gamma.");

            _mediator.Notify(
                this, 
                "Gamma");
        }

        public void DoDelta()
        {
            Console.WriteLine("Component 2 runs Delta.");

            _mediator.Notify(
                this, 
                "Delta");
        }
    }
}
