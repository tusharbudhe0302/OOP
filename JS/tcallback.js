function doCallbackHell(param1, callback) {
    /**return is best practices in javascript.*/
    return callback(null, 'Params + ' + param1);
}
/** how callback works! */
doCallbackHell('myFirstParam', (err, callback) => {
    console.log(callback);
})