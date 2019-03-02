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
        static public void placeHolder_Leave(TextBox txb)
        {
            if (txb.Text == "")
            {
                Text(txb, txb.Tag.ToString());
                ForeColor(txb, Color.Silver);
                txb.Font = new Font("Corbert DemiBold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 1);
            }
        }
        static public void placeHolder_Enter(TextBox txb)
        {
            if (txb.Text == txb.Tag.ToString())
            {
                Text(txb, "");
                ForeColor(txb, Color.Black);
                txb.Font = new Font("Corbert DemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 1);
            }
        }
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
        static public void BackColor(Button btn, string color)
        {
            switch(color)
            {
                case "azul": btn.BackColor = Color.FromArgb(255, 9, 101, 176); break;
                case "rojo": btn.BackColor = Color.FromArgb(255, 223, 47, 59); break;
                case "gris": btn.BackColor = Color.FromArgb(255, 126, 136, 143); break;
            }
        }
        static public void Text(TextBox txb, string str)
        {
            txb.Text = str;
        }
        static public void Text(Button btn, string str)
        {
            btn.Text = str;
        }
        static public void btnEnabled(Button btn, string color)
        {
            if(btn.Enabled == false)
            {
                btn.Enabled = true;
                BackColor(btn, color);
                btn.Visible = true;
            }
        }
        static public void btnUnabled(Button btn, Color color)
        {
            if (btn.Enabled == true)
            {
                btn.Enabled = false;
                btn.BackColor = color;
            }
        }
    }
}
