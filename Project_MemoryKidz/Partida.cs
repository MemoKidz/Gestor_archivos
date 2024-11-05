using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MemoryKidz
{

    /// <summary>
    /// Representa una partida jugada en el juego, con información sobre el avatar, los tiempos en cada nivel, los fallos cometidos y la fecha y hora de la partida.
    /// </summary>
    internal class Partida
    {
        /// <summary>
        /// Obtiene o establece el nombre del avatar del jugador.
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// Obtiene o establece el tiempo que el jugador tardó en completar el primer nivel.
        /// </summary>
        public int TiempoNivel1 { get; set; }

        /// <summary>
        /// Obtiene o establece el tiempo que el jugador tardó en completar el segundo nivel.
        /// </summary>
        public int TiempoNivel2 { get; set; }

        /// <summary>
        /// Obtiene o establece el tiempo que el jugador tardó en completar el tercer nivel.
        /// </summary>
        public int TiempoNivel3 { get; set; }

        /// <summary>
        /// Obtiene o establece el número de intentos cometidos por el jugador durante la partida.
        /// </summary>
        public int Fallos { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha y hora en la que se jugó la partida.
        /// </summary>
        public DateTime FechaHora { get; set; }
    }
}
