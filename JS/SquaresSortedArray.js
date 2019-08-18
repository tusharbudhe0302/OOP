var squreSortedArray = function (nums) {
    var result = [];
    var K = Math.round(nums.length / 2);
    var K = 0; var FstPv = -1, LstNv = -1;
    for (K = 0; K < nums.length; K++)
        if (nums[K] >= 0)
            break;

    FstPv = K;
    LstNv = K - 1;
    console.log('Before While Loop ->  LstNv  : ' + LstNv + ' FstPv :  ' + FstPv);
    while (LstNv >= 0 || FstPv < nums.length) {
        console.log('nums[LstNv] : ' + Math.abs(nums[LstNv]) + ' nums[FstPv] : ' + nums[FstPv]);
        if ((Math.abs(nums[LstNv] * nums[LstNv])) < (nums[FstPv] * nums[FstPv])) {
            result.push(nums[FstPv]);
            LstNv--;
        }
        if (Math.abs(nums[LstNv] * nums[LstNv]) > (nums[FstPv] * nums[FstPv])) {
            result.push(nums[LstNv] * nums[LstNv]);
            FstPv++;
        }
    }
    return result;
}

var squre = squreSortedArray([-4, -1, 0, 3, 10]);
if (squre) {
    for (var k = 0; k < squre.length; k++) {
        console.log(squre[k]);
    }
}