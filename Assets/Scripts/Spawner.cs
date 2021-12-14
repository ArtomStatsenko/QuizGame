using UnityEngine;
using UnityEngine.UI;


namespace ArtomStatsenko
{
    public sealed class Spawner : MonoBehaviour
    {
        private Button _button;
        private Canvas _canvas;
        private float _offsetDistance = 1.4f;

        private void Awake()
        {
            _canvas = FindObjectOfType<Canvas>();
            _button = Resources.Load<Button>("Cell");
        }       

        public void SpawnCells(CellData[] cellData)
        {       
            //for (var x = 0; x < cells.x; x++)
            //{
            //    for (var y = 0; y < cells.y; y++)
            //    {
            //        var position = new Vector3(y * offsetDistance, x * offsetDistance, 0f);

            //        if (_button.TryGetComponent<Image>(out Image image))
            //        {
            //            image.sprite = cellData[cellDataIndex].Image;
            //        }

            //        Instantiate(_button, position, Quaternion.identity, _canvas.transform);

            //        cellDataIndex++;
            //    }
            //}
        }
    }
}