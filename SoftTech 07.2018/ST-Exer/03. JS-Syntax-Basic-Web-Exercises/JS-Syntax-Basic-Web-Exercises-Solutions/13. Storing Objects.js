function solveProblem13(arr) {
	let result = [];
	
	for (let line of arr) {
		let student = {};
		let tokens = line.split(" -> ");
		student['name'] = tokens[0];
		student['age'] = tokens[1];
		student['grade'] = tokens[2];
		result.push(student);
	}
	
	result.forEach(st => {
		console.log(`Name: ${st['name']}\nAge: ${st['age']}\nGrade: ${st['grade']}`);
	})
	
}

solveProblem13([
	'Pesho -> 13 -> 6.00',
	'Ivan -> 12 -> 5.57',
	'Toni -> 13 -> 4.90',
])