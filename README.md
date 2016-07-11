# Motorcycle Physics
Physics-based model. Motorcycle turns forward wheel and equilibrates. It uses countersteering for turning.

#### How to run 
It is Unity project, scene in accets folder. 

#### Keys:
* Escape to exit
* backspace - restore model (if it fell)
* w,a,s,d or arrows for moving
* space for braking the rear wheel

#### Details

At normal speed (about 5 - 30 m/s) it equlibrates only with wheel pretty well.
At low speed it uses engine to speed up and avoid falling.
At high speed there are wobbling :( I used some hacks to increase critical speed from 30 up to 40-50 m/s

In addition, I use physics step 0.005 s.


