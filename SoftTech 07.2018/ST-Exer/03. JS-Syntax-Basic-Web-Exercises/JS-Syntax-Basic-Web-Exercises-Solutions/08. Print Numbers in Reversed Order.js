function printReversed(arr) {
	let nums = arr.map(Number);
	for (let i = nums.length-1; i >=0 ; i--) {
		console.log(nums[i]);
	}
	// nums.reverse();
	// nums.forEach(x=> console.log(x));
}

printReversed(["10","20","30"]);