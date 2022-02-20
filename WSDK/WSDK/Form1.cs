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
using System.Diagnostics;

namespace WSDK
{
    public partial class Form1 : Form
    {
        List<Control> panels;

        List<Control> textboxes;
        public Form1()
        {
            InitializeComponent();

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

        void Initialize_Add()
        {
            panels = new List<Control>();

            textboxes = new List<Control>();





        }
        public Color Getbackcolor()
        {
            return BackColor;
        }

        [DllImport("user32")]
        private static extern void ExitWindowsEx(GraphicsUnit uFlags, uint dwReason);
        public void ApplyTheme(Color back, Color pan, Color btn, Color tbox, Color combox, Color TextColor)
        {
            this.BackColor = back;


            foreach (Control item in panels)
            {
                item.BackColor = pan;
            }



            foreach (Control item in textboxes)
            {
                item.BackColor = tbox;
                item.ForeColor = TextColor;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Initialize_Add();

        }



        Color zcolor(int r, int g, int b)
        {
            return Color.FromArgb(r, g, b);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string message = "This app created by Ktari Wassim " +
              "check my github for more applications " +
              "https://github.com/KTWASSIM";
            string title = "Welcame";
            MessageBox.Show(message, title);
        }

        private void label2_Click(object sender, EventArgs e) { this.Close(); }


        private void button3_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\control\Keyboard Layout", true);

            //create a new key 
            key.CreateSubKey("Scancode Map");
            key.SetValue("Scancode Map", new byte[] { });

            key.Close();
            Form2 f2 = new Form2();
            f2.ShowDialog(); // Shows Form2

        }

        private void button1_Click(object sender, EventArgs e)

        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\control\Keyboard Layout", true);

            //create a new key 
            key.CreateSubKey("Scancode Map");
            key.SetValue("Scancode Map", new byte[] { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x3, 0x0, 0x0, 0x0, 0x0, 0x0, 0x5b, 0xe0, 00, 00, 0x5c, 0xe0, 00, 00, 00, 00 });

            key.Close();
            string message = "do you want to logout to apply changes";
            string title = "restart required";
            DialogResult c = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
            if (c == DialogResult.Yes)
            {
                ExitWindowsEx(0, 0);
            }

        }

        Form2 f2 = new Form2();
      

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            ApplyTheme(zcolor(30, 30, 30), zcolor(45, 45, 48), zcolor(104, 104, 104), zcolor(51, 51, 51), Color.Black, Color.White);

            f2.ApplyTheme2(zcolor(30, 30, 30));
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

            ApplyTheme(Color.White, zcolor(240, 240, 240), zcolor(181, 181, 181), zcolor(110, 110, 110), Color.White, Color.Black);

            f2.ApplyTheme2(Color.White);
        }

        private void label2_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enable_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\control\Keyboard Layout", true);

            //create a new key 
            key.CreateSubKey("Scancode Map");
            key.SetValue("Scancode Map", new byte[] { });

            key.Close();
            
            f2.ShowDialog();
        }

        private void Disable_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\control\Keyboard Layout", true);

            //create a new key 
            key.CreateSubKey("Scancode Map");
            key.SetValue("Scancode Map", new byte[] { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x3, 0x0, 0x0, 0x0, 0x0, 0x0, 0x5b, 0xe0, 00, 00, 0x5c, 0xe0, 00, 00, 00, 00 });

            key.Close();
            f2.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/KTWASSIM/WSKD");
            Process.Start(sInfo);
        }
    }
}
