﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProductShop.Dtos.Export
{
    using System.Xml.Serialization;

    public class UserAndProductsDto
    {
        [XmlElement("count")]
        public int Count { get; set; }

        [XmlArray("users")]
        public UserWithProductsDto[] Users { get; set; }
    }
}
