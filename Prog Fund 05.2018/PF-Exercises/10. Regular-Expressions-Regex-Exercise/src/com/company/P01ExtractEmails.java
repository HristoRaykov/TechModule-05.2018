package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P01ExtractEmails {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String input = scanner.nextLine();
		String regex = "(^|(?<=\\s))([A-Za-z0-9]+([\\._\\-])?[A-Za-z0-9]+)@[A-Za-z]+(\\.|-)?[A-Za-z]+((\\.|-)[a-z]+)+(\\b|&|(?=\\s|,|\\.))";

		Matcher matcher	= Pattern.compile(regex).matcher(input);
		List<String> result = new ArrayList<>();
		while (matcher.find()){
			result.add(matcher.group());
		}
		System.out.println(String.join(System.lineSeparator(),result));
	}
}
