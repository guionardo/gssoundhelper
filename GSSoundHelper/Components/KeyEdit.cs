using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSSoundHelper.Components
{
    public partial class KeyEdit : UserControl
    {
        static object[] keys = null;
        static KeyEdit()
        {
            List<KeyString> k = new List<KeyString>();
            for (int i = 32; i <= 145; i++)
            {
                var key = new KeyString(i);
                if (!key.Valid)
                    continue;
                k.Add(key);
            }
            keys = k.ToArray();
        }

        public KeyEdit()
        {
            InitializeComponent();
            // Obtém a lista de keys para alimentar o combo
            cmbLetters.Items.AddRange(keys);
        }

        public Keys Key
        {
            get
            {
                if (cmbLetters.SelectedIndex >= 0)
                {
                    return ((KeyString)cmbLetters.SelectedItem).Key;
                }
                return Keys.None;
            }
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

        public ModifierKeys Modifiers
        {
            get
            {
                return (chkCtrl.Checked ? GSSoundHelper.ModifierKeys.Control : 0) |
                  (chkAlt.Checked ? GSSoundHelper.ModifierKeys.Alt : 0) |
                  (chkShift.Checked ? GSSoundHelper.ModifierKeys.Shift : 0) |
                  (chkWin.Checked ? GSSoundHelper.ModifierKeys.Win : 0);
            }
            set
            {
                chkWin.Checked = value.HasFlag(GSSoundHelper.ModifierKeys.Win);
                chkAlt.Checked = value.HasFlag(GSSoundHelper.ModifierKeys.Alt);
                chkShift.Checked = value.HasFlag(GSSoundHelper.ModifierKeys.Shift);
                chkCtrl.Checked = value.HasFlag(GSSoundHelper.ModifierKeys.Control);
            }
        }

        class KeyString
        {
            public KeyString(Keys key)
            {
                Key = key;
                SetValid();
            }
            public KeyString(int key)
            {
                Key = (Keys)key;
                SetValid();
            }
            public Keys Key { get; private set; }

            public bool Valid { get; private set; }

            public override string ToString() => Key.ToString();

            void SetValid()
            {
                Valid = (Key >= Keys.Space && Key <= Keys.F24 && !((int)Key > 57 && (int)Key < 65)) ||
                    (Key == Keys.Scroll);
            }
        }
    }
}
