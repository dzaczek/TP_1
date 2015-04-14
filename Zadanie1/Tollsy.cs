using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Tollsy
    {
        private readonly Random _rng=new Random();
            private const string _chars= "ABCDEFGHIJKLMNOPRSTUWXXYZ";
            private const string _chars2 = "AB123451234678967890";

    
            public string RandomString(int size)
            {
                char[] buffer = new char[size];
                for (int i=0;i<size;i++)
                {
                    buffer[i] = _chars[_rng.Next(_chars.Length)];
                }
                return new string(buffer);
            }
        
    }
}
