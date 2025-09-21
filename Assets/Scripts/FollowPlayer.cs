using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    //private Vector3 offset = new Vector3(0, 4, -10); // or change value to (0,5,-13) for better camera for van model

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Offset the camera behind the player by adding to the player's position  
        //transform.position = player.transform.position;
        transform.position = player.transform.position + new Vector3(0, 4, -10);
        //transform.position = player.transform.position + offset;
    }
}
