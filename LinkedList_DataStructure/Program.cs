
﻿


﻿using LinkedList;


Console.WriteLine("Welcome to LinkedList");


linkedlist linklist = new linkedlist();
linklist.Add(56);
linklist.Add(30);
linklist.Add(70);
linklist.Display();




Stack stack = new Stack();
stack.StackPush(70);
stack.StackPush(30);
stack.StackPush(56);
stack.DisplayStack();



Queue queue = new Queue();
queue.Enqueue(56);
queue.Enqueue(30);
queue.Enqueue(70);
queue.DisplayQueue();



linkedlist linklist1 = new linkedlist();
linklist1.Add(56);
linklist1.Add(70);
linklist1.Display();
linklist.Insert(2, 30);




