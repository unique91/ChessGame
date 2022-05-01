using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chessboard : MonoBehaviour
{
    [SerializeField] private int _width, _height;
    [SerializeField] private Field _fieldPrefab;
    [SerializeField] private Transform _camera;

    private void Start()
    {
        CreateBoard();
    }
    void CreateBoard()
    {
        for(int i = 0; i < _width; i++)
        {
            for(int j = 0; j < _height; j++)
            {
                var spawnedField = Instantiate(_fieldPrefab, new Vector3(i, j), Quaternion.identity);
                spawnedField.name = $"Board {i} {j}";
            }
        }

        _camera.transform.position = new Vector3((float)_width/2 - 0.5f, (float)_height/2 - 0.5f, -10);
    }
}
