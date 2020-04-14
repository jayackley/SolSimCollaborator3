using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

	public GameObject thumps;
	public GameObject bass;
    public GameObject bleepMajor;
    public GameObject bleepMinor;
    public GameObject majorArp;
    public GameObject minorArp;
    public GameObject chaos;
    public GameObject undertone;
    public GameObject spaceSound;
    public GameObject fluteLead;
    public GameObject boardMusic1;
    public GameObject boardMusic2;
    public GameObject boardMusic3;
    public GameObject boardMusic4;
    public GameObject sceneManager;
    public GameObject solidarityManager;
    public GameObject boardManager;
    public float maxVolume;
    public float fadeInSpeed;
    public float startingVolume;
    

    void Start () 
    {
        thumps.GetComponent<AudioSource>().volume = startingVolume;
        bass.GetComponent<AudioSource>().volume = startingVolume;
        bleepMajor.GetComponent<AudioSource>().volume = startingVolume;
        bleepMinor.GetComponent<AudioSource>().volume = startingVolume;
        majorArp.GetComponent<AudioSource>().volume = startingVolume;
        minorArp.GetComponent<AudioSource>().volume = startingVolume;
        chaos.GetComponent<AudioSource>().volume = startingVolume;
        undertone.GetComponent<AudioSource>().volume = startingVolume;
        spaceSound.GetComponent<AudioSource>().volume = startingVolume;
        boardMusic1.GetComponent<AudioSource>().volume = startingVolume;
        boardMusic2.GetComponent<AudioSource>().volume = startingVolume;
        boardMusic3.GetComponent<AudioSource>().volume = startingVolume;
        boardMusic4.GetComponent<AudioSource>().volume = startingVolume;

    }
	
	// Update is called once per frame
	void Update () 
    {
        if (sceneManager.GetComponent<SceneManager>().convoCounter >= 0)
        {
            if (thumps.GetComponent<AudioSource>().volume < maxVolume)
            {
                thumps.GetComponent<AudioSource>().volume += fadeInSpeed * Time.deltaTime;
            }
        }

        if (sceneManager.GetComponent<SceneManager>().convoCounter >= 1)
        {
            if (spaceSound.GetComponent<AudioSource>().volume < maxVolume)
            {
                spaceSound.GetComponent<AudioSource>().volume += fadeInSpeed * Time.deltaTime;
            }
        }

        if (sceneManager.GetComponent<SceneManager>().convoCounter >= 2 && solidarityManager.GetComponent<SolidarityManager>().solidarity >= 0)
        {
            if (bleepMajor.GetComponent<AudioSource>().volume < maxVolume)
            {
                bleepMajor.GetComponent<AudioSource>().volume += fadeInSpeed * Time.deltaTime;
            }

        }

        else if (solidarityManager.GetComponent<SolidarityManager>().solidarity < 0)
        {
            if (bleepMajor.GetComponent<AudioSource>().volume > 0)
            {
                bleepMajor.GetComponent<AudioSource>().volume -= fadeInSpeed * Time.deltaTime;
            }
        }

        if (sceneManager.GetComponent<SceneManager>().convoCounter >= 2 && solidarityManager.GetComponent<SolidarityManager>().solidarity < 0)
        {
            if (bleepMinor.GetComponent<AudioSource>().volume < maxVolume)
            {
                bleepMinor.GetComponent<AudioSource>().volume += fadeInSpeed * Time.deltaTime;
            }
        }

        else if (solidarityManager.GetComponent<SolidarityManager>().solidarity >= 0)
        {
            if (bleepMinor.GetComponent<AudioSource>().volume > 0)
            {
                bleepMinor.GetComponent<AudioSource>().volume -= fadeInSpeed * Time.deltaTime;
            }
        }


        if (sceneManager.GetComponent<SceneManager>().convoCounter >= 3)
        {
            if (undertone.GetComponent<AudioSource>().volume < maxVolume)
            {
                undertone.GetComponent<AudioSource>().volume += fadeInSpeed * Time.deltaTime;
            }
        }
        
        if (sceneManager.GetComponent<SceneManager>().convoCounter >= 4 && solidarityManager.GetComponent<SolidarityManager>().solidarity >= 0)
        {
            if (majorArp.GetComponent<AudioSource>().volume < maxVolume)
            {
                majorArp.GetComponent<AudioSource>().volume += fadeInSpeed * Time.deltaTime;
            }
        }

        else if (solidarityManager.GetComponent<SolidarityManager>().solidarity < 0)
        {
            if (majorArp.GetComponent<AudioSource>().volume > 0)
            {
                majorArp.GetComponent<AudioSource>().volume -= fadeInSpeed * Time.deltaTime;
            }
        }

        if (sceneManager.GetComponent<SceneManager>().convoCounter >= 4 && solidarityManager.GetComponent<SolidarityManager>().solidarity < 0)
        {
            if (minorArp.GetComponent<AudioSource>().volume < maxVolume)
            {
                minorArp.GetComponent<AudioSource>().volume += fadeInSpeed * Time.deltaTime;
            }
        }

        else if (solidarityManager.GetComponent<SolidarityManager>().solidarity >= 0)
        {
            if (minorArp.GetComponent<AudioSource>().volume > 0)
            {
                minorArp.GetComponent<AudioSource>().volume -= fadeInSpeed * Time.deltaTime;
            }
        }

        if (sceneManager.GetComponent<SceneManager>().convoCounter >= 5)
        {
            if (bass.GetComponent<AudioSource>().volume < maxVolume)
            {
                bass.GetComponent<AudioSource>().volume += fadeInSpeed * Time.deltaTime;
            }
        }
        if (sceneManager.GetComponent<SceneManager>().convoCounter >= 6)
        {
            if (chaos.GetComponent<AudioSource>().volume < maxVolume)
            {
                chaos.GetComponent<AudioSource>().volume += fadeInSpeed * Time.deltaTime;
            }
        }

        if (sceneManager.GetComponent<SceneManager>().convoCounter >= 7)
        {
            if (fluteLead.GetComponent<AudioSource>().volume < maxVolume)
            {
                fluteLead.GetComponent<AudioSource>().volume += fadeInSpeed * Time.deltaTime;
            }
        }

        if (sceneManager.GetComponent<SceneManager>().convoCounter == 9 || sceneManager.GetComponent<SceneManager>().convoCounter == 10 || sceneManager.GetComponent<SceneManager>().convoCounter == 11)
        {
            fluteLead.GetComponent<AudioSource>().volume =0;
            thumps.GetComponent<AudioSource>().volume =0;
            bass.GetComponent<AudioSource>().volume =0;
            bleepMajor.GetComponent<AudioSource>().volume =0;
            bleepMinor.GetComponent<AudioSource>().volume =0;
            majorArp.GetComponent<AudioSource>().volume =0;
            minorArp.GetComponent<AudioSource>().volume =0;
            chaos.GetComponent<AudioSource>().volume =0;
            undertone.GetComponent<AudioSource>().volume =0;
            spaceSound.GetComponent<AudioSource>().volume = 0;
            if (boardMusic1.GetComponent<AudioSource>().volume < maxVolume)
            {
                boardMusic1.GetComponent<AudioSource>().volume += fadeInSpeed * Time.deltaTime;
            }
        
        }
        if (sceneManager.GetComponent<SceneManager>().convoCounter == 11 && (boardManager.GetComponent<BoardManager>().index >= 8 && boardManager.GetComponent<BoardManager>().index <= 12))
        {
            fluteLead.GetComponent<AudioSource>().volume = 0;
            thumps.GetComponent<AudioSource>().volume = 0;
            bass.GetComponent<AudioSource>().volume = 0;
            bleepMajor.GetComponent<AudioSource>().volume = 0;
            bleepMinor.GetComponent<AudioSource>().volume = 0;
            majorArp.GetComponent<AudioSource>().volume = 0;
            minorArp.GetComponent<AudioSource>().volume = 0;
            chaos.GetComponent<AudioSource>().volume = 0;
            undertone.GetComponent<AudioSource>().volume = 0;
            spaceSound.GetComponent<AudioSource>().volume = 0;
            if (boardMusic1.GetComponent<AudioSource>().volume > startingVolume)
            {
                boardMusic1.GetComponent<AudioSource>().volume -= fadeInSpeed * Time.deltaTime;
            }
            if (boardMusic2.GetComponent<AudioSource>().volume < maxVolume)
            {
                boardMusic2.GetComponent<AudioSource>().volume += fadeInSpeed * Time.deltaTime;
            }
        }
        if (sceneManager.GetComponent<SceneManager>().convoCounter == 11 && (boardManager.GetComponent<BoardManager>().index >= 13 && boardManager.GetComponent<BoardManager>().index <= 17))
        {
            fluteLead.GetComponent<AudioSource>().volume = 0;
            thumps.GetComponent<AudioSource>().volume = 0;
            bass.GetComponent<AudioSource>().volume = 0;
            bleepMajor.GetComponent<AudioSource>().volume = 0;
            bleepMinor.GetComponent<AudioSource>().volume = 0;
            majorArp.GetComponent<AudioSource>().volume = 0;
            minorArp.GetComponent<AudioSource>().volume = 0;
            chaos.GetComponent<AudioSource>().volume = 0;
            undertone.GetComponent<AudioSource>().volume = 0;
            spaceSound.GetComponent<AudioSource>().volume = 0;
            if (boardMusic2.GetComponent<AudioSource>().volume > startingVolume)
            {
                boardMusic2.GetComponent<AudioSource>().volume -= fadeInSpeed * Time.deltaTime;
            }
            if (boardMusic3.GetComponent<AudioSource>().volume < maxVolume)
            {
                boardMusic3.GetComponent<AudioSource>().volume += fadeInSpeed * Time.deltaTime;
            }
        }
        if (sceneManager.GetComponent<SceneManager>().convoCounter == 11 && boardManager.GetComponent<BoardManager>().index >= 18)
        {
            fluteLead.GetComponent<AudioSource>().volume = 0;
            thumps.GetComponent<AudioSource>().volume = 0;
            bass.GetComponent<AudioSource>().volume = 0;
            bleepMajor.GetComponent<AudioSource>().volume = 0;
            bleepMinor.GetComponent<AudioSource>().volume = 0;
            majorArp.GetComponent<AudioSource>().volume = 0;
            minorArp.GetComponent<AudioSource>().volume = 0;
            chaos.GetComponent<AudioSource>().volume = 0;
            undertone.GetComponent<AudioSource>().volume = 0;
            spaceSound.GetComponent<AudioSource>().volume = 0;
            if (boardMusic3.GetComponent<AudioSource>().volume > startingVolume)
            {
                boardMusic3.GetComponent<AudioSource>().volume -= fadeInSpeed * Time.deltaTime;
            }
            if (boardMusic4.GetComponent<AudioSource>().volume < maxVolume)
            {
                boardMusic4.GetComponent<AudioSource>().volume += fadeInSpeed * Time.deltaTime;
            }
        }
    }
}




