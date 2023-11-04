using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

namespace Game.View
{
    public class TestView : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI _textMeshProUGUI = null;
        [SerializeField]
        private Button _button = null;

        private UnityEvent _onClick = new UnityEvent();
        public UnityEvent OnClick => _onClick;

        private void Awake()
        {
            _button.onClick.AddListener(OnButtoin);
        }

        public void SetValue(int value)
        {
            _textMeshProUGUI.text = value.ToString();
        }

        private void OnButtoin()
        {
            _onClick?.Invoke();
        }
    }
}
