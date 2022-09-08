
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
  public playerMovement1 movement ;

  void OnCollisionEnter(Collision collisionInfo){
    Debug.Log(collisionInfo.collider.name);
    if (collisionInfo.collider.tag == "Obstacle" || collisionInfo.collider.name == "Sphere"){
        movement.enabled = false;
        FindObjectOfType<GameManager>().EndGame();
    }

  }
}
