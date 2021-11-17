using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DH_01.Controllers
{
    public class InventoryController : Controller
    {
        InventoryEntities db = new InventoryEntities();

        public ActionResult DH1()
        {
            return View(db.Inventories.ToList());
        }

        public ActionResult DH2()
        {        
            List<Inventory> inventoryCollection = db.Inventories.ToList();
            return View(db.Inventories.ToList());
        }

        public ActionResult To_Do_List()
        { 
            return View();

            //List<Inventory> inventoryCollection = db.Inventories.ToList();
            //return View();
        }
        public string add() {
            List<Inventory> inventoryCollection = db.Inventories.ToList();
            string Item_description = inventoryCollection[0].Description;
            return Item_description;
        }

        public ActionResult List_Items()
        {
            List<Inventory> inventoryCollection = db.Inventories.ToList();
            string Item_description = inventoryCollection[0].Description;


            return View();
        }

        public string get_data(string itemid)
        {
            string result = "";
            List<Inventory> inventoryCollection = db.Inventories.ToList();

            for (int i = 0; i < inventoryCollection.Count; i++)
            { 
                  
            }

            for (int i = 0; i < inventoryCollection.Count; i++) {
                 result += inventoryCollection[i].ItemID + "," + inventoryCollection[i].Description + "," + inventoryCollection[i].Where + ";" ;
            }

            return result;
        }
    }


}