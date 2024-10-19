using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI xpText;

    [SerializeField] private TextMeshProUGUI lvlText;

    [SerializeField] private GameObject menu;

    private void Awake()
    {
        //Making sure we have all our variables set, that way it won't throw any errors;
        Assert.IsNotNull(xpText);
        Assert.IsNotNull(lvlText);
        Assert.IsNotNull(menu);
    }

    public void UpdateLevel(int level)
    {
        lvlText.text = level.ToString();
    }

    public void UpdatedXP(int currentXp, int requiredXp)
    {
        xpText.text = currentXp.ToString() + " / " + requiredXp.ToString();
    }

    public void ToggleMenu()
    {
        menu.SetActive(!menu.activeSelf);
    }

}
