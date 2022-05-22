using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinform03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_COPY_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(CopyFile);
            t.Start();

        }

        private void CopyFile() { 
            FileManager FM = new FileManager();
            FM.Inprogresss += FM_Inprogresss;
            FM.Inprogresss += FM_Inprogresss2;  //event handler 복수개를 사용하는 부분
            if (!FM.Copy("src.txt", "dest.txt")) MessageBox.Show("ERROR");
        }

        private void FM_Inprogresss(object sender, double e)
        {
            if (InvokeRequired) //multi thread를 활용하는 부분으로, UI스레드인지 체크하는 부분
            {   //UI 스레드가 아닌경우
                Invoke(new EventHandler<double>(FM_Inprogresss), sender, e);    //Invoke를 활용하여 UI스레드로 만들어주는 부분
            }
            else
            {   //UI스레드인 경우
                this.progressBar1.Value = (int)e;
                this.PERCENT.Text = string.Format("{0}%", (int)e);
            }
        }
        private void FM_Inprogresss2(object sender, double e)
        {
            Debug.WriteLine("{0}", e);
        }

    }
}
