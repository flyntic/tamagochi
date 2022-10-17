using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTamagochi
{
    class Tamagochi
    {
        private string Name { get; set; }
        string wishToEat() => "Хочу есть";
        string wishToWalk() => "Хочу гулять";
        string wishToSleep() => "Хочу спать";

        const List<var> all_wishes= new List<var>[3] { wishToEat, wishToWalk, wishToSleep };

        aWish wish;
        public override string ToString() 
        {
            string str = "Я - " + Name;
            if (wish == null) return (str + " Желаний нет! ");
            foreach (aWish a in wish.GetInvocationList())
                str += "\n" + a;
            return str;
          
        }

         
        public bool isLeave()
        {
            if (wish.GetInvocationList().Length > 3) return false;
            return true;
        }


        public Tamagochi()
        {
            Name = "1";
          //  all_wiches = new List<aWish>{ ()=>"Хочу есть", ()=>"Хочу гулять",()=>"Хочу спать"};
        }
    }

    delegate string aWish();
}
