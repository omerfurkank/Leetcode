using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays.Easy;
public static class TeemoAttacking
{
    public static int FindPoisonedDuration(int[] timeSeries, int duration)
    {
        int poisoned = 0;
        /////////////////////////////////////////////////////////////////////////////7
        for (int i = 0; i < timeSeries.Length; i++) {
            if (poisoned >= timeSeries[i])
            {
                poisoned += (timeSeries[i] - timeSeries[i-1]);
            }
            else
            {
                poisoned += duration;
            }
        }
        return poisoned;
    }
    public static int FindPoisonedDuration2(int[] timeSeries, int duration)
    {
        int poisoned = 0;

        for (int i = 1; i < timeSeries.Length; i++)
        {
            int interval = timeSeries[i] - timeSeries[i - 1];

            poisoned += Math.Min(interval, duration);
        }

        poisoned += duration;

        return poisoned;
    }
    public static int FindPoisonedDuration3(int[] timeSeries, int duration)
    {
        int timeDiff = 0;
        int count = 0;

        for (int i = 1; i < timeSeries.Length; i++)
        {
            timeDiff = timeSeries[i] - timeSeries[i - 1];
            if (timeDiff > duration)
                count += duration;
            else
                count += timeDiff;
        }
        count += duration;
        return count;
    }

}
