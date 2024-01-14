using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

namespace DesignPatterns.Bridge
{
    public class BridgePattenSample : MonoBehaviour
    {
        void Start()
        {
            Weapons weapons = new Weapons("Gun");

            weapons.Data = new WeaponsData();

            weapons.Show();
            weapons.Next();
            weapons.Show();
            weapons.Next();
            weapons.Show();
            weapons.Add("AWP");

            weapons.ShowAll();
        }
    }

    class WeaponBase
    {
        private string name;
        private DataObject _dataObject;

        public WeaponBase(string name)
        {
            this.name = name;
        }

        public DataObject Data
        {
            set { _dataObject = value; }
            get { return _dataObject; }
        }

        public virtual void Next()
        {
            _dataObject.NextProp();
        }

        public virtual void Prior()
        {
            _dataObject.PriorProp();
        }

        public virtual void Add(string name)
        {
            _dataObject.AddProp(name);
        }

        public virtual void Remove(string name)
        {
            _dataObject.DeleteProp(name);
        }

        public virtual void Show()
        {
            _dataObject.ShowProp();
        }

        public virtual void ShowAll()
        {
            Debug.Log("Weapon name :" + name);
            _dataObject.ShowAllProp();
        }
    }

    class Weapons : WeaponBase
    {
        public Weapons(string name) : base(name) { }

        public override void ShowAll()
        {
            Debug.Log("------------------------");
            base.ShowAll();
            Debug.Log("------------------------");
        }
    }

    abstract class DataObject
    {
        public abstract void NextProp();
        public abstract void PriorProp();
        public abstract void AddProp(string name);
        public abstract void DeleteProp(string name);
        public abstract void ShowProp();
        public abstract void ShowAllProp();
    }

    class WeaponsData : DataObject
    {
        private List<string> _weapons = new List<string>();
        private int _current = 0;

        public WeaponsData()
        {
            _weapons.Add("K1");
            _weapons.Add("K2");
            _weapons.Add("AK-47");
            _weapons.Add("G36K");
            _weapons.Add("Glock");
        }
        public override void NextProp()
        {
            if (_current <= _weapons.Count - 1)
            {
                _current++;
            }
        }

        public override void PriorProp()
        {
            if(_current > 0)
            {
                _current--;
            }
        }

        public override void AddProp(string name)
        {
            _weapons.Add(name);
        }

        public override void DeleteProp(string name)
        {
            _weapons.Remove(name);
        }

        public override void ShowProp()
        {
            Debug.Log(_weapons[_current]);
        }

        public override void ShowAllProp()
        {
            foreach (var weapon in _weapons)
            {
                Debug.Log(" " + weapon);
            }
        }
    }
}
