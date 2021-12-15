using UnityEngine;
using TMPro;


namespace ArtomStatsenko
{
    public sealed class TaskMessage : MonoBehaviour
    {
        private TextMeshProUGUI messageUI;

        private void Awake()
        {
            if (!TryGetComponent(out messageUI))
            {
                throw new System.Exception($"Can not find {messageUI.GetType()} component...");
            }
        }

        public void SetTaskMessage(CellData cell)
        {
            messageUI.text = $"Find {cell.Name}";
        }
    }
}