using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoIPUploader
{
    class Upload
    {
        private const string FileNameGFX = "IP@GFX.txt";
        private const string LocationGFX = @"C:\Users\嘉维\OneDrive - 开发者联盟\IP\"+FileNameGFX;
        private const string FileNameSFC = "IP@GFX.txt";
        private const string LocationSFC = @"C:\Users\wjw_w\OneDrive - 开发者联盟\IP\"+FileNameSFC;
        public static int UploadCount = 0;
        public static bool UploadIP()
        {
            try
            {
                var file = File.CreateText(LocationSFC);
                file.WriteLine(GetIP());
                file.Flush();
                file.Close();
                UploadCount++;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private static string GetIP()
        {
            string tempip = "";
            try
            {
                WebRequest wr = WebRequest.Create("http://www.ip138.com/ips138.asp");
                Stream s = wr.GetResponse().GetResponseStream();
                StreamReader sr = new StreamReader(s, Encoding.Default);
                string all = sr.ReadToEnd(); //读取网站的数据
                int start = all.IndexOf("您的IP地址是：[") + 9;
                int end = all.IndexOf("]", start);
                tempip = all.Substring(start, end - start);
                sr.Close();
                s.Close();
            }
            catch
            {
            }
            return tempip;
        }
    }
}
