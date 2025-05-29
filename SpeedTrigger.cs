using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public float speedFactor = 2.5f;
  void OnTriggerEnter (Collider other)
  {
    //Increasing the player's running speed
    other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
  }
  void OnTriggerExit (Collider other)
  {
    //Reducing the player's running speed
    other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
  }
}
