package com.company;

import java.util.Scanner;

public class P04VowelOrDigit {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		
		char ch = scanner.next().charAt(0);
		if (Character.isDigit(ch)) {
			System.out.println("digit");
		} else if (isVowel(ch)){
			System.out.println("vowel");
		}else {
			System.out.println("other");
		}
	}
	
	private static boolean isVowel(char ch) {
		if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' ||
				ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U') {
			return true;
		}else {
			return false;
		}
	}
}
