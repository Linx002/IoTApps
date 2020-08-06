using IoTApps.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace IoTApps.Controllers
{
    public class ChannelController : Controller
    {
        DBModel db = new DBModel();

        // GET: Channel
        public ActionResult Index()
        {
            List<Channel> channels = db.Channels.ToList();
            return View(channels);
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
        [HttpPost]
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

        public int AddSensorData(string key, int field, double value)
        {
            int res = 0;
            Channel channel = db.Channels.FirstOrDefault(x => x.Key == key);

            if (channel != null)
            {
                Data data = new Data()
                {
                    IdChannel = channel.id,
                    Field = field,
                    Value = value,
                    Date = DateTime.Now
                };
                if (TryValidateModel(data))
                {
                    db.ChannelsData.Add(data);
                    res = db.SaveChanges();
                }
            }
            return res;
        }
    }
}