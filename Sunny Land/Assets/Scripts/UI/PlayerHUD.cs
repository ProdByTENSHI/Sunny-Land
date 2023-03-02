using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHUD : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_PointText;

    private void Update()
    {
        m_PointText.text = PlayerManager.points.ToString();
    }
}