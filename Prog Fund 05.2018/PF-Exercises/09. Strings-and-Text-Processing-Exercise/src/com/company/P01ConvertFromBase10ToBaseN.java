package com.company;

import java.math.BigInteger;
import java.util.Scanner;
import java.util.Stack;


public class P01ConvertFromBase10ToBaseN {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] tokens = input.nextLine().split(" ");


		int base = Integer.parseInt(tokens[0]);
		BigInteger number = new BigInteger(tokens[1]);
		String basedNumber = convertToBaseN(number, base);
		System.out.println(basedNumber);


	}

	private static String convertToBaseN(BigInteger number, int base) {
		Stack<String> baseStack = new Stack<>();
		BigInteger baseNum = new BigInteger(String.valueOf(base));
		while (number.compareTo(new BigInteger("0")) == 1) {
			BigInteger remainderValue = number.remainder(baseNum);
			baseStack.add(remainderValue.toString());
			number = number.divide(baseNum);
		}

		StringBuilder stringNBaseNum = new StringBuilder();
		while (!baseStack.empty()) {
			stringNBaseNum.append(baseStack.pop());
		}
		return stringNBaseNum.toString();
	}


}
