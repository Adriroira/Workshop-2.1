using UnityEngine;

public class WindArea : MonoBehaviour
{
    public float windForce = 0f;

    private void OnTriggerStay(Collider other)
    {
        // Rigidbody rb = other.GetComponent<Rigidbody>();
        // if(rb != null)
        // {
        //     rb.AddForce(Vector3.up * windForce);
        // }

        var hitObject = other.gameObject;
        if(hitObject != null)
        {
            var rb = hitObject.GetComponent<Rigidbody>();
            var direction = transform.up;
            rb.AddForce(direction * windForce);
        }

    }

}
