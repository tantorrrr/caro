using System;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : BaseSingleton<SkinManager>
{
    [SerializeField]
    List<SkinItem> listSkin = new List<SkinItem>();
    public List<SkinItem> ListSkin { get { return listSkin; }}

    private int currentIndex = 0;
    public SkinItem CurrentSkin { get; private set; }

    public void NextSkin()
    {
        if(listSkin.Count > 0)
        {
            currentIndex++;

            if (currentIndex >= listSkin.Count)
            {
                currentIndex = 0;
            }

            CurrentSkin = listSkin[currentIndex];
        }
    }
}

[Serializable]
public class SkinItem
{
    [SerializeField]
    public Sprite X;
    [SerializeField]
    public Sprite O;
    [SerializeField]
    public Sprite None;
}