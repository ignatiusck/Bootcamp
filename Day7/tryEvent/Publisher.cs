namespace Publisher
{
    public class Publisher
    {
        public delegate void Container();
        public event Container? completeted;
        public Container? myContainer;

        public void run()
        {
            Console.WriteLine("Render Video");
            Console.WriteLine("Proccessing...");
            Thread.Sleep(3000);

            onCompleted();
        }

        public void onCompleted()
        {
            completeted?.Invoke();
        }
    }
}