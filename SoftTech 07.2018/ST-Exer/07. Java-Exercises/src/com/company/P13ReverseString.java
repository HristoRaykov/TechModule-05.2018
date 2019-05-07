package com.company;

import java.util.Scanner;

public class P13ReverseString {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		String str = scanner.nextLine();
		
		String result = new StringBuilder(str).reverse().toString();
		System.out.println(result);
	}
}
