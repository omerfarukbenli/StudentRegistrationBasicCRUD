using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration.Data.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task CommitAsync(); //asenkron olan //savechange demek
        void Commit(); //asenkron olmayan //aynı anda kaydetmek amacıyla commitler yazılır
    }
}
