var address = function (address) {
    this.addressLine1 = address.addressLine1;
    this.addressLine2 = address.addressLine2;
    this.city = address.city;
    this.state = address.state;
    this.postalCode = address.postalCode;
}
var person = function (name) {
    this.firstname = name.firstname;
    this.lastname = name.lastname;
    this.fullname = this.firstname + " " + this.lastname;
    /*    this.address = new address(name.address); */
    // person {
    //     firstname: 'Tushar',
    //     lastname: 'Budhe',
    //     fullname: 'Tushar Budhe',
    //     address:
    //      address {
    //        addressLine1: '1366 B, Paterson Plank RD',
    //        addressLine2: '',
    //        city: 'secaucus',
    //        state: 'NJ',
    //        postalCode: '07094' } }
    /*    this.address = address.call(this, name.address); */
    // person {
    //     firstname: 'Tushar',
    //     lastname: 'Budhe',
    //     fullname: 'Tushar Budh
    //     addressLine1: '1366 B,
    //     addressLine2: '',
    //     city: 'secaucus',
    //     state: 'NJ',
    //     postalCode: '07094',
    //     address: undefined }
}
person.prototype = Object.create(address.prototype); // // subclass extends superclass
var newPerson = new person({
    firstname: 'Tushar', lastname: 'Budhe', address: {
        addressLine1: '1366 B, Paterson Plank RD',
        addressLine2: '',
        city: 'secaucus',
        state: 'NJ',
        postalCode: '07094'
    }
});
console.log(newPerson);