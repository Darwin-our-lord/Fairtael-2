using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [Header("player stats")]
    [SerializeField] int maxHealth;
    [SerializeField] int currentHealth;

    #region "health stuff"
    public void TakeDamage(int dmg)
    {
        currentHealth -= dmg;
        if(currentHealth >= 0)
        {
            die();
        }

    }
    public void GainHealth(int heal)
    {
        currentHealth += heal;
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
    public void LoseMaxHealth(int dmg)
    {
        maxHealth -= dmg;
        if (maxHealth >= 0)
        {
            die();
        }
    }
    public void GainMaxHealth(int heal)
    {
        maxHealth += heal;
    }
    public void die()
    {
        Debug.Log("shi i died");
    }
    #endregion


}
