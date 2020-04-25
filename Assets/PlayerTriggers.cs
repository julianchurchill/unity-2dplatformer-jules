using UnityEngine;

public class PlayerTriggers : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);
        }
    }
}
