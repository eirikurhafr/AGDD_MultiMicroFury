using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public Transform prefab;
    public int boxCount;

    void Start()
    {
        boxCount = 1;
        InvokeRepeating("SpawnProjectiles", 2.0f, 1f);
        InvokeRepeating("ChangeCount", 2.0f, 2f);
    }

    void SpawnProjectiles()
    {
        for (int i = 0; i < boxCount; i++)
        {
            float x = Random.Range(-25.38f, 1.55f);
            Instantiate(prefab, new Vector3(x, 25f, -4.539f), Quaternion.identity);
        }
    }
    
    void ChangeCount()
    {
        boxCount += 1;
    }

    void TurnOff()
    {
        CancelInvoke();
    }
}
