using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour {

    public string whosFocus;
    public string scene;
    public GameObject pcCam;
    public GameObject wrenchCam;
    public GameObject tempCam;
    public GameObject welderCam;
    public GameObject bigguyCam;
    public GameObject dataCam;
    public GameObject accountingCam;
    public GameObject managerCam;
    public GameObject orbCam;
    public GameObject corporateCam;
    public GameObject boardWrenchCam;
    public GameObject boardTempCam;
    public GameObject boardWelderCam;
    public GameObject boardbigguyCam;
    public GameObject boardDataCam;
    public GameObject boardAccountingCam;
    public GameObject boardManagerCam;
    public GameObject boardScriptObject;
    public GameObject strikePongCamera;
	
	void Start ()
    {
        whosFocus = "pc";
        scene = "walkaround";
	}

    private void OnGUI()
    {
        if (Event.current.Equals(Event.KeyboardEvent("0")))
        {
            whosFocus = "pc";
        }
        if (Event.current.Equals(Event.KeyboardEvent("1")))
        {
            whosFocus = "wrench";
        }
        if (Event.current.Equals(Event.KeyboardEvent("2")))
        {
            whosFocus = "temp";
        }
        if (Event.current.Equals(Event.KeyboardEvent("3")))
        {
            whosFocus = "welder";
        }
        if (Event.current.Equals(Event.KeyboardEvent("4")))
        {
            whosFocus = "bigguy";
        }
        if (Event.current.Equals(Event.KeyboardEvent("5")))
        {
            whosFocus = "data";
        }
        if (Event.current.Equals(Event.KeyboardEvent("6")))
        {
            whosFocus = "accounting";
        }
        if (Event.current.Equals(Event.KeyboardEvent("7")))
        {
            whosFocus = "manager";
        }
        if (Event.current.Equals(Event.KeyboardEvent("8")))
        {
            whosFocus = "orb";
        }
        if (Event.current.Equals(Event.KeyboardEvent("9")))
        {
            whosFocus = "corporate";
        }
    }
    void Update () 
    {
        if (whosFocus == "pc") 
        {
            pcCam.SetActive(true);
            wrenchCam.SetActive(false);
            tempCam.SetActive(false);
            welderCam.SetActive(false);
            bigguyCam.SetActive(false);
            dataCam.SetActive(false);
            accountingCam.SetActive(false);
            managerCam.SetActive(false);
            orbCam.SetActive(false);
            corporateCam.SetActive(false);
            boardWrenchCam.SetActive(false);
            boardTempCam.SetActive(false);
            boardWelderCam.SetActive(false);
            boardbigguyCam.SetActive(false);
            boardDataCam.SetActive(false);
            boardAccountingCam.SetActive(false);
            boardManagerCam.SetActive(false);
            strikePongCamera.SetActive(false);
        }
        if (whosFocus == "wrench" & scene == "walkaround")
        {
            pcCam.SetActive(false);
            wrenchCam.SetActive(true);
            tempCam.SetActive(false);
            welderCam.SetActive(false);
            bigguyCam.SetActive(false);
            dataCam.SetActive(false);
            accountingCam.SetActive(false);
            managerCam.SetActive(false);
            orbCam.SetActive(false);
            corporateCam.SetActive(false);
            boardWrenchCam.SetActive(false);
            boardTempCam.SetActive(false);
            boardWelderCam.SetActive(false);
            boardbigguyCam.SetActive(false);
            boardDataCam.SetActive(false);
            boardAccountingCam.SetActive(false);
            boardManagerCam.SetActive(false);
            strikePongCamera.SetActive(false);
        }
        if (whosFocus == "temp" & scene == "walkaround")
        {
            pcCam.SetActive(false);
            wrenchCam.SetActive(false);
            tempCam.SetActive(true);
            welderCam.SetActive(false);
            bigguyCam.SetActive(false);
            dataCam.SetActive(false);
            accountingCam.SetActive(false);
            managerCam.SetActive(false);
            orbCam.SetActive(false);
            corporateCam.SetActive(false);
            boardWrenchCam.SetActive(false);
            boardTempCam.SetActive(false);
            boardWelderCam.SetActive(false);
            boardbigguyCam.SetActive(false);
            boardDataCam.SetActive(false);
            boardAccountingCam.SetActive(false);
            boardManagerCam.SetActive(false);
            strikePongCamera.SetActive(false);
        }
        if (whosFocus == "welder" & scene == "walkaround")
        {
            pcCam.SetActive(false);
            wrenchCam.SetActive(false);
            tempCam.SetActive(false);
            welderCam.SetActive(true);
            bigguyCam.SetActive(false);
            dataCam.SetActive(false);
            accountingCam.SetActive(false);
            managerCam.SetActive(false);
            orbCam.SetActive(false);
            corporateCam.SetActive(false);
            boardWrenchCam.SetActive(false);
            boardTempCam.SetActive(false);
            boardWelderCam.SetActive(false);
            boardbigguyCam.SetActive(false);
            boardDataCam.SetActive(false);
            boardAccountingCam.SetActive(false);
            boardManagerCam.SetActive(false);
            strikePongCamera.SetActive(false);
        }
        if (whosFocus == "bigguy" & scene == "walkaround")
        {
            pcCam.SetActive(false);
            wrenchCam.SetActive(false);
            tempCam.SetActive(false);
            welderCam.SetActive(false);
            bigguyCam.SetActive(true);
            dataCam.SetActive(false);
            accountingCam.SetActive(false);
            managerCam.SetActive(false);
            orbCam.SetActive(false);
            corporateCam.SetActive(false);
            boardWrenchCam.SetActive(false);
            boardTempCam.SetActive(false);
            boardWelderCam.SetActive(false);
            boardbigguyCam.SetActive(false);
            boardDataCam.SetActive(false);
            boardAccountingCam.SetActive(false);
            boardManagerCam.SetActive(false);
            strikePongCamera.SetActive(false);
        }
        if (whosFocus == "data" & scene == "walkaround")
        {
            pcCam.SetActive(false);
            wrenchCam.SetActive(false);
            tempCam.SetActive(false);
            welderCam.SetActive(false);
            bigguyCam.SetActive(false);
            dataCam.SetActive(true);
            accountingCam.SetActive(false);
            managerCam.SetActive(false);
            orbCam.SetActive(false);
            corporateCam.SetActive(false);
            boardWrenchCam.SetActive(false);
            boardTempCam.SetActive(false);
            boardWelderCam.SetActive(false);
            boardbigguyCam.SetActive(false);
            boardDataCam.SetActive(false);
            boardAccountingCam.SetActive(false);
            boardManagerCam.SetActive(false);
            strikePongCamera.SetActive(false);
        }
        if (whosFocus == "accounting" & scene == "walkaround")
        {
            pcCam.SetActive(false);
            wrenchCam.SetActive(false);
            tempCam.SetActive(false);
            welderCam.SetActive(false);
            bigguyCam.SetActive(false);
            dataCam.SetActive(false);
            accountingCam.SetActive(true);
            managerCam.SetActive(false);
            orbCam.SetActive(false);
            corporateCam.SetActive(false);
            boardWrenchCam.SetActive(false);
            boardTempCam.SetActive(false);
            boardWelderCam.SetActive(false);
            boardbigguyCam.SetActive(false);
            boardDataCam.SetActive(false);
            boardAccountingCam.SetActive(false);
            boardManagerCam.SetActive(false);
            strikePongCamera.SetActive(false);
        }
        if (whosFocus == "manager" & scene == "walkaround")
        {
            pcCam.SetActive(false);
            wrenchCam.SetActive(false);
            tempCam.SetActive(false);
            welderCam.SetActive(false);
            bigguyCam.SetActive(false);
            dataCam.SetActive(false);
            accountingCam.SetActive(false);
            managerCam.SetActive(true);
            orbCam.SetActive(false);
            corporateCam.SetActive(false);
            boardWrenchCam.SetActive(false);
            boardTempCam.SetActive(false);
            boardWelderCam.SetActive(false);
            boardbigguyCam.SetActive(false);
            boardDataCam.SetActive(false);
            boardAccountingCam.SetActive(false);
            boardManagerCam.SetActive(false);
            strikePongCamera.SetActive(false);
        }
        if (whosFocus == "orb")
        {
            pcCam.SetActive(false);
            wrenchCam.SetActive(false);
            tempCam.SetActive(false);
            welderCam.SetActive(false);
            bigguyCam.SetActive(false);
            dataCam.SetActive(false);
            accountingCam.SetActive(false);
            managerCam.SetActive(false);
            orbCam.SetActive(true);
            corporateCam.SetActive(false);
            boardWrenchCam.SetActive(false);
            boardTempCam.SetActive(false);
            boardWelderCam.SetActive(false);
            boardbigguyCam.SetActive(false);
            boardDataCam.SetActive(false);
            boardAccountingCam.SetActive(false);
            boardManagerCam.SetActive(false);
            strikePongCamera.SetActive(false);
        }
        if (whosFocus == "corporate")
        {
            corporateCam.SetActive(true);
            pcCam.SetActive(false);
            wrenchCam.SetActive(false);
            tempCam.SetActive(false);
            welderCam.SetActive(false);
            bigguyCam.SetActive(false);
            dataCam.SetActive(false);
            accountingCam.SetActive(false);
            managerCam.SetActive(false);
            orbCam.SetActive(false);
            boardWrenchCam.SetActive(false);
            boardTempCam.SetActive(false);
            boardWelderCam.SetActive(false);
            boardbigguyCam.SetActive(false);
            boardDataCam.SetActive(false);
            boardAccountingCam.SetActive(false);
            boardManagerCam.SetActive(false);
            strikePongCamera.SetActive(false);
        }


        if (whosFocus == "wrench" & scene == "board")
        {
            pcCam.SetActive(false);
            wrenchCam.SetActive(false);
            tempCam.SetActive(false);
            welderCam.SetActive(false);
            bigguyCam.SetActive(false);
            dataCam.SetActive(false);
            accountingCam.SetActive(false);
            managerCam.SetActive(false);
            orbCam.SetActive(false);
            corporateCam.SetActive(false); 
            boardWrenchCam.SetActive(true);
            boardTempCam.SetActive(false);
            boardWelderCam.SetActive(false);
            boardbigguyCam.SetActive(false);
            boardDataCam.SetActive(false);
            boardAccountingCam.SetActive(false);
            boardManagerCam.SetActive(false);
            strikePongCamera.SetActive(false);
        }
        if (whosFocus == "temp" & scene == "board")
        {
            pcCam.SetActive(false);
            wrenchCam.SetActive(false);
            tempCam.SetActive(false);
            welderCam.SetActive(false);
            bigguyCam.SetActive(false);
            dataCam.SetActive(false);
            accountingCam.SetActive(false);
            managerCam.SetActive(false);
            orbCam.SetActive(false);
            corporateCam.SetActive(false);
            boardWrenchCam.SetActive(false);
            boardTempCam.SetActive(true);
            boardWelderCam.SetActive(false);
            boardbigguyCam.SetActive(false);
            boardDataCam.SetActive(false);
            boardAccountingCam.SetActive(false);
            boardManagerCam.SetActive(false);
            strikePongCamera.SetActive(false);
        }
        if (whosFocus == "welder" & scene == "board")
        {
            pcCam.SetActive(false);
            wrenchCam.SetActive(false);
            tempCam.SetActive(false);
            welderCam.SetActive(false);
            bigguyCam.SetActive(false);
            dataCam.SetActive(false);
            accountingCam.SetActive(false);
            managerCam.SetActive(false);
            orbCam.SetActive(false);
            corporateCam.SetActive(false);
            boardWrenchCam.SetActive(false);
            boardTempCam.SetActive(false);
            boardWelderCam.SetActive(true);
            boardbigguyCam.SetActive(false);
            boardDataCam.SetActive(false);
            boardAccountingCam.SetActive(false);
            boardManagerCam.SetActive(false);
            strikePongCamera.SetActive(false);
        }
        if (whosFocus == "bigguy" & scene == "board")
        {
            pcCam.SetActive(false);
            wrenchCam.SetActive(false);
            tempCam.SetActive(false);
            welderCam.SetActive(false);
            bigguyCam.SetActive(false);
            dataCam.SetActive(false);
            accountingCam.SetActive(false);
            managerCam.SetActive(false);
            orbCam.SetActive(false);
            corporateCam.SetActive(false);
            boardWrenchCam.SetActive(false);
            boardTempCam.SetActive(false);
            boardWelderCam.SetActive(false);
            boardbigguyCam.SetActive(true);
            boardDataCam.SetActive(false);
            boardAccountingCam.SetActive(false);
            boardManagerCam.SetActive(false);
            strikePongCamera.SetActive(false);
        }
        if (whosFocus == "data" & scene == "board")
        {
            pcCam.SetActive(false);
            wrenchCam.SetActive(false);
            tempCam.SetActive(false);
            welderCam.SetActive(false);
            bigguyCam.SetActive(false);
            dataCam.SetActive(false);
            accountingCam.SetActive(false);
            managerCam.SetActive(false);
            orbCam.SetActive(false);
            corporateCam.SetActive(false);
            boardWrenchCam.SetActive(false);
            boardTempCam.SetActive(false);
            boardWelderCam.SetActive(false);
            boardbigguyCam.SetActive(false);
            boardDataCam.SetActive(true);
            boardAccountingCam.SetActive(false);
            boardManagerCam.SetActive(false);
            strikePongCamera.SetActive(false);
        }
        if (whosFocus == "accounting" & scene == "board")
        {
            pcCam.SetActive(false);
            wrenchCam.SetActive(false);
            tempCam.SetActive(false);
            welderCam.SetActive(false);
            bigguyCam.SetActive(false);
            dataCam.SetActive(false);
            accountingCam.SetActive(false);
            managerCam.SetActive(false);
            orbCam.SetActive(false);
            corporateCam.SetActive(false);
            boardWrenchCam.SetActive(false);
            boardTempCam.SetActive(false);
            boardWelderCam.SetActive(false);
            boardbigguyCam.SetActive(false);
            boardDataCam.SetActive(false);
            boardAccountingCam.SetActive(true);
            boardManagerCam.SetActive(false);
            strikePongCamera.SetActive(false);
        }
        if (whosFocus == "manager" & scene == "board")
        {
            pcCam.SetActive(false);
            wrenchCam.SetActive(false);
            tempCam.SetActive(false);
            welderCam.SetActive(false);
            bigguyCam.SetActive(false);
            dataCam.SetActive(false);
            accountingCam.SetActive(false);
            managerCam.SetActive(false);
            orbCam.SetActive(false);
            corporateCam.SetActive(false);
            boardWrenchCam.SetActive(false);
            boardTempCam.SetActive(false);
            boardWelderCam.SetActive(false);
            boardbigguyCam.SetActive(false);
            boardDataCam.SetActive(false);
            boardAccountingCam.SetActive(false);
            boardManagerCam.SetActive(true);
            strikePongCamera.SetActive(false);
        }

        if (whosFocus == "strikepong")
        {
            strikePongCamera.SetActive(true);
            pcCam.SetActive(false);
            wrenchCam.SetActive(false);
            tempCam.SetActive(false);
            welderCam.SetActive(false);
            bigguyCam.SetActive(false);
            dataCam.SetActive(false);
            accountingCam.SetActive(false);
            managerCam.SetActive(false);
            orbCam.SetActive(false);
            corporateCam.SetActive(false);
            boardWrenchCam.SetActive(false);
            boardTempCam.SetActive(false);
            boardWelderCam.SetActive(false);
            boardbigguyCam.SetActive(false);
            boardDataCam.SetActive(false);
            boardAccountingCam.SetActive(false);
            boardManagerCam.SetActive(false);

        }

        if (boardScriptObject.GetComponent<BoardManager>().index == 33)
        {
            pcCam.GetComponent<CinemachineConfiner>().enabled = false;
        }
    }
}
