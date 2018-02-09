using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathProgram.Models
{
    public class GuestResponse
    {

        //this will actually be the user input of # >> only 2# ( public int first {get;set;} and public int second {get;set;}
        public int First {get;set;}
        public int Second {get;set;}
        public string Operation {get;set;}
        public bool? WillAttend  {get;set;}

    }
}
