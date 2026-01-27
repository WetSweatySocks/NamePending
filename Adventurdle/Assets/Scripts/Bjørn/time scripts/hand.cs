using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class hand : MonoBehaviour
{
    time time;
    [SerializeField] private Vector3 rotation;

    watch watch;
    public int offset = 50;
    public int offsetx = -7;

    void Start()
    {
        time = FindFirstObjectByType<time>();

        watch = FindFirstObjectByType<watch>();
    }

    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, time.timer);

        transform.position = watch.transform.position + new Vector3(offsetx,offset,0);
    }
}
