using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUrbe
{
    public partial class Conf : Form
    {
        public Conf()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        public static string ConvertStringToHex(String input, System.Text.Encoding encoding)
        {
            Byte[] stringBytes = encoding.GetBytes(input);
            StringBuilder sbBytes = new StringBuilder(stringBytes.Length * 2);
            foreach (byte b in stringBytes)
            {
                sbBytes.AppendFormat("{0:X2}", b);
            }
            return sbBytes.ToString();
        }
        public static string ConvertHexToString(String hexInput, System.Text.Encoding encoding)
        {
            int numberChars = hexInput.Length;
            byte[] bytes = new byte[numberChars / 2];
            for (int i = 0; i < numberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hexInput.Substring(i, 2), 16);
            }
            return encoding.GetString(bytes);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            key.SetValue("MyUrbe", Application.ExecutablePath.ToString());
            
            string[] lines = { ConvertStringToHex(txtCod.Text, System.Text.Encoding.Unicode), ConvertStringToHex(txtSen.Text, System.Text.Encoding.Unicode)};
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\local.zin";
            File.WriteAllLines(path, lines);
            MessageBox.Show("Configuração salva com sucesso! A aplicação sera encerrada","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Application.Exit();


        }
        public void Registro(string P_pedido)
        {
            WebRequest request = WebRequest.Create("https://myurbe.com/empresas/pedido.php");

            request.Method = "POST";


            string postData = "{\"id\":\"" + P_pedido + "\",\"p\":\"1\"}";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);


            request.ContentType = "application/x-www-form-urlencoded";

            request.ContentLength = byteArray.Length;


            Stream dataStream = request.GetRequestStream();

            dataStream.Write(byteArray, 0, byteArray.Length);

            dataStream.Close();


            WebResponse response = request.GetResponse();

            using (dataStream = response.GetResponseStream())
            {

                StreamReader reader = new StreamReader(dataStream);
                string json = reader.ReadToEnd();
                /*var ac = JsonConvert.DeserializeObject<jsonpedidos>(json);
                wbMensage.DocumentText = ac.pedido[0].msg.ToString();
                txMensage.Text = "";*/
            }
        }
    }
}
