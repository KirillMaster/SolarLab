using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DataAccessLayer.Models
{
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
        /// group consist for
        /// </summary>
      //  public virtual List<Group> Groups { get; set; }

        /// <summary>
        /// Owned messages
        /// </summary>
       // public virtual List<Message> Messages { get; set; }

        /// <summary>
        /// readabel documents
        /// </summary>
        public virtual List<Document> Documents { get; set; }

        /// <summary>
        /// viewable posts
        /// </summary>
        public virtual List<Post> Posts { get; set; }

        /// <summary>
        /// viewable tasks
        /// </summary>
       // public virtual List<AppTask> Tasks { get; set; }

        /// <summary>
        /// Owned comments
        /// </summary>
     //   public virtual List<Comment> Comments { get; set; }
    }

   
}

