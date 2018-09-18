using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}


public class BoardGame
{
    readonly int boardSize;
    CellData [,] board = new CellData[GAME_DEFINE.MAX_SIZE, GAME_DEFINE.MAX_SIZE];
    
    public BoardGame()
    {
        boardSize = GAME_DEFINE.DEFAULT_SIZE;
    }

    public BoardGame(int _size)
    {
        boardSize = _size;

        for (int i = 0; i < boardSize; i++)
        {
            for (int j = 0; j < boardSize; j++)
            {
                board[i, j] = new CellData(XO.NONE);
            }
        }
    }
}

public static class GAME_DEFINE
{
    public static readonly int DEFAULT_SIZE = 64;
    public static readonly int MAX_SIZE = 128;
}

public class CellData
{
    public XO cellValue { get; private set; }

    public CellData(XO _value)
    {
        // Init
        cellValue = _value;

    }


}

public enum XO
{
    NONE = -1,
    O = 0,
    X = 1,
}