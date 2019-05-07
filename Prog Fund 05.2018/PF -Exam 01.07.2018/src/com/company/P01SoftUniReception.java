package com.company;

import java.util.Scanner;

public class P01SoftUniReception {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int employee1 = Integer.parseInt(scanner.nextLine());
		int employee2 = Integer.parseInt(scanner.nextLine());
		int employee3 = Integer.parseInt(scanner.nextLine());
		int students = Integer.parseInt(scanner.nextLine());
		
		int studentsPerHour = employee1 + employee2 + employee3;
		
		int hours = 0;
		
		int workingHours = students%studentsPerHour==0?students/studentsPerHour:students/studentsPerHour+1;
		int breakHours = workingHours%3==0?workingHours/3-1:workingHours/3;
		
		if (workingHours<=3){
			hours = workingHours;
		}else{
			hours = workingHours + breakHours;
		}
		
		System.out.printf("Time needed: %dh.",hours);
//		int studentsAnswered = 0;
//		int counter =0;
//
//		while (true) {
//			if (studentsAnswered>=students){
//				break;
//			}
//			studentsAnswered += studentsPerHour;
//			hours++;
//			if (studentsAnswered>=students){
//				break;
//			}
//			if (hours>0 && hours%3==0){
//				counter++;
//			}
//		}
//
//		System.out.printf("Time needed: %dh.", hours+counter);
	}
}
