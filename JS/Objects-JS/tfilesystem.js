const fs = require('fs');
const writeFileName = './write.txt'
const writeStreamFileName = './writeStream.txt'
const readStreamFileName = './readStream.txt'
/**This is not file stream program. This is file system program */
const writeData = (data) => {
    /**This will append data to file */
    fs.appendFileSync(writeFileName, '\n' + data, 'utf-8');
}
writeData('Title : Write Stream Feature NodeJS!');
writeData('Write Stream 1');
writeData('Write Stream 2');
writeData('Write Stream 3');
writeData('Write Stream 4');
writeData('Write Stream 5');

const writeStream = fs.createWriteStream(writeStreamFileName);
const readStream = fs.createReadStream(readStreamFileName);
/**Add some data into file.*/
writeStream.write('Some Sample : writeStream.write ');
writeStream.on('ready', () => {
    /**Add some additional data into file.*/
    writeStream.write(`\n Write Some Extra on Ready : writeStream.on('ready',()=>{}) `);
});
/**Read data from file stream. */
readStream.on("data", function (data) {
    var chunk = data.toString();
    console.log(chunk);
});
/* Pipe feature created by gulpJS*/
readStream.pipe(writeStream);