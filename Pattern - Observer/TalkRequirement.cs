using System;

namespace Pattern___Observer
{
    public class TalkRequirement : Requirement
    {
        public TalkRequirement(string requirement) : base(requirement)
        {
        }

        public override void PerformRequirement()
        {
            base.PerformRequirement();
            Console.WriteLine($"Talk with {requirementDescription}");
        }
    }
}
