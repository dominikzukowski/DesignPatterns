﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class Course : ICourse
    {
        public string GetDescription()
        {
            return "Language Course";
        }
    }
}
