using System.Collections.Generic;


namespace Project_MemoryKidz
{
    /// <summary>
    /// Clase que representa un grupo de avatares dentro del sistema.
    /// </summary>
    public class Group
    {
        /// <summary>
        /// El identificador del grupo.
        /// </summary>
        public int group { get; set; }

        /// <summary>
        /// Lista de avatares asociados a este grupo.
        /// </summary>
        public List<Avatar> avatars { get; set; }
    }
}
