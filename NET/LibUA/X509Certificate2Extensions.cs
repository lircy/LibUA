using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LibUA
{
    public static class X509Certificate2Extensions
    {

        public static RSA GetRSAPublicKey(this X509Certificate2 certificate)
        {
            if (certificate == null)
                throw new ArgumentNullException(nameof(certificate));
            if (certificate.PublicKey.Key is RSA rsaPublicKey)
            {
                return rsaPublicKey;
            }
            return null;
        }
    }
}
