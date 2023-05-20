using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SHSpawn : MonoBehaviour
{
    [SerializeField]
    AutoWalk goCreate;

    [SerializeField]
    float fTimeIntervals;

    [SerializeField]
    Vector3 v3SpawnPosJitter;

    public Transform targetObject;

    float fTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        fTimer = fTimeIntervals;
    }

    // Update is called once per frame
    void Update()
    {
        fTimer -= Time.deltaTime;
        if (fTimer <= 0)
        {
            fTimer = fTimeIntervals;

            Vector3 v3SpawnPos = transform.position;
            v3SpawnPos += Vector3.right * v3SpawnPosJitter.x * (Random.value - 0.5f);
            v3SpawnPos += Vector3.forward * v3SpawnPosJitter.z * (Random.value - 0.5f);
            v3SpawnPos += Vector3.up * v3SpawnPosJitter.y * (Random.value - 0.5f);

            AutoWalk pop  = Instantiate<AutoWalk>(goCreate, v3SpawnPos, Quaternion.identity);
            pop.targetObject = targetObject;
        }
    }
}
