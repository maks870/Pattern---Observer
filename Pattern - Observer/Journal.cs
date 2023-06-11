using System;
using System.Collections.Generic;

namespace Pattern___Observer
{
    class Journal : IObservable
    {
        private List<IObserver> questList = new List<IObserver>();
        private List<IQuestRequirement> requirementList = new List<IQuestRequirement>();

        private bool CheckObjForQuest(object obj)
        {
            bool isQuest = false;

            if (obj.GetType().IsSubclassOf(typeof(Quest)) || obj.GetType() == typeof(Quest))
                isQuest = true;

            return isQuest;
        }

        public void AddObserver(IObserver obs)
        {
            if (!CheckObjForQuest(obs))
                return;

            questList.Add(obs);
            Quest quest = (Quest)obs;
            quest.observable = this;
            IQuestRequirement requirement = quest.questRequirement;
            requirementList.Add(requirement);
        }


        public void NotifyObservers()
        {
            Console.WriteLine("Notify observers");

            for (int i = 0; i < questList.Count; i++)
            {
                questList[i].Update();
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
