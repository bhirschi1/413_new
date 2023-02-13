using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;



namespace hashingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //string filePath = @"C:\Users\19139\Downloads\RootBeerTest365A.pdf";
            //FileStream fs = File.OpenRead(filePath);


            //SHA1 sha = new SHA1Managed();
            //string output = BitConverter.ToString(sha.ComputeHash(fs));
            //Console.WriteLine(output);

            //string filePath2 = @"C:\Users\19139\Downloads\RootBeerTest365B.pdf";
            //FileStream fs2 = File.OpenRead(filePath2);


            //SHA1 sha2 = new SHA1Managed();
            //string output2 = BitConverter.ToString(sha2.ComputeHash(fs2));
            //Console.WriteLine(output2);

            //byte [] hashBytes;

            //var md5 = MD5.Create();
      
            //string filePath3 = @"C:\Users\19139\Downloads\console1.png";
            //FileStream fs3 = File.OpenRead(filePath3);
            //hashBytes = md5.ComputeHash(fs3);

            //string output3 = BitConverter.ToString(hashBytes);
            //Console.WriteLine(output3);

            //SHA1 sha3 = new SHA1Managed();
            //string output3 = BitConverter.ToString(sha3.ComputeHash(fs3));
            //Console.WriteLine(output3);


            //string filePath4 = @"C:\Users\19139\Downloads\console2.png";

            //FileStream fs4 = File.OpenRead(filePath4);
            //byte[] hashBytes2;
            //var md52 = MD5.Create();
            //hashBytes2 = md52.ComputeHash(fs4);


            ////SHA1 sha4 = new SHA1Managed();
            //string output4 = BitConverter.ToString(hashBytes2);
            //Console.WriteLine(output4);

            //sha256 for ping console1:
            string filePath3 = @"C:\Users\19139\Downloads\console1.png";
            FileStream fs3 = File.OpenRead(filePath3);

            HashAlgorithm sha = SHA256.Create();
            byte[] result = sha.ComputeHash(fs3);

            string output = BitConverter.ToString(result);
            Console.WriteLine("console1png: " + output);


            //sha256 for ping console2:
            string filePath4 = @"C:\Users\19139\Downloads\console2.png";
            FileStream fs4 = File.OpenRead(filePath4);

            HashAlgorithm sha4 = SHA256.Create();
            byte[] result4 = sha4.ComputeHash(fs4);

            string output4 = BitConverter.ToString(result4);
            Console.WriteLine("console2png: " + output4);

            //sha256 for Rootbeertest365A.pdf:
            string filePath5 = @"C:\Users\19139\Downloads\RootBeerTest365A.pdf";
            FileStream fs5 = File.OpenRead(filePath5);

            HashAlgorithm sha5 = SHA256.Create();
            byte[] result5 = sha5.ComputeHash(fs5);

            string output5 = BitConverter.ToString(result5);
            Console.WriteLine("Rootbeertest365A.pdf: " + output5);

            //sha256 for Rootbeertest365B.pdf:
            string filePath6 = @"C:\Users\19139\Downloads\RootBeerTest365B.pdf";
            FileStream fs6 = File.OpenRead(filePath6);

            HashAlgorithm sha6 = SHA256.Create();
            byte[] result6 = sha6.ComputeHash(fs6);

            string output6 = BitConverter.ToString(result6);
            Console.WriteLine("Rootbeertest365B.pdf: " + output6);
        }
    }
}
            
