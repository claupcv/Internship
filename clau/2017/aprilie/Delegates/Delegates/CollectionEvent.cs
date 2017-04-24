using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void OnCollectionEvent(CollectionEvent eventInfo);

    /// <summary>
    /// Enumerates possible collection event types
    /// </summary>
    public enum CollectionEventType
    {
        /// <summary>
        /// Nothing happened
        /// </summary>
        None = 0,

        /// <summary>
        /// An element was added
        /// </summary>
        ElementAdded,

        /// <summary>
        /// An element was updated
        /// </summary>
        ElementUpdated,

        /// <summary>
        /// An element was removed
        /// </summary>
        ElementRemoved,

        /// <summary>
        /// The collection was cleared
        /// </summary>
        CollectionCleared
    }

    /// <summary>
    /// Represents the collection event info
    /// </summary>
    public class CollectionEvent
    {
        /// <summary>
        /// Gets the event type
        /// </summary>
        public CollectionEventType EventType
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the affected element value
        /// </summary>
        public int? Element
        {
            get;
            private set;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="eventType">The event type</param>
        /// <param name="element">The affected element value (may be null for collection-general events)</param>
        public CollectionEvent(CollectionEventType eventType, int? element)
        {
            this.EventType = eventType;
            this.Element = element;
        }
    }
}
