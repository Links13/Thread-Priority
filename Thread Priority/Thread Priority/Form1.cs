using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thread_Priority
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void frmTrackThread_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart delThread = new ThreadStart(MyThreadClass.Thread1);
            ThreadStart delThread2 = new ThreadStart(MyThreadClass.Thread2);

            Thread ThreadA = new Thread(delThread);
            ThreadA.Name = "Thread A Process";

            Thread ThreadB = new Thread(delThread2);
            ThreadB.Name = "Thread B Process";

            Thread ThreadC = new Thread(delThread);
            ThreadC.Name = "Thread C Process";

            Thread ThreadD = new Thread(delThread2);
            ThreadD.Name = "Thread D Process";


            Console.WriteLine("Before the thread start");

           
            ThreadA.Priority = ThreadPriority.Highest;
            ThreadB.Priority = ThreadPriority.Normal;
            ThreadC.Priority = ThreadPriority.AboveNormal;
            ThreadD.Priority = ThreadPriority.BelowNormal;

            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();

            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();
            label1.Text = "-End of Thread-";
            Console.WriteLine(label1.Text.ToString());
        }
    }
    
}
