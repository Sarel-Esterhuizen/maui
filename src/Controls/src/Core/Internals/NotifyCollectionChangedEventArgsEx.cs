using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Microsoft.Maui.Controls.Internals
{
	/// <include file="../../../docs/Microsoft.Maui.Controls.Internals/NotifyCollectionChangedEventArgsEx.xml" path="Type[@FullName='Microsoft.Maui.Controls.Internals.NotifyCollectionChangedEventArgsEx']/Docs" />
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class NotifyCollectionChangedEventArgsEx : NotifyCollectionChangedEventArgs
	{
		/// <include file="../../../docs/Microsoft.Maui.Controls.Internals/NotifyCollectionChangedEventArgsEx.xml" path="//Member[@MemberName='.ctor']/Docs" />
		public NotifyCollectionChangedEventArgsEx(int count, NotifyCollectionChangedAction action) : base(action)
		{
			Count = count;
		}

		/// <include file="../../../docs/Microsoft.Maui.Controls.Internals/NotifyCollectionChangedEventArgsEx.xml" path="//Member[@MemberName='.ctor']/Docs" />
		public NotifyCollectionChangedEventArgsEx(int count, NotifyCollectionChangedAction action, IList changedItems) : base(action, changedItems)
		{
			Count = count;
		}

		/// <include file="../../../docs/Microsoft.Maui.Controls.Internals/NotifyCollectionChangedEventArgsEx.xml" path="//Member[@MemberName='.ctor']/Docs" />
		public NotifyCollectionChangedEventArgsEx(int count, NotifyCollectionChangedAction action, IList newItems, IList oldItems) : base(action, newItems, oldItems)
		{
			Count = count;
		}

		/// <include file="../../../docs/Microsoft.Maui.Controls.Internals/NotifyCollectionChangedEventArgsEx.xml" path="//Member[@MemberName='.ctor']/Docs" />
		public NotifyCollectionChangedEventArgsEx(int count, NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex) : base(action, newItems, oldItems, startingIndex)
		{
			Count = count;
		}

		/// <include file="../../../docs/Microsoft.Maui.Controls.Internals/NotifyCollectionChangedEventArgsEx.xml" path="//Member[@MemberName='.ctor']/Docs" />
		public NotifyCollectionChangedEventArgsEx(int count, NotifyCollectionChangedAction action, IList changedItems, int startingIndex) : base(action, changedItems, startingIndex)
		{
			Count = count;
		}

		/// <include file="../../../docs/Microsoft.Maui.Controls.Internals/NotifyCollectionChangedEventArgsEx.xml" path="//Member[@MemberName='.ctor']/Docs" />
		public NotifyCollectionChangedEventArgsEx(int count, NotifyCollectionChangedAction action, IList changedItems, int index, int oldIndex) : base(action, changedItems, index, oldIndex)
		{
			Count = count;
		}

		/// <include file="../../../docs/Microsoft.Maui.Controls.Internals/NotifyCollectionChangedEventArgsEx.xml" path="//Member[@MemberName='.ctor']/Docs" />
		public NotifyCollectionChangedEventArgsEx(int count, NotifyCollectionChangedAction action, object changedItem) : base(action, changedItem)
		{
			Count = count;
		}

		/// <include file="../../../docs/Microsoft.Maui.Controls.Internals/NotifyCollectionChangedEventArgsEx.xml" path="//Member[@MemberName='.ctor']/Docs" />
		public NotifyCollectionChangedEventArgsEx(int count, NotifyCollectionChangedAction action, object changedItem, int index) : base(action, changedItem, index)
		{
			Count = count;
		}

		/// <include file="../../../docs/Microsoft.Maui.Controls.Internals/NotifyCollectionChangedEventArgsEx.xml" path="//Member[@MemberName='.ctor']/Docs" />
		public NotifyCollectionChangedEventArgsEx(int count, NotifyCollectionChangedAction action, object changedItem, int index, int oldIndex) : base(action, changedItem, index, oldIndex)
		{
			Count = count;
		}

		/// <include file="../../../docs/Microsoft.Maui.Controls.Internals/NotifyCollectionChangedEventArgsEx.xml" path="//Member[@MemberName='.ctor']/Docs" />
		public NotifyCollectionChangedEventArgsEx(int count, NotifyCollectionChangedAction action, object newItem, object oldItem) : base(action, newItem, oldItem)
		{
			Count = count;
		}

		/// <include file="../../../docs/Microsoft.Maui.Controls.Internals/NotifyCollectionChangedEventArgsEx.xml" path="//Member[@MemberName='.ctor']/Docs" />
		public NotifyCollectionChangedEventArgsEx(int count, NotifyCollectionChangedAction action, object newItem, object oldItem, int index) : base(action, newItem, oldItem, index)
		{
			Count = count;
		}

		/// <include file="../../../docs/Microsoft.Maui.Controls.Internals/NotifyCollectionChangedEventArgsEx.xml" path="//Member[@MemberName='Count']/Docs" />
		public int Count { get; private set; }
	}
}