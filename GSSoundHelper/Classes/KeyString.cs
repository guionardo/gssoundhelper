using System.Windows.Forms;

namespace GSSoundHelper.Classes
{
    /// <summary>
    /// Classe para encapsular uma Key com informações de validade e string
    /// </summary>
    public class KeyString
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