using Random = UnityEngine.Random;
using System.Collections.Generic;


namespace ArtomStatsenko
{
    public static class Extentions
    {
        public static CellData RandomCell(this CellData[] cellData) => cellData[Random.Range(0, cellData.Length)];

        public static CellData[] GetUniqCells(this CellData[] cellData, int uniqCellCount)
        {
            Dictionary<CellData, bool> found = new Dictionary<CellData, bool>();
            List<CellData> uniques = new List<CellData>();

            while(uniques.Count < uniqCellCount)
            {
                CellData cell = cellData.RandomCell();

                if (!found.ContainsKey(cell))
                {
                    found[cell] = true;
                    uniques.Add(cell);
                }
            }

            return uniques.ToArray();
        }
    }
}