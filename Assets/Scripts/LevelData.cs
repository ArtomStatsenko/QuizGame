using UnityEngine;
using System;


namespace ArtomStatsenko
{
    [Serializable]
    public sealed class LevelData
    {
        [SerializeField] private int _levelNumber;
        [SerializeField] private Vector2 _cells;

        public int LevelNumber => _levelNumber;

        public Vector2 Cells => _cells;
    }
}