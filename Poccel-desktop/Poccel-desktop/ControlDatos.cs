using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

//Color Azul Poccel: System.Drawing.ColorTranslator.FromHtml("#0965B0");
//Color Amarillo Poccel: System.Drawing.ColorTranslator.FromHtml("#FEE40B");
//Color Gris Poccel: System.Drawing.ColorTranslator.FromHtml("#7E888F");
//Color Rojo Poccel: System.Drawing.ColorTranslator.FromHtml("#DF2F3B");


namespace ctrlDatos
{
    static class ControlDatos
    {
        static public void placeHolder_Leave(TextBox txb)
        {
            if (txb.Text == "")
            {
                Text(txb, txb.Tag.ToString().Split(',')[0]);
                ForeColor(txb, Color.Silver);
                txb.Font = new Font("Corbert DemiBold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 1);
            }
        }
        static public void placeHolder_Enter(TextBox txb)
        {
            if (txb.Text == txb.Tag.ToString().Split(',')[0] && (txb.ForeColor == Color.Silver || txb.ForeColor == Color.Red))
            {
                Text(txb, "");
                ForeColor(txb, Color.Black);
                txb.Font = new Font("Corbert DemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 1);
            }
        }
        static public void txbBorrar(TextBox txb)
        {
            txb.Text = "";
            placeHolder_Leave(txb);
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
        static public void btnUnabled(Button btn, string color, bool visible)
        {
            if (btn.Enabled == true)
            {
                btn.Enabled = false;
                BackColor(btn, color);
                btn.Visible = visible;
            }
        }
        
        static public void validar(TextBox txb, string str)
        {
            str = str.Trim();
            str = str.ToLower();
            bool error = true;
            if (txb.Text != txb.Tag.ToString().Split(',')[0])
            {
                switch (str)
                {
                    case "alfanumerico":
                        error = false;

                        break;
                    case "texto":
                        error = !Regex.IsMatch(txb.Text, @"^[a-zA-ZñÑ\s]+$");


                        break;
                    case "numero":
                        error = !Regex.IsMatch(txb.Text, @"^[0-9]+$");

                        break;
                    case "correo":
                        error = !Regex.IsMatch(txb.Text, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");

                        break;
                    case "telefono":
                        error = !Regex.IsMatch(txb.Text, @"^[0-9]{10}$");

                        break;
                    case "moneda":
                        error = !Regex.IsMatch(txb.Text, @"^[0-9]+(.)+[0-9]{2}$");



                        break;

                    default: if (str != "alfanumerico") MessageBox.Show("Test"); error = false; break;
                }

            }
            txb.ForeColor = (error) ? Color.Red : Color.Black;
        }
        static public bool validar(object[] array)
        {
            foreach(TextBox o in (TextBox[]) array)
            {
                if (o.Text == o.Tag.ToString() || o.ForeColor == Color.Silver || o.ForeColor == Color.Red)
                {
                    return true;
                }

            }
            return false;

        }

        static public string ImageToBase64String(Image imagen)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                imagen.Save(ms, imagen.RawFormat);
                return Convert.ToBase64String(ms.ToArray());
            }
        }

        static public Image Base64StringToImage(string stringBase64)
        {
            byte[] imageBytes = Convert.FromBase64String(stringBase64);
            using (var ms = new System.IO.MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                return Image.FromStream(ms, true);
            }
        }
    }
}
