using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameReset : MonoBehaviour
{
    public static GameReset Instance;
    public List<Player> allPlayers;
    public Team kzTeam;
    public Team ukrTeam;
    public TMP_Text KZTeamScoreText;
    public TMP_Text UKRTeamScoreText;
    
    
    
    private void Awake()    
    {
        if (Instance == null)
            Instance = this;
        else 
            Destroy(gameObject);
    }

    private void Update()
    {
        KeepScore();
    }
     
    public IEnumerator ResetScene()
    {
        yield return new WaitForSeconds(1f);
        Ball.Instance.ResetPosition();
        foreach (Player player in allPlayers)
        {
            player.ResetPosition();
        }
    }
    

        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public void KeepScore()
    {
        KZTeamScoreText.text = $"KZ: {kzTeam.score}";
        UKRTeamScoreText.text = $"UKR: {ukrTeam.score}";
    }
}
