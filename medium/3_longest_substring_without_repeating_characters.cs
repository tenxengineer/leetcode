public class Solution {
    public int LengthOfLongestSubstring(string s) {
        // Create a hash set to store unique characters in the current window
        HashSet<char> seenChars = new HashSet<char>();
        
        // Initialize left pointer and max length
        int left = 0;
        int maxLength = 0;
        
        // Loop through each character in the string with the right pointer
        for (int right = 0; right < s.Length; right++) {
            // If the character at 'right' is already in the set, slide the 'left' pointer
            while (seenChars.Contains(s[right])) {
                seenChars.Remove(s[left]); // Remove character at 'left'
                left++; // Move 'left' pointer to the right
            }
            
            // Add the character at 'right' to the set
            seenChars.Add(s[right]);
            
            // Update maxLength if the current window length is greater
            maxLength = Math.Max(maxLength, right - left + 1);
        }
        
        // Return the maximum length found
        return maxLength;
    }
}
