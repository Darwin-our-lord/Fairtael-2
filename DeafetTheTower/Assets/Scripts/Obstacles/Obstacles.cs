using Unity.VisualScripting;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    [SerializeField] protected bool shootThrough;
    [SerializeField] protected bool breakable;
    [SerializeField] protected float hp;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public void TakeDamage(float damage)
    {
      if (breakable)
        {
            hp -= damage;
            if (hp <= 0)
            {
                Death();
            }
        }
    }
    void Death()
    {
        Destroy(gameObject);
    }
}
