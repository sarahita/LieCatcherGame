//Stores the question contents

public static class questions{

	private static string[] content = {
		"Where were you born?",
		"How many years did you\nlive in your first home?",
		"What is your mother's job?",
		"What is your father's job?",
		"Are your parents divorced?",
		"Have you ever broken a bone?",
		"Do you have any allergies?",
		"Have you ever stayed\novernight at a hospital?",
		"Have you ever tweeted before?",
		"Have you ever bought\nanything on eBay?",
		"Do you own an e-reader of any kind?",
		"Who was the last person\nyou were in a physical fight with?",
		"Have you ever gotten in\ntrouble with the police?",
		"Who ended your last\nromantic relationship?",
		"Who do you love more,\nyour mother or your father?",
		"What's the most you've\never spent on a pair of shoes?",
		"What's the last movie\nyou saw that you really hated?",
		"Have you ever gone ice skating?",
		"Do you currently own a tennis racket?",
		"How many roommates do you have?",
		"What's your major at Columbia?",
		"Did you ever have a pet cat?",
		"Have you ever\nwatched a person or pet die?",
		"Did you ever cheat\non a test in high school?"
	};
			

	public static string getQuestion (int qnum){
			return content[qnum-1];
	}
}