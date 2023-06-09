namespace Pattern___Observer
{
    public abstract class Requirement : IQuestRequirement
    {
        protected bool isDone;
        protected string requirementDescription;

        public Requirement(string requirement)
        {
            isDone = false;
            requirementDescription = requirement;
        }

        public bool CheckRequirement()
        {
            return isDone;
        }

        public virtual void PerformRequirement()
        {
            isDone = true;
        }
    }

}
