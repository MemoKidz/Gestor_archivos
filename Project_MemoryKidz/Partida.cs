using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MemoryKidz
{
    internal class Partida
    {
        public string Avatar { get; set; }
        public int TiempoNivel1 { get; set; }
        public int TiempoNivel2 { get; set; }
        public int TiempoNivel3 { get; set; }
        public int TiempoNivel4 { get; set; }
        public int Fallos { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
