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

namespace dedeles
{
    public partial class frmbasicthread : Form
    {
        private Thread ThreadA = new Thread(MyThreadClass.Thread1);

        private Thread ThreadB = new Thread(MyThreadClass.Thread1);
        public frmbasicthread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before Starting Thread-");
 
            ThreadA.Name = "ThreadA";
            ThreadB.Name = "ThreadB";

            ThreadA.Start();
            ThreadB.Start();

           
            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("-End of Thread-");

            label1.Text = "End Of Thread";
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
