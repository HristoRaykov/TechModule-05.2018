package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P06ReplaceTag {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);

		StringBuilder text = new StringBuilder();
		while (true){
		String input = scanner.nextLine();
		if (input.equals("end")) {
			break;
		}
		text.append(input);
		text.append(System.lineSeparator());
		}

		String regex = "(<a ?href=)(.*)>(.*)(<\\/a>)";
		String replacement = "[URL href=$2]$3[/URL]";
		Matcher matcher = Pattern.compile(regex).matcher(text);
		String result = matcher.replaceAll(replacement);

		System.out.println(result);
	}
}
