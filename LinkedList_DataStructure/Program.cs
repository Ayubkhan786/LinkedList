
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




//To DeleteLast
linkedlist linklist3= new linkedlist();
linklist3.Add(56);
linklist3.Add(30);
linklist3.Add(70);
linklist3.DeleteLast();
linklist3.Display();



//To FindNode
linkedlist linklist4 = new linkedlist();
linklist4.Add(56);
linklist4.Add(30);
linklist4.Add(70);
linklist4.Display();
linklist4.Find(30);



//To InsertDataInBetween
linkedlist linklist5 = new linkedlist();
linklist5.Add(56);
linklist5.Add(30);
linklist5.Add(70);
linklist5.Insert(2, 40);
linklist5.Display();






//To DeleteDataInBetween
linkedlist linklist6 = new linkedlist();
linklist6.Add(56);
linklist6.Add(30);
linklist6.Add(40);
linklist6.Add(70);
linklist6.DeleteBetween(40);
linklist6.Display();
