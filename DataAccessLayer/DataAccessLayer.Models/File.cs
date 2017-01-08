using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    /// <summary>
    /// Модель для работы с файлами
    /// </summary>
    public class File : BaseEntity<long>
    {
        /// <summary>
        /// Имя файла от пользователя
        /// </summary>
        public string UserFileName { get; set; }

        /// <summary>
        /// Системное имя файла
        /// </summary>
        public string SystemFileName { get; set; }

        /// <summary>
        /// Контент файла в байтовом представлении
        /// </summary>
        public byte[] Content { get; set; }

        /// <summary>
        /// Список постов, куда прикрепляется данный файл
        /// </summary>
        public virtual List<Post> Posts { get; set; }
        /// <summary>
        /// Список задач, в которых фигурирует данный файл
        /// </summary>
        public virtual List<AppTask> Tasks { get; set; }

        /// <summary>
        /// Список документов, которому принадлежит данный файл
        /// </summary>
        public virtual List<Document> Documents { get; set; }


       
    }
}
