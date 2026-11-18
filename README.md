# GAME-EGN Labs
For labs in Game Engine

-

-

Charleen Chu, 100784133

-

-

-

**LAB 2**

**Project descriptuion:**

Project is called Wild Ride, which is a small side project made to test game engine labs and activities. This is spin on Frogger/Crossy Road, you forgot your picknik food, so you have to drive around and forage for food before going to your campsite... But becareful! This road belongs to 'The Wilds'.

The controls are: 'WASD' to move, 'E' to check time elapsed, 'R' to restart

Currently there is no goal on how many food to collect, but the point is to collect enough and proceed to the end like how it is in Frogger/Crossy Road.

**Screenshots:**

SpawnDestroy after around 1 minute:

<img width="1141" height="506" alt="SpawnDestroy 1 min" src="https://github.com/user-attachments/assets/955b064e-b9cc-4b30-9ef3-b7767195a179" />

-

Pooling after around 1 minute:

<img width="1455" height="632" alt="Pooling 1 min" src="https://github.com/user-attachments/assets/27f2e69a-d327-488c-a6f2-ecfa9059ae8a" />

-

SpawnDestroy after around 2 minute:

<img width="1137" height="663" alt="Pooling 2 min" src="https://github.com/user-attachments/assets/9e6d7846-b799-497d-9918-a541aa60622a" />

-

Pooling after around 2 minute:

<img width="1455" height="515" alt="Pooling 2 min" src="https://github.com/user-attachments/assets/49536d16-5b41-482c-b612-d61f0a4b01f6" />

-

-

-

**Implementation:**

A factory pattern for the food instead of spawner (which is now used for the animals, but maybe I can replace it too), as well as pooling for the food. I also added SceneManager for scene handling like resets and display time elapsed, but in console right now though, I had no time for UI :(

This project must be opened in editor to see the console message for elapsed time, as well as the current scores, and quotes.

**What Improved:**

I believed pooling definitely have to improve the performance, as it prevents constant instancing and destroying, thus lowers GC Allocations.

**What Revealed:**

Currently I'm ignoring Physics, Animation, and UI, as I don't think this will affect them/optimize them.

It looks like GC Allocation improved a bit, as after selecting a random frame (2567) during the 2 minutes mark, it shows that SpawnDestroy has 30.0KB for GC Allocation, while Pooling has only 18.4KB. 

Script is also slightly faster on Pooling than SpawnDestroy (though only for 0.01ms difference). CPU usage is also higher on Pooling than SpawnDestroy. 

But other than that, Pooling is better in Total Used Memory (0.16 GB difference) and GC Used Memory (0.2 MB difference).

I believe future improvements is to be replacing the old spawner system with pooling for the animals as well.

-

-

-

**LAB 1**

**Project descriptuion:**

Project is called Accel, which came from a personal WIP project used for this lab. It's a past paced 3D platformer where you have to jump through platforms until you reach the glowing blue gate and go to next level, if you touch the ground you will reset to the begining. 

The controls are: 'WASD' to move, 'Mouse' to look around, 'Shift' to speed, and 'R' to restart



**Diagram for my Singleton GameManager**

<img width="965" height="1581" alt="singleton chart lab 1" src="https://github.com/user-attachments/assets/901ab436-3794-48a3-876d-720d8d98076f" />



**Reflection:**

The singleton is perfect as a GameManager. It manages the "best time score," handles the scenes and it's transition, as well as restarting the current scene for a reset.



**Refrences:**

Player character uses Mixamo's Kachujin G. Rosales' model. For level prototyping I uses Unity's basic 3D primitives.

Marcus.

Chart formatting used to make my chart from Medium (https://medium.com/@Code_With_K/understanding-the-singleton-pattern-in-c-and-unity-f5abd1ab80bb):

<img width="583" height="429" alt="image" src="https://github.com/user-attachments/assets/673f11d1-7a94-4609-a5f7-948f6f1af59e" />
