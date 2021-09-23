using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneOnClick : MonoBehaviour
{       
    public int numberOfClones = 3;
    // Start is called before the first frame update
    void Start()
    {
      
    }
    // Update is called once per frame
    void Update()
    {
      
    }
    
private void OnMouseDown() {

    for (int i = 0; i < numberOfClones; i = i + 1) {

 //mort :  Destroy(gameObject); vie : Instantiate(gameObject);
            GameObject clone = Instantiate(gameObject);
            Destroy(clone, 1f);

    }

           

}

}