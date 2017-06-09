namespace Octokit.GraphQL
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Represents a 'demilestoned' event on a given issue or pull request.
    /// </summary>
    public class DemilestonedEvent : QueryEntity
    {
        public DemilestonedEvent(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// Identifies the actor who performed the 'demilestoned' event.
        /// </summary>
        public IActor Actor => this.CreateProperty(x => x.Actor, Octokit.GraphQL.Internal.StubIActor.Create);

        /// <summary>
        /// Identifies the date and time when the object was created.
        /// </summary>
        public string CreatedAt { get; }

        public string Id { get; }

        /// <summary>
        /// Identifies the milestone title associated with the 'demilestoned' event.
        /// </summary>
        public string MilestoneTitle { get; }

        /// <summary>
        /// Object referenced by event.
        /// </summary>
        public MilestoneItem Subject => this.CreateProperty(x => x.Subject, Octokit.GraphQL.MilestoneItem.Create);

        internal static DemilestonedEvent Create(IQueryProvider provider, Expression expression)
        {
            return new DemilestonedEvent(provider, expression);
        }
    }
}