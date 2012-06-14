using System;
using System.Collections;
using System.Text;
using Tamir.SharpSsh;


namespace SharepSSHTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Sftp sftp = new Sftp("10.5.1.108", "developer", "pandora");
            //sftp.AddIdentityFile("[Path to Private kEY]");
            sftp.Connect();
            //sftp.Put(@"D:\temp\blog\feed.csv", "[PATH OF FILE ON SERVER]");
            //sftp.Delete("[PATH OF FILE ON SERVER]");
            Console.WriteLine(String.Join("\n", sftp.GetFileList("Desktop")));
            foreach (long size in sftp.GetFileSizes("Desktop"))
            {
                Console.WriteLine(Convert.ToString(size));
            }
            sftp.Close();
        }
    }
}
