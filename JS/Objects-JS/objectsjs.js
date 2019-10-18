var checkSplit = "";
// var myMap = checkSplit.split('', 2);
var k = 2;
for (var i = 0; i < checkSplit.length; i += (k * 2)) {
    checkSplit = checkSplit.replace(checkSplit.slice(i, i + k), checkSplit.slice(i, i + k).split('').reverse().join(''));
}
console.log(checkSplit);