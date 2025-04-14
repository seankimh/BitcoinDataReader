using UnityEngine;

public class CoinClick : MonoBehaviour
{
    public long transactionIndex;

    void OnMouseDown()
    {
        Debug.Log("You clicked a coin! TX Index: " + transactionIndex);
    }
}
