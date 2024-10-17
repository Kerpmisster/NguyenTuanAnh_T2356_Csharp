using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._8
{
    internal class Document : IStoreable,IEncryptable
    {
        public string content { get; set; }
        public string Data 
        { get { return content; }
          set { content = value; }
        }

        public string Decrypt()
        {
            string decryptData = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(content));
            Console.WriteLine("noi dung encrpyt");
            return decryptData;
        }

        public string Encrypt()
        {
            string encryptData = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(content));
            Console.WriteLine("noi dung encrpyt");
            return encryptData;
        }

        public void Read(string fileName)
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine($"File{fileName} khong thoat ");
                return;
            }
            using(FileStream fs = new FileStream(fileName,FileMode.Open))
            using(StreamReader sr = new StreamReader(fs)) 
            {
                content = sr.ReadToEnd();
                Console.WriteLine($"Noi dung doc duoc tu File{fileName}");
            }

        }

        public void Write(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create)) 
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(content);
                Console.WriteLine($"Noi dung viet {fileName}");
            }
        }
    }
}
