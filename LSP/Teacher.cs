using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    internal class Teacher : Person , IExperience
    {
        public string GetExperience()
        {
            return "GetExperience";
        }

        public override string GetFullName()
        {
            return "GetFullName";
        }
    }
}
