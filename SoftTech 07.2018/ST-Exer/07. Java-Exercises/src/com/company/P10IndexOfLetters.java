package com.company;
		
		import java.util.Scanner;

public class P10IndexOfLetters {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		String letters = scanner.nextLine();
		
		for (int i = 0; i < letters.length(); i++) {
			char ch =letters.charAt(i);
			int index = (int)ch - 97;
			System.out.println(String.format("%c -> %d",ch,index));
		}
	}
}
