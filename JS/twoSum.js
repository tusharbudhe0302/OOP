var twoSum = function (nums, target) {
    var result = [];
    for (var i = 0; i < nums.length; i++) {
        var newTarget = target - nums[i];
        console.log('Target : ' + target + ' --> Index : ' + i);
        var j = nums.lastIndexOf(newTarget)
        console.log('New target : ' + newTarget + '--> Index : ' + j);
        if (j > -1 && j != i) {
            result.push(i, j);
            return result;
        }
    }
};
// var result = twoSum([2, 7, 11, 15], 9);
var result = twoSum([3, 2, 4], 6);
console.log('Result : ');
console.log(JSON.stringify(result));