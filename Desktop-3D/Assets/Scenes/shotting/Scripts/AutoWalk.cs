using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoWalk : MonoBehaviour
{
    public Transform targetObject; // The game object the model will walk towards
    public float speed = 1.0f; // The speed at which the model will walk
    public float stoppingDistance = 0.1f; // The distance at which the model will stop walking

    private Vector3 startPosition; // The starting position of the model
    private Vector3 targetPosition; // The target position of the model
    private bool isWalking = false; // Whether the model is currently walking

    void Start()
    {
        // Get the starting position of the model
        startPosition = transform.position;

        // Get the target position of the model
        targetPosition = targetObject.position;
    }

    void Update()
    {
        // Calculate the distance between the model and the target object
        float distanceToTarget = Vector3.Distance(transform.position, targetPosition);

        // If the model is not already walking and is not within the stopping distance, start walking
        if (!isWalking && distanceToTarget > stoppingDistance)
        {
            isWalking = true;
        }

        // If the model is currently walking, move it towards the target object
        if (isWalking)
        {
            // Calculate the direction to move the model in
            Vector3 direction = (targetPosition - transform.position).normalized;

            // Move the model in the calculated direction at the specified speed
            transform.position += direction * speed * Time.deltaTime;

            // If the model has reached the stopping distance, stop walking
            if (distanceToTarget <= stoppingDistance)
            {
                isWalking = false;
            }
        }
    }
}