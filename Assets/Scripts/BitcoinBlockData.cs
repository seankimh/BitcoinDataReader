using System.Collections.Generic;

[System.Serializable]
public class BitcoinBlockData
{
    public string hash;
    public long time;
    public int block_index;
    public int height;
    public List<long> txIndexes;
}
