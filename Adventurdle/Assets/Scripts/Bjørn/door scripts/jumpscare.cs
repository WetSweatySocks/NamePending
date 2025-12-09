using UnityEngine;

public class jumpscare : MonoBehaviour
{
    time time;

    public MeshRenderer jumpscarePrefab;
    void Start()
    {
        time = FindFirstObjectByType<time>();
        jumpscarePrefab.enabled = false;
    }

   void Update()
    {
        if (time.timer <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        print("YOU DEID");
        jumpscarePrefab.enabled = true;
    }
}
