using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUrbe
{
    public partial class ConfPrint : Form
    {
        string str;
        public ConfPrint()
        {
            InitializeComponent();
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
            }
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
            }
            if (checkread() == 1)
            {
                checkBox1.Checked = true;
            }
            if(checkread() == 0)
            {
                checkBox2.Checked = true;
            }

            
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                checkwrite("1");
            }
            if (checkBox1.Checked == false)
            {
                checkwrite("0");
            }
        }

        public int checkread()
        {
            
                string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\imp.zin";
                string[] array = File.ReadAllLines(path);
                str = array[0];
                 return Convert.ToInt32(str);      
            
        }
        public void  checkwrite(string conf)
        {

            string[] lines = {conf};
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\imp.zin";
            File.WriteAllLines(path, lines);
            MessageBox.Show("Configuração salva com sucesso! A aplicação sera encerrada", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
