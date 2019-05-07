package com.company;

import java.util.Scanner;

public class P14FitStringin20Chars {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		String input = scanner.nextLine();
		String asterisks = "********************";
		String result = "";
		
		if (input.length()<20){
			int len = 20-input.length();
			result = input + asterisks.substring(0,len);
		}else {
			result = input.substring(0,20);
		}
		
		System.out.println(result);
	}
}
