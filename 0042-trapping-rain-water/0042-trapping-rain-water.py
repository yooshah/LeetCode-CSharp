class Solution:
    def trap(self, height: List[int]) -> int:

        n=len(height);

        arr1=[]
        arr2=[]
        l=0;
        r=0;

        tSum=0;
        for i in range(0,n):

            l=max(height[i],l)
            arr1.append(l)
            r=max(height[n-i-1],r)
            arr2=[r]+arr2
        
        for j in range(0,n):
            if(min(arr1[j],arr2[j])-height[j]>0):
                tSum+=min(arr1[j],arr2[j])-height[j]

        return tSum


            
        