using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DataAccessLayer.Models
{

    /// <summary>
    /// Модель пользователя приложения
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Обратите внимание, что authenticationType должен совпадать с типом, определенным в CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Здесь добавьте утверждения пользователя
            return userIdentity;
        }


        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Отчество пользователя
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Аватарка пользователя
        /// </summary>
        public byte[] Photo { get; set; }

        /// <summary>
        /// Сообщения пользователя
        /// </summary>
        public virtual List<Message> Messages { get; set; }

        /// <summary>
        /// readabel documents
        /// </summary>
        public virtual List<Document> Documents { get; set; }

        /// <summary>
        /// Посты пользователя
        /// </summary>
        public virtual List<Post> Posts { get; set; }

        /// <summary>
        /// Задачи пользователя
        /// </summary>
        public virtual List<AppTask> Tasks { get; set; }

        /// <summary>
        /// Комментарии пользователя
        /// </summary>
        public virtual List<Comment> Comments { get; set; }
    }

   
}

