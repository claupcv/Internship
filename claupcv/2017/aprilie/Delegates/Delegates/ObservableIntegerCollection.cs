using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    /// <summary>
/// Represents an observable int collection, which raises events
/// when elements are added, updated, removed or collection is cleared
/// </summary>
public class ObservableIntegerCollection
{
  // stores the collection
  private readonly List<int> collection;
 
  // the collection change event (private field)
  private event OnCollectionEvent collectionEvent;
 
  // constructor
  public ObservableIntegerCollection()
  {
	this.collection = new List<int>();
  }
 
  // we expose the collection elements for
  // iteration purposes. No adding/updating/deleting/clear
  // supported via IEnumerable<int>
  public IEnumerable<int> Elements
  {
	get
	{
  	return this.collection;
	}
  }
 
  // public event accessor (like properties)
  public event OnCollectionEvent OnCollectionEvent
  {
	add
	{
  	// triggered when a handler is attached
  	this.collectionEvent += value;
	}
	remove
	{
  	// triggered when a handler is removed
  	this.collectionEvent -= value;
	}
  }
 
  public void Add(int element)
  {
	this.collection.Add(element);
 
	// notice the conditional member access syntax used to invoke the event
	// this is safer than this.collectionEvent(new CollectionEvent(CollectionEventType.ElementAdded, element));
	// because "collectionEvent" may have no attached handlers, since it would be null
	// and the above statement would throw exception
	this.collectionEvent.Invoke(new CollectionEvent(CollectionEventType.ElementAdded, element));
  }
 
  public void Update(int index, int element)
  {
	if((index < 0) || (index >= this.collection.Count))
	{
  	throw new IndexOutOfRangeException("The index was out of the bounds [0 .. "+(this.collection.Count - 1)+"] of the collection");
	}
 
	this.collection[index] = element;
 
	// conditional member access syntax used to invoke the event (I explained why above)
	this.collectionEvent.Invoke(new CollectionEvent(CollectionEventType.ElementUpdated, element));
  }
 
  public void Remove(int index)
  {
	if ((index < 0) || (index >= this.collection.Count))
	{
  	throw new IndexOutOfRangeException("The index was out of the bounds [0 .. "+(this.collection.Count - 1)+"] of the collection");
	}
 
	var element = this.collection[index];
 
	this.collection.RemoveAt(index);
 
	// conditional member access syntax used to invoke the event (I explained why above)
	this.collectionEvent.Invoke(new CollectionEvent(CollectionEventType.ElementRemoved, element));
  }
 
  public void Clear()
  {
	this.collection.Clear();
 
	// conditional member access syntax used to invoke the event (I explained why above)
	this.collectionEvent.Invoke(new CollectionEvent(CollectionEventType.CollectionCleared, null));
  }
}

}
