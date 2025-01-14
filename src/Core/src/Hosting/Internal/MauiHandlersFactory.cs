#nullable enable
using System;
using System.Collections.Generic;

namespace Microsoft.Maui.Hosting.Internal
{
	class MauiHandlersFactory : MauiFactory, IMauiHandlersFactory
	{
		public MauiHandlersFactory(IEnumerable<HandlerMauiAppBuilderExtensions.HandlerRegistration> registrationActions) :
			base(CreateHandlerCollection(registrationActions), constructorInjection: false)
		{
		}

		private static IMauiServiceCollection CreateHandlerCollection(IEnumerable<HandlerMauiAppBuilderExtensions.HandlerRegistration> registrationActions)
		{
			var collection = new MauiHandlersCollection();
			if (registrationActions != null)
			{
				foreach (var registrationAction in registrationActions)
				{
					registrationAction.AddRegistration(collection);
				}
			}
			return collection;
		}

		public IElementHandler? GetHandler(Type type)
			=> GetService(type) as IElementHandler;

		public IElementHandler? GetHandler<T>() where T : IElement
			=> GetHandler(typeof(T));

		public Type? GetHandlerType(Type iview)
		{
			if (!TryGetServiceDescriptors(ref iview, out var single, out var enumerable))
				return default;

			if (single != null)
				return single.ImplementationType;

			if (enumerable != null)
			{
				foreach (var descriptor in enumerable)
				{
					return descriptor.ImplementationType;
				}
			}

			return default;
		}

		public IMauiHandlersCollection GetCollection() => (IMauiHandlersCollection)InternalCollection;
	}
}