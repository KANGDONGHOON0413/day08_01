using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace MyWinform03
{

    class FileManager
    {
        public event EventHandler<double> Inprogresss; // 전해주려는 형식을 정의

        public bool Copy(string SrcFile, string DestFile)
        {
            byte[] buffer = new byte[1024]; //1kb
            int pointer01 = 0;

            try
            {
                //file size
                var f1 = new FileInfo(SrcFile);
                var fileSize = f1.Length;


                using (BinaryReader rd = new BinaryReader(File.Open(SrcFile, FileMode.Open)))
                using (var wt = new BinaryWriter(File.Open(DestFile, FileMode.Create)))
                {
                    while (pointer01 < fileSize)
                    {
                        int cnt = rd.Read(buffer, 0, buffer.Length);
                        wt.Write(buffer, 0, cnt);
                        pointer01 += cnt;

                        double pct = (pointer01 / (double)fileSize) * 100.0;
                           
                        if(Inprogresss != null)
                        {
                            Inprogresss(this, pct);// 파라미터는 sender(송신측), reciever(수신측)이다
                        }
                    }
                }
                return true;
            }
            catch (FileNotFoundException e)
            {
                return false;
            }

        }
    }
}
