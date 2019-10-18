# Events

The Events class is within the global scope, making it unlikely that one would need to ever use** require('events')**.

> require('events')
> require('events').EventEmitter

`var emitter = new EventEmitter()`

*Basic Methods*
 - emitter.eventNames()
 - emitter.listenerCount(eventName)
-  emitter.listeners(eventName)
 - emitter.removeListener(eventName, listener)
- events.once(emitter, name)
- EventEmitter.defaultMaxListeners.

*** Notes : 
1. All basic events are part of operating system.Event Custom event internaly use Interface provided by OS to register your custom event.
2. Event Emitter should not return callback results.