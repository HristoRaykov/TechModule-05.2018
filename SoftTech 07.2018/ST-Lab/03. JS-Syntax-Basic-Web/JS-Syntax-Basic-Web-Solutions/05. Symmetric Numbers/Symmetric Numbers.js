function SymmetricNumbers(arr) {
	let n = Number(arr[0]);
	let result = "";
	for (let num = 1; num <= n; num++) {
		if (isSymmetric(num.toString())){
			result += num.toString() + " ";
		}
	}
	console.log(result);
	
	function isSymmetric(num) {
		for (let i = 0; i < num.length/2; i++) {
			if (num[i]!==num[num.length-1-i]) {
				return false;
			}
		}
		return true;
	}
}

console.log(SymmetricNumbers([50]));