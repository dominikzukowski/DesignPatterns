using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.LanguageSchool;

namespace DesignPatterns.Factory
{
    public interface IFactoryMethod
    {
        ICourseType CreateClassrom();
    }
}
