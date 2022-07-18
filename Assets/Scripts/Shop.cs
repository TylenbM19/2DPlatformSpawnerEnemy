using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private List<Weapons> _weapons;
    [SerializeField] private Player _player;
    [SerializeField] private WeaponView _template;
    [SerializeField] private GameObject _itemContainer;

    private void Start()
    {
        for(int i = 0; i < _weapons.Count; i++)
        {
            AddItem(_weapons[i]);
        }
    }

    private void AddItem(Weapons weapon)
    {
        var view = Instantiate(_template,_itemContainer.transform);
        view.SellButtinClick += OnSellButtonClick;
        view.Render(weapon);
    }

    private void OnSellButtonClick(Weapons weapon,WeaponView view)
    {
        TrySellWeapon(weapon, view);
    }

    private void TrySellWeapon(Weapons weapon, WeaponView view)
    {
        if(weapon.Price <= _player.Money)
        {
            _player.BuyWeapon(weapon);
            weapon.Buy();
            view.SellButtinClick -= OnSellButtonClick;
        }
    }
}
  
