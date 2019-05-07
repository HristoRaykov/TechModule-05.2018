package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P03Regexmon {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String text = scanner.nextLine();

		Matcher didiMatcher = Pattern.compile("[^A-Za-z\\-]+").matcher(text);
		Matcher bojoMatcher = Pattern.compile("[A-Za-z]+\\-[A-Za-z]+").matcher(text);
		int startIndex = 0;

		while (true) {
			if (didiMatcher.find(startIndex)) {
				String match = didiMatcher.group();
				startIndex = didiMatcher.start(0) + match.length();
				System.out.println(match);
			}else{
				break;
			}
			if (bojoMatcher.find(startIndex)) {
				String match = bojoMatcher.group();
				startIndex = bojoMatcher.start(0) + match.length();
				System.out.println(match);
			}else{
				break;
			}

		}


	}
}
