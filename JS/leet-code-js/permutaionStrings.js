var sort = function (str) {
    var splitString = str.split("").reverse().join("");
    return splitString;
}
var checkInclusion = function (s1, s2) {
    if (s2.length < s1.length) {
        return false;
    }
    for (var i = 0; i <= s2.length - s1.length; i++) {
        s1 = sort(s1);
        if (s1 === (sort(s2.substring(i, i + s1.length)))) {
            return true;
        }
    }
    return false;
}

console.log(checkInclusion("ab", "eidboaoo"));