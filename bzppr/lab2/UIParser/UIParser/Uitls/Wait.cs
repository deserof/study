﻿using System.Diagnostics;

namespace UIParser.Uitls
{
    public class Wait
    {
        public static void Until(
            Func<bool> waitForFunction,
            TimeSpan? timeout = null,
            int tickSize = 500,
            string? exceptionText = null)
        {
            if (waitForFunction == null)
            {
                throw new ArgumentNullException(nameof(waitForFunction));
            }

            if (timeout == null)
            {
                timeout = TimeSpan.FromSeconds(10);
            }

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            try
            {
                while (stopwatch.Elapsed < timeout)
                {
                    if (waitForFunction())
                    {
                        return;
                    }

                    Thread.Sleep(tickSize);
                }

                var timeOutExceptionText = exceptionText ?? $"Timed out after {timeout} seconds. {waitForFunction.Method.Name}";

                throw new TimeoutException(timeOutExceptionText);
            }
            finally
            {
                stopwatch.Stop();
            }
        }

        public static void For(TimeSpan timeout)
        {
            Thread.Sleep(timeout);
        }
    }
}
