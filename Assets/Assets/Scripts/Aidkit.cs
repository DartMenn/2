using UnityEngine;

public class Aidkit : MonoBehaviour
{
    public float healAmount = 50;

    private void OnTriggerEnter(Collider other)
    {
        var playerHealth = other.gameObject.GetComponent<Health>();
        if (playerHealth != null )
        {
            //playerHealth.AddHealth(healAmount);
        }
    }

    
}
