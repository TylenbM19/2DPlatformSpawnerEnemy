using UnityEngine;

public abstract class Weapons : MonoBehaviour
{
    [SerializeField] private int _price;
    [SerializeField] private string _label;
    [SerializeField] private Sprite _icon;
    [SerializeField] private bool _isBuyed = false;

    [SerializeField] protected Arrow Arrow;

    public string Label => _label;
    public int Price => _price;
    public Sprite Icon => _icon;

    public bool IsBuyed => _isBuyed;

    public abstract void Shoot(Transform shooPoint);

    public void Buy()
    {
        _isBuyed = true;
    }
}
