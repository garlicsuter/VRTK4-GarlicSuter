using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnomatic : MonoBehaviour
{
    public GameObject SpawnThis;
    public string myName;

    
    public void SpawnTime()
    {
        //Instantiate(SpawnThis, new Vector3(i* 2.0F, 0, 0), Quaternion.identity);
        Instantiate(SpawnThis, new Vector3(0.7f,-1.37f,2), transform.rotation);
    }
}
