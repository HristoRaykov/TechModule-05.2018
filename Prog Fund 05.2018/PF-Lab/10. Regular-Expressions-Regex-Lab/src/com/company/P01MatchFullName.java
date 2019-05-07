package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P01MatchFullName {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String names = input.nextLine();

		String regex = "\\b[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+";
		Matcher matcher = Pattern.compile(regex).matcher(names);

		List<String> result = new ArrayList<>();
		while (matcher.find()){
			result.add(matcher.group());
		}
		System.out.println(String.join(" ",result));

	}
}
