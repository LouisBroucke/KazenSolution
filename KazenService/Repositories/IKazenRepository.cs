using KazenService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KazenService.Repositories
{
    public interface IKazenRepository
    {
        IQueryable<Kaas> FindAll();
        Kaas FindById(int id);
        IQueryable<Kaas> FindBySmaak(string smaak);
        bool Exists(int id);
        void Update(Kaas kaas);
    }
}
