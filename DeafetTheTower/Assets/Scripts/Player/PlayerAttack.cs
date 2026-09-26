using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    [SerializeField] float fireRate = 2;
    [Header("")]
    [SerializeField] GameObject bulletPrefab;

    bool justFired;

    void Update()
    {

        if (!justFired)
        {
            Vector2 shootdir = Vector2.zero;
            if (Input.GetKey(KeyCode.UpArrow)) { shootdir = Vector2.up; }
            else if (Input.GetKey(KeyCode.DownArrow)) { shootdir = Vector2.down; }
            else if (Input.GetKey(KeyCode.LeftArrow)) { shootdir = Vector2.left; }
            else if (Input.GetKey(KeyCode.RightArrow)) { shootdir = Vector2.right; }

            if (shootdir != Vector2.zero)
            {
                justFired = true;
                Shoot(shootdir);
                StartCoroutine(WaitAndAllowShoot(fireRate));
            }
        }
    }
    void Shoot(Vector2 shootdir)
    {
        // Calculate the angle from the last movement direction
        float angle = Mathf.Atan2(-shootdir.y, -shootdir.x) * Mathf.Rad2Deg;

        // Create a rotation quaternion based on this angle
        Quaternion angleFixed;
        angleFixed = Quaternion.Euler(0, 0, angle + Random.Range(-2f, 2f));

        // Spawn the bullet object
        GameObject bullet = Instantiate(bulletPrefab, transform.position, angleFixed);
    }

    IEnumerator WaitAndAllowShoot(float tTime)
    {
        yield return new WaitForSeconds(tTime);
        justFired = false;
    }
}
