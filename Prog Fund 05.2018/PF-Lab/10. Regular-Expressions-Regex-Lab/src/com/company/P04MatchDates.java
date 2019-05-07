package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P04MatchDates {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String input = scanner.nextLine();
		String regex = "\\b(\\d{2})(\\.|-|\\/)([A-Z][a-z]{2})\\2(\\d{4})\\b";

		Matcher matcher = Pattern.compile(regex).matcher(input);

		while (matcher.find()){
			System.out.printf("Day: %s, Month: %s, Year: %s",matcher.group(1),matcher.group(3),matcher.group(4));
			System.out.println();
		}

	}

}
