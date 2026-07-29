public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int max_length = 0;

        for (int start = 0; start < s.Length; start++) {
            HashSet<char> seen = new HashSet<char>();

            for (int end = start; end < s.Length; end++) {
                char current_letter = s[end];

                if (seen.Contains(current_letter)) {
                    break;
                }

                seen.Add(current_letter);
                max_length = Math.Max(max_length, end - start + 1);
            }
        }

        return max_length;
    }
}