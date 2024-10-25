public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Initialize a dictionary to store numbers and their indices
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();
        
        // Loop through each number in the array
        for (int i = 0; i < nums.Length; i++) {
            // Calculate the complement needed to reach the target
            int complement = target - nums[i];
            
            // Check if the complement is in the dictionary
            if (numToIndex.ContainsKey(complement)) {
                // If found, return the indices of the current number and the complement
                return new int[] { numToIndex[complement], i };
            }
            
            // If complement not found, add the current number and its index to the dictionary
            numToIndex[nums[i]] = i;
        }
        
        // The problem guarantees a solution exists, so we shouldn't reach here
        throw new ArgumentException("No two sum solution");
    }
}
