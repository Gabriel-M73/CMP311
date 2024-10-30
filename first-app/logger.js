
const   EventEmmitter = require('events');

var url = 'http://L.io/log';

class Logger extends EventEmmitter {
    log(message) {
        console.log(message);
    
        // raise an event
        this.emit('messageLogged', { id: 1, url: 'https://'});
    }    
}

module.exports = Logger;