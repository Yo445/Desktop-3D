using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SHSpawnOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;

    [SerializeField]
    bool SpawnSelf = false;

    [SerializeField]
    bool SpawnOther = false;

    [SerializeField]
    GameObject oSpawn;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag== strTag)
        {
            if (SpawnSelf)
                Instantiate(oSpawn, transform.position, Quaternion.identity);
            if (SpawnOther)
                Instantiate(oSpawn, collision.transform.position, Quaternion.identity);
        }
    }
}