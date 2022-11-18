using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject objectToSpawn;
    public GameObject addObject;

    // Start is called before the first frame update
    void Start()
    {
        addObject = Instantiate(objectToSpawn, transform.position, transform.rotation);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReSpawn()
    {
        addObject = Instantiate(objectToSpawn, transform.position, transform.rotation);
    }

    public void DestroyEnemy()
    {
       Destroy(addObject);

    }
    

}
