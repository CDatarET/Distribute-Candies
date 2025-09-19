public class Solution {
    public int DistributeCandies(int[] candyType) {
        Dictionary<int, int> d = new Dictionary<int, int>();

        for(int i = 0; i < candyType.Length; i++){
            if(d.ContainsKey(candyType[i])){
                d[candyType[i]] = d[candyType[i]] + 1;
            }
            else{
                d.Add(candyType[i], 1);
            }
        }

        if(d.Count >= candyType.Length / 2){
            return(candyType.Length / 2);
        }
        else{
            return(d.Count);
        }
    }
}
