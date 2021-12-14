using Random = UnityEngine.Random;


namespace ArtomStatsenko
{
    public static class Extentions
    {
        //TODO add condition "if value does not repeat"
        public static CellData RandomCell(this CellData[] cellData) => cellData[Random.Range(0, cellData.Length)];        
    }
}