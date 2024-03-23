using UnityEngine;

public class Fireball : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _lifeTime;
    [SerializeField] private float _damage = 10.0f;

    public void DestroyFireball()
    {
        Destroy(gameObject);
    }

    private void Start()
    {
        Invoke(nameof(DestroyFireball), _lifeTime);
    }

    private void FixedUpdate()
    {
        MoveFixedUpdate();
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.gameObject;
        if (other.TryGetComponent(out Health health) && !other.TryGetComponent(out PlayerController _))
        {
            ApplyDamage(health);
            DestroyFireball();
        }
    }

    private void ApplyDamage(Health health)
    {
        health.GetDamage(_damage);
    }

    private void MoveFixedUpdate()
    {
        transform.position += _speed * Time.fixedDeltaTime * transform.forward;
    }
}
