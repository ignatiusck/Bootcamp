using System.ComponentModel;
static class Program
{
    static void Main()
    {
        Publisher.Publisher newContainer = new();
        // newContainer = Subscriber.Subcriber.message;

        //Use delegate
        // newContainer.myContainer = Subscriber.Subcriber.message;
        // newContainer.myContainer += Subscriber.Subcriber.message2;
        // newContainer.myContainer += Subscriber.Subcriber.message2;
        // newContainer.myContainer();

        //Use event
        newContainer.completeted += Subscriber.Subcriber.MeassageDone;
        newContainer.completeted += Subscriber.Subcriber.MeassageWait;

        newContainer.run();
    }
}
