using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   [SerializeField]
    private float hitpoints = 100f;
    [SerializeField]
    private float movementSpeed = 1f;
    [SerializeField]
    private float attackDamage = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * movementSpeed;
        float verticalMovement = Input.GetAxis("Vertical") * movementSpeed;

        horizontalMovement *= Time.deltaTime;
        verticalMovement   *= Time.deltaTime;

        transform.Translate(horizontalMovement, 0, 0);
        transform.Translate(0, 0, verticalMovement);
    }
}
