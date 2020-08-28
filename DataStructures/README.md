# Linked List

### What is a linked list?  
  
#### A linked list provides a way for somebody to store a list of values in a manner aside from an array. This kind of list is expandable, and many methods can be created for this list.  
  
### Why use a linked list?  
  
#### With linked lists, you can quickly - and with minimal space used - add a value. With an array in C#, to add a value to the normal array you have to create an entirely new array.  
  
Linked lists, while optimal for some things, may not always be the best option. Below are some of the methods that are in my linked list object.  
Keep in mind, this list will be growing as more methods become useful.  

#### Insert(value)  
Insert will add a new **Node** to the list with the given value, making it the new **Head**, and the old Head the **Next** value.  
  
### What's a node? Or a head?  
  
#### A node is how we store our values with a linked list. Every node in a list has a **Value** property and a **Next** property.  
#### The head is the very first value in the linked list. It's the most recent value put in, and would be the first to be removed if a node were to be removed.  
#### This structure is what we refer to as FIFO/LILO -> First In First Out/Last In Last Out.
  
#### Includes(value)  
Includes will search the list to try and find a given value. If it's in the list, it will return true, if not it returns false.  
  
#### ToString()  
ToString will take the whole list, converting it to a string that is easier to read for a user than the basic list structure.  
  