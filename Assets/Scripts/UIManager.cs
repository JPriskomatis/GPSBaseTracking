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

    private void Update()
    {
        UpdateLevel();
        UpdateXP();
    }

    public void UpdateLevel()
    {
        lvlText.text = GameManager.Instance.CurrentPlayer.Lvl.ToString();
    }

    public void UpdateXP()
    {
        xpText.text = GameManager.Instance.CurrentPlayer.Xp + " / " + GameManager.Instance.CurrentPlayer.RequiredXP;
    }

    public void ToggleMenu()
    {
        menu.SetActive(!menu.activeSelf);
    }

}
