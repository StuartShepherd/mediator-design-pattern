namespace MediatorDesignPattern
{
    public class ConcreteMediator : IMediator
    {
        private readonly Component1 _component1;

        private readonly Component2 _component2;

        public ConcreteMediator(
            Component1 component1, 
            Component2 component2)
        {
            _component1 = component1;
            _component1.SetMediator(this);

            _component2 = component2;
            _component2.SetMediator(this);
        }

        public void Notify(
            object sender, 
            string value)
        {
            if (value == "Alpha")
            {
                Console.WriteLine("Mediator reacts on Alpha and triggers folowing operations:");
                _component2.DoGamma();
                return;
            }

            if (value == "Delta")
            {
                Console.WriteLine("Mediator reacts on Delta and triggers following operations:");
                _component1.DoBeta();
                _component2.DoGamma();
                return;
            }
        }
    }
}
