using UnityEngine;

public class UserInfoManager : Singleton<UserInfoManager>
{
    public string userName;
    public Sprite[] userProfileImage;

    [HideInInspector] public int currentIndex = 0;
    
    private void Start()
    {
        currentIndex = 0;
        
    }

    public void GetUserProfileIndex(int index)
    {
        currentIndex = index;
    }

    public void GetUserName(string name)
    {
        userName = name;
    }

    public void InitUserName()
    {
        userName = null; 
    }
}
