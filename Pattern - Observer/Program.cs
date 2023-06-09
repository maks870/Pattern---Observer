using System;

namespace Pattern___Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuestRequirement slayWolfReq = new SlayRequirement("10 wolves");
            IQuestRequirement talkPrincessReq = new TalkRequirement("Princess");
            IQuestRequirement collectHealingPotionReq = new CollectRequirement("Healing potion");

            Quest helpThePeasants = new Quest("Healing potion", slayWolfReq);
            Quest saveTheKing = new Quest("Royal blessing", collectHealingPotionReq);
            Quest marryPrincess = new Quest("Happy life", talkPrincessReq);

            Journal journal = new Journal();

            journal.AddObserver(helpThePeasants);
            journal.AddObserver(saveTheKing);
            journal.AddObserver(marryPrincess);

            slayWolfReq.PerformRequirement();
            journal.NotifyObservers();

            collectHealingPotionReq.PerformRequirement();
            journal.NotifyObservers();

            talkPrincessReq.PerformRequirement();
            journal.NotifyObservers();

            Console.ReadKey();
        }
    }
}
