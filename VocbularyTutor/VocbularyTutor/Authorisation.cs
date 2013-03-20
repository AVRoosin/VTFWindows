using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows;

namespace VocbularyTutor
{
    public enum AuthorisationResult
    {
        Success,
        Fail,
    }
    public class Authorisation
    {
        private static IAuthorisationProvider provider;

        static public AuthorisationResult Authorise()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader("users.txt"))
                {
                    String line = streamReader.ReadToEnd();
                    List<String> usersList = new List<String>();
                    var login = provider.GetLogin();
                    var password = provider.GetPassword();
                }
            }
            catch
            {
                return AuthorisationResult.Fail;
            }
            return AuthorisationResult.Success;
        }
    }
}
