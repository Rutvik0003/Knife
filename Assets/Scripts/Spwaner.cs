using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spwaner : MonoBehaviour
{
    public GameObject Knife;
    
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnKnife();
            Score.score += 1;
        }
        
    }

    private void SpawnKnife()
    {
       GameObject SpwanedKnives = Instantiate (Knife,transform.position, Quaternion.identity);
        

    }
}
