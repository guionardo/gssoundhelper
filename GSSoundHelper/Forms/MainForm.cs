using GSSoundHelper.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace GSSoundHelper
{
    public partial class MainForm : Form
    {
        KeyboardHook keyboardHook = new KeyboardHook();
        private bool mShowAllowed;
        bool Mute;

        public MainForm()
        {
            InitializeComponent();

            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(Application.ExecutablePath);
            notifyIcon.Text = Text = "GS Sound Helper - " + fvi.FileVersion;

            InitKeysAndModifiers();

            keyboardHook.KeyPressed += new EventHandler<KeyPressedEventArgs>(KeyboardHook_KeyPressed);
            keyboardHook.RegisterHotKey(Modifiers, Key);

            if (SoundHelper.GetVolume(out int level) && level == 0)
                Mute = true;

            SetNotifyIcon(Mute);
            chkRunWithWindows.Checked = StartWithWindows.IsAdded();
            notifyIcon.Visible = true;

        }

        public Keys Key
        {
            get => cmbLetters.SelectedIndex < 0 ? Keys.None : ((KeyString)cmbLetters.SelectedItem).Key;
            set
            {
                for (int i = 0; i < cmbLetters.Items.Count; i++)
                    if (((KeyString)cmbLetters.Items[i]).Key == value)
                    {
                        cmbLetters.SelectedIndex = i;
                        return;
                    }
                cmbLetters.SelectedIndex = -1;
            }
        }

        public KeyModifiers Modifiers
        {
            get
            {
                return (chkCtrl.Checked ? KeyModifiers.Control : 0) |
                  (chkAlt.Checked ? KeyModifiers.Alt : 0) |
                  (chkShift.Checked ? KeyModifiers.Shift : 0) |
                  (chkWin.Checked ? KeyModifiers.Win : 0);
            }
            set
            {
                chkWin.Checked = value.HasFlag(KeyModifiers.Win);
                chkAlt.Checked = value.HasFlag(KeyModifiers.Alt);
                chkShift.Checked = value.HasFlag(KeyModifiers.Shift);
                chkCtrl.Checked = value.HasFlag(KeyModifiers.Control);
            }
        }

        protected override void SetVisibleCore(bool value)
        {
            if (!mShowAllowed) value = false;
            base.SetVisibleCore(value);
            mShowAllowed = true;
        }

        private void ButtonsClick(object sender, EventArgs e)
        {
            if (sender == btnGravar)
            {
                if (cmbLetters.SelectedIndex >= 0)
                {
                    Properties.Settings.Default.KeyMute = (int)Key;
                    Properties.Settings.Default.ModifierMute = (int)Modifiers;
                    Properties.Settings.Default.Save();
                    if (chkRunWithWindows.Checked)
                        StartWithWindows.Add();
                    else
                        StartWithWindows.Remove();
                    Hide();
                }
                else
                    MessageBox.Show("Tecla não foi selecionada!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (sender == btnMinimizar)
            {
                ShowInTaskbar = false;
                Hide();
            }

        }

        private void InitKeysAndModifiers()
        {
            List<KeyString> k = new List<KeyString>();
            for (int i = 32; i <= 145; i++)
            {
                var keyI = new KeyString(i);
                if (!keyI.Valid)
                    continue;
                k.Add(keyI);
            }
            cmbLetters.Items.AddRange(k.ToArray());

            Key = (Keys)Properties.Settings.Default.KeyMute;
            Modifiers = (KeyModifiers)Properties.Settings.Default.ModifierMute;
        }
        private void KeyboardHook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            Mute = !Mute;

            if (Mute)
                SoundHelper.Mute();
            else
                SoundHelper.UnMute();

            SetNotifyIcon(Mute);
        }

        private void NotifyMenuClick(object sender, EventArgs e)
        {
            if (sender == miConfigurar)
            {
                mShowAllowed = true;
                Show();
                ShowInTaskbar = true;
            }
            else if (sender == miSobre)
            {
                using (var f = new AboutBox())
                    f.ShowDialog();
            }
            else if (sender == miSair)
            {
                Show();
                Close();
            }
        }

        private void SetNotifyIcon(bool mute)
        {
            notifyIcon.Icon = mute ? Properties.Resources.mute : Properties.Resources.speaker;
        }
    }
}
