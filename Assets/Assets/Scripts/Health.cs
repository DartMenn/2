using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _value = 100.0f;

    public float Value => _value;

    public void GetDamage(float damage)
    {
        _value -= damage;
        if (_value < 0)
        {
            Destroy(gameObject);
        }

    }
}