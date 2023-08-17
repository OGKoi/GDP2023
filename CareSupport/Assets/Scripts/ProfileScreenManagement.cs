using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Firebase;
using Firebase.Auth;
using System.Threading.Tasks;

public class ProfileScreenManagement : MonoBehaviour
{
    public DependencyStatus dependencyStatus;
    public FirebaseAuth auth;
    public FirebaseUser user;
    public Text usernameDisplay;
    public Text emailDisplay;
    public GameObject emailresetScreen;
    public InputField newEmailInput;
    public GameObject passwordresetScreen;
    public InputField newPasswordInput;
    public InputField newPasswordConfirmInput;

    void Awake()
    {
        //Check that all of the necessary dependencies for Firebase are present on the system
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            dependencyStatus = task.Result;
            if (dependencyStatus == DependencyStatus.Available)
            {
                //If they are avalible Initialize Firebase
                InitializeFirebase();
            }
            else
            {
                Debug.LogError("Could not resolve all Firebase dependencies: " + dependencyStatus);
            }
        });
    }
    private void InitializeFirebase()
    {
        auth = FirebaseAuth.DefaultInstance;
        auth.StateChanged += AuthStateChanged;
        AuthStateChanged(this, null);
    }

    public void AuthStateChanged(object sender, System.EventArgs eventArgs)
    {
        if (auth.CurrentUser != user)
        {
            bool signedIn = user != auth.CurrentUser && auth.CurrentUser != null && auth.CurrentUser.IsValid();
            if (!signedIn && user != null)
            {
                Debug.Log("Signed out " + user.UserId);
            }
            user = auth.CurrentUser;
            if (signedIn)
            {
                Debug.Log("Signed in " + user.DisplayName + " " + user.Email);
                usernameDisplay.text = user.DisplayName.ToString();
                emailDisplay.text = user.Email.ToString();
            }
        }

    }

    void OnDestroy()
    {
        auth.StateChanged -= AuthStateChanged;
        auth = null;
    }









    public void openEmailResetScreen()
    {
        emailresetScreen.SetActive(true);
    }
    
    public void closeEmailResetScreen()
    {
        emailresetScreen.SetActive(false);
    }
    public void changeEmail()
    {
        Firebase.Auth.FirebaseUser user = auth.CurrentUser;
        if (user != null)
        {
            user.UpdateEmailAsync(newEmailInput.text).ContinueWith(task => {
                if (task.IsCanceled)
                {
                    Debug.LogError("UpdateEmailAsync was canceled.");
                    return;
                }
                if (task.IsFaulted)
                {
                    Debug.LogError("UpdateEmailAsync encountered an error: " + task.Exception);
                    return;
                }

                Debug.Log("User email updated successfully.");
            });
        }
    }
    
    public void openPWResetScreen()
    {
        passwordresetScreen.SetActive(true);
    }

    public void closePWResetScreen()
    {
        passwordresetScreen.SetActive(false);
    }
    
    public void changePassword()
    {
        Firebase.Auth.FirebaseUser user = auth.CurrentUser;
        if (newPasswordInput == newPasswordConfirmInput)
        {
            string newPassword = newPasswordInput.text;
            if (user != null)
            {
                user.UpdatePasswordAsync(newPassword).ContinueWith(task => {
                    if (task.IsCanceled)
                    {
                        Debug.LogError("UpdatePasswordAsync was canceled.");
                        return;
                    }
                    if (task.IsFaulted)
                    {
                        Debug.LogError("UpdatePasswordAsync encountered an error: " + task.Exception);
                        return;
                    }

                    Debug.Log("Password updated successfully.");
                });
            }
        }
       
    }











    public void SignOut()
    {
        auth.SignOut();
        SceneManager.LoadScene(0);
    }
    
}

        