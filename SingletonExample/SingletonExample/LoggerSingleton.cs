using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class LoggerSingleton
    {
        public string Login { get; set; }
        protected string Password { get; set; }
        protected static DateTime Date { get; set; }
        private LoggerSingleton (string login, string password, DateTime date) 
        {
            Login = login;
            Password = password;
            Date = date;
        }
        private static LoggerSingleton _loggerSingletonInstance;
        private static readonly object locker = new object();

        public static LoggerSingleton GetInstance
        {
            get
            {
                if (_loggerSingletonInstance == null)
                {
                    throw new Exception("Object was not created");
                }
                return _loggerSingletonInstance;
            }
        }
        public static void Signin(string login, string password, DateTime date)
        {
            Signout();
            _loggerSingletonInstance = new LoggerSingleton(login, password, date);
        }

        public static void Signout()
        {
            _loggerSingletonInstance = null;
        }

        public static bool IsAuthorized()
        {
            DateTime currentTime = DateTime.Now;
            if (currentTime > Date.AddSeconds(10))
            {
                return false;
            }
            return true;
        }
    }
}
