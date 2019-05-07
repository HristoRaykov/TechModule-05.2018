package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P02MatchPhoneNumber {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String phoneNums = input.nextLine();
		String regex = "\\+359(-| )2\\1\\d{3}\\1\\d{4}\\b";

		Matcher matcher = Pattern.compile(regex).matcher(phoneNums);

		List<String> result = new ArrayList<>();
		while (matcher.find()){
			result.add(matcher.group());
		}
		System.out.println(String.join(", ",result));
	}
}
