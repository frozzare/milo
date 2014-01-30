using System.Collections.Generic;
using Milo.Spring.Interfaces;
using Milo.Spring.Interfaces.Adapters;
using Raven.Client;
using Raven.Client.Document;

namespace Milo.Spring.Adapters
{
    /// <summary>
    /// Raven database client.
    /// </summary>
    public class Raven : IAdapter, IDatabase, IRaven
    {
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        private string Url { get; set; }

        /// <summary>
        /// Gets or sets the name of the database.
        /// </summary>
        /// <value>
        /// The name of the database.
        /// </value>
        private string DatabaseName { get; set; }

        /// <summary>
        /// The Document store instance.
        /// </summary>
        private IDocumentStore Store { get; set; }

        /// <summary>
        /// Prevents a default instance of the <see cref="Raven"/> class from being created.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="databaseName">Name of the database.</param>
        private Raven(string url, string databaseName)
        {
            Url = url;
            DatabaseName = databaseName;

            Store = new DocumentStore {
                Url = url
            }.Initialize();

           //Store.DatabaseCommands.EnsureDatabaseExists(DatabaseName);
        }

        /// <summary>
        /// Inserts the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>The entity.</returns>
        public dynamic Insert(dynamic entity)
        {
            using (var session = Store.OpenSession())
            {
                session.Store(entity);
                session.SaveChanges();
                return entity;
            }
        }

        /// <summary>
        /// Query Raven result.
        /// </summary>
        /// <typeparam name="T">The entity to use</typeparam>
        /// <returns>Query result</returns>
        public IEnumerable<T> Query<T>()
        {
            using (var session = Store.OpenSession())
            {
                return session.Query<T>();
            }
        }

        /// <summary>
        /// Query Raven result.
        /// </summary>
        /// <typeparam name="T">The entity to use</typeparam>
        /// <param name="indexName">Index name</param>
        /// <param name="isMapReduce">Is map reduce?</param>
        /// <returns>Query result</returns>
        public IEnumerable<T> Query<T>(string indexName, bool isMapReduce = false)
        {
            using (var session = Store.OpenSession())
            {
                return session.Query<T>(indexName, isMapReduce);
            }
        }

        /// <summary>
        /// Connects the specified URL and database name.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="databaseName">Name of the database.</param>
        /// <returns>Database interface.</returns>
        public static IDatabase Connect(string url = "http://localhost:8080/", string databaseName = "Milo")
        {
            return new Raven(url, databaseName);
        }

        /// <summary>
        /// Disconnects this instance.
        /// Since Raven don't have any Disconnect feature we always return true here.
        /// </summary>
        /// <returns>True.</returns>
        public bool Disconnect()
        {
            Store = null;
            return true;
        }
    }
}
