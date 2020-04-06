using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{

    public GameObject[,] tileMap;
    [SerializeField] public Vector2Int dimensions;
    [SerializeField] public float padding;
    [SerializeField] public GameObject prefab;
    [SerializeField] public Transform board;
    public bool letUsParty;

    private void GenerateBoard()
    {
        tileMap = new GameObject[dimensions.x, dimensions.y];

        for (int i = 0; i < dimensions.x; i++)
        {
            for (int j = 0; j < dimensions.y; j++)
            {
                CreateTile(i, j);
            }
        }
    }

    private void CreateTile(int x, int y)
    {
        Debug.Log("generating tile [" + x + "][" + y + "]");
        tileMap[x, y] = Tile.InstantiateTile(prefab, new Vector3(x*(padding+1), y*(padding+1), 0), board);
    }

    public IEnumerator randomDanceParty()
    {
        for (int i = 0; i < dimensions.x; i++)
        {
            for (int j = 0; j < dimensions.y; j++)
            {
                tileMap[i, j].GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
                Vector3 tempPosition = tileMap[i, j].transform.position;
                tempPosition.x = Random.value * 2;
                tempPosition.y = Random.value * 4;
                tempPosition.z = Random.value * 8;
                tileMap[i, j].transform.position = tempPosition;
            }

        }

        yield return new WaitForSeconds(5f);

        StartCoroutine(randomDanceParty());
    }

    private void Start()
    {
        GenerateBoard();
        if (letUsParty)
            StartCoroutine(randomDanceParty());
    }
}
