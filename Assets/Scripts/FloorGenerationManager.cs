using UnityEngine;
using System.Collections;

public class FloorGenerationManager : MonoBehaviour {

    public GameObject[] floorPrefabs;
    public float prefabSize = 0.48f;

    public GameObject[] flowerPrefabs;
    public int nbFlowers = 100;

    public float terrainSize = 101f;

	void Start ()
    {
        GenerateFloor();
        GenerateFlowers();
	}

    void GenerateFloor()
    {
        for (int i = 0; i < terrainSize; i++)
        {
            for (int j = 0; j < terrainSize; j++)
            {
                Vector3 pos = new Vector3(i * prefabSize - (prefabSize * (terrainSize/2f)), j * prefabSize - ( prefabSize * (terrainSize / 2f)), 0f);
                GameObject.Instantiate(floorPrefabs[(int)Random.Range(0, floorPrefabs.Length)], pos, Quaternion.identity);
            }
        }
    }

    void GenerateFlowers()
    {
        float maxPos = prefabSize * (terrainSize / 2f);
        Vector2 pos;
        for (int i = 0; i < nbFlowers; i++)
        {
            pos = new Vector2(Random.Range(-maxPos, maxPos), Random.Range(-maxPos, maxPos));
            GameObject.Instantiate(flowerPrefabs[(int)Random.Range(0, flowerPrefabs.Length)], pos, Quaternion.identity);
        }
    }
}
