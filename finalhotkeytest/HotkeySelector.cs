using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HotkeySelection
{
    public partial class HotkeySelector : TextBox
    {
        const int MOD_ALT = 0x0001;
        const int MOD_CONTROL = 0x0002;
        const int MOD_SHIFT = 0x0004;
        const int WM_HOTKEY = 0x0312;
        const ushort WM_KEYDOWN = 0x0100;
        static int count = 0;

        //for keeping track of modifiers
        private int modifier = 0;

        //currently selected hotkey
        private int selectedKeyCode = 0;

        //keep track of IDs
        private int hotkeyId = 0;

        private int hotkeyCode = 0;

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public HotkeySelector()
            : base()
        {
            InitializeComponent();
            hotkeyId = count;
            count++;
        }

        private void HotkeySelector_KeyDown(object sender, KeyEventArgs e)
        {
            this.Text = string.Empty;

            //If delete is pressed, suppress the keypress so it doesn't actually delete anything
            if (e.KeyCode == (Keys)46)
            {
                e.SuppressKeyPress = true;
            }

            if (e.Control)
            {
                modifier = MOD_CONTROL;
                this.Text = "CTRL + ";
            }

            if (e.Alt)
            {
                modifier = MOD_ALT;
                this.Text = "ALT + ";
            }

            if (e.Shift)
            {
                modifier = MOD_SHIFT;
                this.Text = "SHIFT + ";
            }
            selectedKeyCode = e.KeyValue;
            if (!e.KeyCode.ToString().Contains("Key") && !e.KeyCode.ToString().Contains("Menu"))
                this.Text = this.Text + e.KeyCode.ToString();
        }



        private void HotkeySelector_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        public bool RegisterSelectedHotkey()
        {
            return RegisterHotKey(this.Handle, hotkeyId, modifier, selectedKeyCode);
        }

        public bool UnregisterSelectedHotkey()
        {
            if (this.Parent == null)
                return false;
            bool ret = UnregisterHotKey(this.Handle, hotkeyId);
            return ret;
        }

        public event EventHandler HotKeyPressed;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                if (m.WParam.ToInt32() == this.HotKeyId)
                {
                    if (HotKeyPressed != null)
                    {
                        EventArgs e = new EventArgs();
                        this.HotKeyPressed(this, e);
                    }
                }
            }

            base.WndProc(ref m);
        }

        private void HotkeySelector_TextChanged(object sender, EventArgs e)
        {
            UnregisterSelectedHotkey();
        }

        public int getHotKeyCode()
        {
            return selectedKeyCode * 0x10000 + modifier;
        }
        public void setHotKeyCode(int keyValue)
        {
            KeysConverter kc = new KeysConverter();
            string txtHotkey = "";

            hotkeyCode = keyValue;
            modifier = hotkeyCode << 16 >> 16;
            selectedKeyCode = hotkeyCode >> 16;

            switch (modifier)
            {
                case MOD_CONTROL:
                    txtHotkey = "Control+";
                    break;
                case MOD_ALT:
                    txtHotkey = "Alt+";
                    break;
                case MOD_SHIFT:
                    txtHotkey = "Shift+";
                    break;
            }
            //txtHotkey += System.Convert.ToChar(selectedKeyCode).ToString();
            txtHotkey += kc.ConvertToString(selectedKeyCode);

            KeyEventArgs k = new KeyEventArgs((Keys)kc.ConvertFromString(txtHotkey));
            HotkeySelector_KeyDown(this, k);
        }

        public int HotKeyId
        {
            get { return hotkeyId; }
        }

        [Browsable(false)]
        [Category("Behavior")]
        [DisplayName("Multiline")]
        public bool Multiline
        {
            get { return false; }
        }
    }
}
