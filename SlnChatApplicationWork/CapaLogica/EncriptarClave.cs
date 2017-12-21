using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CapaLogica
{
    public class EncriptarClave
    {
        public static string encriptar(string laCadena)
        {
            SHA1CryptoServiceProvider elProveedor = new SHA1CryptoServiceProvider();
            byte[] vectoBytes = System.Text.Encoding.UTF8.GetBytes(laCadena);
            byte[] inArray = elProveedor.ComputeHash(vectoBytes);
            elProveedor.Clear();
            return Convert.ToBase64String(inArray);
        }

        public static string Encriptacion(string texto)
        {
            try
            {
            string key="elvinsalinasespinoza"; //llave para encriptar datos
            byte [] keyarray;
            byte[] ArregloaCifrar = UTF8Encoding.UTF8.GetBytes(texto);

                //utilizamos las clases de encriptacion MD5
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyarray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();

                //algoritmo tripleDES
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

                tdes.Key = keyarray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateEncryptor();

                byte [] ArrayResultado = cTransform.TransformFinalBlock(ArregloaCifrar,0,ArregloaCifrar.Length);
                tdes.Clear();

                //se devuelve el resultado en forma de una cadena
                texto = Convert.ToBase64String(ArrayResultado,0,ArrayResultado.Length);
            }
            catch(Exception)
            {
            }
            return texto;
        }

        public static string Desencriptar(string textoEncriptado)
        {
            try 
            {
            string key = "elvinsalinasespinoza";
                byte[] keyArray;
                byte[] ArrayaDescifrar = Convert.FromBase64String(textoEncriptado);

                //algoritmo md5
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte [] resultArray = cTransform.TransformFinalBlock(ArrayaDescifrar,0,ArrayaDescifrar.Length);

                tdes.Clear();
                textoEncriptado = UTF8Encoding.UTF8.GetString(resultArray);
            }
            catch(Exception)
            {
            }
            return textoEncriptado;
        }

    }
}
