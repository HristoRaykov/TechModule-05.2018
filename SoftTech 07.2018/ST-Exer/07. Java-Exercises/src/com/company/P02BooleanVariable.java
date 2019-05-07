package com.company;

import java.util.Scanner;

public class P02BooleanVariable {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		String str = scanner.nextLine();
		
		boolean isTrue = Boolean.parseBoolean(str);
		
		if (isTrue){
			System.out.println("Yes");
		}else {
			System.out.println("No");
		}
		
		
	}
}
