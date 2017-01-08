using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Document> Documents { get; }
        IRepository<File> Files { get; }
        IRepository<Group> Groups { get; }
        IRepository<Post> Posts { get; }
        IRepository<AppTask> Tasks { get; }

        IRepository<Employee> Employees { get; }
        void Save();
    }
}
