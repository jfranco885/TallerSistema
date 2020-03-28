using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;



namespace MiLibreria
{
    public class Hash
    {
        public string PassHash(string dato)
        {
            SHA1 sha = SHA1.Create();
            byte[] hasdata = sha.ComputeHash(Encoding.Default.GetBytes(dato));
            StringBuilder returnValue = new StringBuilder();
            for (int i = 0; i < hasdata.Length; i++)
            {

                returnValue.Append(hasdata[i].ToString());

            }
            return returnValue.ToString();
        }


    }
}
