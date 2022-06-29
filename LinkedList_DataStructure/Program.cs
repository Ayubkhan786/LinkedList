
﻿


﻿using LinkedList;


Console.WriteLine("Welcome to LinkedList");

//To Add 
linkedlist linklist = new linkedlist();
linklist.Add(56);
linklist.Add(30);
linklist.Add(70);
linklist.Display();




// To Add in Stack
Stack stack = new Stack();
stack.StackPush(70);
stack.StackPush(30);
stack.StackPush(56);
stack.DisplayStack();


//To Add in Queue
Queue queue = new Queue();
queue.Enqueue(56);
queue.Enqueue(30);
queue.Enqueue(70);
queue.DisplayQueue();



//To Insert
linkedlist linklist2 = new linkedlist();
linklist2.Add(56);
linklist2.Add(70);
linklist2.Insert(2 , 30);
linklist2.Display();



// To DeleteFirst
linkedlist linklist1 = new linkedlist();
linklist1.Add(56);
linklist.Add(30);
linklist1.Add(70);
linklist1.Pop();
linklist1.Display();






