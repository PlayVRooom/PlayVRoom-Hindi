using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public static GameObject thisGO; 

    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if (thisGO == null)
        {
            thisGO = this.gameObject;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
