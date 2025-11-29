namespace Min_Cost_Climbing_Stairs
{
    internal class Program
    {
        public class Solution
        {
            public int MinCostClimbingStairs(int[] cost)
            {
                int length = cost.Length, current = cost[1], previous = cost[0];

                for (int i = 2; i < length; i++)
                {
                    (current, previous) = (cost[i] + Math.Min(current, previous), current);
                }
                return Math.Min(current, previous);
            }
        }
    }
}
