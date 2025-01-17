﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Serialization;
using System.IO;

namespace Projeto_Pedidos_de_Produtos
{
    /// <summary>
    /// Lógica interna para PedidoWindow.xaml
    /// </summary>
    public partial class PedidoWindow : Window
    {
        public PedidoWindow()
        {
            InitializeComponent();
        }

        private void CadastrarPedido_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(Idpedido.Text);
            string nome = Nomeusuario.Text;
            string datacriacao = Datacriacao.Text;
            string dataenvio = Dataenvio.Text;
            string status = combostatus.Text;
 

            Pedido p = new Pedido
            {
                IdPedido = id,
                NomeUsuario = nome,
                DataCriacao = datacriacao,
                DataEnvio = dataenvio,
                StatusPedido = status
            };
            NPedido.Inserir(p);

            ItemWindow iten = new ItemWindow();
            iten.ShowDialog();
        }

    }
}
    

