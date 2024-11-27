using System.Collections.Generic;

namespace Project_MemoryKidz
{
    /// <summary>
    /// Clase que representa la estructura raíz que contiene una lista de grupos de avatares.
    /// </summary>
    public class Root
    {
        /// <summary>
        /// Lista de grupos que contienen avatares y sus datos relacionados.
        /// </summary>
        public List<Group> groups { get; set; }
    }
}
