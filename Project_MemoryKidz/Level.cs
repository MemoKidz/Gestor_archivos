namespace Project_MemoryKidz
{
    /// <summary>
    /// Clase que representa el nivel de un avatar dentro de un grupo.
    /// </summary>
    public class Level
    {
        /// <summary>
        /// El número del nivel (1, 2 y 3).
        /// </summary>
        public int level { get; set; }

        /// <summary>
        /// El tiempo registrado para completar este nivel.
        /// </summary>
        public string time { get; set; }

        /// <summary>
        /// La cantidad de intentos realizados para completar este nivel.
        /// </summary>
        public int attempts { get; set; }
    }
}
