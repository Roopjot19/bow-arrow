using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootArrow : MonoBehaviour
{

    public float LaunchForce;

    public GameObject Arrow;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            //when we hit space key we want to launch an Arrow

            Shoot();
        }
    }
    
    void Shoot() {
      GameObject ArrowIns = Instantiate(Arrow, transform.position, transform.rotation);

      //apply force to the arrow we just created
      
      ArrowIns.GetComponent<Rigidbody2D>().AddForce(transform.right * LaunchForce);
    }

    

}
