using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaSala
{
    class Reserva
    {
        public string Responsavel { get; set; }
        public string Sala { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Horario { get; set; }
        public TimeSpan Duracao { get; set; }

        public Reserva(string responsavel, string sala,
                       DateTime data, TimeSpan horario, TimeSpan duracao)
        {
            Responsavel = responsavel;
            Sala = sala;
            Data = data;
            Horario = horario;
            Duracao = duracao;
        }
    }
}