using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;


using System.Runtime.InteropServices;


namespace WSDK
{
 


        public partial class Form2 : Form
        {
           
            public Form2()
            {
            InitializeComponent();

        }
        void Initialize_Add()
            {
            
            }
            Color zcolor(int r, int g, int b)
            {
                return Color.FromArgb(r, g, b);
            }
            [DllImport("user32")]
            private static extern void ExitWindowsEx(GraphicsUnit uFlags, uint dwReason);
            private void Form2_Load(object sender, EventArgs e)
            {
                Initialize_Add();
                Form f = new Form();
            if (f.BackColor == zcolor(30, 30, 30))
            {
                ApplyTheme2(zcolor(30, 30, 30));
            }
            else if (f.BackColor == Color.White)
            {
                ApplyTheme2(Color.White);

            }





        }

            public void ApplyTheme2(Color back)
            {
                this.BackColor = back;
            }
            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);
                if (m.Msg == WM_NCHITTEST)
                    m.Result = (IntPtr)(HT_CAPTION);
            }

            private const int WM_NCHITTEST = 0x84;
            private const int HT_CLIENT = 0x1;
            private const int HT_CAPTION = 0x2;
            private void Enable_Click(object sender, EventArgs e)
            {
               
            }

         

        private void Enable_Click_1(object sender, EventArgs e)
        {
            ExitWindowsEx(0, 0);
        }

        private void Disable_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

