public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary <int,int> hash = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++){

            int complemento = target - nums[i];

            if (hash.ContainsKey(complemento)){

                int[] retorno = {hash[complemento], i};
                return retorno;
            }

            if (!hash.ContainsKey(nums[i])){
                hash.Add(nums[i], i);
            }
        }

        return null;
    }

}