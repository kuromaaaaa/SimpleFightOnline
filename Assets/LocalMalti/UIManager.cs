using UnityEngine;
using UnityEngine.UI;

public class UIManager : SingletonMonoBehaviour<UIManager>
{
    [SerializeField]
    Text _textHp1;
    public Text hp1
    {
        get => _textHp1;
        set {_textHp1 = value; }
    }
    [SerializeField]
    Text _textHp2;
    public Text hp2
    {
        get => _textHp2;
        set { _textHp2 = value; }
    }
}
