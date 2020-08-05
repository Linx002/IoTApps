using IoTApps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IoTApps.Controllers
{
    public class ChannelController : Controller
    {
        DBModel db = new DBModel();

        // GET: Channel
        public ActionResult Index()
        {
            return View();
        }

        //Muestra la vista de agregar canal
        public ActionResult Add()
        { 
                return View();
        }
        [HttpPost]
        public ActionResult Add(Channel channel)
        {
            if (ModelState.IsValid)
            {
                db.Channels.Add(channel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(channel);
        }
        public ActionResult Edit(int id)
        {
            try
            {
                Channel channel = db.Channels.Find(id);

                if (channel != null)
                {
                    return View(channel);
                }
            }
            catch (Exception) {

            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Edit(Channel channel)
        {
            if (ModelState.IsValid)
            {
                db.Channels.Add(channel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(channel);
        }
    }
}