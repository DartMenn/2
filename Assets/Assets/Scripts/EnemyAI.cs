using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private PlayerController _player;
    [SerializeField] private float _damage = 5.0f;
    private NavMeshAgent _navMeshAgent;

    private void Start()
    {
        InitComponentLink();
    }

    private void AttackUpdate()
    {
        if (_navMeshAgent.remainingDistance <= _navMeshAgent.stoppingDistance)
        {
            _player.GetComponent<Health>().GetDamage(_damage * Time.deltaTime);
        }
    }

    private void Update()
    {
        if (_player != null)
        {
            AttackUpdate();
            _navMeshAgent.destination = _player.transform.position;
        }
    }

    private void InitComponentLink()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    //Спавн 
    public void InitPlayerReference(PlayerController playerController)
    {
        _player = playerController;
    }
}
