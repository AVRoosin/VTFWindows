using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows;
using System.Xml;

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
        private List<User> UserList;
        public Authorisation()
        {
            XmlNodeList NamesList;
            XmlNodeList PasswordsList;
            XmlNodeList RegistrationDatesList;
            XmlNodeList AuthorisationList;
            var UsersStorage = new XmlDocument();
            UserList = new List<User>();
            UsersStorage.Load("Users.xml");
            NamesList = UsersStorage.GetElementsByTagName("UserName");
            PasswordsList = UsersStorage.GetElementsByTagName("Password");
            RegistrationDatesList = UsersStorage.GetElementsByTagName("Registrationdate");
            AuthorisationList = UsersStorage.GetElementsByTagName("IsAuthorised");
            for (int i = 0; i < NamesList.Count; i++)
            {
                var newuser = new User(NamesList[i].InnerText, PasswordsList[i].InnerText,
                                       RegistrationDatesList[i].InnerText, AuthorisationList[i].InnerText);
                UserList.Add(newuser);
            }
        }
        public List<String> GetUsersList()
        {
            List<String> CurrentList = new List<String>();
            for (int i = 0; i < UserList.Count; i++)
            {
                CurrentList.Add(UserList[i].GetUserName());
            }
            return CurrentList;
        }

        public bool CheckPassword(String name, String password)
        {
            for (int i = 0; i < UserList.Count; i++)
            {
                if (UserList[i].CheckPassword(name, password))
                {
                    return true;
                }
            }
            return false;
        }

        public int CheckIfAlreadyAuthorised()
        {
            for (int i = 0; i < UserList.Count; i++)
            {
                if (UserList[i].IsAuthorised)
                {
                    return i+1;
                }
            }
            return 0;
        }

        static public AuthorisationResult Authorise()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader("users.txt"))
                {
                    String line = streamReader.ReadToEnd();
                    List<String> usersList = new List<String>();
                    var login    = provider.GetLogin();
                    var password = provider.GetPassword();
                }
            }
            catch
            {
                return AuthorisationResult.Fail;
            }
            return AuthorisationResult.Success;
        }

        class User
        {
            private String UserName;
            private String UserPassword;
            private DateTime RegistrationDate;
            private bool isAuthorised;
            public bool IsAuthorised
            {
                get
                {
                    return isAuthorised;
                }
                set
                {
                    if (value.GetType()==typeof(bool))
                    {
                        isAuthorised = value;
                    }
                    else
                    {
                        throw new ArgumentException("Boolean type expected!");
                    }
                }
            }
            public User(String name, String password, String regDate, String authorised)
            {
                UserName = name;
                UserPassword = password;
                RegistrationDate = new DateTime();
                RegistrationDate = DateTime.Parse(regDate);
                IsAuthorised = (authorised=="1");
            }
            public bool CheckPassword(String name, String password)
            {
                return (UserName == name && UserPassword == password);
            }

            public String GetUserName()
            {
                return UserName;
            }
        }
    }
}
