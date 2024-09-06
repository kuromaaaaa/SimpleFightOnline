using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour
{
    int _hp = 1000;
    Text _hpText;
    private void Start()
    {
        _hpText = MultiManager.Instance.SetPlayer(this.gameObject);
        _hpText.text = _hp.ToString();
    }
    public void Damage(int x)
    {
        _hp -= x;
        _hpText.text = _hp.ToString();
        Debug.Log($"イテ！ {x}ダメージ受けた！");
    }
}
