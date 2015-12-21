using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GW2_TP_App.Models;
using GW2_TP_App.ViewModels;

namespace GW2_TP_App.Services
{
    

    public class DataService
    {
        public GW2TPEntities db = new GW2TPEntities();

        public DataService() {

            
        }

        public void SaveAll()
        {
            for(int i = 0; i < 21; i++) { 
                var item = new BoughtItems();
                item.ID = Guid.NewGuid();
                item.Name = "Test" + i;
                item.Price_buy = 4.3 +i ;
                item.Price_sell_plan = 7.3 + 1;
                db.BoughtItems.Add(item);
                db.SaveChanges();
            }


        }

        public List<BoughtItems> GetAll()
        {
            return db.BoughtItems.OrderBy(a => a.Name).ToList();

        }

    }
}