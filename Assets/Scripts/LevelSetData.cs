using UnityEngine;


namespace ArtomStatsenko
{
    [CreateAssetMenu(fileName = "New LevelSetData", menuName = "Level Set Data")]
    public sealed class LevelSetData : ScriptableObject
    {
        [SerializeField] private LevelData[] _levelData;

        public LevelData[] LevelData => _levelData;
    }
}