using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizens : Identification
    {
        private string name;
        private int age;
        public Citizens(string id, string name, int age)
            : base(id)
        {
            this.name = name;
            this.age = age;
        }
    }
}
