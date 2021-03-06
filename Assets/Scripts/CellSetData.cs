using UnityEngine;


namespace ArtomStatsenko
{
    [CreateAssetMenu(fileName = "New CellSetData", menuName = "Cell Set Data")]
    public sealed class CellSetData : ScriptableObject
    {
        [SerializeField] private CellData[] _cellData;

        public CellData[] CellData => _cellData;
    }
}