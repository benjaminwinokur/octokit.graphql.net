namespace Octokit.GraphQL
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of UpdateProjectColumn
    /// </summary>
    public class UpdateProjectColumnPayload : QueryEntity
    {
        public UpdateProjectColumnPayload(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The updated project column.
        /// </summary>
        public ProjectColumn ProjectColumn => this.CreateProperty(x => x.ProjectColumn, Octokit.GraphQL.ProjectColumn.Create);

        internal static UpdateProjectColumnPayload Create(IQueryProvider provider, Expression expression)
        {
            return new UpdateProjectColumnPayload(provider, expression);
        }
    }
}