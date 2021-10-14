using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class Form_Loading : Form
    {
        public int time = 2000;
        public Form_Loading()
        {
            InitializeComponent();         
        }
        
        void autoCloseTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Loading_Load(object sender, EventArgs e)
        {
            //Timer autoCloseTimer = new Timer();
            //autoCloseTimer.Interval = time;
            //autoCloseTimer.Enabled = true;
            //autoCloseTimer.Tick += new EventHandler(autoCloseTimer_Tick);
        }

        public void Close_Form()
        {
            this.Close();
        }
    }
}
