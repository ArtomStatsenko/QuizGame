using UnityEngine;


namespace ArtomStatsenko
{
    //TODO delete monobehaviour
    public sealed class TaskCreator : MonoBehaviour
    {
        [SerializeField] private CellSetData _cellSetData;
        [SerializeField] private LevelSetData _levelSetData;

        private Spawner _spawner;
        private TaskMessage _taskMessage;
        private LevelData[] _levelData;
        private CellData[] _cellData;

        private void Awake()
        {
            _spawner = new Spawner();
            _taskMessage = FindObjectOfType<TaskMessage>();

            if (_cellSetData == null)
            {
                throw new System.Exception("Cell Set Data is missing...");
            }

            if (_levelSetData == null)
            {
                throw new System.Exception("Level Set Data is missing...");
            }

            _levelData = _levelSetData.LevelData;
            _cellData = _cellSetData.CellData;
        }

        private void Start()
        {
            CreateNewTask(Diffuculty.Hard);
        }

        public void CreateNewTask(Diffuculty difficulty)
        {
            Vector2 levelCells;

            switch (difficulty)
            {
                case Diffuculty.Easy:
                    levelCells = _levelData[0].Cells;
                    break;
                case Diffuculty.Medium:
                    levelCells = _levelData[1].Cells;
                    break;
                case Diffuculty.Hard:
                    levelCells = _levelData[2].Cells;
                    break;
                default:
                    return;
            }

            int cellsNumber = (int)levelCells.x * (int)levelCells.y;
            CellData[] cellData = new CellData[cellsNumber];

            for (var i = 0; i < cellsNumber; i++)
            {
                cellData[i] = _cellData.RandomCell();
            }

            _spawner.SpawnCells(cellData, levelCells);

            var randomCell = cellData.RandomCell();
            _taskMessage.ChangeTaskMessage(randomCell);
        }
    }
}