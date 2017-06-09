namespace Octokit.GraphQL
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of UpdateProject
    /// </summary>
    public class UpdateProjectPayload : QueryEntity
    {
        public UpdateProjectPayload(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The updated project.
        /// </summary>
        public Project Project => this.CreateProperty(x => x.Project, Octokit.GraphQL.Project.Create);

        internal static UpdateProjectPayload Create(IQueryProvider provider, Expression expression)
        {
            return new UpdateProjectPayload(provider, expression);
        }
    }
}