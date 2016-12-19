
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    /// <summary>
    /// Модель для работы с объявлениями.
    /// </summary>
    public class Post : BaseEntity<long>
    {
        /// <summary>
        /// Название файла
        /// </summary>
       public string Title { get; set; }
        /// <summary>
        /// Описание файла
        /// </summary>
       public string Description { get; set; }

        /// <summary>
        /// Список файлов
        /// </summary>
       public virtual List<File> Files { get; set; }
    }
}
