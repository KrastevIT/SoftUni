using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Identification
    {
        private string id;

        public Identification(string id)
        {
            this.id = id;
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
    }
}
