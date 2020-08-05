using IoTApps.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace IoTApps.Controllers
{
    public class TokensController : Controller
    {
        DBModel db = new DBModel();
        // GET: Tokens
        public ActionResult Index()
        {
            ViewBag.Sources = db.Sources.ToList();
            return View();
        }
        public string Add(int source, string data)
        {
            string msg = "Error proccesing the request.";

            try
            {
                if (data != string.Empty && data != null)
                {
                    Token token = new Token()
                    {
                        Data = data,
                        Fecha = DateTime.Now,
                        IdSource = source
                    };
                    db.Tokens.Add(token);
                    db.SaveChanges();
                    msg = "Operation success...";
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