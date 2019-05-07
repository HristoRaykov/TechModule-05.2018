package com.company;

import java.util.Scanner;

public class P05IntegerToHexAndBinary {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		int num = Integer.parseInt(scanner.nextLine());
		
		String hex = Integer.toHexString(num);
		String bin = Integer.toBinaryString(num);
		
		System.out.println(hex.toUpperCase());
		System.out.println(bin);
		
	}
}
