public class Solution {
    public IList<int> GetRow(int rowIndex) {
        List<IList<int>> triangle = new List<IList<int>>();

        for (int i = 0; i <= rowIndex; i++) {

            List<int> row = new List<int>();

            for (int j = 0; j <= i; j++) {

                if (j == 0 || j == i){

                    row.Add(1);
                }

                else{
                    
                    row.Add(triangle[i - 1][j - 1] + triangle[i - 1][j]);
                }
            }

            triangle.Add(row);
        }

        return triangle.Last();
        
    }
}

