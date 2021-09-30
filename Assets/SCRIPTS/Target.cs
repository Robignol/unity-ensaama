using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// eye target + 
public class Target : MonoBehaviour
{
    // Start is called before the first frame update
   public Transform target;
   public bool isFalling = false;
   public GameObject clone;

    // Update is called once per frame
    void Update()
    {
        if (target != null){
            if (isFalling == false) {
                transform.LookAt(target);
            }
        }
    }

    void OnMouseDown() {
        GameObject clone = Instantiate(gameObject, transform.parent);
        clone.SetActive(false);


         isFalling = true;
         Rigidbody body = gameObject.AddComponent<Rigidbody>();
        //"trainée angulaire", càd la friction associée à la rotation.
        //0?05 par défaut, nous mettons 0,2f pour ralentir les yeux.
        body.angularDrag = 0.8f;

        Debug.Log("i'm fallllliiiiiinnnngg");

        StartCoroutine(FallEnd());



    }

//pénible mais méthode dans unity pour retarde une éxécution, un délai. > fonction type IEnumerator
    IEnumerator FallEnd(){
        yield return new WaitForSeconds(4f);
        isFalling = false;

        Debug.Log("im still alive youhoo");

        clone.SetActive(true);
    }
}
