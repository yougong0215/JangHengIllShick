using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PartsInfoPanel : MonoBehaviour
{
    [SerializeField] private GameObject _partsPanel;
    public void SetPanel(Sprite image, string name, float atk, float def, string info)
    {
        GameObject panel = Instantiate(_partsPanel, GameObject.Find("BuildRobotContent").transform);

        Image img = panel.transform.Find("PartsImage").GetComponent<Image>();
        img.sprite = image;
        GameObject txtGroup = panel.transform.Find("TextGroup").gameObject;
        TextMeshProUGUI text = txtGroup.transform.Find("NameText").GetComponent<TextMeshProUGUI>();
        text.SetText(name);
        text = txtGroup.transform.Find("AtkText").GetComponent<TextMeshProUGUI>();
        text.SetText(atk.ToString());
        text = txtGroup.transform.Find("DefText").GetComponent<TextMeshProUGUI>();
        text.SetText(def.ToString());
        text = txtGroup.transform.Find("infoText").GetComponent<TextMeshProUGUI>();
        text.SetText(info);
    }
}
