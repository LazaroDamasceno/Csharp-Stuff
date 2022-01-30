﻿using Generics;

var collection = new GenericCollection<int>();
collection.InsertAtTheEnd(1);
collection.InsertAtTheEnd(7);
collection.InsertAtTheEnd(7);
collection.InsertAtTheEnd(7);
collection.InsertAtTheEnd(5);
collection.InsertAtTheEnd(6);
collection.DisplayAllElements();
collection.Resize(10);
collection.InsertAtTheEnd(7);
collection.InsertAtTheEnd(8);
collection.InsertAtTheEnd(9);
collection.InsertAtTheEnd(10);
collection.DisplayAllElements();
collection.RemoveSpecificElement(7);
collection.DisplayAllElements();
collection.InsertAtTheEnd(14);
collection.InsertAtTheEnd(14);
collection.InsertAtTheEnd(13);
collection.InsertAtTheEnd(14);
collection.DisplayAllElements();
collection.RemoveSpecificElement(14);
collection.DisplayAllElements();
collection.InsertAtTheEnd(7);
collection.InsertAtTheEnd(8);
collection.InsertAtTheEnd(9);
collection.InsertAtTheEnd(10);
collection.DisplayAllElements();
collection.RemoveAt(9);
collection.DisplayAllElements();
collection.RemoveFirst();
collection.DisplayAllElements();
collection.RemoveLast();
collection.DisplayAllElements();
collection.InsertAtTheEnd(33);
collection.DisplayAllElements();
collection.InsertAtTheBegin(32);
collection.InsertAtTheBegin(34);
collection.InsertAtTheBegin(35);
collection.DisplayAllElements();