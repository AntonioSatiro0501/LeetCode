public class Solution {
    public int MirrorDistance(int n) {
        
        string sn = n.ToString();
        string r = "";
        for (int i = sn.Length - 1; i >= 0; i--){
            r = r + sn[i];
        } 

        int reverso = int.Parse(r);

        return Math.Abs(n - reverso);
    }
}