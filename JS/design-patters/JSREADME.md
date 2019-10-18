
### Object JS
Objects in JavaScript, just as in many other programming languages, can be compared to objects in real life. The concept of objects in JavaScript can be understood with real life, tangible objects.

-  Objects and properties objectName.propertyName
       
    -  Brackets ` var obj = {};`
        * Curly Brackets
        ```javascript
        let obj = { cat: 'meow',dog: 'woof'};
        let sound = obj.cat;
        console.log(sound);// meow
        let obj = {cat: 'meow',dog: 'woof'};
        let sound = obj['cat'];
        console.log(sound);// meow
        ```
        * Square Brackets
        ```javascript
        let obj = {}; obj['cat'] = 'meow'; obj['dog'] = 'woof';
         console.log(obj['cat']) // meow
        console.log(obj.cat) // meow
        ```
        * Complex Senario 
         ```javascript
        let obj = {cat: 'meow',dog: 'woof'};
        let dog = 'cat';
        let sound = obj[dog];
        console.log(sound);// meow
        ```
    - Create `var obj2 = Object.create(Object.prototype);`
        * Empty Object 
         ```javascript 
         var task2 = Object.create(Object.prototype);
        task2.title = 'Title 2';
        task2.description = 'My Task Description';
        task2.toString = function () {return this.title + ' ' + this.description;}
        console.log(task2.title); // Title 2
        console.log(task2.toString()); // My Task Description
        ```
    - new Object `var obj3 = new Object();`
         * new keyword 
           ```javascript 
            var task4 = new Object();
            task4.title = 'Title 4';
            task4.description = 'My Task Description';
            task4.toString = function () {return this.title + ' ' + this.description;}
            console.log(task4.title); // Title 4
            console.log(task4.toString()); // My Task Description
            ```
    - Object.defineProperties 
        *Object.defineProperties
    ```javascript 
    const object2 = {};
    Object.defineProperties(object2, {
        property1: {
            value: 42,
            writable: true
        },
        property2: {}
    });
    console.log(object2.property1);
    // expected output: 42
    ```

    -  Object.defineProperty
    *Object.defineProperty
    ```javascript 
    var object1 = {};
    Object.defineProperty(object1, 'property1', {
        value: 72,
        writable: false,
        enumerable: true,
        configurable: true
    })
    if (Object.isSealed(object1))
        console.log(`Is Sealed Object`);
    else
        object1.property1 = 77;
    // throws an error in strict mode
    ```

### typeof 

|Type   | Result |
---     | --     |
| Undefined	| "undefined"|
| Null | "object" (see below)|
| Boolean |	"boolean"|
| Number	| "number" |
| BigInt	| "bigint" |
|String	| "string" |
|Symbol (new in ECMAScript 2015) |	"symbol"|
|Host object (provided by the JS environment) |	Implementation-dependent|
|Function object (implements [[Call]] in ECMA-262 terms) |	"function"|
|Any other object |	"object"|

 - Some Sample Code :
   ```javascript 
    var returntype;
  if(isNaN()  == 'undefined' || isNaN()  == undefined)
   returntype = true;
   else returntype = false;
   // this will return returntype as : false
    ```

### Array Properties

- Array.length
The Array constructor's length property whose value is 1.
- get Array[@@species]
The constructor function that is used to create derived objects.
- Array.prototype
Allows the addition of properties to all array objects.
Methods
- Array.from()
Creates a new Array instance from an array-like or iterable object.
- Array.isArray()
Returns true if a variable is an array, if not false.
- Array.of()
Creates a new Array instance with a variable number of arguments, regardless of number or type of the arguments.
- Array instances
All Array instances inherit from Array.prototype. The prototype object of the Array constructor can be modified to affect all Array instances.

###### Prototype Properties

- Array.prototype.constructor
Specifies the function that creates an object's prototype.
- Array.prototype.length
Reflects the number of elements in an array.
- Array.prototype[@@unscopables]
A symbol containing property names to exclude from a with binding scope.
Methods
Mutator methods
These methods modify the array:
- Array.prototype.copyWithin()
Copies a sequence of array elements within the array.
- Array.prototype.fill()
Fills all the elements of an array from a start index to an end index with a static value.
- Array.prototype.pop()
Removes the last element from an array and returns that element.
- Array.prototype.push()
Adds one or more elements to the end of an array and returns the new length of the array.
- Array.prototype.reverse()
Reverses the order of the elements of an array in place — the first becomes the last, and the last becomes the first.
- Array.prototype.shift()
Removes the first element from an array and returns that element.
- Array.prototype.sort()
Sorts the elements of an array in place and returns the array.
- Array.prototype.splice()
Adds and/or removes elements from an array.
- Array.prototype.unshift()
Adds one or more elements to the front of an array and returns the new length of the array.

###### Accessor methods

These methods do not modify the array and return some representation of the array.
- Array.prototype.concat()
Returns a new array that is this array joined with other array(s) and/or value(s).
- Array.prototype.includes()
Determines whether an array contains a certain element, returning true or false as appropriate.
- Array.prototype.indexOf()
Returns the first (least) index of an element within the array equal to the specified value, or -1 if none is found.
- Array.prototype.join()
Joins all elements of an array into a string.
- Array.prototype.lastIndexOf()
Returns the last (greatest) index of an element within the array equal to the specified value, or -1 if none is found.
- Array.prototype.slice()
Extracts a section of an array and returns a new array.
- Array.prototype.toSource() 
Returns an array literal representing the specified array; you can use this value to create a new array. Overrides the Object.prototype.toSource() method.
- Array.prototype.toString()
Returns a string representing the array and its elements. Overrides the - Object.prototype.toString() method.
- Array.prototype.toLocaleString()
Returns a localized string representing the array and its elements. Overrides the Object.prototype.toLocaleString() method.

###### Iteration methods

Several methods take as arguments functions to be called back while processing the array. When these methods are called, the length of the array is sampled, and any element added beyond this length from within the callback is not visited. Other changes to the array (setting the value of or deleting an element) may affect the results of the operation if the method visits the changed element afterwards. While the specific behavior of these methods in such cases is well-defined, you should not rely upon it so as not to confuse others who might read your code. If you must mutate the array, copy into a new array instead.

- Array.prototype.entries()
Returns a new Array Iterator object that contains the key/value pairs for each index in the array.
- Array.prototype.every()
Returns true if every element in this array satisfies the provided testing function.
- Array.prototype.filter()
Creates a new array with all of the elements of this array for which the provided filtering function returns true.
- Array.prototype.find()
Returns the found value in the array, if an element in the array satisfies the provided testing function or undefined if not found.
- Array.prototype.findIndex()
Returns the found index in the array, if an element in the array satisfies the provided testing function or -1 if not found.
- Array.prototype.forEach()
Calls a function for each element in the array.
- Array.prototype.keys()
Returns a new Array Iterator that contains the keys for each index in the array.
- Array.prototype.map()
Creates a new array with the results of calling a provided function on every element in this array.
- Array.prototype.reduce()
Apply a function against an accumulator and each value of the array (from left-to-right) as to reduce it to a single value.
- Array.prototype.reduceRight()
Apply a function against an accumulator and each value of the array (from right-to-left) as to reduce it to a single value.
- Array.prototype.some()
Returns true if at least one element in this array satisfies the provided testing function.
- Array.prototype.values()
Returns a new Array Iterator object that contains the values for each index in the array.
- Array.prototype[@@iterator]()
Returns a new Array Iterator object that contains the values for each index in the array.

### Function.prototype

- Function.bind()
 bind() method creates a new function 
 ** syntax : `function.bind(thisArg[, arg1[, arg2[, ...]]])`
Code : 
 ```javascript 
 var module = { x: 42, getX: function() { return this.x; } }
var unboundGetX = module.getX;
// The function gets invoked at the global scope
console.log(unboundGetX()); // expected output: undefined
var boundGetX = unboundGetX.bind(module);
console.log(boundGetX());// expected output: 42
```

- Function.apply()
apply() method calls a function with a given this value, and arguments 
** syntax : `function.apply(thisArg, [argsArray])`
Code :
 ```javascript 
 var numbers = [5, 6, 2, 3, 7];
var max = Math.max.apply(null, numbers);
console.log(max);// 7
```
- Function.call()
call()to chain constructors for an object, similar to Java
** syntax :  `function.call(thisArg, arg1, arg2, ...)`
Code:
```javascript 
function Product(name, price) {
  this.name = name;
  this.price = price;
};
function Food(name, price) {
  Product.call(this, name, price);
  this.category = 'food';
};
function Toy(name, price) {
  Product.call(this, name, price);
  this.category = 'toy';
};
var cheese = new Food('feta', 5);
var fun = new Toy('robot', 40);
console.log(`Chese Object : ${JSON.stringify(cheese)}`);  
//Chese Object : {"name":"feta","price":5,"category":"food"}
```

### Iterators and Generators in Javascript
- Iterators
An iterator is an object that can access one item at a time from a collection while keeping track of its current position. Javascript is a bit ‘simpler’ than c# in this aspect and just requires that you have a method called next to move to the next item to be a valid iterator.
```javascript
function makeRangeIterator(start = 0, end = Infinity, step = 1) {
    let nextIndex = start;
    let iterationCount = 0;

    const rangeIterator = {
       next: function() {
           let result;
           if (nextIndex < end) {
               result = { value: nextIndex, done: false }
               nextIndex += step;
               iterationCount++;
               return result;
           }
           return { value: iterationCount, done: true }
       }
    };
    return rangeIterator;
}
```
We could now use this function to create an iterator and iterate over it:
```javascript
let it = makeRangeIterator(1, 10, 2);

let result = it.next();
while (!result.done) {
 console.log(result.value); // 1 3 5 7 9
 result = it.next();
}
console.log("Iterated over sequence of size: ", result.value); 
// [5 numbers returned, that took interval in between: 0 to 10]

```

- Generators 
Generator functions are written using the function* syntax. When called initially, generator functions do not execute any of their code, instead returning a type of iterator called a Generator. When a value is consumed by calling the generator's next method, the Generator function executes until it encounters the yield keyword.

```javascript
function* makeRangeIterator(start = 0, end = 100, step = 1) {
    for (let i = start; i < end; i += step) {
        yield i;
    }
}
```

- Deferred Execution
Since we have the same possibilities for yielding return values in Javascript as in C#, the only what’s missing to be able to recreate LINQ in Javascript are extension methods. Javascript doesn’t have extension methods, but we can do something similar.

What we’d like to do is to be able to write something like this:
`generateNumbers().skip(3).take(5).select(n => n * 3);`

```javascript
function* Chainable() {
} 
function createChainable(f){ 
    f.prototype = Chainable.prototype; 
    return f; 
}
```

```javascript
function createFunction(f) { 
    createChainable(f); 
    Chainable.prototype[f.name] = function(...args) { 
        return f.call(this, ...args); }; 
        return f; 
    }
}
```

In the above method:

- It makes sure the function itself is also chainable, by calling createChainable
- Then it attaches the method to the shared protoype (using the name of the function). The method receives the arguments, which gets passed on to that method while supplying the correct this-context.

With this in place we can now create our “extension methods” in Javascript:
```javascript
// the base generator 
let test = createChainable(function*(){ 
    yield 1; 
    yield 2; 
    yield 3; 
    yield 4; 
    yield 5; 
}); 
// an 'extension' method 
createFunction(function* take(count){ 
    for(let i=0;i<count;i++){ 
        yield this.next().value; 
    } 
}); 
// an 'extension' method 
createFunction(function* select(selector){ 
    for(let item of this){ 
        yield selector(item); 
    } 
}); 

// now we can iterate over this and this will log 2,4,6) 
for(let item of test.take(3).select(n => n*2)){ 
    console.log(item); 
}
```
Note that in the above method, it doesn’t matter whether we first <font face="Courier New">take</font> and then <font face="Courier New">select</font> or the other way around. Because of the deferred execution, it will only fetch 3 values and do only 3 selects.

### Caveat

One problem with the above is that it doesn’t work on standard iterables such as Arrays, Sets and Maps because they don’t share the prototype. The workaround is to write a wrapper-method that wraps the iterable with a method that does use the shared prototype:
```javascript
let wrap = createChainable(function*(iterable){ 
    for(let item of iterable){ 
        yield item; 
    } 
});

With the wrap function, we can now wrap any array, set or map and chain our previous function to it:
```javascript
let myMap = new Map(); 
myMap.set("1", "test"); 
myMap.set("2", "test2"); 
myMap.set("3", "test3"); 
for(let item of wrap(myMap).select(([key,value]) => key + "--" + value)
                           .take(3)){ 
   console.log(item); 
}

```
One more thing I want to add is the ability to execute a chain, so that it returns an array (for c# devs: the ToList-method). This method can be added on to the prototype:
```javascript
Chainable.prototype.toArray = function(){ 
    let arr = []; 
    for(let item of this){ 
        arr.push(item); 
    } 
    return arr; 
}
```