using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CFGEditor
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            
            using (StreamReader sr = File.OpenText("DebugConsoleSettings.cfg"))
            {
                int i = 0;
                int fCamCheck;
                int dConsoleCheck;

                string s = String.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    i++;
                    if (i == 1)
                    {
                        kBind.Text = s;
                    }
                    else if (i == 2)
                    {
                        fCamCheck = Int32.Parse(s);
                        if (fCamCheck == 1)
                        {
                            fCam.Checked = true;
                        }
                    }
                    else if (i == 3)
                    {
                        dConsoleCheck = Int32.Parse(s);
                        if (dConsoleCheck == 1)
                        {
                            dConsole.Checked = true;
                        }
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fCamCheck, dConsoleCheck;
            string keyBind, dCon, fCamc;

            if (fCam.Checked == true)
            {
                fCamCheck = 1;
            }
            else
            {
                fCamCheck = 2;
            }
            if (dConsole.Checked == true)
            {
                dConsoleCheck = 1;
            }
            else
            {
                dConsoleCheck = 0;
            }

            keyBind = Convert.ToString((kBind.Text));
            fCamc = Convert.ToString(fCamCheck);
            dCon = Convert.ToString(dConsoleCheck);



            using (StreamWriter sw = new StreamWriter("DebugConsoleSettings.cfg"))
            {
                sw.WriteLine((keyBind));   
                sw.WriteLine(fCamc);
                sw.WriteLine(dCon);
            }
            Application.Exit();
        }
    }
}
