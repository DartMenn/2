using UnityEngine;

public class Destroy : MonoBehaviour
{
    private Health _healts;

    private void Start()
    {
        _healts= GetComponent<Health>();
        
    }

    private void Update()
    {
        if (_healts.Value <=0) 
        {
            Destroy(gameObject);
        }
    }
}
