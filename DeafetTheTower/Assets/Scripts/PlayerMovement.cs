using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] float moveSpeed = 2;

    [Header("other")]
    [SerializeField] Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {

        Vector3 direction = new Vector3(0, 0, 0);
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
        direction = Vector3.ClampMagnitude(direction, 1);
        direction *= moveSpeed;
        rb.linearVelocity = direction;






    }
}
