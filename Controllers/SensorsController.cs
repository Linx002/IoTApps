using IoTApps.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace IoTApps.Controllers
{
    public class SensorsController : Controller
    {
        DBModel db = new DBModel();

        public ActionResult Index()
        {
            ViewBag.Sensors = db.Sensors.ToList();
            return View();
        }

        // GET: Sensors
        public string AnalogReading(int sensor, double value)
        {
            string msg = "Error processing the request.";
            try
            {
                if (sensor > 0)
                {
                    Readings readings = new Readings()
                    {
                        IdSensor = sensor,
                        Date = DateTime.Now,
                        Value = value,
                        Data = value.ToString(),

                    };
                    db.Readings.Add(readings);
                    db.SaveChanges();
                    msg = "|Value stored succesfully";
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;

            }
            return msg;
        }
    }
}