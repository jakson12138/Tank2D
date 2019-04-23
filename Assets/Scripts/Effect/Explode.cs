using UnityEngine;

public class Explode : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 0.2f);
    }
}