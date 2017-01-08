using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Document : BaseEntity<long>
    {
        
        /// <summary>
        /// Название документа
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата создания документа
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Прикрепленные файлы
        /// </summary>
        public virtual List<File> Files { get; set; }
        
        /// <summary>
        /// Описание документа
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Пользователи, которым рассылается документ
        /// </summary>
        public virtual List<ApplicationUser> Users { get; set; }
    }
}
