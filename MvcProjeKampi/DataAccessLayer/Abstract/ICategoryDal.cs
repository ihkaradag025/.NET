using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {
        //CRUD-Create-Read-Update-Delete
        //Type Name()
        List<Category> List(); ///List() bu bölüm ismi Listele de olabilirdi. burada listeleme işlemi yapılacak.(R)
        void Insert(Category p);//C
        void Update(Category p);//U
        void Delete(Category p);//D
    }
}
