using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField]
    Vector2Int _boardSize = new Vector2Int(11, 11);

    [SerializeField]
    GameBoard board = default;


    private void Awake()
    {
        board.Initialize(_boardSize);
    }


    private void OnValidate()
    {
        if (_boardSize.x < 2)
            _boardSize.x = 2;
        if (_boardSize.y < 2)
            _boardSize.y = 2;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
