function solveProblem11(arr) {
	let map = {};
	for (let i = 0; i < arr.length; i++) {
		let line = arr[i];
		let key = "";
		if (i===arr.length-1) {
			key = line.trim();
			if (map[key]){
				return map[key];
			} else {
				return "None";
			}
			break;
		}
		key=line.split(" ")[0];
		let value = line.split(" ")[1];
		if (!map[key]){
			map[key] = "";
		}
		map[key]=value;
	}
}

console.log(solveProblem11([
	'3 test',
	'3 test1',
	'4 test2',
	'4 test3',
	'4 test5',
	'4',
]));