const events = require('events');
const myEmitter = new events.EventEmitter();
/**Problem 1 : Create Simple Event emitter and call */
myEmitter.on('firsteventNoArgumet', () => {
    console.log('first default event occurred!');
});
myEmitter.emit('firsteventNoArgumet');
/**Problem 2 : Create Simple Event emitter with params */
myEmitter.on('secondEventWithArgument', (message) => {
    console.log('second event occurred!' + message);
});

myEmitter.emit('secondEventWithArgument', 'Hello Second Event Emitter');
/** Problem 3 : Do Callback in event emitter.Next to impossible.
 * Event emiter is not made for this. Go With Stream feature. 
 * Event Emitter should not return callback results.
 *  It's not easy way. To callback data in event emitter. Only Solution create global scope of Buffer to hold data. 
 *  This will help to separet read and write stream. As network has upload an ddonload speed. 
 *  By assuming network has two pipe.
 * 1. Write Stream
 * 2. Read Stream
 * Simply go with stream feature of nodeJs.
 */
myEmitter.on('thirdEventWithArgumentCallback ', (message, callback) => {
    console.log('thrid  event occurred !');
    message += ' thirdEventWithArgumentCallback.Done!'
    callback(null, message);
});

myEmitter.emit('thirdEventWithArgumentCallback', 'Hello from callback to event emiter', (err, response) => {
    if (err) {
        console.log('Best Practices as nodeJS developer , always check error irst then retun callback.')
        return;
    } else {
        console.log(`${response} , It's event emitter callback!`);
    }
});

/**Comment for test max event listener Option. Default stop */
// myEmitter.setMaxListeners(myEmitter.getMaxListeners() + 1);
/**Not need to call expicitly.It will atomitcly call Once 'firsteventNoArgumet' fired.*/
myEmitter.once('firsteventNoArgumet', () => {
    // do stuff Once event Occure. Max Listner is default 10.
    console.log(`Get Max Listeners : ${myEmitter.getMaxListeners()}`);
    /**Cutom max listner max Count */
    myEmitter.setMaxListeners(3);
});

myEmitter.emit('firsteventNoArgumet');

myEmitter.once('OnceOnlyEventOccured', () => {
    console.log(`OnceOnlyEventOccured Should not execute always`);
})
