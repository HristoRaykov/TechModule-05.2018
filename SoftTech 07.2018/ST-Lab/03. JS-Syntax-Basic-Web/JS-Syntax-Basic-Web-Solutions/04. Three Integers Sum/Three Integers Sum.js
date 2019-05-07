function FindSum(arr) {
	let nums = arr[0].split(' ').map(Number);
	let num1 = nums[0];
	let num2 = nums[1];
	let num3 = nums[2];
	let result = check(num1, num2, num3) ||
		check(num1, num3, num2) ||
		check(num2, num3, num1) || "No";
	console.log(result);
	
	function check(num1, num2, sum) {
		let result = "";
		if (num1 + num2 == sum) {
			result = `${Math.min(num1, num2)} + ${Math.max(num1, num2)} = ${sum}`;
		}else{
			result= false;
		}
		return result;
	}
	
}

let result = FindSum(["8 15 7"]);
console.log(result);

