using System;
using UnityEngine;


namespace ArtomStatsenko
{
    //Delete monobehaviour
    public sealed class TaskCreator : MonoBehaviour
    {
        private Spawner _spawner;

        [SerializeField] CellSetData _cellSetData;
        [SerializeField] LevelSetData _levelSetData;

        private void Awake()
        {
            if (_cellSetData == null)
            {
                throw new Exception("Cell Set Data is missing...");
            }

            if (_levelSetData == null)
            {
                throw new Exception("Level Set Data is missing...");
            }

            _spawner = new Spawner();
        }

        private void Start()
        {
            CellData[] cellData = new CellData[3];

            cellData[0] = cellData.RandomCell();
            cellData[1] = cellData.RandomCell();
            cellData[2] = cellData.RandomCell();

            _spawner.SpawnCells(cellData);
        }
    }
}