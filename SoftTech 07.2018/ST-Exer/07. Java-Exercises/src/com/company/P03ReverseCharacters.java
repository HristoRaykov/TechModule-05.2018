package com.company;

import java.util.Scanner;
import java.util.Stack;

public class P03ReverseCharacters {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		Stack<String> arr = new Stack<String>();
		
		for (int i = 0; i < 3; i++) {
			String str = scanner.nextLine();
			arr.push(str);
		}
		
		while (!arr.isEmpty()){
			System.out.print(arr.pop());
		}
	}
}
