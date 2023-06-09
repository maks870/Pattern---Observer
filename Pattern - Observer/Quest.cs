using System;
using System.Collections.Generic;
namespace Pattern___Observer
{
    class Quest : IObserver
    {
        public IObservable observable;
        public IQuestRequirement questRequirement;
        public string rewardDescription;

        public Quest(string rewardDescription, IQuestRequirement questRequirement)
        {
            observable = null;
            this.rewardDescription = rewardDescription;
            this.questRequirement = questRequirement;
        }

        private void GetReward()
        {
            Console.WriteLine($"Your reward is {rewardDescription}");
        }

        public void Update()
        {
            Journal journal = (Journal)observable;
            foreach (IQuestRequirement questRequirement in journal.GetRequirementList())
            {
                if (!Equals(this.questRequirement, questRequirement))
                    continue;

                if (questRequirement.CheckRequirement())
                {
                    GetReward();
                    journal.RemoveRequirement(questRequirement);
                    observable.RemoveObserver(this);
                    break;
                }
            }
        }

    }
}
