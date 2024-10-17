using System.Security.Cryptography;

namespace Les4_WebApAuthContein.RSATools
{
    public class RSAExtensions
    {
        public static RSA GeneratePrivateKey()  //добавил static после RSA
        {
            var key = File.ReadAllText(@"./private_key.pem");
            var rsa = RSA.Create();
            rsa.ImportFromPem(key);

            return rsa;
        }
    }
}
