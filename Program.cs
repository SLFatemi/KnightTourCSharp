int[,] chessBoard = {
    {0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0}
    };
int x, y;
x = int.Parse(Console.ReadLine());
y = int.Parse(Console.ReadLine());
bool[,] visited = new bool[8, 8];
DFS(chessBoard, visited, x ,y);
void DFS(int[,] board, bool[,] visit, int i, int j)
{
    visit[i, j] = true;
    board[i, j] = 1;
    for (int m = 0; m < 8; m++)
    {
        for (int n = 0; n < 8; n++)
        {
            Console.Write($"{board[m,n]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    int[] iMovement = { +2, +2, +1, -1, -2, -2, +1, -1 };
    int[] jMovement = { -1, +1, +2, +2, +1, -1, +2, -2 };
    for (int k = 0; k < 8; k++)
    {
        int newi = i + iMovement[k];
        int newj = j + jMovement[k];
        if (isOK(chessBoard, visit, newi, newj))
        {
            DFS(chessBoard, visit, newi, newj);
        }
    }
}
// I'M NOT HERE
bool isOK(int[,] board, bool[,] visit, int i, int j)
{
    if (i >= 0 && j >= 0 && i < 8 && j < 8 && visit[i, j] is false)
        return true;
    return false;
}
