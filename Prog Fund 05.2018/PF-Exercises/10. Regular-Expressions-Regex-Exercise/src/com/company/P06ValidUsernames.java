package com.company;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import java.util.stream.Collectors;

public class P06ValidUsernames {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String text = scanner.nextLine();
		String delimiter = "[ \\/\\\\()]+";
		List<String> usernames = Arrays.asList(text.split(delimiter));
		List<String> validUsernames = new ArrayList<>();

		String validRegex = "^[A-Za-z]{1}\\w{2,24}$";
		Pattern usernamePattern = Pattern.compile(validRegex);

		usernames = usernames
				.stream()
				.map(String::trim)
				.map(s -> {
					Matcher matcher = usernamePattern.matcher(s);
					String result = "";
					if (matcher.find()) {
						result = matcher.group();
					}
					return result;
				})
				.filter(s -> s.length() != 0)
				.collect(Collectors.toList());

		int maxSum = 0;
		int index = 0;
		for (int i = 0; i <usernames.size()-1; i++) {
			int currSum = usernames.get(i).length()+usernames.get(i+1).length();
			if (currSum > maxSum){
				maxSum = currSum;
				index = i;
			}
		}
		System.out.println(usernames.get(index));
		System.out.println(usernames.get(index+1));

		System.out.println();
	}
}
