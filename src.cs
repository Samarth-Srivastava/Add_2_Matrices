class Solution {
    public List<List<int>> solve(List<List<int>> A, List<List<int>> B) {
        int N = A.Count();
        int M = A[0].Count();

        List<List<int>> C = new List<List<int>>();
        for(int i = 0; i < N; i++){
            List<int> inner = new List<int>();
            for(int j = 0; j < M; j++){
                inner.Add(A[i][j] + B[i][j]);
            }
            C.Add(inner);
        }
        return C;
    }
}
