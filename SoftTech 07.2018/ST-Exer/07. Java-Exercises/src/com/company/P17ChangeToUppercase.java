package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P17ChangeToUppercase {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		String text = scanner.nextLine();
		
		Pattern pattern = Pattern.compile("<upcase>(.*?)</upcase>");
		Matcher matcher = pattern.matcher(text);
		String replacement = "";

		while (matcher.find()){
			replacement = matcher.group(1).toUpperCase();
			text=text.replace(matcher.group(0),replacement);
		}
		
		System.out.println(text);
	}
}
