namespace Boats_to_Save_People
{
    internal class Program
    {
        public class Solution
        {

            public int NumRescueBoats(int[] people, int limit)
            {

                Array.Sort(people);
                int left = 0;                     // light
                int right = people.Length - 1;    // heavy
                int boats = 0;

                while (left <= right)
                {
                    // we're trying to seat the light one together with the heavy one
                    if (people[left] + people[right] <= limit)
                    {
                        left++;   // лёгкий сел
                    }

                    right--;      // the heavy one will always float away
                    boats++;      // the boat left
                }

                return boats;
            }
        }
    }
}
