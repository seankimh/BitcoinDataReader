using UnityEngine;

public class BitcoinCoinSpawner : MonoBehaviour
{
    public BitcoinBlockSO bitcoinData;
    public GameObject coinPrefab;

    public int maxCoinsToSpawn = 50;
    public float spacing = 2f;
    public int gridWidth = 10;

    void Start()
    {
        int count = 0;

        foreach (var tx in bitcoinData.blockData.txIndexes)
        {
            if (count >= maxCoinsToSpawn) break;

            int x = count % gridWidth;
            int z = count / gridWidth;
            Vector3 pos = new Vector3(x * spacing, 0.5f, z * spacing);

            GameObject coin = Instantiate(coinPrefab, pos, Quaternion.identity);

            CoinClick clickScript = coin.GetComponent<CoinClick>();
            if (clickScript != null)
            {
                clickScript.transactionIndex = tx;
            }

            count++;
        }
    }
}
