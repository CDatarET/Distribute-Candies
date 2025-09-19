class Solution(object):
    def distributeCandies(self, candyType):
        """
        :type candyType: List[int]
        :rtype: int
        """
        d = {}
        for i in range(len(candyType)):
            if(candyType[i] in d):
                d[candyType[i]] = d[candyType[i]] + 1
            else:
                d[candyType[i]] = 1
        
        if(len(d) >= len(candyType) / 2):
            return(len(candyType) / 2)
        else:
            return(len(d))
