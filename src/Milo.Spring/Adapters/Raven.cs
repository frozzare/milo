using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Milo.Spring.Interfaces;
using Raven.Client;
using Raven.Client.Document;
using Raven.Client.Extensions;

namespace Milo.Spring.Adapters
{
    public class Raven : IAdapter, IDatabase
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
        private IDocumentStore _store { get; set; }

        /// <summary>
        /// Prevents a default instance of the <see cref="Raven"/> class from being created.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="databaseName">Name of the database.</param>
        private Raven(string url, string databaseName)
        {
            Url = url;
            DatabaseName = databaseName;

            _store = new DocumentStore
            {
                Url = url
            }.Initialize();

           //_store.DatabaseCommands.EnsureDatabaseExists(DatabaseName);
        }

        /// <summary>
        /// Inserts the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>The entity.</returns>
        public dynamic Insert(dynamic entity)
        {
            using (var session = _store.OpenSession())
            {
                session.Store(entity);
                session.SaveChanges();
                return entity;
            }
        }

        /// <summary>
        /// Wheres the specified predicate.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="predicate">The predicate.</param>
        /// <returns>IEnumerable list with entities.</returns>
        public IEnumerable<TEntity> Where<TEntity>(Func<TEntity, bool> predicate)
        {
            using (var session = _store.OpenSession())
            {
                return session.Query<TEntity>().Where(predicate).AsEnumerable();
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
            _store = null;
            return true;
        }
    }
}
