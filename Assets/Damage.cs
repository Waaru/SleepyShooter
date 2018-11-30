using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

    public GameObject prefabEffect;

    void Start()
    {
        //prefabEffect = Resources.Load("HitParticules") as GameObject;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Hellephant")
        {
            var Effet = Instantiate(prefabEffect, 
                collision.contacts[0].point, 
                Quaternion.FromToRotation(Vector3.up, collision.contacts[0].normal)
            ) as GameObject;
            collision.gameObject.GetComponent<Stats>().life -= 10;
            Destroy(Effet, 1f);
        }
    }
}
