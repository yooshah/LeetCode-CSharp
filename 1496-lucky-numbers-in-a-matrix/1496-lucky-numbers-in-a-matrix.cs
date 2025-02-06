public class Solution {
    public IList<int> LuckyNumbers(int[][] matrix) {

        int n=matrix.Length;
        int m=matrix[0].Length;
        List<int> minRow=new List<int>();
        for(int i=0;i<n;i++)
        {   
            int minRowNum=matrix[i][0];
            for(int j=0;j<m;j++)
            {
                minRowNum=Math.Min(matrix[i][j],minRowNum);
            }
            minRow.Add(minRowNum);

        }

        List<int> maxCol=new List<int>();
        for(int j=0;j<m;j++)
        {   
            int minColNum=matrix[0][j];
            for(int i=0;i<n;i++)
            {
                minColNum=Math.Max(matrix[i][j],minColNum);
            }
            maxCol.Add(minColNum);
        }

        List<int> luckyNum=new List<int>();
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                if(matrix[i][j]==minRow[i] && matrix[i][j]==maxCol[j])
                {
                    luckyNum.Add(matrix[i][j]);
                }
            }
        }

        return luckyNum;

    }

    
}