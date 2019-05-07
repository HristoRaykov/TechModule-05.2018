package com.company;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class P23AverageGrades {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		int n = Integer.parseInt(scanner.nextLine());
		
		List<Student> students = new ArrayList<>();
		
		for (int i = 0; i < n; i++) {
			String[] input = scanner.nextLine().split(" ", 2);
			String name = input[0];
			List<Double> grades = Arrays.stream(input[1].split(" "))
					.map(Double::parseDouble)
					.collect(Collectors.toList());
			Student student = new Student(name, grades);
			students.add(student);
		}
		
		students.stream()
				.filter(s -> s.getAverageGrade() >= 5.0)
				.sorted((s1, s2) -> {
					int result = s1.getName().compareTo(s2.getName());
					if (result == 0) {
						result = Double.compare(s2.getAverageGrade(), s1.getAverageGrade());
					}
					return result;
				})
				.forEach(s -> System.out.println(String.format("%s -> %.2f", s.getName(), s.getAverageGrade())));
		
		
	}
}

class Student {
	private String name;
	
	private List<Double> grades;
	
	private double averageGrade;
	
	public Student(String name, List<Double> grades) {
		this.name = name;
		this.grades = grades;
	}
	
	public String getName() {
		return name;
	}
	
	public List<Double> getGrades() {
		return grades;
	}

//	public void setGrades(List<Double> grades) {
//		this.grades.addAll(grades);
//	}
	
	public double getAverageGrade() {
		
		return this.grades.stream().mapToDouble(Double::doubleValue).sum()/this.grades.size();
	}
	
}
