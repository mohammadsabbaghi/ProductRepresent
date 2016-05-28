using ProductRepresent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ProductRepresent.Commands
{
    public class CommandPR0100 : ICommand<PR0100>
    {
        public bool Create(PR0100 entity)
        {
            using (var context = new ProductRepresentContext())
            {
                context.PR0100s.Add(entity);
                
                return
                    context.SaveChanges() == 1;
            }
        }

        public bool Delete(Expression<Func<PR0100, bool>> predicate)
        {
            using (var context = new ProductRepresentContext())
            {
                context.PR0100s
                    .RemoveRange(context.PR0100s
                                    .Where(predicate));

                return
                    context.SaveChanges() == 1;
            }
        }

        public bool Delete(PR0100 entity)
        {
            using (var context = new ProductRepresentContext())
            {
                context.PR0100s.Remove(entity);

                return 
                    context.SaveChanges() == 1;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool Exist(Expression<Func<PR0100, bool>> predicate)
        {
            using (var context = new ProductRepresentContext())
            {
                return
                    context.PR0100s.Any(predicate);
            }
        }

        public PR0100 Read(Expression<Func<PR0100, bool>> predicate)
        {
            using (var context = new ProductRepresentContext())
            {
                return
                    context.PR0100s.FirstOrDefault(predicate);
            }
        }

        public List<PR0100> Reads()
        {
            using (var context = new ProductRepresentContext())
            {
                return
                    context.PR0100s.ToList();
            }
        }

        public List<PR0100> Reads(Expression<Func<PR0100, bool>> predicate)
        {
            using (var context = new ProductRepresentContext())
            {
                return
                    context.PR0100s.Where(predicate).ToList();
            }
        }

        public bool Update(Expression<Func<PR0100, bool>> predicate)
        {
            using (var context = new ProductRepresentContext())
            {
                context.PR0100s
                    .UpdateRange(context.PR0100s
                                    .Where(predicate));

                return
                    context.SaveChanges() == 1;
            }
        }

        public bool Update(PR0100 entity)
        {
            using (var context = new ProductRepresentContext())
            {
                context.PR0100s
                    .Update(entity);

                return
                    context.SaveChanges() == 1;
            }
        }
    }
}
