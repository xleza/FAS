﻿using System;

namespace FAS.Core
{
    public static class Ensure
    {
        public static void NotNull<T>(T arg, string name)
        {
            if (arg == null)
                throw new ArgumentNullException(name);
        }

        public static void NotEmpty(string arg, string name)
        {
            if (string.IsNullOrWhiteSpace(arg))
                throw new ArgumentException($"String parameter '{name}' cannot be null or all whitespace");
        }

        public static void IsPositive(int arg, string name)
        {
            if (arg <= 0)
                throw new ArgumentException($"Parameter '{name}' must be a positive");
        }
    }
}
