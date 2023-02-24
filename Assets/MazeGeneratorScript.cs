using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGeneratorScript : MonoBehaviour
{
    readonly int[] dx = new int[] { -1, 0, 1, 0 };
    readonly int[] dy = new int[] { 0, 1, 0, -1 };

    // Cell cell = new();

    public List<List<Cell>> cellList;

    [SerializeField]
    private int maxSize;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    struct CustomPair
    {
        public CustomPair(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int x;
        public int y;
    }

    public List<List<Cell>> GetCell()
    {
        for (int x = 0; x < maxSize; x++)
        {
            cellList.Add(new List<Cell>());
            for (int y = 0; y < maxSize; y++)
            {
                cellList[x].Add(new Cell());
            }
        }

        Backtracking(ref cellList, 0, 0);

        return cellList;
    }

    void Backtracking(ref List<List<Cell>> cellList, int startX, int startY)
	{
        Stack<CustomPair> stk = new();
        CustomPair pair;

        pair.x = startX;
        pair.y = startY;
        
        stk.Push(pair);

        cellList[startX][startY].visited = true;
	}
}
