(sv)
## Labb2

Denna labb är utförd av Philip Alderstig

- Jag började med att titta över projektet för att förstå dess funktion.

- Jag bröt ut de metoder som låg i OrderServicen till egna klasser med intentionen att använda Single responsibility principen.

- Jag skapade interface för mina klasser för att underlätta framtida utökning av projektet enligt Open/Closed principen samt  Interface segregation principen.

- Tack vare min refaktorering samt genom att ändra på properties i Order så att en order istället för att ta en order-prioritering nu tog en "processmetod" (alltså på vilket sätt/vilken fart ordern skulle behandlas)
  kunde jag ta bort det if-statement som låg i OrderService och därmed få bort många rader kod

- Jag gjorde sedan så att OrderService kunde ta processa en lista av orders och därmed hantera flera orders samtidigt

(eng)
## Lab2

This lab is made by Philip Alderstig

- I started by looking at the project to understand its function.

- I refactored the methods that were located in the OrderService into their own classes with the intention of using the Single responsibility principle.

- I created interfaces for my classes to facilitate future expansion of the project according to the Open / Closed principle and the Interface segregation principle.

- Thanks to my refactoring and by changing the properties in Order so that an order instead of taking an order-priority now took a "processmethod" (in what way / what speed the order would be processed),
  i was able to delete the if-statement that was in OrderService and thus remove many lines of code

- I then made it so that OrderService could process a list of orders rather than a single order and thus handle several orders simultaneously