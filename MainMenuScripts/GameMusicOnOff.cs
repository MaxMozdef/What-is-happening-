using UnityEngine;

public class GameMusicOnOff : MonoBehaviour
{
    [SerializeField] private AudioSource audioSourceInGame;
    [SerializeField] private Collider2D colliderMusic;
    [SerializeField] private GameObject musicButton;
    [SerializeField] private Sprite spriteMusicOff, spriteMusicOn;
    [SerializeField] private bool musicIsPlay;
    private static int chekForSavePlayMusic;

    private void Start()
    {
        musicIsPlay = true;
        chekForSavePlayMusic = PlayerPrefs.GetInt("cfspm");
        StartMusicConfiguration();
    }

    private void Update()
    {
        Debug.Log(chekForSavePlayMusic);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == colliderMusic && musicIsPlay == true && chekForSavePlayMusic == 1)
        {
            WhenOn();
            chekForSavePlayMusic = 0;
            PlayerPrefs.SetInt("cfspm", chekForSavePlayMusic);
            return;
        }
        if (musicIsPlay == false && collision == colliderMusic && chekForSavePlayMusic == 0)
        {
            WhenOff();
            chekForSavePlayMusic = 1;
            PlayerPrefs.SetInt("cfspm", chekForSavePlayMusic);
        }
        Debug.Log(chekForSavePlayMusic);
    }

    private void StartMusicConfiguration()
    {
        if (chekForSavePlayMusic == 0)
        {
            WhenOn();
        }
        if (chekForSavePlayMusic == 1)
        {
            WhenOff();
        }
    }

    private void WhenOn()
    {
        audioSourceInGame.volume = 0;
        musicButton.GetComponent<SpriteRenderer>().sprite = spriteMusicOn;
        musicIsPlay = false;
    }
    private void WhenOff()
    {
        audioSourceInGame.volume = 0.269f;
        musicButton.GetComponent<SpriteRenderer>().sprite = spriteMusicOff;
        musicIsPlay = true;
    }
}
