using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.ChangeScore(coinValue);
        }
    }
}
