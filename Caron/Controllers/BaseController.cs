﻿using Caron.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Caron.Controllers
{
    public class BaseController : Controller
    {

        public CaronEntities Db => new CaronEntities();
        // GET: Base

    }
}