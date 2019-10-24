using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotkeySelection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister1_Click(object sender, EventArgs e)
        {
            hotkeySelector1.RegisterSelectedHotkey();
        }

        private void btnUnregister1_Click(object sender, EventArgs e)
        {
            hotkeySelector1.UnregisterSelectedHotkey();
        }

        private void btnRegister2_Click(object sender, EventArgs e)
        {
            hotkeySelector2.RegisterSelectedHotkey();
        }

        private void btnUnregister2_Click(object sender, EventArgs e)
        {
            hotkeySelector2.UnregisterSelectedHotkey();
        }

        //Gets hotkey data from selector1 (saving) and sets it to selector2 (loading)
        private void btnMimicSave_Click(object sender, EventArgs e)
        {
            int savedData = hotkeySelector1.getHotKeyCode();
            hotkeySelector2.setHotKeyCode(savedData);
        }

        private void hotkeySelector1_HotKeyPressed(object sender, EventArgs e)
        {
            MessageBox.Show("1 Hotkey pressed in form");
        }

        private void hotkeySelector2_HotKeyPressed(object sender, EventArgs e)
        {
            MessageBox.Show("2 Hotkey pressed in form");
        }
    }
}
