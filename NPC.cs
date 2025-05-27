// Paul Sazon
using UnityEngine;

public class NPC : MonoBehaviour
{
    // NPC Health
    public int health = 5;
    // NPC Level
    public int level = 1;
    // NPC Speed
    public float speed = 1.2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

       public void Start()

        {
        health = health + level;
        print("Player health:" + health);
            
        }

        // Update is called once per frame
        void Update()
        {
            // Step 1: Record the current position
            Vector3 newPosition = transform.position;
            // Step 2: Update the Z axis based on speed and time between frames
            newPosition.z += speed * Time.deltaTime;
            // Step 3: Assign the new position back to the NPC's transform
            transform.position = newPosition;
            print(transform.position);
            
        }
}
