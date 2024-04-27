using KeyedServices.Abstract;

namespace KeyedServices
{
    public class Sample1 : ISample
	{
		public Sample1()
		{
		}

        public void Display()
        {
            Console.WriteLine("Display from Sample 1");
        }
    }
}

