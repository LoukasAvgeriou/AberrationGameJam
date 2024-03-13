using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    [SerializeField, Range(0, 100)] private int offset = 10;

    void Update()
    {
        if (player != null)
        {
            // Update the camera's position to match the player's position with the offset

            //transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z - offset);

            Vector3 newPosition = transform.position;

        }
    }
}
