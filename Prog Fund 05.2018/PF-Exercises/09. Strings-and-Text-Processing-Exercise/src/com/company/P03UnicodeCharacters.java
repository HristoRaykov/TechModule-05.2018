package com.company;

import java.util.Scanner;

public class P03UnicodeCharacters {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String line = input.nextLine();
		
		for (char ch : line.toCharArray()) {
			System.out.print(String.format("\\u" + "%04x", (int)ch));
		}
		
	}
}
