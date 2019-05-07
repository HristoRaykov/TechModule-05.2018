package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P03SoftUniBarIncome {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String regex = "%([A-Z][a-z]+)%.*<(\\w+)>.*\\|(\\d+)\\|(?:[^\\|0-9]*)([1-9]\\d*(?:\\.\\d+)?)\\$";
//		String regexPrice = "((?:[1-9]\\d*)(?:(?:\\.\\d+)?))\\$";
		Pattern pattern = Pattern.compile(regex);
//		Pattern patternPrice = Pattern.compile(regexPrice);
		
		double totoalIncome = 0;
		
		while (true){
			String line = scanner.nextLine();
			if (line.equals("end of shift" )){
				break;
			}
			Matcher matcher = pattern.matcher(line);
//			Matcher matcherPrice = patternPrice.matcher(line);
			String customer ="";
			String product ="";
			int count = 0;
			double price = 0.0;
			if (matcher.find()) {
				customer = matcher.group(1);
				product = matcher.group(2);
				count = Integer.parseInt(matcher.group(3));
				price = Double.parseDouble(matcher.group(4));
			}else{
				continue;
			}
			double totalPrice = count*price;
			totoalIncome += totalPrice;
			System.out.printf("%s: %s - %.2f",customer,product,totalPrice);
			System.out.println();
			
			
		}
		
		System.out.printf("Total income: %.2f",totoalIncome);
		System.out.println();
	}
}
