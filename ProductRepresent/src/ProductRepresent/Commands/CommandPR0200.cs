using ProductRepresent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ProductRepresent.Commands
{
    public class CommandPR0200 : ICommand<PR0200>
    {
        public bool Create(PR0200 entity)
        {
            using (var context = new ProductRepresentContext())
            {
                context.PR0200s.Add(entity);

                return
                    context.SaveChanges() == 1;
            }
        }

        public bool Delete(Expression<Func<PR0200, bool>> predicate)
        {
            using (var context = new ProductRepresentContext())
            {
                context.PR0200s
                    .RemoveRange(context.PR0200s
                                    .Where(predicate));

                return
                    context.SaveChanges() == 1;
            }
        }

        public bool Delete(PR0200 entity)
        {
            using (var context = new ProductRepresentContext())
            {
                context.PR0200s.Remove(entity);

                return
                    context.SaveChanges() == 1;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool Exist(Expression<Func<PR0200, bool>> predicate)
        {
            using (var context = new ProductRepresentContext())
            {
                return
                    context.PR0200s.Any(predicate);
            }
        }

        public PR0200 Read(Expression<Func<PR0200, bool>> predicate)
        {
            using (var context = new ProductRepresentContext())
            {
                return
                    context.PR0200s.FirstOrDefault(predicate);
            }
        }

        public List<PR0200> Reads()
        {
            using (var context = new ProductRepresentContext())
            {
                return
                    context.PR0200s.ToList();
            }
        }

        public List<PR0200> Reads(Expression<Func<PR0200, bool>> predicate)
        {
            using (var context = new ProductRepresentContext())
            {
                return
                    context.PR0200s.Where(predicate).ToList();
            }
        }

        public bool Update(Expression<Func<PR0200, bool>> predicate)
        {
            using (var context = new ProductRepresentContext())
            {
                context.PR0200s
                    .UpdateRange(context.PR0200s
                                    .Where(predicate));

                return
                    context.SaveChanges() == 1;
            }
        }

        public bool Update(PR0200 entity)
        {
            using (var context = new ProductRepresentContext())
            {
                context.PR0200s
                    .Update(entity);

                return
                    context.SaveChanges() == 1;
            }
        }
    }
}
