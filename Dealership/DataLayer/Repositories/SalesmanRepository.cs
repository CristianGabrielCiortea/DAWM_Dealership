using DataLayer.Entities;

namespace DataLayer.Repositories
{
    public class SalesmanRepository
    {
        public List<Salesman> GetAll()
        {
            var result = DbContext.Salesmen;

            return result;
        }

        public Salesman GetById(int salesmanId)
        {
            var result = DbContext.Salesmen
                .Where(x => x.Id == salesmanId)
                .FirstOrDefault();

            return result;
        }
    }
}