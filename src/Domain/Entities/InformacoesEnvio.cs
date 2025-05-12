using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class InformacoesEnvio : Entitybase
    {
        public string endereço { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string telefone { get; set; }
        public string nomeDestinatario { get; set; }
        public string sobrenomeDestinatario { get; set; }
        public string cpfDestinatario { get; set; }
        public string emailDestinatario { get; set; }
        
        public Datetime datetimeEnvio { get; set; }
        public Datetime dataDeEnvioPrevista
    }
}