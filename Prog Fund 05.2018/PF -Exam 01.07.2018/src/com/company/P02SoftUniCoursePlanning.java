package com.company;

import java.util.*;

public class P02SoftUniCoursePlanning {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		List<String> schedule = new ArrayList(Arrays.asList(scanner.nextLine().split(", ")));
		
		while (true) {
			String line = scanner.nextLine();
			if (line.equals("course start")) {
				break;
			}
			String[] tokens = line.split(":");
			String command = tokens[0];
			String lesson = tokens[1];
			boolean lessonExist = schedule.contains(lesson);
			String lessonExercise = lesson + "-Exercise";
			boolean lessonExerciseExist = schedule.contains(lessonExercise);
			switch (command) {
				case "Add":
					if (lessonExist == false) {
						schedule.add(lesson);
					}
					break;
				case "Insert":
					int index = Integer.parseInt(tokens[2]);
					if (lessonExist == false && (index >= 0 && index <= schedule.size())) {//????
						schedule.add(index, lesson);
					}
					break;
				case "Remove":
					if (lessonExist) {
						schedule.remove(lesson);
					}
					if (lessonExerciseExist) {
						schedule.remove(lessonExercise);
					}
					break;
				case "Swap":
					String lessonToSwap = tokens[2];
					String lessonToSwapExercise = lessonToSwap + "-Exercise";
					boolean lessonToSwapExist = schedule.contains(lessonToSwap);
					boolean lessonToSwapExerciseExist = schedule.contains(lessonToSwapExercise);
					
					int lessonIndex = schedule.indexOf(lesson);
					int lessonToSwapIndex = schedule.indexOf(lessonToSwap);
					
					if (lessonExist && lessonToSwapExist) {
						Collections.swap(schedule, lessonIndex, lessonToSwapIndex);
						if (lessonExerciseExist) {
							schedule.remove(lessonExercise);
							int lessonExerciseNewIndex = schedule.indexOf(lesson) + 1;
							schedule.add(lessonExerciseNewIndex, lessonExercise);
						}
						if (lessonToSwapExerciseExist) {
							schedule.remove(lessonToSwapExercise);
							int lessonToSwapExerciseNewIndex = schedule.indexOf(lessonToSwap) + 1;//index out of range???
							schedule.add(lessonToSwapExerciseNewIndex, lessonToSwapExercise);
						}
					}
					
					break;
				case "Exercise":
					int exerciseIndex = schedule.indexOf(lesson) + 1;
					if (lessonExist && lessonExerciseExist == false) {
						schedule.add(exerciseIndex, lessonExercise);
					}
					if (lessonExist == false) {
						schedule.add(lesson);
						schedule.add(lessonExercise);
					}
					break;
			}
			
		}
		
		for (int i = 0; i < schedule.size(); i++) {
			System.out.printf("%d.%s", i + 1, schedule.get(i));
			System.out.println();
		}
		
	}
}
