function GetLargestNumbers(arr) {
	let nums = arr.map(Number);
	nums = nums.sort((a,b)=>b-a);
	let count = Math.min(nums.length,3);
	for (let i = 0; i < count; i++) {
		console.log(nums[i]);
	}
}

