using System;

using Microsoft.Practices.Unity;

namespace TestClient
{
    internal sealed class Container : IContainer
    {
        private readonly UnityContainer _unity = new UnityContainer();

        static Container() {}

        private static Container _instance;
        public static Container Instance
        {
            get
            {
                return _instance ?? (_instance = new Container());
            }
        }

        public T Resolve<T>()
        {
            return _unity.Resolve<T>();
        }

        public void RegisterAsSingleton<TInterface, TImplementor>()
            where TImplementor : TInterface
        {
            _unity.RegisterType<TInterface, TImplementor>(
                new ContainerControlledLifetimeManager());
        }

        public void RegisterInstance(Type type, object instance)
        {
            _unity.RegisterInstance(type, instance);
        }
    }
}

