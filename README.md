# Exercise 10: Unity Basics

This is an exercise for the coursera course [Introduction to C# Programming and Unity](https://www.coursera.org/learn/introduction-programming-unity)

### Problem 1 - Make yellow teddy bear 4 times as large

First you'll change the game so the yellow teddy bear is drawn four times as large. You'll make these changes in code, not in the editor 

1. Right click in the Project window and create a new folder named scripts. 

2. Right click the scripts folder in the Project window and select Create > C# script. Rename the new script YellowTeddyBear

3. Double click the script in the Project window to open it in your IDE and add a documentation comment for the class


4. Delete the **Update** method, including the comment above it and all its curly braces. We don't need      that method for our solution

5. To change the location and scale of the game object the script is attached to, we need to modify the Transform component of the game object. If you look at the documentation for the **Transform** class in the Unity Scripting Reference, you'll see that it has a **localScale** variable we can access. Save a copy of that using the following code (don't put a blank line between the comment and the code):

```
//  quadruple  width  and  height
Vector3  newScale  =  transform.localScale;
```

6. Now that we have a copy, we can make the width and height four times as large using the following (don't put a blank line between the two lines of code):

```
newScale.x  ∗=  4;
newScale.y  ∗=  4;
```

7. Finally, we need to change the actual local scale of the game object using:

`transform.localScale  =  newScale;`

You might have thought that we could simply change the **x** and **y** properties of the **transform.localScale** variable directly instead of copying it into **newScale**, changing **newScale**, then copying **newScale** back into **transform.localScale**, but that doesn't work because of the rules about how C# properties work. You'll end up using this copy-change-copy back approach regularly in your Unity scripts, especially when working with the **Transform** class.

8. Drag the script from the Project window onto the YellowTeddyBear game object in the  Hierarchy window to attach the script to that game object as a component.      Left click the YellowTeddyBear game object in the Hierarchy window and look at the Inspector to confirm the script has been added

9. Run the game to confirm your code works properly

### Problem 2 - Make the green teddy bear 3 times as tall

Next you'll change the game so the green teddy bear is drawn at normal width but three times as tall

Use Steps 2-9 above as a guide to implement the required change

### Problem 3 - Make the purple teddy bear 3 times as wide

Finally, you'll change the game so the purple teddy bear is drawn three times as wide but normal height

Use Steps 2-9 above as a guide to implement the required change

 
## Installation
To install, follow these steps:

Via Downloading from GitHub:

Download this repository onto your machine by clicking the "Clone or Download" button or Fork the repo into your own Github account
Download and extract the zip file to a directory of your choice.  

Via command line:

`$ git clone https://github.com/puglisac/coursera-c-sharp-ex11.git`  

add folder to [Unity](https://unity.com/) with [Unity Hub](https://unity3d.com/get-unity/download).
