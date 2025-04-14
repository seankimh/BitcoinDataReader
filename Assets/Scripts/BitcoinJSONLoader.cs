using UnityEngine;
using System.IO;

public class BitcoinJSONLoader : MonoBehaviour
{
    public TextAsset jsonFile;
    public BitcoinBlockSO bitcoinBlockSO;

    void Start()
    {
        if (jsonFile != null && bitcoinBlockSO != null)
        {
            BitcoinBlockData data = JsonUtility.FromJson<BitcoinBlockData>(jsonFile.text);
            bitcoinBlockSO.blockData = data;

            Debug.Log("Block Height: " + bitcoinBlockSO.blockData.height);
            Debug.Log("First Transaction Index: " + bitcoinBlockSO.blockData.txIndexes[0]);
        }
    }
}
