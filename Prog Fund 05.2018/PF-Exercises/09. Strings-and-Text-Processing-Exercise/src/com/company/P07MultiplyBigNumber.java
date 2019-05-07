package com.company;

import java.util.Scanner;
import java.util.Stack;

public class P07MultiplyBigNumber {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String number = input.nextLine().replaceFirst("^0+(?!$)", "").trim();
		int multiplier = Integer.parseInt(input.nextLine().replaceFirst("^0+(?!$)", "").trim());
		
		if (multiplier == 0) {
			System.out.println(0);
			return;
		}
		
		Stack<String> result = new Stack<>();
		int onMind = 0;
		for (int i = number.length() - 1; i >= 0; i--) {
			String numToAdd = "";
			int digit = Integer.parseInt(String.valueOf(number.charAt(i)));
			int product = digit * multiplier + onMind;
			if (i == 0) {
				numToAdd = String.valueOf(product);
			} else {
				numToAdd = String.valueOf(product % 10);
			}
			result.add(numToAdd);
			onMind = product / 10;
		}
		
		while (result.isEmpty() == false) {
			System.out.print(result.pop());
		}
		
	}
}
