namespace Lab4._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document();
            doc.content = "DAY LA NOI DUNG CUA DOCUMENT";
            string filePath = "document.txt";
            doc.Write(filePath);
            doc.Read(filePath);
            Console.WriteLine($"Noi dung tai lieu:{doc.content}");
            string encryptedContent = doc.Encrypt();
            Console.WriteLine($"Ma hoa noi dung: {encryptedContent}");
            doc.content = encryptedContent;
            string decrypyedContent = doc.Decrypt();
            Console.WriteLine($"Decrypted no dung: {decrypyedContent}");
        }
    }
}
