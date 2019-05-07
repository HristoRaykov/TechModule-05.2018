package com.softuni.entity;

public class Calculator {
	
	private double leftOperand;
	
	private String operator;
	
	private double rightOperand;
	
	public double calculateResult() {
		double result = 0;
		switch (this.operator) {
			case "+":
				result = this.leftOperand + this.rightOperand;
				break;
			case "-":
				result = this.leftOperand - this.rightOperand;
				break;
			case "*":
				result = this.leftOperand * this.rightOperand;
				break;
			case "/":
				result = this.leftOperand / this.rightOperand;
				break;
			case "^":
				result = Math.pow(this.leftOperand, this.rightOperand);
				break;
		}
		return result;
	}
	
	public Calculator(double leftOperand, String operator, double rightOperand) {
		this.leftOperand = leftOperand;
		this.operator = operator;
		this.rightOperand = rightOperand;
	}
	
	
	public Calculator() {
	
	}
	
	public double getLeftOperand() {
		return leftOperand;
	}
	
	public String getOperator() {
		return operator;
	}
	
	public double getRightOperand() {
		return rightOperand;
	}
}
