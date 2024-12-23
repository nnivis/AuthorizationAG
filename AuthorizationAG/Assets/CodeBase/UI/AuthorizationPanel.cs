using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.UI
{
    public class AuthorizationPanel : MonoBehaviour
    {
        [SerializeField] private Button authorizationButton;

        private void OnEnable() => authorizationButton.onClick.AddListener(OnAuthorizationButton);

        private void OnDisable() => authorizationButton.onClick.RemoveListener(OnAuthorizationButton);

        private void OnAuthorizationButton()
        {
            
        }
    }
}