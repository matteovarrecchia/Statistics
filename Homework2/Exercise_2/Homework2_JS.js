// Array
const myArray = ['value1', 'value2', 'value3'];

// Loop (break/continue)
for (let i = 0; i < myArray.length; i++) {
    if (myArray[i] === 'condition1') {
        break; // Break the loop and exit
    }
    if (myArray[i] === 'condition2') {
        continue; // Continue to the next iteration
    }
}

// Add/Remove/Get/Set/Check the existence of value
myArray.push('value4'); // Add a new element to the end of the array
myArray.pop(); // Remove the last element from the array
myArray.unshift('newElement'); // Add a new element to the beginning of the array
myArray.shift(); // Remove the first element from the array
const x = myArray[0]; // Get an element by index
myArray[1] = 'something else'; // Set the value of the element at index 1
const isPresent = myArray.includes('value1'); // Check if an element exists in the array
const valueIndex = myArray.indexOf('value1'); // Find the index of an element in the array

// List
class Node {
    constructor(data) {
        this.data = data;
        this.next = null;
    }
}

class LinkedList {
    constructor() {
        this.head = null;
    }

    // Loop (break/continue)
    for(let current = this.head; current; current = current.next) {
        // Loop through the linked list
    }

    // Add/Remove/Get/Set/Check the existence of value
    append(data) {
        // Add a new node to the end of the linked list
    }

    remove(data) {
        // Remove the first occurrence of a node with the given data
    }

}

// Dictionary (Using Map)
const dictionary = new Map();

// Loop (break/continue)
for (const [key, value] of dictionary) {
    console.log(`Key: ${key}, Value: ${value}`);
}

// Add/Remove/Get/Set/Check the existence of key
dictionary.set('key1', 'value1'); // Add key-value pairs
dictionary.delete('key1'); // Remove a key-value pair
const value = dictionary.get('key1'); // Get the value using a key
const hasKey = dictionary.has('key1'); // Check if a key exists

// Sorted List
class SortedList {
    constructor() {
        this.list = [];
    }

    // Loop (break/continue)
    for(let i = 0; i <this.list.length; i++) {
    // Loop through the sorted list
}

// Add/Remove/Get/Set/Check the existence of value
addItem(value) {
    // Add an element to the sorted list
}

removeItem(value) {
    // Remove an element from the sorted list
}

}

// HashSet
const mySet = new Set();

// Loop (break/continue)
mySet.forEach(value => {
    // Loop through the set
});

// Add/Remove/Check the existence of value
mySet.add(1); // Add elements to the set
mySet.delete(2); // Remove elements from the set
const hasTwo = mySet.has(2); // Check if an element exists

// SortedSet
class SortedSet {
    constructor() {
        this.values = [];
        this.set = new Set();
    }

    // Loop (break/continue)
    for(let i = 0; i <this.values.length; i++) {
    // Loop through the sorted set
}

// Add/Remove/Check the existence of value
add(value) {
    // Add an element to the sorted set
}

remove(value) {
    // Remove an element from the sorted set
}

}

// Queue (Using Array)
const queue = [];

// Loop (break/continue)
for (let i = 0; i < queue.length; i++) {
    // Loop through the queue
}

// Add/Remove/Check the existence of value
queue.push(1); // Enqueue (add to the back)
const removedElement = queue.shift(); // Dequeue (remove from the front)

// Stack (Using Array)
const stack = [];

// Loop (break/continue)
for (let i = 0; i < stack.length; i++) {
    // Loop through the stack
}

// Add/Remove/Check the existence of value
stack.push(1); // Push (add to the end)
const poppedElement = stack.pop(); // Pop (remove from the end)
