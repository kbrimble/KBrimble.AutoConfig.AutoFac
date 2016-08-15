using Autofac;
using Autofac.Builder;

namespace KBrimble.AutoConfig.AutoFac
{
    public static class AutoConfigAutoFacExtensions
    {
        public static IRegistrationBuilder<T, SimpleActivatorData, SingleRegistrationStyle> RegisterConfig<T>(this ContainerBuilder builder, string sectionName = null) where T : class
        {
            return builder.RegisterInstance(Nerdle.AutoConfig.AutoConfig.Map<T>()).As<T>();
        }
    }
}
