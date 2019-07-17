using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robots : Identification
    {
        private string model;
        public Robots(string id, string model)
            : base(id)
        {
            this.model = model;
        }
    }
}
