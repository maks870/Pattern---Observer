using System;

namespace Pattern___Observer
{
    public class SlayRequirement : Requirement
    {
        public SlayRequirement(string requirement) : base(requirement)
        {
        }

        public override void PerformRequirement()
        {
            base.PerformRequirement();
            Console.WriteLine($"Slay {requirementDescription}");
        }
    }
}
