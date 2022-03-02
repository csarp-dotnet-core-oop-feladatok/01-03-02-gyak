# 01-03-02-gyak
## StudentProject
Iskolába járó diák elvégez egy osztályt. Egy ilyen feladat programozása a cél egy Digitális napló projektben. A fejlesztő csapat munkája után elkészült az osztály UML diagramja. Ön azt a feladatot kapta, hogy fejlessze ki az osztályt!

Student classban a konstruktor feltétel: ha a diák létreozásánál 1-nél kisebb vagy 12-nél nagyobb osztályt adunk meg akko a diák legyen elsős.

![alt text](https://github.com/csarp-dotnet-core-oop-feladatok/01-03-02-gyak/blob/main/StudentClass.png "UML diagram")   


A csapat segítségül tesztkimeneteket határozott meg. Munkája ellenőrzéseként használja a következő kódot:   
```
Student studentJhon = new Student("Jeles János", 3);
studentJhon.ToConsole();
studentJhon.CompletesStudentTheClass();
studentJhon.ToConsole();
studentJhon.CompletesStudentTheClass();
studentJhon.ToConsole();

Student studentPeter = new Student("Példás Péter", 7);
studentPeter.ToConsole();
studentPeter.CompletesStudentTheClass();
studentPeter.ToConsole();
studentPeter.CompletesStudentTheClass();
studentPeter.ToConsole();

```
A kód kimenete a következő kell legyen:   
```
Jeles János 3. osztályos tanuló. Alsó tagozatra jár.    
Jeles János 4. osztályos tanuló. Alsó tagozatra jár.    
Jeles János 5. osztályos tanuló. Felső tagozatra jár.     
Példás Péter 7. osztályos tanuló. Felső tagozatra jár.    
Példás Péter 8. osztályos tanuló. Felső tagozatra jár.    
Példás Péter 9. osztályos tanuló. Készül az érettségire.    
```
