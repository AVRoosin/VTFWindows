using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VocbularyTutor
{
     public interface IAuthorisationProvider
    {
        string GetLogin();
        string GetPassword();
    }
}
