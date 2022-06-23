using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateTanks : MonoBehaviour
{
    [SerializeField] GameObject tank;
    Vector3 instPos;
    // Start is called before the first frame update
    void Start()
    {
        instPos = new Vector3(6.07f, 0f, 175.8f);
        StartCoroutine(Spawn());
        
    }

    public virtual void SpawnTank()
    {
        Instantiate(tank, instPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        


    }


     IEnumerator Spawn()
    {
        InvokeRepeating("SpawnTank", 2.5f, 4.0f);
        yield return new WaitForSeconds(2);
    }
    
    
        
        
    
}
