using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int xp = 0;
    [SerializeField] private int requiredXP = 100;
    [SerializeField] private int levelBase = 100;
    [SerializeField] private List<GameObject> droids = new List<GameObject>();
    private int lvl = 1;

    public int Xp { get { return xp; } }
    public int RequiredXP {  get {  return requiredXP; } }
    public int LevelBase { get { return levelBase; } }
    public List<GameObject> Droids { get { return droids; } }

    private void Start()
    {
        InitLevelData();
    }
    public void AddXp(int xp)
    {
        this.xp = Mathf.Max(0, xp);
    }

    public void AddDroid(GameObject droid)
    {
        droids.Add(droid);
    }

    public void InitLevelData()
    {
        lvl = (xp / levelBase) + 1;
        requiredXP = levelBase * lvl;
    }


}
