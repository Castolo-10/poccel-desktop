using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Color Azul Poccel: System.Drawing.ColorTranslator.FromHtml("#0965B0");
//Color Amarillo Poccel: System.Drawing.ColorTranslator.FromHtml("#FEE40B");
//Color Gris Poccel: System.Drawing.ColorTranslator.FromHtml("#7E888F");
//Color Rojo Poccel: System.Drawing.ColorTranslator.FromHtml("#DF2F3B");


namespace Poccel_desktop
{
    static class Control
    {
        static public void ForeColor(TextBox txb, Color color)
        {
            txb.ForeColor = color;
        }
        static public void ForeColor(Button btn, Color color)
        {
            btn.ForeColor = color;
        }
        static public void BackColor(TextBox txb, Color color)
        {
            txb.BackColor = color;
        }
        static public void BackColor(Button btn, Color color)
        {
            btn.BackColor = color;
        }
        static public void Text(TextBox txb, string str)
        {
            txb.Text = str;
        }
        static public void Text(Button btn, string str)
        {
            btn.Text = str;
        }
        static public void EnabledUnabled(Button btn)
        {
            if(btn.Enabled == true)
            {
                btn.Enabled = false;
                btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#DF2F3B");
            }
            else
            {
                btn.Enabled = true;
                btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#0965B0");
            }
        }
    }
}
