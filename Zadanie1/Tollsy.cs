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


          public  string RandomStringHash(int length, string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789")
            {
                if (length < 0) throw new ArgumentOutOfRangeException("length", "length cannot be less than zero.");
                if (string.IsNullOrEmpty(allowedChars)) throw new ArgumentException("allowedChars may not be empty.");

                const int byteSize = 0x100;
                var allowedCharSet = new HashSet<char>(allowedChars).ToArray();
                if (byteSize < allowedCharSet.Length) throw new ArgumentException(String.Format("allowedChars may contain no more than {0} characters.", byteSize));

                // Guid.NewGuid and System.Random are not particularly random. By using a
                // cryptographically-secure random number generator, the caller is always
                // protected, regardless of use.
                using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
                {
                    var result = new StringBuilder();
                    var buf = new byte[128];
                    while (result.Length < length)
                    {
                        rng.GetBytes(buf);
                        for (var i = 0; i < buf.Length && result.Length < length; ++i)
                        {
                            // Divide the byte into allowedCharSet-sized groups. If the
                            // random value falls into the last group and the last group is
                            // too small to choose from the entire allowedCharSet, ignore
                            // the value in order to avoid biasing the result.
                            var outOfRangeStart = byteSize - (byteSize % allowedCharSet.Length);
                            if (outOfRangeStart <= buf[i]) continue;
                            result.Append(allowedCharSet[buf[i] % allowedCharSet.Length]);
                        }
                    }
                    return result.ToString();
                }
            }

            public string RandomString(int x, int y)

            {
                int size=_rng.Next(x,y);
                char[] buffer = new char[size];
                for (int i = 0; i < size; i++)
                {
                    buffer[i] = _chars[_rng.Next(_chars.Length)];
                }
                return new string(buffer);
            }
        
    }
}
