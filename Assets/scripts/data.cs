using UnityEngine;

//Stores all the information that needs to be accessed globally EXCEPT the score

public static class data{

    public static int numberFiles = 13;   
    public static int numFolders = 3;   


    public static bool loaded = false;
    public static int hit_id;
	private static int test_position;
	private static string[] fileNames = new string[numberFiles];
	private static AudioClip[] audio = new AudioClip[numberFiles];
	private static int[] qnum = new int[numberFiles];
	private static bool[] answers = new bool[numberFiles];
	private static string[] playerAnswers = new string[numberFiles];
	private static int[] timesPlayed = new int[numberFiles];
    public static string[] timeAudioFinish = new string[numberFiles];
    public static string[] timePressAnswer = new string[numberFiles];
    private static string startTime;

	//TODO Remove
	public static string myTxt;

	public static int getHit_id {
		get {
			return hit_id;
		}
		set {
			hit_id = value;
		}
	}

	public static int getTest_position {
		get {
			return test_position;
		}
		set {
			test_position = value;
		}
	}

	public static void setFileName (int index, string fname){
		fileNames [index] = fname;
	}

	public static void setAudio (int index, AudioClip newAudio){
		audio [index] = newAudio;
	}

	public static void setQnum (int index, int nqnum){
		qnum [index] = nqnum;
	}

	public static void setAnswer (int index, bool ans){
		answers [index] = ans;
	}

	public static string getStartTime {
		get {
			return startTime;
		}
		set {
			startTime = value;
		}
	}

	public static string getFileName(int index){
		return fileNames [index - 1];
	}

	public static AudioClip getAudio(int index){
		return audio [index - 1];
	}

	public static int getQnum(int index){
		return qnum [index - 1];
	}

	public static bool getAnswer(int index){
		return answers [index - 1];
	}

	public static string getPlayerAnswer(int index){
		return playerAnswers [index - 1];
	}

	public static void setPlayerAnswer(int qnum, string ans){
		playerAnswers [qnum - 1] = ans;
	}

	public static int getTimesPlayed(int index){
		return timesPlayed[index - 1];
	}


    public static void incrementTimesPlayed(int index){
		timesPlayed [index - 1] = timesPlayed [index - 1] + 1;
	}

}