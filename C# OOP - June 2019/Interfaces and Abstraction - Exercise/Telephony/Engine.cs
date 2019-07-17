using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Engine
    {
        private Smartphone smartPhone;

        public Engine()
        {
            this.smartPhone = new Smartphone();
        }

        public void Run()
        {
            string[] numbers = Console.ReadLine().Split();

            string[] sites = Console.ReadLine().Split();

            CallNumber(numbers);

            BrowseInternet(sites);

        }

        private void BrowseInternet(string[] sites)
        {
            foreach (var site in sites)
            {
                try
                {
                    Console.WriteLine(this.smartPhone.Browsing(site));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        private void CallNumber(string[] numbers)
        {
            foreach (var number in numbers)
            {
                try
                {
                    Console.WriteLine(this.smartPhone.Calling(number));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
