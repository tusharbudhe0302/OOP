/**
 * Buffer instances are also Uint8Array instances. However, there are subtle incompatibilities with TypedArray. For example, while ArrayBuffer#slice() creates a copy of the slice, the implementation of Buffer#slice() creates a view over the existing Buffer without copying, making Buffer#slice() far more efficient.

It is also possible to create new TypedArray instances from a Buffer with the following caveats:

The Buffer object's memory is copied to the TypedArray, not shared.

The Buffer object's memory is interpreted as an array of distinct elements, and not as a byte array of the target type. That is, new Uint32Array(Buffer.from([1, 2, 3, 4])) creates a 4-element Uint32Array with elements [1, 2, 3, 4], not a Uint32Array with a single element [0x1020304] or [0x4030201].
 */
const buffer = require('buffer').Buffer;
const arr = new Uint16Array(2);
arr[0] = 100;
arr[1] = 200;
// Copies the contents of `arr`.
const buf1 = buffer.from(arr);
// Shares memory with `arr`.
const buf2 = buffer.from(arr.buffer);

arr[1] = 6000;

console.log(buf1);
// Prints: <Buffer 88 a0>
console.log(buf2);
// Prints: <Buffer 88 a0>


