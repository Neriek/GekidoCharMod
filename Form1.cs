using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace GekidoCharMod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Mem m = new Mem();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy == false)
                backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            String addr = "base+B38D44";
            while (true)
            {
                //Find and attach to process
                int pID = m.getProcIDFromName("epsxe");
                bool attachProc = false;
                if (pID > 0) attachProc = m.OpenProcess(pID);

                //If Attached to process
                if (attachProc)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        procStatus.Text = "WE GOOD TO GO";
                        procStatus.ForeColor = Color.Green;
                    
                        if ((string)charSelect.SelectedItem == "Travis" && setChar.Checked) m.writeMemory(addr, "byte", "0x01");
                        if ((string)charSelect.SelectedItem == "Gorilla" && setChar.Checked) m.writeMemory(addr, "byte", "0x02");
                        if ((string)charSelect.SelectedItem == "Michelle" && setChar.Checked) m.writeMemory(addr, "byte", "0x03");
                        if ((string)charSelect.SelectedItem == "Tetsuo" && setChar.Checked) m.writeMemory(addr, "byte", "0x04");
                        if ((string)charSelect.SelectedItem == "Kobuchi" && setChar.Checked) m.writeMemory(addr, "byte", "0x05");
                        if ((string)charSelect.SelectedItem == "Ushi" && setChar.Checked) m.writeMemory(addr, "byte", "0x06");
                        if ((string)charSelect.SelectedItem == "Kintaro" && setChar.Checked) m.writeMemory(addr, "byte", "0x07");
                        if ((string)charSelect.SelectedItem == "Angela" && setChar.Checked) m.writeMemory(addr, "byte", "0x08");
                        if ((string)charSelect.SelectedItem == "Akujin" && setChar.Checked) m.writeMemory(addr, "byte", "0x09");
                        if ((string)charSelect.SelectedItem == "Mechi" && setChar.Checked) m.writeMemory(addr, "byte", "0x0A");
                        if ((string)charSelect.SelectedItem == "Ciccio" && setChar.Checked) m.writeMemory(addr, "byte", "0x0B");
                        if ((string)charSelect.SelectedItem == "Koji" && setChar.Checked) m.writeMemory(addr, "byte", "0x0C");
                        if ((string)charSelect.SelectedItem == "Kuji" && setChar.Checked) m.writeMemory(addr, "byte", "0x0D");
                        if ((string)charSelect.SelectedItem == "Yushin Pro" && setChar.Checked) m.writeMemory(addr, "byte", "0x0E");
                        if ((string)charSelect.SelectedItem == "Ishigame" && setChar.Checked) m.writeMemory(addr, "byte", "0x0F");
                        if ((string)charSelect.SelectedItem == "Shadow" && setChar.Checked) m.writeMemory(addr, "byte", "0x10");
                        if ((string)charSelect.SelectedItem == "Shuju" && setChar.Checked) m.writeMemory(addr, "byte", "0x11");
                        if ((string)charSelect.SelectedItem == "Kintarog" && setChar.Checked) m.writeMemory(addr, "byte", "0x12");

                    });

                }

            }
        }




    }
}
