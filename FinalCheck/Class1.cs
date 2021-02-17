using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Model
{
    public class MenuItem 
    {
        
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        string name;

        float price;
        bool active;
        DateTime dateOfLaunch;
        string category;
        bool freeDelivery;
        public MenuItem() { }
        public MenuItem(long id,string name,float price,
        bool active,
        DateTime dateOfLaunch,
        string category,
        bool freeDelivery)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.active = active;
            this.dateOfLaunch = dateOfLaunch;
            this.category = category;
            this.freeDelivery = freeDelivery;

        }
    }
    public class Cart
    {
        List<MenuItem> menuItemList;
        double total;
    }
}
