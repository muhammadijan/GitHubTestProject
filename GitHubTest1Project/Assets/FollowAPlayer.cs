using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAPlayer : MonoBehaviour
{
    public Transform player;
    public float speed = 10;
    float rotationSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=Vector3.MoveTowards(transform.position,player.transform.position,Time.deltaTime);
        if (player.position != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                Quaternion.LookRotation(player.position),
                Time.deltaTime * rotationSpeed
            );
        }
    }
}
