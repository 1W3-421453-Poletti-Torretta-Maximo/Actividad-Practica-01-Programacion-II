using Microsoft.Data.SqlClient;
using Practica01.Data.Helpers;
using Practica01.Data.Interfaces;
using Practica01.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01.Data.Implementations
{
    public class InvoiceRepository : IInvoiceRepository
    {
        public List<InvoiceDetail> GetAll()
        {
            throw new NotImplementedException();
        }

        public InvoiceDetail? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(Invoice invoice)
        {
            throw new NotImplementedException();
        }
    }
}

