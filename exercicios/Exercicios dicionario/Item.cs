using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_dicionario
{
    internal class Item
    {
        private string _Descricao;
        private DateTime _Data ;
        private float _Altura;

        public Item(string descricao, DateTime data, float altura)
        {
            _Descricao = descricao;
            _Data = data;
            _Altura = altura;
        }

        public string Descricao { get => _Descricao; set => _Descricao = value; }
        public DateTime Data { get => _Data; set => _Data = value; }
        public float Altura { get => _Altura; set => _Altura = value; }
    }
}
