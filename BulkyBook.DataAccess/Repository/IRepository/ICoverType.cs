using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface ICoverType:IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
