using System;

namespace Quiz
{
    public static class ext
    {
        public static R To<T, R>(this T me, Func<T, R> transform) => transform(me);
    }
}
