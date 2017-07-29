using System;
 
namespace COC 
{
    public class Clash 
    {
        public int NoOfCanons { get; set; }
        public int NoOfBarabarians { get; set; }

        public string FinishBattle()
        {
            //add logic for battle 
            var shotsRequiredByCannon = NoOfBarabarians * 5;
            var shotsRequiredByBarbarians = NoOfCanons * 49;
            return shotsRequiredByCannon < shotsRequiredByBarbarians ? "Defence" : "Attack";
        }
    }

}