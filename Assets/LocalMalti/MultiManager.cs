using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiManager : SingletonMonoBehaviour<MultiManager>
{
    
    GameObject _player1;
    GameObject _player2;
    public Text SetPlayer(GameObject p) 
    {
        if(!_player1)
        {
            _player1 = p;
            return UIManager.Instance.hp1;
        }
        else
        {
            _player2 = p;
            return UIManager.Instance.hp2;
        }
    }

}
