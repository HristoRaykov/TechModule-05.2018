package com.company;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintStream;

public class P05FolderSize {
	public static void main(String[] args) throws FileNotFoundException {
		File folder = new File("resources-and-results/05. Folder Size/TestFolder");
		PrintStream writer = new PrintStream("resources-and-results/05. Folder Size/result.txt");
		File[] files = folder.listFiles();
		double sum =0;
		for (File file : folder.listFiles() ) {
			if (file.isFile()){
				sum +=file.length();
			}
		}
		sum /= (1024*1024);
		writer.print(sum);
	}
}
