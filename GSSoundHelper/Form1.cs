using System;
using System.Windows.Forms;

namespace GSSoundHelper
{
    public partial class Form1 : Form
    {
        KeyboardHook keyboardHook = new KeyboardHook();
        bool Mute;

        public Form1()
        {
            InitializeComponent();
            keMute.Key = (Keys)Properties.Settings.Default.KeyMute;
            keMute.Modifiers = (ModifierKeys)Properties.Settings.Default.ModifierMute;

            keyboardHook.RegisterHotKey(keMute.Modifiers, keMute.Key);
            keyboardHook.KeyPressed += new EventHandler<KeyPressedEventArgs>(KeyboardHook_KeyPressed);

            if (SoundMute.GetVolume(out int level) && level == 0)
                Mute = true;

            SetNotifyIcon(Mute);
            chkRunWithWindows.Checked = StartWithWindows.IsAdded();
            notifyIcon1.Visible = true;
        }

        private void SetNotifyIcon(bool mute)
        {
            if (mute)
                notifyIcon1.Icon = Properties.Resources.mute;
            else
                notifyIcon1.Icon = Properties.Resources.speaker;
        }

        private void KeyboardHook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            if (!Mute)
                SoundMute.Mute();
            else
                SoundMute.UnMute();
            Mute = !Mute;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundMute.UnMute();
        }
    }
}
