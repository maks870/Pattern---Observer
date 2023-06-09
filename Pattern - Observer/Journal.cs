using System;
using System.Collections.Generic;

namespace Pattern___Observer
{
    class Journal : IObservable
    {
        private List<IObserver> questList = new List<IObserver>();
        private List<IQuestRequirement> requirementList = new List<IQuestRequirement>();

        public void AddObserver(IObserver obs)
        {
            questList.Add(obs);
            Quest quest = (Quest)obs;
            quest.observable = this;
            IQuestRequirement requirement = quest.questRequirement;
            requirementList.Add(requirement);
        }

        public void NotifyObservers()
        {
            Console.WriteLine("Notify observers");

            List<IObserver> tempList = new List<IObserver>();
            tempList.AddRange(questList);

            for (int i = 0; i < questList.Count; i++)
            {
                Quest quest = (Quest)questList[i];
                quest.Update();
            }
        }

        public void RemoveObserver(IObserver obs)
        {
            questList.Remove(obs);
        }

        public List<IQuestRequirement> GetRequirementList()
        {
            return requirementList;
        }

        public void RemoveRequirement(IQuestRequirement requirement)
        {
            requirementList.Remove(requirement);
        }
    }
}
