using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class MazeSpawner : MonoBehaviour
{

    public GameObject CellPrefab;

    private void Start()
    { 

        MazeGenerator generator = new MazeGenerator();
        MazeGeneratorCell[,] maze = generator.GenerateMaze();

        for (int x = 0; x < maze.GetLength(0); x++)
        {
            for (int y = 0; y < maze.GetLength(1); y++)
            {
                Cell c = Instantiate(CellPrefab, new Vector3(x, y, -0.5f), Quaternion.identity).GetComponent<Cell>();
                c.wallLeft.SetActive(maze[x, y].wallLeft);
                c.wallBottom.SetActive(maze[x, y].wallBottom);
            }
        }
    }
    
}

