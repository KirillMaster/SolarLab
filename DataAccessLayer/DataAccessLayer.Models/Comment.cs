using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    /// <summary>
    /// Комментарий к задаче
    /// </summary>
   public class Comment : BaseEntity<long>
    {
        /// <summary>
        /// время создания
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Содержание комментария
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Автор комментария
        /// </summary>
        public virtual ApplicationUser Author { get; set; }

        /// <summary>
        /// Задача, к которой написан комментарий
        /// </summary>
        public virtual AppTask Task { get; set; }
    }
}
