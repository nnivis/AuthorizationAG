using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.UI
{
    public class LogOutPanel : MonoBehaviour
    {
        [SerializeField] private Button logOutButton;
        [SerializeField] private Image avatarImage;
        [SerializeField] private TextMeshProUGUI nameText;
        [SerializeField] private TextMeshProUGUI emailText;
        
        private void OnEnable() => logOutButton.onClick.AddListener(OnLogOutButton);

        private void OnDisable() => logOutButton.onClick.RemoveListener(OnLogOutButton);

        private void OnLogOutButton()
        {
            
        }

        private void UpdateUserInformation()
        {                                                             
            //update avatar  
            //update name
            //update email
        }
        
    }
}
