using System;
using UnityEngine;


namespace ArtomStatsenko
{
    [Serializable]
    public sealed class CellData
    {
        [SerializeField] private string _name;
        [SerializeField] private Sprite _image;

        public string Name => _name;

        public Sprite Image => _image;
    }
}