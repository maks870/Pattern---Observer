using System;

namespace Pattern___Observer
{
    public class CollectRequirement : Requirement
    {
        public CollectRequirement(string requirement) : base(requirement)
        {
        }

        public override void PerformRequirement()
        {
            base.PerformRequirement();
            Console.WriteLine($"Collect {requirementDescription}");
        }
    }
}
