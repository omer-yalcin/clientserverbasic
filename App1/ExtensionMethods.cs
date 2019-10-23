using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public static class ExtensionMethods
    {

        public static void AppendText(this RichTextBox box, string text, Color color)
        {

            box.AppendText(text, color, box.SelectionFont.Style);
        }

        public static void AppendText(this RichTextBox box, string text, Color color, FontStyle fs)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionFont = new Font(box.SelectionFont, fs);
            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
            box.SelectionFont = new Font(box.SelectionFont, FontStyle.Regular);
        }
    }
}

