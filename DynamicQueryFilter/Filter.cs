﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicQueryFilter.Attributes;

namespace DynamicQueryFilter
{
    public class Filter
    {
        [FilterProperty(CompareTypes.Equal, "FirstName")]
        public string Name { get; set; }
    }
}
