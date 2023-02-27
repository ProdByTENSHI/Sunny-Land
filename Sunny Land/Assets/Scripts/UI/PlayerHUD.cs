using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHUD : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_PointText;

    private void Start()
    {
        PlayerManager.onPointChange.AddListener(UpdatePointDisplay);
    }

    private void UpdatePointDisplay()
    {
        m_PointText.SetText(PlayerManager.GetHealth().ToString());
    }
}