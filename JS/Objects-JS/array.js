const stringToJson = `{
"firstanme" :  " Some first name ",
"lastname" : "some last name",
"age" : 5,
"addresses" : [
{
    "line1": " SomeAddressLine",
    "zipcode": "07094"
},
{
    "line1": " SomeAddressLine2",
    "zipcode": "07093"
}
]
}`;
var obj = {
    "firstname": "Some First Name",
    "lastname": "Some Last Name",
    "age": 45,
    "address": [
        {
            "line1": "Some Line 1",
            "zip": 45678
        },
        {
            "line1": "Some Line 1",
            "zip": 4298
        }
    ]
}
// var str = JSON.stringify(obj, null, 2);
const object = JSON.parse(stringToJson)

console.dir(object, { depth: null, colors: true })
// console.log(stclsr);