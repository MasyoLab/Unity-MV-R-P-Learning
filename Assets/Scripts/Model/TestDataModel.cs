using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

namespace Game.Model
{
    public class TestDataModel : MonoBehaviour
    {
        private ReactiveProperty<int> _value = new ReactiveProperty<int>();
        public IObservable<int> Value => _value;

        // Start is called before the first frame update
        private void Start()
        {
            _value.Value = 0;
        }

        public void AddValue()
        {
            _value.Value++;
        }
    }
}
