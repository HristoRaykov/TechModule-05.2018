package com.company;

import java.time.DayOfWeek;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class P20CountWorkingDays {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		DateTimeFormatter formatter = DateTimeFormatter.ofPattern("dd-MM-yyyy");
		LocalDate startDate = LocalDate.parse(scanner.nextLine(), formatter);
		LocalDate endDate = LocalDate.parse(scanner.nextLine(), formatter);
		
		int year = startDate.getYear();
				List<Integer> holidays = Arrays.asList(
						LocalDate.of(year, 1, 1).getDayOfYear(),
						LocalDate.of(year, 3, 3).getDayOfYear(),
						LocalDate.of(year, 5, 1).getDayOfYear(),
						LocalDate.of(year, 5, 6).getDayOfYear(),
						LocalDate.of(year, 5, 24).getDayOfYear(),
						LocalDate.of(year, 9, 6).getDayOfYear(),
						LocalDate.of(year, 9, 22).getDayOfYear(),
						LocalDate.of(year, 11, 1).getDayOfYear(),
						LocalDate.of(year, 12, 24).getDayOfYear(),
						LocalDate.of(year, 12, 25).getDayOfYear(),
						LocalDate.of(year, 12, 26).getDayOfYear()
				);
		
		int workingDays = 0;
		
		for (LocalDate currentDate = startDate;
		     currentDate.isBefore(endDate.plusDays(1));
		     currentDate = currentDate.plusDays(1)) {
			year=currentDate.getYear();
			if (!(currentDate.getDayOfWeek().equals(DayOfWeek.SATURDAY) ||
					currentDate.getDayOfWeek().equals(DayOfWeek.SUNDAY)) &&
					!holidays.contains(currentDate.getDayOfYear())) {
				workingDays++;
			}
		}
		
		System.out.println(workingDays);
	}
}
