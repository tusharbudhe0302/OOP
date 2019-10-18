// var input = 7;
// var oputPut = "";
// var executeLoop = function () {
//     for (var i = 0; i <= input; i++) {
//         oputPut += i;
//         var count = i;
//         i.toExponential
//         while (count > 0) {
//             oputPut += '-';
//             count--;
//         }
//     }
// }();
// console.log(oputPut);
let level;
var getBatteryIcon = function (batteryLevel) {
    const x = batteryLevel;
    switch (true) {
        case (x > 80):
            level = '/batterylevel_four.png';
            break;
        case (x > 50):
            level = '/batterylevel_three.png';
            break;
        case (x > 24):
            level = '/batterylevel_two.png';
            break;
        default:
            level = 'batterylevel_one.png';
            break;
    }

    return './../../../android/app/src/main/res/drawable' + level;
}

console.log(getBatteryIcon(55));


// let range = (a, b) => a > b ? range(b, a).reverse() : (a == b ? [a] : range(a, b - 1).concat(b));
