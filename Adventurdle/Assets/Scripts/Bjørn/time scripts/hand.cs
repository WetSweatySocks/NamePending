using Unity.VisualScripting;
using UnityEngine;

public class hand : MonoBehaviour
{
    time time;
    [SerializeField] private Vector3 rotation;

    void Start()
    {
        time = FindFirstObjectByType<time>();
    }

    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, time.timer);
    }
}
