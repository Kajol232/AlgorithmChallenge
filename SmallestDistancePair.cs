using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge1
{
    public class SmallestDistancePair
    {
        public static int SmallestDistance(int[] nums, int k)
        {

            int kDistance = 0;
            int kIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
               
                for(int j = 1; j < nums.Length; j++)
                {
                    if(kIndex > k)
                    {
                        break;
                    }
                    kDistance = Math.Abs(nums[i] - nums[j]);
                    kIndex++;                                      

                }
            }
            return kDistance;
        }
    }
}
