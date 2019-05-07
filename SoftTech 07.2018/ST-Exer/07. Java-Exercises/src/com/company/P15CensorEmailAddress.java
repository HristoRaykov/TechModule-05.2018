package com.company;

import java.util.Scanner;

public class P15CensorEmailAddress {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		String email = scanner.nextLine();
		String text = scanner.nextLine();
		
		String username = email.split("@")[0];
		String cryptedName = newString("*", username.length());
		String cryptedEmail = email.replaceFirst(username, cryptedName);
		
		text = text.replaceAll("\\b"+email+"\\b", cryptedEmail);
		
		System.out.println(text);
	}
	
	private static String newString(String s, int length) {
		StringBuilder result = new StringBuilder();
		for (int i = 0; i < length; i++) {
			result.append(s);
		}
		return result.toString();
	}
}
