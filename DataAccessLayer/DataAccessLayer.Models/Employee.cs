using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    /// <summary>
    /// Сотрудник кафедры
    /// Информация необходимая для регистрации находится в модели User
    /// </summary>
    public class Employee : BaseEntity<long?>
    {

            /// <summary>
            /// Ученая степень сотрудника
            /// </summary>
            public virtual string Degree {get;set;}
            /// <summary>
            /// Связь один к одному с зарегистрированным аккаунтом
            /// </summary>
            public virtual ApplicationUser User { get; set; }
        
    }
}
