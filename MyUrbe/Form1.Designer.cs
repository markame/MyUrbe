namespace MyUrbe
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.wbMensage = new System.Windows.Forms.WebBrowser();
            this.button3 = new System.Windows.Forms.Button();
            this.txMensage = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgPedidos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btImpres = new System.Windows.Forms.Button();
            this.PanelPedido = new System.Windows.Forms.Panel();
            this.gpBoxCli = new System.Windows.Forms.GroupBox();
            this.lbTipPag = new System.Windows.Forms.Label();
            this.lbendereco = new System.Windows.Forms.Label();
            this.lb12 = new System.Windows.Forms.Label();
            this.gpBoxDe = new System.Windows.Forms.GroupBox();
            this.lbData = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPedido = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbTipPed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCodPed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btRecusa = new System.Windows.Forms.Button();
            this.btConf = new System.Windows.Forms.Button();
            this.info1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impressorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.PanelPedido.SuspendLayout();
            this.gpBoxCli.SuspendLayout();
            this.gpBoxDe.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1390, 679);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.txMensage);
            this.panel2.Location = new System.Drawing.Point(890, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 666);
            this.panel2.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.wbMensage);
            this.groupBox5.Location = new System.Drawing.Point(3, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(491, 592);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mensagens";
            // 
            // wbMensage
            // 
            this.wbMensage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbMensage.Location = new System.Drawing.Point(3, 18);
            this.wbMensage.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMensage.Name = "wbMensage";
            this.wbMensage.Size = new System.Drawing.Size(485, 571);
            this.wbMensage.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(368, 611);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "Enviar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // txMensage
            // 
            this.txMensage.Location = new System.Drawing.Point(3, 603);
            this.txMensage.Multiline = true;
            this.txMensage.Name = "txMensage";
            this.txMensage.Size = new System.Drawing.Size(345, 60);
            this.txMensage.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgPedidos);
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 666);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pedidos ";
            // 
            // dgPedidos
            // 
            this.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgPedidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgPedidos.Location = new System.Drawing.Point(6, 21);
            this.dgPedidos.MultiSelect = false;
            this.dgPedidos.Name = "dgPedidos";
            this.dgPedidos.ReadOnly = true;
            this.dgPedidos.RowHeadersWidth = 51;
            this.dgPedidos.RowTemplate.Height = 24;
            this.dgPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPedidos.ShowCellToolTips = false;
            this.dgPedidos.Size = new System.Drawing.Size(446, 635);
            this.dgPedidos.TabIndex = 0;
            this.dgPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgPedidos_CellContentClick);
            this.dgPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgPedidos_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btImpres);
            this.groupBox1.Controls.Add(this.PanelPedido);
            this.groupBox1.Controls.Add(this.btRecusa);
            this.groupBox1.Controls.Add(this.btConf);
            this.groupBox1.Location = new System.Drawing.Point(468, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 673);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datalhes do pedido";
            // 
            // btImpres
            // 
            this.btImpres.Enabled = false;
            this.btImpres.Location = new System.Drawing.Point(165, 622);
            this.btImpres.Name = "btImpres";
            this.btImpres.Size = new System.Drawing.Size(81, 45);
            this.btImpres.TabIndex = 4;
            this.btImpres.Text = "Imprimir";
            this.btImpres.UseVisualStyleBackColor = true;
            this.btImpres.Click += new System.EventHandler(this.BtImpres_Click);
            // 
            // PanelPedido
            // 
            this.PanelPedido.AutoScroll = true;
            this.PanelPedido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelPedido.Controls.Add(this.gpBoxCli);
            this.PanelPedido.Controls.Add(this.gpBoxDe);
            this.PanelPedido.Location = new System.Drawing.Point(7, 22);
            this.PanelPedido.Name = "PanelPedido";
            this.PanelPedido.Size = new System.Drawing.Size(402, 594);
            this.PanelPedido.TabIndex = 3;
            // 
            // gpBoxCli
            // 
            this.gpBoxCli.Controls.Add(this.lbTipPag);
            this.gpBoxCli.Controls.Add(this.lbendereco);
            this.gpBoxCli.Controls.Add(this.lb12);
            this.gpBoxCli.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpBoxCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoxCli.Location = new System.Drawing.Point(0, 381);
            this.gpBoxCli.Name = "gpBoxCli";
            this.gpBoxCli.Size = new System.Drawing.Size(402, 213);
            this.gpBoxCli.TabIndex = 11;
            this.gpBoxCli.TabStop = false;
            this.gpBoxCli.Text = "Dados Cliente";
            this.gpBoxCli.Enter += new System.EventHandler(this.GroupBox4_Enter);
            // 
            // lbTipPag
            // 
            this.lbTipPag.AutoSize = true;
            this.lbTipPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipPag.Location = new System.Drawing.Point(18, 39);
            this.lbTipPag.Name = "lbTipPag";
            this.lbTipPag.Size = new System.Drawing.Size(153, 20);
            this.lbTipPag.TabIndex = 13;
            this.lbTipPag.Text = "Tipo de Pagamento";
            // 
            // lbendereco
            // 
            this.lbendereco.AutoSize = true;
            this.lbendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbendereco.Location = new System.Drawing.Point(18, 79);
            this.lbendereco.Name = "lbendereco";
            this.lbendereco.Size = new System.Drawing.Size(85, 20);
            this.lbendereco.TabIndex = 12;
            this.lbendereco.Text = "Endereço:";
            // 
            // lb12
            // 
            this.lb12.AutoSize = true;
            this.lb12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb12.Location = new System.Drawing.Point(18, 59);
            this.lb12.Name = "lb12";
            this.lb12.Size = new System.Drawing.Size(85, 20);
            this.lb12.TabIndex = 11;
            this.lb12.Text = "Endereço:";
            // 
            // gpBoxDe
            // 
            this.gpBoxDe.AutoSize = true;
            this.gpBoxDe.Controls.Add(this.lbData);
            this.gpBoxDe.Controls.Add(this.label5);
            this.gpBoxDe.Controls.Add(this.lbPedido);
            this.gpBoxDe.Controls.Add(this.lbStatus);
            this.gpBoxDe.Controls.Add(this.lbTipPed);
            this.gpBoxDe.Controls.Add(this.label3);
            this.gpBoxDe.Controls.Add(this.lbCodPed);
            this.gpBoxDe.Controls.Add(this.label1);
            this.gpBoxDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpBoxDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoxDe.Location = new System.Drawing.Point(0, 0);
            this.gpBoxDe.Name = "gpBoxDe";
            this.gpBoxDe.Size = new System.Drawing.Size(402, 198);
            this.gpBoxDe.TabIndex = 7;
            this.gpBoxDe.TabStop = false;
            this.gpBoxDe.Text = "Pedido";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(86, 96);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(0, 20);
            this.lbData.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data: ";
            // 
            // lbPedido
            // 
            this.lbPedido.AutoSize = true;
            this.lbPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPedido.Location = new System.Drawing.Point(15, 152);
            this.lbPedido.Name = "lbPedido";
            this.lbPedido.Size = new System.Drawing.Size(65, 20);
            this.lbPedido.TabIndex = 8;
            this.lbPedido.Text = "Pedido:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(86, 58);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 20);
            this.lbStatus.TabIndex = 3;
            // 
            // lbTipPed
            // 
            this.lbTipPed.AutoSize = true;
            this.lbTipPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipPed.Location = new System.Drawing.Point(6, 123);
            this.lbTipPed.Name = "lbTipPed";
            this.lbTipPed.Size = new System.Drawing.Size(79, 20);
            this.lbTipPed.TabIndex = 8;
            this.lbTipPed.Text = "PEDIDO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status:";
            // 
            // lbCodPed
            // 
            this.lbCodPed.AutoSize = true;
            this.lbCodPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodPed.Location = new System.Drawing.Point(86, 22);
            this.lbCodPed.Name = "lbCodPed";
            this.lbCodPed.Size = new System.Drawing.Size(0, 20);
            this.lbCodPed.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido:";
            // 
            // btRecusa
            // 
            this.btRecusa.BackColor = System.Drawing.Color.DarkRed;
            this.btRecusa.Enabled = false;
            this.btRecusa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRecusa.Location = new System.Drawing.Point(7, 622);
            this.btRecusa.Name = "btRecusa";
            this.btRecusa.Size = new System.Drawing.Size(110, 45);
            this.btRecusa.TabIndex = 2;
            this.btRecusa.Text = "Recusar";
            this.btRecusa.UseVisualStyleBackColor = false;
            this.btRecusa.Click += new System.EventHandler(this.BtRecusa_Click);
            // 
            // btConf
            // 
            this.btConf.BackColor = System.Drawing.Color.DarkGreen;
            this.btConf.Enabled = false;
            this.btConf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btConf.Location = new System.Drawing.Point(299, 622);
            this.btConf.Name = "btConf";
            this.btConf.Size = new System.Drawing.Size(110, 45);
            this.btConf.TabIndex = 1;
            this.btConf.Text = "Confirmar";
            this.btConf.UseVisualStyleBackColor = false;
            this.btConf.Click += new System.EventHandler(this.BtConf_Click);
            // 
            // info1ToolStripMenuItem
            // 
            this.info1ToolStripMenuItem.Name = "info1ToolStripMenuItem";
            this.info1ToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.info1ToolStripMenuItem.Text = "Configuração";
            this.info1ToolStripMenuItem.Click += new System.EventHandler(this.Info1ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem,
            this.impressorasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1414, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            this.configuraçõesToolStripMenuItem.Click += new System.EventHandler(this.ConfiguraçõesToolStripMenuItem_Click);
            // 
            // impressorasToolStripMenuItem
            // 
            this.impressorasToolStripMenuItem.Name = "impressorasToolStripMenuItem";
            this.impressorasToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.impressorasToolStripMenuItem.Text = "Impressoras";
            this.impressorasToolStripMenuItem.Click += new System.EventHandler(this.ImpressorasToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument2_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 722);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyUrbe";
            this.Load += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.PanelPedido.ResumeLayout(false);
            this.PanelPedido.PerformLayout();
            this.gpBoxCli.ResumeLayout(false);
            this.gpBoxCli.PerformLayout();
            this.gpBoxDe.ResumeLayout(false);
            this.gpBoxDe.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txMensage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btRecusa;
        private System.Windows.Forms.Button btConf;
        private System.Windows.Forms.ToolStripMenuItem info1ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgPedidos;
        private System.Windows.Forms.Panel PanelPedido;
        private System.Windows.Forms.GroupBox gpBoxCli;
        private System.Windows.Forms.GroupBox gpBoxDe;
        private System.Windows.Forms.Label lbPedido;
        private System.Windows.Forms.Label lbTipPed;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCodPed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTipPag;
        private System.Windows.Forms.Label lbendereco;
        private System.Windows.Forms.Label lb12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.WebBrowser wbMensage;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impressorasToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btImpres;
        private System.Drawing.Printing.PrintDocument printDocument2;
    }
}

