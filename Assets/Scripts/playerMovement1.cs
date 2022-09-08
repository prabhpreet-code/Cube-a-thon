// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using System.Collections;

// public class playerMovement1 : MonoBehaviour
// {
//     // Start is called before the first frame update
   
//      public int jumpVar = 0 ;
//     // void Start()
//     // {
//     //     Debug.Log("HELLO WORLD");
//     //     rb.AddForce(0,200,500);
//     // }

//     // Update is called once per frame

//     void Update(){
//         if(Input.GetKeyDown(KeyCode.B))
//          {  jumpVar = jumpVar + 1;
//             // rb.AddForce(0, jumpForce * Time.deltaTime , 0);

//             if(jumpVar < 2){
//                rb.AddForce(0, jumpForce * Time.deltaTime , 0);
//             }
//         }
//     }

    

//     void OnCollisionEnter(Collision collisionInfo){
//     if (collisionInfo.collider.name == "Ground"){
//         jumpVar = 0 ;
//     }
// }
    
// }

 public class playerMovement1 : MonoBehaviour {
         
        public Rigidbody rb ;

        public float forwardForce;
        public float sidewaysForce;
        public Vector3 jump;
        public float jumpForce;
        public int jumpVar = 0 ;
      
        public bool isGrounded;
        
          void Start(){
              
              jump = new Vector3(0.0f, 2.0f, 0.0f);
          }
      
          void OnCollisionStay()
          {
              isGrounded = true;
              jumpVar = 0 ;
          }
          void OnCollisionExit(){
            isGrounded = false;
      }
          void Update(){
              if(Input.GetKeyDown(KeyCode.Space) && isGrounded){
      
                  rb.AddForce(jump * jumpForce, ForceMode.Impulse);
                  jumpVar = jumpVar + 1;
                //   isGrounded = false;
              }

              else if(Input.GetKeyDown(KeyCode.Space) && (jumpVar < 2)){
      
                  rb.AddForce(jump * jumpForce, ForceMode.Impulse);
                  jumpVar = jumpVar + 1;
                  isGrounded = false;
              }


          }

    void FixedUpdate()
    {
        rb.AddForce(0, 0 ,forwardForce * Time.deltaTime);

        if(Input.GetKey("right")){
            rb.AddForce(sidewaysForce * Time.deltaTime , 0 , 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("left")){
            rb.AddForce(-sidewaysForce * Time.deltaTime , 0 , 0 , ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f){
            
            FindObjectOfType<GameManager>().EndGame() ;
        }
         
    }
}
