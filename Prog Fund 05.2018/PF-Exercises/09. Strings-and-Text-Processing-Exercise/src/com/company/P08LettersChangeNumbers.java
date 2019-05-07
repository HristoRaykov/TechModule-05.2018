package com.company;


import java.util.Scanner;


public class P08LettersChangeNumbers {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] tokens = input.nextLine().trim().split("[\\s]+");
		double sum = 0;
		for (String token : tokens) {
			char firstChar = token.charAt(0);
			char secondChar = token.charAt(token.length()-1);
			String numberString = token.substring(1,token.length()-1);


			double number = Double.parseDouble(numberString);
			double result = 1.0*number;

			if (Character.isLetter(firstChar) && Character.isUpperCase(firstChar)){
				result /= 1.0*((int)firstChar-64);
			}else if (Character.isLetter(firstChar) && Character.isLowerCase(firstChar)){
				result *= 1.0*((int)firstChar-96);
			}
			if (Character.isLetter(secondChar) && Character.isUpperCase(secondChar)){
				result -= 1.0*((int)secondChar-64);
			}else if (Character.isLetter(secondChar) && Character.isLowerCase(secondChar)){
				result += 1.0*((int)secondChar-96);
			}
			sum+=result;

		}



		System.out.printf("%.2f",sum);
	}
}
