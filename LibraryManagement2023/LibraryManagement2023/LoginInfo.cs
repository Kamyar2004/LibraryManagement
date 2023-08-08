using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement2023
{
    static class LoginInfo
    {
        private static int _access;
        private static int _userId;
        private static string _name;

        public static int access
        {
            get
            {
                return _access;
            }
            set
            {
                _access = value;
            }
        }

        public static int userId
        {
            get
            {
                return _userId;
            }
            set
            {
                _userId = value;
            }
        }

        public static string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
}
