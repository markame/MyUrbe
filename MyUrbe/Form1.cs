using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;


namespace MyUrbe
{
    public partial class Form1 : Form
    {

        public string id_pedido;
        public int quantp;
        public string statusp;
        public string curentJson;
        public string msgc;



        public class Pedido
        {

            public string id { get; set; }
            public string para { get; set; }
            public string data { get; set; }
            public string valor { get; set; }
            public string status { get; set; }
        }

        public class Jsonurbe
        {
            public IList<Pedido> pedidos { get; set; }
            public int hora { get; set; }
        }
        string pedidoss;
        public class Pedidos
        {
            public string id { get; set; }
            public string para { get; set; }
            public long data { get; set; }
            public string fp { get; set; }
            public string referencia { get; set; }
            public string valor { get; set; }
            public string status { get; set; }
            public string pedido_code { get; set; }
            public string msg { get; set; }
        }

        public string id_p;

        public class jsonpedidos
        {
            public IList<Pedidos> pedido { get; set; }
        }
        public Form1()
        {
          
            InitializeComponent();

            lerarquivo();
            buscaJson();
            JsonAsync();
            this.dgPedidos.CurrentCell = null;



        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public async Task<bool> JsonAsync()
        {
            bool suceok = false;
            while (!suceok)
            {
                WebRequest request = WebRequest.Create("https://myurbe.com/empresas/listapedidos.php ");

                request.Method = "POST";


                string postData = "{\"idp\":\"" + id_p + "\"}";
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
                    string jsonresp = reader.ReadToEnd();
                    var ab = JsonConvert.DeserializeObject<Jsonurbe>(jsonresp);


                    this.dgPedidos.DataSource = ab.pedidos;
                    this.dgPedidos.CurrentCell = null;



                    dgPedidos.Columns[0].HeaderText = "Pedido";
                    dgPedidos.Columns[1].HeaderText = "Para";
                    dgPedidos.Columns[2].HeaderText = "Data e Hora";

                    for (int x = 0; x < dgPedidos.Rows.Count; x++)
                    {
                        long myLong = long.Parse(ab.pedidos[x].data);
                        String data = UnixTimeToDateTime(myLong).ToString("HH-mm dd-MM ");
                        dgPedidos.Rows[x].Cells["Data"].Value = data;
                        if (dgPedidos.Rows[x].Cells[4].Value.ToString() == "5")
                        {
                            dgPedidos.Rows[x].Cells[0].Style.BackColor = Color.LightBlue;
                        }
                        if (dgPedidos.Rows[x].Cells[4].Value.ToString() == "4")
                        {
                            dgPedidos.Rows[x].Cells[0].Style.BackColor = Color.LightGreen;
                        }
                        if (dgPedidos.Rows[x].Cells[4].Value.ToString() == "1")
                        {
                            dgPedidos.Rows[x].Cells[0].Style.BackColor = Color.LightYellow;
                            newP();
                        }
                        if (dgPedidos.Rows[x].Cells[4].Value.ToString() == "2")
                        {
                            dgPedidos.Rows[x].Cells[0].Style.BackColor = Color.LightYellow;
                            newP();
                        }
                        if (dgPedidos.Rows[x].Cells[4].Value.ToString() == "5")
                        {
                            dgPedidos.Rows[x].Cells[0].Style.BackColor = Color.LightBlue;
                        }
                        if (dgPedidos.Rows[x].Cells[4].Value.ToString() == "4")
                        {
                            dgPedidos.Rows[x].Cells[0].Style.BackColor = Color.LightGreen;
                        }
                        if (dgPedidos.Rows[x].Cells[4].Value.ToString() == "6")
                        {
                            dgPedidos.Rows[x].Cells[0].Style.BackColor = Color.Gray;
                        }
                        if (dgPedidos.Rows[x].Cells[4].Value.ToString() == "9")
                        {
                            dgPedidos.Rows[x].Cells[0].Style.BackColor = Color.Salmon;
                        }
                    }
                    
                    if (ab.pedidos.Count > quantp)
                    {
                        PopupNotifier popup = new PopupNotifier();

                        popup.TitleText = "MyUrbe";
                        popup.ContentText = "Existe um novo Pedido!";

                        popup.Delay = 10000;
                        popup.Popup();
                        newP();

                        quantp = ab.pedidos.Count();
                    }

                }
                await Task.Delay(10000);
                dgPedidos.CurrentCell = null;
            }
            return suceok;
        }

        private void newP()
        {
            SoundPlayer musica = new SoundPlayer(@Properties.Resources._new);
            musica.Play();
        }


        public void buscaJson()
        {
            try{
                WebRequest request = WebRequest.Create("https://myurbe.com/empresas/listapedidos.php ");

                request.Method = "POST";


                string postData = "{\"idp\":\"" + id_p + "\"}";
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
                    string jsonresp = reader.ReadToEnd();
                    var ab = JsonConvert.DeserializeObject<Jsonurbe>(jsonresp);


                    this.dgPedidos.DataSource = ab.pedidos;
                    
                    this.dgPedidos.CurrentCell = null;

                    dgPedidos.Columns[0].HeaderText = "Pedido";
                    dgPedidos.Columns[1].HeaderText = "Para";
                    dgPedidos.Columns[2].HeaderText = "Data e Hora";


                    for (int x = 0; x < dgPedidos.Rows.Count; x++)
                    {
                        long myLong = long.Parse(ab.pedidos[x].data);
                        String data = UnixTimeToDateTime(myLong).ToString("HH-mm dd-MM ");
                        dgPedidos.Rows[x].Cells["Data"].Value = data;

                        if (dgPedidos.Rows[x].Cells[4].Value.ToString() == "5")
                        {
                            dgPedidos.Rows[x].Cells[0].Style.BackColor = Color.LightBlue;
                        }
                        if (dgPedidos.Rows[x].Cells[4].Value.ToString() == "4")
                        {
                            dgPedidos.Rows[x].Cells[0].Style.BackColor = Color.LightGreen;
                        }
                        if (dgPedidos.Rows[x].Cells[4].Value.ToString() == "1")
                        {
                            dgPedidos.Rows[x].Cells[0].Style.BackColor = Color.LightYellow;
                        }
                        if (dgPedidos.Rows[x].Cells[4].Value.ToString() == "5")
                        {
                            dgPedidos.Rows[x].Cells[0].Style.BackColor = Color.LightBlue;
                        }
                        if (dgPedidos.Rows[x].Cells[4].Value.ToString() == "4")
                        {
                            dgPedidos.Rows[x].Cells[0].Style.BackColor = Color.LightGreen;
                        }
                        if (dgPedidos.Rows[x].Cells[4].Value.ToString() == "6")
                        {
                            dgPedidos.Rows[x].Cells[0].Style.BackColor = Color.Gray;
                        }
                        if (dgPedidos.Rows[x].Cells[4].Value.ToString() == "9")
                        {
                            dgPedidos.Rows[x].Cells[0].Style.BackColor = Color.Salmon;
                        }
                    }


                    quantp = ab.pedidos.Count();
                }
                this.dgPedidos.CurrentCell = null;

            }
            
            catch (Exception e )
            {
                MessageBox.Show(e.Message,"Erro de conexão");
            }


        }
        public DateTime UnixTimeToDateTime(long unixtime)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateTime = dateTime.AddSeconds(unixtime).ToLocalTime();
            return dateTime;
        }

        private void ListBox1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void DgPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = dgPedidos.Rows[e.RowIndex];
                id_pedido = dataGridViewRow.Cells["id"].Value.ToString();
                JsonDetalhesP(id_pedido);


            }
        }

        public void JsonDetalhesP(string id_pedido)
        {
            WebRequest request = WebRequest.Create("https://myurbe.com/empresas/pedido.php");

            request.Method = "POST";


            string postData = "{\"id\":\"" + id_pedido + "\",\"p\":\"99\"}";
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
                var ac = JsonConvert.DeserializeObject<jsonpedidos>(json);


                for (int x = 0; x < ac.pedido.Count; x++)
                {
                    string code = ac.pedido[x].pedido_code.ToString();

                    wbMensage.DocumentText = ac.pedido[x].msg.ToString();
                    var ad = JsonConvert.DeserializeObject<destinoClie>(code);
                    lbCodPed.Text = ac.pedido[x].id.ToString();
                    if (ac.pedido[x].status == "5")
                    {
                        id_pedido = ac.pedido[x].id;
                        lbStatus.ForeColor = Color.Blue;
                        lbStatus.Text = "Finalizado";
                        btConf.Enabled = false;
                        btRecusa.Enabled = false;
                        statusp = ac.pedido[x].status;
                        msgc = ac.pedido[x].msg.ToString();
                        btImpres.Enabled = true;


                    }
                    if (ac.pedido[x].status == "4")
                    {

                        btConf.Enabled = true;
                        lbStatus.ForeColor = Color.Green;
                        lbStatus.Text = "Em Preparo";
                        if (checkread() == 1)
                        {
                            btConf.Text = "Enviar e imprimir";
                            buscaJson();

                        }
                        buscaJson();
                        btConf.Text = "Enviar";


                        id_pedido = ac.pedido[x].id;
                        statusp = ac.pedido[x].status;
                        btRecusa.Enabled = false;
                        msgc = ac.pedido[x].msg.ToString();
                        
                        btImpres.Enabled = true;


                    }
                    if (ac.pedido[x].status == "1")
                    {

                        btConf.Enabled = true;
                        btRecusa.Enabled = true;
                        lbStatus.ForeColor = Color.DarkOrange;
                        lbStatus.Text = "Aguardando Confimaçao";
                        btConf.Text = "Confirmar";
                        id_pedido = ac.pedido[x].id;
                        statusp = ac.pedido[x].status;
                        msgc = ac.pedido[x].msg.ToString();
                        buscaJson();
                        btImpres.Enabled = false;



                    }
                    if (ac.pedido[x].status == "6")
                    {
                        lbStatus.ForeColor = Color.Red;
                        lbStatus.Text = "Cancelado Pela Empresa";
                        btConf.Enabled = false;
                        btRecusa.Enabled = false;
                        id_pedido = ac.pedido[x].id;
                        statusp = ac.pedido[x].status;
                        msgc = ac.pedido[x].msg.ToString();
                        btImpres.Enabled = false;
                        buscaJson();
                     
                        }
                    if (ac.pedido[x].status == "9")
                    {
                        lbStatus.ForeColor = Color.Red;
                        lbStatus.Text = "Pedido não atendido";
                        btConf.Enabled = false;
                        btRecusa.Enabled = false;
                        id_pedido = ac.pedido[x].id;
                        statusp = ac.pedido[x].status;
                        msgc = ac.pedido[x].msg.ToString();
                        btImpres.Enabled = false;
                        buscaJson();
                    }

                        lbData.Text = UnixTimeToDateTime(ac.pedido[x].data).ToString("HH:mm - dd/MM/yyyy ");
                    
                    

                    for (int k = 0; k < ad.carrinho.Count; k++)
                    {
                        pedidoss += ad.carrinho[k].qtde+"X ";
                        pedidoss += ad.carrinho[k].nome;

                        for (int j=0;j< ad.carrinho[k].comps.Count; j++) {

                            pedidoss += "\n";
                            pedidoss +="    "+ ad.carrinho[k].comps[j].quantidade+ "·" + ad.carrinho[k].comps[j].comp;
                            

                        }
                        if (ad.carrinho[x].obs!="")
                        {
                            pedidoss += "\n    *" + ad.carrinho[x].obs + "\n";
                        }
                        pedidoss += "\n";
                        pedidoss += "    " + "Sub:R$" + ad.carrinho[k].valor;
                        pedidoss += "\n";

                        
                        //pedidoss += "*"+ad.carrinho[x].obs;
                        pedidoss += "\n";
                        pedidoss += "*****";
                        pedidoss += "\n";




                    }    
                   
                    lbPedido.Text = pedidoss;
                    
                   
                    
                    string desenha;
                    desenha = "\n";
                    
                    desenha += "   Frete:R$ " + (Math.Round(ad.frete,2,MidpointRounding.AwayFromZero).ToString("0.00"));
                    desenha += "\n";
                    desenha += "   Total do pedido:R$" + ((Convert.ToDouble(ad.valor) +Math.Round(ad.frete, 2, MidpointRounding.AwayFromZero)).ToString("0.00"));
                    lbPedido.Text += desenha;
                    desenha = "";
                    pedidoss = "";



                    string enderecocomp = ad.destino.rua.ToString();
                    enderecocomp += "\n";
                    enderecocomp += ad.destino.nm.ToString();
                    enderecocomp += "\n";
                    enderecocomp += ad.destino.bairro.ToString();
                    enderecocomp += "\n";
                    enderecocomp += ac.pedido[x].referencia;
                    enderecocomp += "\n";
                    enderecocomp += ad.destino.para.ToString();
                    enderecocomp += "\n";
                    enderecocomp += ad.destino.telefone.ToString();
                    lbendereco.Text = enderecocomp;
                    if (ac.pedido[x].fp == "1")
                    {
                        lbTipPag.Text = "Tipo Pagamento: Cartão de Credito";
                    }
                    if (ac.pedido[x].fp == "2")
                    {
                        lbTipPag.Text = "Tipo Pagamento: Dinheiro";
                    }

                    if (ac.pedido[x].fp == "3")
                    {
                        lbTipPag.Text = "Tipo Pagamento: Cartão de Debito";
                    }
                    if (ac.pedido[x].fp == "4")
                    {
                        lbTipPag.Text = "Tipo Pagamento: Cartão Vale";
                    }
                    if (ac.pedido[x].fp == "5")
                    {
                        lbTipPag.Text = "Tipo Pagamento: Pago Online";
                    }
                }
            }
        }

        public void selectprint()
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = printDocument1;
          
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        public int checkread()
        {

            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\imp.zin";
            string[] array = File.ReadAllLines(path);
            string str = array[0];
            return Convert.ToInt32(str);

        }

        public void RespondeMensagem(string Id_Pedido, string Msg, string statuspedido)
        {
            WebRequest request = WebRequest.Create("https://myurbe.com/empresas/msg.php");

            request.Method = "POST";


            string postData = "{\"p\":\"" + Id_Pedido + "\",\"msg\":\"" + Msg + "\",\"c\":\"" + statuspedido + "\"}";
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

            }


        }
        public void CancelaPedido(string Id_Pedido, string Msg, string statuspedido)
        {
            WebRequest request = WebRequest.Create("https://myurbe.com/empresas/msg.php");

            request.Method = "POST";


            string postData = "{\"p\":\"" + Id_Pedido + "\",\"msg\":\"" + Msg + "\",\"c\":\"" + statuspedido + "\"}";
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

            }
            MessageBox.Show("Cancelado com sucesso");


        }

        public void RespondePedido(string Id_Pedido, string Resposta)
        {
            WebRequest request = WebRequest.Create("https://myurbe.com/empresas/pedido.php");

            request.Method = "POST";


            string postData = "{\"id\":\"" + Id_Pedido + "\",\"p\":\"" + Resposta + "\"}";
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

            }


        }


        public class Destino
        {
            public string para { get; set; }
            public string telefone { get; set; }
            public string rua { get; set; }
            public string nm { get; set; }
            public string bairro { get; set; }
            public string id_b { get; set; }
            public string refe { get; set; }
        }

        public class Comp
        {
            public string comp { get; set; }
            public int quantidade { get; set; }
            public double valor_unitario { get; set; }
            public int index { get; set; }
            public int grupo { get; set; }
        }

        public class Carrinho
        {
            public string id { get; set; }
            public string nome { get; set; }
            public int qtde { get; set; }
            public string valor { get; set; }
            public int sem_frt { get; set; }
            public IList<Comp> comps { get; set; }
            public string obs { get; set; }
        }

        public class destinoClie
        {
            public Destino destino { get; set; }
            public string id_m { get; set; }
            public IList<Carrinho> carrinho { get; set; }
            public double valor { get; set; }
            public double desconto { get; set; }
            public double frete { get; set; }
            public string pt_min { get; set; }
            public bool sem_frt { get; set; }
            public int tx_min { get; set; }
            public int id_cupom { get; set; }
            public bool aberta { get; set; }
            public string empresa { get; set; }
            public string id_l { get; set; }
            public int id_c { get; set; }
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void LbFrete_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void BtConf_Click(object sender, EventArgs e)
        {

            if (statusp == "1")
            {

                RespondePedido(id_pedido, "2");
                lbStatus.ForeColor = Color.Green;
                btConf.BackColor = Color.DarkBlue;
                btConf.ForeColor = Color.White;
                lbStatus.Text = "Em Preparo";
                btConf.Text = "Finalizar e enviar";
                btRecusa.Enabled = false;
                buscaJson();
                statusp = "0";
            }
            if (statusp == "4")
            {

                RespondePedido(id_pedido, "3");
                lbStatus.ForeColor = Color.Blue;
                lbStatus.Text = "Finalizado";
                btRecusa.Enabled = false;

                if (checkread() == 1)
                {
                    selectprint();
                    buscaJson();
                    statusp = "0";
                }
                else
                    buscaJson();
                btConf.Enabled = false;
                statusp = "0";

            }


        }

        private void BtRecusa_Click(object sender, EventArgs e)
        {
          string motivo =  Microsoft.VisualBasic.Interaction.InputBox("Qual o Motivo do cancelamento?", "Cancelar Pedido", "");
            CancelaPedido(id_pedido, motivo,1.ToString());
            buscaJson();
            JsonDetalhesP(id_pedido);
            

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            RespondeMensagem(id_pedido, txMensage.Text.ToString(), 0.ToString());
            NewMensage(id_pedido);



        }

        public void NewMensage(string P_pedido)
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
                var ac = JsonConvert.DeserializeObject<jsonpedidos>(json);
                wbMensage.DocumentText = ac.pedido[0].msg.ToString();
                txMensage.Text = "";
            }
        }

        private void Info1ToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        public void lerarquivo()
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\local.zin";
            string[] array = File.ReadAllLines(path);
            string str = array[0];
            id_p = ConvertHexToString(str, System.Text.Encoding.Unicode);
            Console.WriteLine(id_p);
            Console.WriteLine(id_p);
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

        private void ConfiguraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conf newconf = new Conf();
            newconf.Show();


        }

        private void ImpressorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfPrint imp = new ConfPrint();
            imp.ShowDialog();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            Bitmap bb = new Bitmap(this.gpBoxCli.Width, this.gpBoxCli.Height);
            gpBoxCli.DrawToBitmap(bb, new Rectangle(0, 0, this.gpBoxCli.Width, this.gpBoxCli.Height));
            Bitmap bt = new Bitmap(this.gpBoxDe.Width, this.gpBoxDe.Height);
            gpBoxDe.DrawToBitmap(bt, new Rectangle(0, 0, this.gpBoxDe.Width, this.gpBoxDe.Height));

            int width = bt.Width + bb.Width;
            int height = (bt.Height+bb.Height);
            Bitmap fullBmp = new Bitmap(width, height);
            Graphics gr = Graphics.FromImage(fullBmp);
            gr.DrawImage(bt, 0, 0, bt.Width, bt.Height);
            gr.DrawImage(bb, 0, bt.Height);
            e.Graphics.DrawImage(fullBmp,0,0);



        }

        private void BtImpres_Click(object sender, EventArgs e)
        {
            selectprint();
        }

        private void PrintDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }
    }

}
