using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour
{
    [SerializeField]
    Transform _ground;

    [SerializeField]
    GameTile _tile;

    Vector2Int _size;

    
    public  void Initialize(Vector2Int size)
    {
        this._size = size;
        _ground.localScale = new Vector3(size.x,1, size.y);

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
