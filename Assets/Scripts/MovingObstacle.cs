using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    public float speed = 3f;
    public Vector3 direction = Vector3.right;
    public float distance = 5f;

    private Vector3 startPos;
    private bool goingForward = true;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        float movedDistance = Vector3.Distance(transform.position, startPos);
        if (movedDistance >= distance)
        {
            direction = -direction;
            startPos = transform.position;
        }
    }
}
