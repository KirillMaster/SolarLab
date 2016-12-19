using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    /// <summary>
    /// Модель для работы с файлами
    /// </summary>
    public class File : BaseEntity<Guid>
    {
        /// <summary>
        /// Имя файла от пользователя
        /// </summary>
        public string UserFileName { get; set; }
        /// <summary>
        /// Контент файла в байтовом представлении
        /// </summary>
        public byte[] Content { get; set; }

        public virtual Post Post { get; set; }
        public virtual List<Task> Tasks { get; set; }
    }
}
