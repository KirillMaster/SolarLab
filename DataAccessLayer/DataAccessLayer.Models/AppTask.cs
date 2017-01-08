using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class AppTask : BaseEntity<long>
    {
        /// <summary>
        /// Название задачи 
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Краткое описание задачи
        /// </summary>
        public string  Description { get; set;}
        /// <summary>
        /// Срок выполнения задачи
        /// </summary>
        public DateTime DeadLine { get; set; }
        /// <summary>
        /// Прикрепленные файлы задачи
        /// </summary>
        public List<File> Files { get; set; }
    }
}
