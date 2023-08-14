using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class take : MonoBehaviour
{
    public AudioSource bip;
    public AudioSource take_;

    public Animator anim_door;

    public float mesafe;
    
    public GameObject text_E;

    public bool kart_aldý = false;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 yon = transform.TransformDirection(Vector3.forward);

        RaycastHit hit;

        if (Physics.Raycast (transform.position , yon, out hit, mesafe));
        {

            if (hit.distance < mesafe && hit.collider.gameObject.tag == "obj")
            {
               
                text_E.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    take_.Play();
                    kart_aldý = true;
                    Destroy(hit.collider.gameObject);
                }
                
                
            }
            
            else if (hit.distance < mesafe && hit.collider.gameObject.tag == "panel" && kart_aldý)
            {

                text_E.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    bip.Play();
                    anim_door.SetBool("door",true);
                    kart_aldý = false;
                    Debug.Log("açýldý");
                }


            }
            else
            {
                text_E.SetActive(false);
            }

        }
    }
}
