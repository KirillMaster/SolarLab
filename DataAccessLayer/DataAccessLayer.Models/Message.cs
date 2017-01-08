using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{

    /// <summary>
    /// Личные сообщения между зарегистрированными пользователями
    /// </summary>
   public class Message : BaseEntity<long?>
    { 
            /// <summary>
            /// Тема сообщения
            /// </summary>
            public string Title { get; set; }
            /// <summary>
            /// Время отправки сообщения
            /// </summary>
            public DateTime CreatedAt { get; set; }

            /// <summary>
            /// Содержание сообщения
            /// </summary>
            public string Content { get; set; }

            /// <summary>
            /// Автор сообщения
            /// </summary>
            public virtual ApplicationUser From { get; set; }

            /// <summary>
            /// Получатель сообщения
            /// </summary>
            public virtual ApplicationUser To { get; set; }
        
    }
}
