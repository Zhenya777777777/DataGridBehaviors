using System;

namespace TestClient
{
    internal interface IContainer
    {
        T Resolve<T>();

        void RegisterAsSingleton<TInterface, TImplementor>()
            where TImplementor : TInterface;

        void RegisterInstance(Type type, object instance);
    }
}