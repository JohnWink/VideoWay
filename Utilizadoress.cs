using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoWay
{
    class Utilizadoress
    {
        //insert the constructors base sturcture of the users
        //currently missing some more atributes but will be added later

        public string username;
        public string password;
        public string email;
        public string status;

        //empthy patther constructor
        public Utilizadoress()
        {

        } 

        //adding parrameters to the constructor
        public Utilizadoress(string username, string password, string email, string status)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.status = status;

        }
    }
}
