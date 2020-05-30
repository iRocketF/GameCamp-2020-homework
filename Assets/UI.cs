using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{

    private string gameTime;
    private float roundTimer;
    [SerializeField]
    private TextMeshProUGUI roundText = null;
    [SerializeField]
    private TextMeshProUGUI info = null;
    [SerializeField]
    private TextMeshProUGUI gameOver = null;
    [SerializeField]
    private TextMeshProUGUI gameWin = null;

    int i = 1;

    // Start is called before the first frame update
    void Start()
    {
        gameOver.enabled = false;
        gameWin.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        roundTimer = roundTimer + Time.deltaTime;
        
        if(roundTimer >= i)
        {
            roundTimer = Mathf.Round(roundTimer);
            gameTime = "Time: " + roundTimer;
            roundText.text = gameTime;
            i++;
        }

        if(roundTimer >= 30)
        {
            gameWin.enabled = true;
        }
        
    }
}
