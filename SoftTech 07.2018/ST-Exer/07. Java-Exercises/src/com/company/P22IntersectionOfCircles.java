package com.company;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class P22IntersectionOfCircles {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		List<Circle> circles = new ArrayList<>();
		
		for (int i = 0; i < 2; i++) {
			int[] tokens = Arrays.stream(scanner.nextLine().split(" "))
					.mapToInt(Integer::parseInt)
					.toArray();
			Point center = new Point(tokens[0],tokens[1]);
			int radius = tokens[2];
			Circle circle = new Circle(center,radius);
			circles.add(circle);
		}
		
		boolean result = Circle.hasIntersect(circles.get(0),circles.get(1));
		if (result) {
			System.out.println("Yes");
		}else {
			System.out.println("No");
		}
	}
}

class Circle{
	private Point center;
	
	private double radius;
	
	public Circle(Point center, double radius) {
		this.center = center;
		this.radius = radius;
	}
	
	static boolean hasIntersect(Circle c1, Circle c2){
		if (Point.calculateDistance(c1.getCenter(),c2.getCenter())<=c1.getRadius()+c2.getRadius()){
			return true;
		}else {
			return false;
		}
	}
	
	public Point getCenter() {
		return center;
	}
	
	public void setCenter(Point center) {
		this.center = center;
	}
	
	public double getRadius() {
		return radius;
	}
	
	public void setRadius(double radius) {
		this.radius = radius;
	}
}

class Point{
	private double x;
	
	private double y;
	
	public Point(double x, double y) {
		this.x = x;
		this.y = y;
	}
	
	static double calculateDistance(Point p1,Point p2){
		double distance = Math.sqrt (Math.pow(p1.getX() - p2.getX(),2)+ Math.pow(p1.getY()- p2.getY(),2));
		return distance;
	}
	
	public double getX() {
		return x;
	}
	
	public void setX(double x) {
		this.x = x;
	}
	
	public double getY() {
		return y;
	}
	
	public void setY(double y) {
		this.y = y;
	}
}