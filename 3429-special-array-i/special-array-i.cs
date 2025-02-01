
public class Solution {
    public bool IsArraySpecial(int[] nums) {
        if (nums.Length == 1)
            return true;

        for (int i = 1; i < nums.Length; i++)
        {
            if ((nums[i] + nums[i - 1]) % 2 != 1)
                return false;
        }

        return true;
    }
}