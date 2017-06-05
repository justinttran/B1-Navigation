using UnityEngine;
using System.Collections;

public class AnimationPlayerController : MonoBehaviour
{
    Animator anim;
    private float speed = 0.5f;
    
    
    
    void Start(){
        anim = GetComponent<Animator>();
    }

    void Update(){

         if (Input.GetKeyDown(KeyCode.Space)){
            anim.SetBool("jump", true);
        }
        else{
            anim.SetBool("jump", false);
        }

        if (Input.GetKey(KeyCode.W)){
            if (Input.GetKey(KeyCode.LeftShift)){
                 anim.SetFloat("velZ", speed*2, 1f, Time.deltaTime);
            }
            else{
                anim.SetFloat("velZ", speed, 1f, Time.deltaTime);
            }
            anim.SetBool("walking", true);
        }
        else if (Input.GetKey(KeyCode.S)){
            anim.SetFloat("velZ", -speed);
            anim.SetBool("walking", true);
        }
        else{
            anim.SetFloat("velZ", 0); 
            anim.SetBool("walking", false);
        }

        if (Input.GetKey(KeyCode.A)){
                anim.SetFloat("velX", -speed);
        }
        else if (Input.GetKey(KeyCode.D)){
            anim.SetFloat("velX", speed);
        }
        else{
            anim.SetFloat("velX", 0);
        }

       


        //no only state machines
        // if (Input.GetKeyDown(KeyCode.Space)){
        //     anim.SetBool("jump", true);
        // }
        // else{
        //     anim.SetBool("jump", false);
        // }

        // if (Input.GetKey(KeyCode.W)){
        //     if (Input.GetKey(KeyCode.LeftShift)){
        //         anim.SetFloat("speed", speed*2);
        //     }
        //     else{
        //         anim.SetFloat("speed", speed);
        //     }
        // }
        // else{
        //     anim.SetFloat("speed", 0);
            
        // }

        



        
       
    }
}