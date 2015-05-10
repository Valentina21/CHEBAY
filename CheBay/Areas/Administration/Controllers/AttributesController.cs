using CheBay.Areas.Administration.Models;
using CheBay.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheBay.Areas.Administration.Controllers
{
    public class AttributesController : Controller
    {
        // GET: Administration/Attributes
        public ActionResult Index()
        {
            AtributoModel atributomodel = new AtributoModel();
            atributomodel.atributoListCollction = Logic.LogicLayer.GetAtributos();
          
            return View(atributomodel);
        }


        public ActionResult Create()
        {
            AtributoModel atributomodel = new AtributoModel();
            return View(atributomodel);
        }


        [HttpPost]
        public ActionResult Create(AtributoModel atributomodel)
        {
            try
            {
                Atributo _obj = new Atributo();
                _obj.titulo = atributomodel.atributo.titulo;
                Logic.LogicLayer.AddAtributo(_obj);
                atributomodel.atributoListCollction = Logic.LogicLayer.GetAtributos();
                atributomodel.atributo = new Atributo();
           //  ControllerContext.RouteData.Values["action"].ToString();
                ViewBag.Message = "Atributo cargado correctamente.";
            }
            catch
            {
                ViewBag.Message = "Error al cargar atributo.";
            }
            return View(atributomodel);
        }

    }
}