﻿using Logger.Exceptions;
using Logger.Models.Contracts;
using Logger.Models.Layouts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Factories
{
    public class LayoutFactory
    {
        public ILayout GetLayout(string type)
        {
            ILayout layout;

            if (type == "SimpleLayout")
            {
                layout = new SimpleLayout();
            }
            else if (type == "XmlLayout")
            {
                layout = new XmlLayout();
            }
            else
            {
                throw new InvalidLayoutTypeException();
            }

            return layout;
        }
    }
}
