using UnityEngine;
using UnityEngine.UI;


namespace ArtomStatsenko
{
    public sealed class Spawner
    {
        private Button _button;
        private Canvas _canvas;
        private Image _image;
        private float _offsetDistance = 1.5f;

        public Spawner()
        {
            _canvas = Object.FindObjectOfType<Canvas>();
            _button = Resources.Load<Button>("Cell");

            //TODO set white background
            _image = _button.GetComponent<Image>();

            //if (!_button.TryGetComponent(out Image _image))
            //{
            //    throw new System.Exception($"Can not find {_image.GetType()} component...");
            //}
        }

        public void SpawnCells(CellData[] cellData, Vector2 cells)
        {
            var cellDataIndex = 0;

            for (var x = 0; x < cells.x; x++)
            {
                for (var y = 0; y < cells.y; y++)
                {
                    var position = new Vector3(y * _offsetDistance, x * _offsetDistance, 0f);
                    _image.sprite = cellData[cellDataIndex].Image;

                    Object.Instantiate(_button, position, Quaternion.identity, _canvas.transform);

                    cellDataIndex++;
                }
            }
        }
    }
}