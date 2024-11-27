using System.Collections.Generic;

namespace Project_MemoryKidz
{
    /// <summary>
    /// Clase que representa un avatar dentro de un grupo, incluyendo su progreso en los niveles.
    /// </summary>
    public class Avatar
    {
        /// <summary>
        /// El identificador del avatar (por ejemplo, 1 para "Mono", 2 para "Tiburón", etc.).
        /// </summary>
        public int avatar { get; set; }

        /// <summary>
        /// Lista de niveles que representan el progreso del avatar en el juego.
        /// </summary>
        public List<Level> levels { get; set; }
    }
}
