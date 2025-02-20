public class Solution {
    public string FindDifferentBinaryString(string[] nums) {
        var length = nums.Length;
        var result = new char[length];

        for (int i = 0; i < length; i++)
        {
            // Flip the i-th bit of the i-th string to ensure the result is different
            result[i] = nums[i][i] == '0' ? '1' : '0';
        }
        return new string(result);
    }
}
