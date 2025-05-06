using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentGenerator : MonoBehaviour
{
    public GameObject[] segmentPrefabs;      // Your tile/segment prefabs
    public GameObject[] obstaclePrefabs;     // Your obstacle prefabs
    [SerializeField] int zPos = 50;
    [SerializeField] bool creatingSegment = false;
    [SerializeField] int segmentNum;

    void Update()
    {
        if (creatingSegment == false)
        {
            creatingSegment = true;
            StartCoroutine(SegmentGen());
        }
    }

    IEnumerator SegmentGen()
    {
        segmentNum = Random.Range(0, segmentPrefabs.Length);
        GameObject newSegment = Instantiate(segmentPrefabs[segmentNum], new Vector3(0, 0, zPos), Quaternion.identity);

        SpawnObstaclesOnSegment(newSegment);

        zPos += 50;
        yield return new WaitForSeconds(3);
        creatingSegment = false;
    }

    void SpawnObstaclesOnSegment(GameObject segment)
    {
        // Find all child objects tagged "ObstacleSpawn" inside the segment
        foreach (Transform child in segment.transform)
        {
            if (child.CompareTag("ObstacleSpawn"))
            {
                if (Random.value > 0.5f) // 50% chance to spawn
                {
                    int rand = Random.Range(0, obstaclePrefabs.Length);
                    Instantiate(obstaclePrefabs[rand], child.position, Quaternion.identity, segment.transform);
                }
            }
        }
    }
}
