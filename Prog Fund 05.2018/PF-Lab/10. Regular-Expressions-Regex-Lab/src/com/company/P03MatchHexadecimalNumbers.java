package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P03MatchHexadecimalNumbers {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String input = scanner.nextLine();
		String regex = "\\b(0x)?[0-9A-F]+\\b";

		Matcher matcher = Pattern.compile(regex).matcher(input);
		List<String> result = new ArrayList<>();
		while (matcher.find()){
			result.add(matcher.group());
		}

		System.out.println(String.join(" ",result));
	}

}
