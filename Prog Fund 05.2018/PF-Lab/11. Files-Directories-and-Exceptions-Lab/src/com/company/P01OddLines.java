package com.company;

import java.io.IOException;
import java.io.PrintStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.List;
import java.util.stream.IntStream;

public class P01OddLines {
	public static void main(String[] args) throws IOException {
		Path path = Paths.get("resources-and-results/01. Odd Lines/Input.txt");
		PrintStream writer = new PrintStream("resources-and-results/01. Odd Lines/output.txt");
		
		List<String> list = Files.readAllLines(path);
		IntStream.range(0,list.size())
				.filter(i->i%2==1)
				.forEach(i-> writer.println(list.get(i)));
		
	}
}
