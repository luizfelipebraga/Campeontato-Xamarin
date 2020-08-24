﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinWsTower.Helpers;

namespace XamarinWsTower.Models
{
    public partial class Jogador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Posicao { get; set; }
        public int Qtdefaltas { get; set; }
        public int QtdecartoesAmarelo { get; set; }
        public int QtdecartoesVermelho { get; set; }
        public int Qtdegols { get; set; }
        public string Informacoes { get; set; }
        public int NumeroCamisa { get; set; }
        public byte[] Foto { get; set; }
        public ImageSource Img { get => Utils.ByteToImage(Foto); }
        public int? SelecaoId { get; set; }
        public virtual Selecao Selecao { get; set; }
    }
}
