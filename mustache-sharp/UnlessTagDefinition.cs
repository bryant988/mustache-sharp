using System.Collections.Generic;

namespace Mustache
{
    /// <summary>
    /// Defines a tag that renders its content depending on the logical NOT truthyness
    /// of its argument, with optional elif and else nested tags. Opposite of if tag.
    /// </summary>
    internal sealed class UnlessTagDefinition : ConditionTagDefinition
    {
        /// <summary>
        /// Initializes a new instance of a UnlessTagDefinition.
        /// </summary>
        public UnlessTagDefinition()
            : base("unless")
        {
        }

        /// <summary>
        /// Gets whether the tag only exists within the scope of its parent.
        /// </summary>
        protected override bool GetIsContextSensitive()
        {
            return false;
        }

        /// <summary>
        /// Gets whether the primary generator group should be used to render the tag.
        /// </summary>
        /// <param name="arguments">The arguments passed to the tag.</param>
        /// <returns>
        /// True if the primary generator group should be used to render the tag;
        /// otherwise, false to use the secondary group.
        /// </returns>
        public override bool ShouldGeneratePrimaryGroup(Dictionary<string, object> arguments)
        {
            // Return opposite of if statement
            return !base.ShouldGeneratePrimaryGroup(arguments);
        }
    }
}
