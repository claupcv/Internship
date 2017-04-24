using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    /// <summary>
/// Represents an observer of a collection change
/// </summary>
    public class IntegerCollectionChangeObserver
    {
      /// <summary>
      /// Gets the observer name (used for message display purpose)
      /// </summary>
      public string ObserverName
      {
	    get;
	    private set;
      }
 
      // ctor
      public IntegerCollectionChangeObserver(string observerName)
      {
	    this.ObserverName = observerName;
      }
 
      // will be used as event handler because it matches OnCollectionEvent delegate definition
      public void OnReceiveCollectionEvent(CollectionEvent eventInfo)
      {
	    if(eventInfo != null)
	    {
            Console.WriteLine("{0}> {1} just happend, affected element is: {2}", this.ObserverName, eventInfo.EventType, eventInfo.Element);
	    }
      }
    }
}
