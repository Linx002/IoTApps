using IoTApps.Models;
using System;
using System.Data.Entity;
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
            catch (Exception)
            {

            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Edit(Channel channel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(channel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(channel);
        }
        public ActionResult Delete(int id)
        {
            try
            {
                Channel channel = db.Channels.Find(id);

                if (channel != null)
                {
                    return View(channel);
                }
            }
            catch (Exception)
            {

            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Delete(int id, Channel channel)
        {
            db.Channels.Remove(channel);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public int AddData(Data data)
        {
            int res = 0;

            if (ModelState.IsValid)
            {
                db.ChannelsData.Add(data);
                res = db.SaveChanges();
            }
            return res;
        }
    }
}