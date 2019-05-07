function solveProblem15(arr) {
	let obj = {};
	for (let line of arr) {
		let tokens = line.split(" -> ");
		let key;
		let value;
		if (isNaN(tokens[0])) {
			key = tokens[0];
		} else {
			key = Number(tokens[0]);
		}
		if (isNaN(tokens[1])) {
			value = tokens[1];
		} else {
			value = Number(tokens[1]);
		}
		obj[key] = value;
	}
	console.log(JSON.stringify(obj));
}