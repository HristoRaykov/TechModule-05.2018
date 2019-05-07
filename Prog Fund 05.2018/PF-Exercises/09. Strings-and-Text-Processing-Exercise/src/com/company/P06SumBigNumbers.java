package com.company;

import java.util.Scanner;
import java.util.Stack;

public class P06SumBigNumbers {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String token1 = input.nextLine().replaceFirst("^0+","");
		String token2 = input.nextLine().replaceFirst("^0+","");
		String shorterNum = token1.length() < token2.length() ? token1 : token2;
		String longerNum = token1.length() >= token2.length() ? token1 : token2;

		Stack<String> result = new Stack<>();
		int onMind = 0;
		for (int i = longerNum.length() - 1; i >= 0; i--) {
			int index = i - (longerNum.length() - shorterNum.length());
			int digit1 = 0;
			int digit2 = 0;
			if (index >= 0) {
				digit1 = Integer.parseInt(String.valueOf(longerNum.charAt(i)));
				digit2 = Integer.parseInt(String.valueOf(shorterNum.charAt(index)));
				
			} else {
				digit1 = Integer.parseInt(String.valueOf(longerNum.charAt(i)));
				digit2 = 0;
			}
			
			if (digit1 + digit2 + onMind > 9) {
				if (i > 0) {
					result.add(Integer.toString(digit1 + digit2 + onMind - 10));
				} else {
					result.add(Integer.toString(digit1 + digit2 + onMind));
				}
				onMind = 1;
			} else {
				result.add(Integer.toString(digit1 + digit2 + onMind));
				onMind = 0;
			}
		}
		
		
		
		while (result.isEmpty()==false){
			System.out.print(result.pop());
		}
		
		
	}
}
