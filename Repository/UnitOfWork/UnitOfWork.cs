using DataAccess.Context;
using Repository.Repository;
using System;

namespace Repository.UnitOfWork
{
    public class UnitOfWork  : IUnitOfWork
    {
        private readonly ChargerContext _context;

        public UnitOfWork()
        {
            _context = new ChargerContext();
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new Repository<T>(_context);
        }

        public int SaveChanges()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (Exception ex) { throw; }
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                    _context.Dispose();
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
