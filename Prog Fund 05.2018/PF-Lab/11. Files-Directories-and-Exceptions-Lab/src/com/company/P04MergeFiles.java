package com.company;

import java.io.IOException;
import java.io.PrintStream;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.List;
import java.util.stream.IntStream;

public class P04MergeFiles {
	public static void main(String[] args) throws IOException {
		List<String> lines1 = Files.readAllLines(Paths.get("resources-and-results/04. Merge Files/FileOne.txt"));
		List<String> lines2 = Files.readAllLines(Paths.get("resources-and-results/04. Merge Files/FileTwo.txt"));
		PrintStream writer = new PrintStream("resources-and-results/04. Merge Files/result.txt");
		IntStream.range(0,lines1.size())
				.forEach(index -> {
					writer.println(lines1.get(index));
					writer.println(lines2.get(index));
				});
	
	
	}
}
