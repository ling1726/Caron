using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Caron.DAL.Models;

namespace Caron.BusinessLogic
{
    public class BaseBll
    {
        public BaseBll(CaronEntities db)
        {
            _db = db;
        }
        private CaronEntities _db;
        public CaronEntities Db => _db;
    }
}