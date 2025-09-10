using Practica01.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01.Data.Interfaces
{
    public interface IItemRepository
    {
        List<Item> GetAll();
        Item? GetById(int id);

        bool Save(Item item);

        bool Delete(int id);

    }
}
