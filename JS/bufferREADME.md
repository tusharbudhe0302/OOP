# Buffer

Prior to the introduction of TypedArray, the JavaScript language had no mechanism for reading or manipulating streams of binary data. The Buffer class was introduced as part of the Node.js API to enable interaction with octet streams in TCP streams, file system operations, and other contexts.

With TypedArray now available, the Buffer class implements the Uint8Array API in a manner that is more optimized and suitable for Node.js.

Instances of the Buffer class are similar to arrays of integers from 0 to 255 (other integers are coerced to this range by & 255 operation) but correspond to fixed-sized, raw memory allocations outside the V8 heap. The size of the Buffer is established when it is created and cannot be changed.

The Buffer class is within the global scope, making it unlikely that one would need to ever use** require('buffer').Buffer**.

JavaScript language had no mechanism for reading or manipulating streams of binary data.
 *  Buffer class was introduced as part of the Node.js API to enable interaction with octet streams in TCP streams, file system operations, and other contexts
 * With "TypedArray" now available, the Buffer class implements the "Uint8Array" API in a manner that is more optimized and suitable for Node.js.
 * A TypedArray object describes an array-like view of an underlying binary data buffer.
 * The Uint8Array typed array represents an array of 8-bit unsigned integers. The contents are initialized to 0

1. create a TypedArray with a size in bytes
`const typedArray1 = new Int8Array(8);`
`typedArray1[0] = 32;`
`const typedArray2 = new Int8Array(typedArray1);`
`typedArray2[1] = 42;`
`console.log(typedArray1);`
// expected output: Int8Array [32, 0, 0, 0, 0, 0, 0, 0]
`console.log(typedArray2);`
// expected output: Int8Array [32, 42, 0, 0, 0, 0, 0, 0]`
2. The Uint8Array typed array represents an array of 8-bit unsigned integers. The contents are initialized to 0. Once established, you can reference elements in the array using the object's methods, or using standard array index syntax (that is, using bracket notation).
`new Uint8Array();`
`new Uint8Array(length);`
`new Uint8Array(typedArray);`
`new Uint8Array(object);`
`new Uint8Array(buffer [, byteOffset [, length]]);`
------------

- Buffer.from(), Buffer.alloc(), and Buffer.allocUnsafe()
	The --zero-fill-buffers command line option
	What makes Buffer.allocUnsafe() and Buffer.allocUnsafeSlow() "unsafe"?
- Buffers and Character Encodings
- Buffers and TypedArray
- Buffers and iteration


------------

- Class: Buffer

	new Buffer(array)
	new Buffer(arrayBuffer[, byteOffset[, length]])
	new Buffer(buffer)
	new Buffer(size)
	new Buffer(string[, encoding])
	Class Method: Buffer.alloc(size[, fill[, encoding]])
	Class Method: Buffer.allocUnsafe(size)
	Class Method: Buffer.allocUnsafeSlow(size)
	Class Method: Buffer.byteLength(string[, encoding])
	Class Method: Buffer.compare(buf1, buf2)
	Class Method: Buffer.concat(list[, totalLength])
	Class Method: Buffer.from(array)
	Class Method: Buffer.from(arrayBuffer[, byteOffset[, length]])
	Class Method: Buffer.from(buffer)
	Class Method: Buffer.from(object[, offsetOrEncoding[, length]])
	Class Method: Buffer.from(string[, encoding])
	Class Method: Buffer.isBuffer(obj)
	Class Method: Buffer.isEncoding(encoding)
	Class Property: Buffer.poolSize
	buf[index]
	buf.buffer
	buf.byteOffset
	buf.compare(target[, targetStart[, targetEnd[, sourceStart[, sourceEnd]]]])
	buf.copy(target[, targetStart[, sourceStart[, sourceEnd]]])
	buf.entries()
	buf.equals(otherBuffer)
	buf.fill(value[, offset[, end]][, encoding])
	buf.includes(value[, byteOffset][, encoding])
	buf.indexOf(value[, byteOffset][, encoding])
	buf.keys()
	buf.lastIndexOf(value[, byteOffset][, encoding])
	buf.length
	buf.parent
	buf.readBigInt64BE([offset])
	buf.readBigInt64LE([offset])
	buf.readBigUInt64BE([offset])
	buf.readBigUInt64LE([offset])
	buf.readDoubleBE([offset])
	buf.readDoubleLE([offset])
	buf.readFloatBE([offset])
	buf.readFloatLE([offset])
	buf.readInt8([offset])
	buf.readInt16BE([offset])
	buf.readInt16LE([offset])
	buf.readInt32BE([offset])
	buf.readInt32LE([offset])
	buf.readIntBE(offset, byteLength)
	buf.readIntLE(offset, byteLength)
	buf.readUInt8([offset])
	buf.readUInt16BE([offset])
	buf.readUInt16LE([offset])
	buf.readUInt32BE([offset])
	buf.readUInt32LE([offset])
	buf.readUIntBE(offset, byteLength)
	buf.readUIntLE(offset, byteLength)
	buf.subarray([start[, end]])
	buf.slice([start[, end]])
	buf.swap16()
	buf.swap32()
	buf.swap64()
	buf.toJSON()
	buf.toString([encoding[, start[, end]]])
	buf.values()
	buf.write(string[, offset[, length]][, encoding])
	buf.writeBigInt64BE(value[, offset])
	buf.writeBigInt64LE(value[, offset])
	buf.writeBigUInt64BE(value[, offset])
	buf.writeBigUInt64LE(value[, offset])
	buf.writeDoubleBE(value[, offset])
	buf.writeDoubleLE(value[, offset])
	buf.writeFloatBE(value[, offset])
	buf.writeFloatLE(value[, offset])
	buf.writeInt8(value[, offset])
	buf.writeInt16BE(value[, offset])
	buf.writeInt16LE(value[, offset])
	buf.writeInt32BE(value[, offset])
	buf.writeInt32LE(value[, offset])
	buf.writeIntBE(value, offset, byteLength)
	buf.writeIntLE(value, offset, byteLength)
	buf.writeUInt8(value[, offset])
	buf.writeUInt16BE(value[, offset])
	buf.writeUInt16LE(value[, offset])
	buf.writeUInt32BE(value[, offset])
	buf.writeUInt32LE(value[, offset])
	buf.writeUIntBE(value, offset, byteLength)
	buf.writeUIntLE(value, offset, byteLength)

------------

- buffer.INSPECT_MAX_BYTES
- buffer.kMaxLength
- buffer.transcode(source, fromEnc, toEnc)
- Class: SlowBuffer
	new SlowBuffer(size)
- Buffer Constants
	buffer.constants.MAX_LENGTH
	buffer.constants.MAX_STRING_LENGTH