using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICell : MonoBehaviour
{
    [SerializeField]
    Sprite mainTex;

    CellData cell;


    public void SetState(CellData _cell)
    {
        cell = _cell;

        switch(cell.cellValue)
        {
            case XO.NONE:

                break;
            case XO.X:

                break;
            case XO.O:

                break;
        }
    }


}
