package com.company;

import java.io.IOException;
import java.io.PrintStream;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.List;
import java.util.stream.IntStream;

public class P02LineNumbers {
	public static void main(String[] args) throws IOException {
		List<String> lines = Files.readAllLines(Paths.get("resources-and-results/02. Line Numbers/Input.txt"));
		PrintStream writer = new PrintStream("resources-and-results/02. Line Numbers/result.txt");
		
		IntStream.range(0,lines.size())
				.forEach(index -> writer.printf("%d. %s%n",index+1,lines.get(index)));
	
	}
}
