class Solution {
    public int distributeCandies(int[] candyType) {
        HashMap<Integer, Integer> map = new HashMap<Integer, Integer>();
        for(int i = 0; i < candyType.length; i++){
            if(map.containsKey(candyType[i])){
                map.put(candyType[i], map.get(candyType[i] + 1));
            }
            else{
                map.put(candyType[i], 1);
            }
        }
        
        if(map.size() >= candyType.length / 2){
            return(candyType.length / 2);
        }
        else{
            return(map.size());
        }
    }
}
