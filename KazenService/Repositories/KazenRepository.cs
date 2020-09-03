using KazenService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KazenService.Repositories
{
    public class KazenRepository : IKazenRepository
    {
        private readonly KaasLandContext context;
        public KazenRepository(KaasLandContext context)
        {
            this.context = context;
        }

        public bool Exists(int id)
        {
            return context.Kazen.Where(kaas => kaas.ID == id).Count() != 0;
        }

        public IQueryable<Kaas> FindAll()
        {
            return context.Kazen.AsQueryable();
        }

        public Kaas FindById(int id)
        {
            return context.Kazen.Find(id);
        }

        public IQueryable<Kaas> FindBySmaak(string smaak)
        {
            return context.Kazen.Where(kaas => kaas.Smaak == smaak).AsQueryable();
        }

        public void Update(Kaas kaas)
        {
            context.Kazen.Update(kaas);
            context.SaveChanges();
        }
    }
}
