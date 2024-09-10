using System;

namespace AlsoLet
{
    public static class KotlinScopeFunctionsExtension
    {
        public static T Also<T>(this T it, Action<T> block)
        {
            block(it);
            return it;
        }

        public static R Let<T, R>(this T it, Func<T, R> block)
        {
            return block(it);
        }
    }
}
