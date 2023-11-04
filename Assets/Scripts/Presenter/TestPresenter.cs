using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Game.Model;
using Game.View;

namespace Game.Presenter
{
    public class TestPresenter : MonoBehaviour
    {
        [SerializeField]
        private TestDataModel _testDataModel = null;
        [SerializeField]
        private TestView _testView = null;

        private void Awake()
        {
            // Model -> View
            _testDataModel.Value.Subscribe((value) =>
            {
                _testView.SetValue(value);
            }).AddTo(this);

            // View -> Model
            _testView.OnClick.AddListener(() =>
            {
                _testDataModel.AddValue();
            });
        }
    }
}
