class Rectangle {

    height;
    width;

    constructor(height, width) {

        this.height = height;
        this.width = width;
    }

    get Height() {
        return this.height;
    }

    get Width() {
        return this.width;
    }
    get area() {
        return this.calcArea();
    }

    calcArea() {
        return this.height * this.width;
    }
}

class Human {
    constructor(species) {
        this.species = species;
    }

    getSpecie() {
        return this.species;
    }
}

class Person extends Human {
    constructor(firstName, lastName, age, species) {

        super(species)

        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    getFullName() {
        return this.firstName + " " + this.lastName;
    }
}

const square = new Rectangle(10,10);

const person = new Person("Bruno", "Silva", 23, "Mammal");
console.log(person.getSpecie())
console.log(person.getFullName())

console.log(square.Width)
console.log(square.Height)
console.log(square.area)