using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int numberToSpawn;
    public List<GameObject> spawnPool;
    public GameObject splashscreenBG;

    // Start is called before the first frame update
    void Start()
    {
        spawnObjects();
    }

    public void spawnObjects()
    {
        int randomItem = 0;
        GameObject toSpawn;
        MeshCollider c = splashscreenBG.GetComponent<MeshCollider>();

        float screenX, screenY;
        Vector3 pos;

        for(int i = 0; i < numberToSpawn; i++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool [randomItem];

            screenX = Random.Range(-1514, 1514);
            screenY = Random.Range(-1495, 1495);
            pos = new Vector3(screenX, screenY, -1968);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
        }
    }
    private void destroyObjects()
    {
        foreach(GameObject o in GameObject.FindGameObjectsWithTag("Spawnable"))
        {
            Destroy(o);
        }
    }


}

