package com.company;

import java.util.Arrays;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P02MemorView {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		StringBuilder memoryView = new StringBuilder();

		while (true) {
			String line = scanner.nextLine();
			if (line.equals("Visual Studio crash")) {
				break;
			}
			memoryView.append(" "+line);
		}
		String regex = "32656\\s+19759\\s+32763\\s+0\\s+[1-9]\\d*\\s+0\\s+((?:[1-9]\\d*\\s+)+)(?=0\\s+)";
		Matcher matcher = Pattern.compile(regex).matcher(memoryView);
		int startIndex = 0;
		while (matcher.find(startIndex)) {
			String strChars = matcher.group(1);
			int startIndexGroup1 = matcher.start(1);
			startIndex = startIndexGroup1+strChars.length();
			String str = GetStringFromChars(strChars);
			System.out.println(str);
		}


	}

	private static String GetStringFromChars(String strChars) {
		StringBuilder result = new StringBuilder();
		strChars = strChars.trim();
		int[] chars = Arrays.stream(strChars.split(" "))
				.mapToInt(Integer::parseInt)
				.toArray();
		for (int num : chars) {
			result.append((char) num);
		}
		return result.toString();
	}
}
