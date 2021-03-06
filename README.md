# Thanks for helping the Project Fizzyo 
----

Our hope is the Fizzyo device will motivate children to do their physio every day and potentially help other families with Cystic Fibrosis as well!

If you are a game developer it’s as easy as 1-2-3.

The Fizzyo device appears as a Joystick on the computer, so you simply need to have your game interpret joystick inputs.

The Unity3d Fizzyo Framework is available  at https://github.com/Fizzyo/FizzyoFramework-Unity 

----
### We allow for 2 types of inputs:

 - Breath – This appears as the Horizontal axis of the joystick, (float) returns breath strength from (-1 – 1) with 0 being not breathing, > 0.7 blowing or breathing out hard and < -0.5 breathing in hard
 
 - Button Press – We’ve added 1 button to the device to make game interactions a little more sophisticated. This button appears as Fire1 from a joystick control.

----

## Typical Physio Sequence

- 9 - 10 cycles of the following routine
- Long slow breadth in until lungs are full typically 2 sec depending on size of child
- Exhale out active but not forced typically 3 secs in length depending on size of child - maintained velocity so this is about duration not velocity) 
- Think about these durations in terms of game play 
- The patient is required to do  a huff/cough (the device is typically removed) This is forceful and the most important as its part of airway clearance (can this be used with your game? or do you simply want to pause the game play after the end of the cycle)

----
## Game Types - think about the exercise

### Games children have suggested
- Bowling/firing a object (Breadth to charge)
- Geometry Dash/Flappy Bird (Jumping or movement)
- Angry Bird (Breadth to charge/fire)

----
## Game requirements

Keep in mind that we don’t want to force the children to blow to a certain pressure or for a certain amount of time. This is really up to the individual doing the exercises, we just want to detect a blow.

Designing a game for these limited interactions can be challenging! A good play pattern has been to use the blow to propel the character forward (at a constant speed) and the button to jump or fire a weapon.

In relation to output of the games from Health Hack we would like to implement a specific requirement / specification of games for use with the Fizzyo devices.

Children may have to 10 cycles of 10 breadths with a pause for a huff and cough between each cycle.

At the end of each set the game should pause and allow the children to huff and cough then press a button to continue with the game.

----
## Hardware Requirement for the Fizzyo Games

Windows UWP Games are required for the patients.
The specification of the games needs to be capable of running on the following hardware specifications. 

- Resolution: 1280 x 800
- Processor Intel® Atom™ x5-Z8300 (Cherry Trail) Quad Core, 64 Bit
- Graphics Intel® HD Graphics (Generation 8)
- Memory 2gb DDR3L-1600
- Storage Internal: 32GB eMMc 


### Airway Clearance Physio Devices

![Airway Clearance Devices](Airway.jpg)


### Test Data from devices + Samples

- We have provided a Unity Sample Game which shows the input methods - see [Fizzyo-Unity-Example]- https://github.com/Fizzyo/FizzyoFramework-Unity Folder which contains pre calibration information, a sample game and test harness + test data
- 
- We have provided Test Harnesses and sample data. The data data set of captured results from the devices are for games testing. This includes an example that allows you to load and playback breath data saved from a fizzyo device.

### Performance Optimisation of Unity Games 

See the following Unity Resources. 

- https://docs.unity3d.com/Manual/MobileOptimizationPracticalGuide.html
- https://unity3d.com/partners/microsoft/porting-guides
----
## How the Devices are used by Patients and how this should be related to game play

- Although getting a decent sized breath during inspiration is important – most of the focus is on expiration so the length duration of the breadth (this is the part where airway clearance is most effective).

- Inspiration is ‘free’ and un-resisted in all three techniques – while all 3 devices provide resistance against expiratory airflow 
(providing ‘positive expiratory pressure’ or PEP)

- PEP provides a consistent and measureable resistance against expiration

- Acapella and Flutter provide oscillatory resistance (Acapella with a magnetic lever and Flutter with a ball valve)

- Children aim for ‘active’ expiration rather than ‘relaxed or elastic recoil’ expiration(which is what happens normally). This means consistent, steady flow at a higher velocity than usual but not forced breathing.  

- Children aim for prolonged steady expiratory flow of at least 3s (although this may be a bit shorter in small children or those with severe disease who are breathless)

- The resistance in mid expiration for PEP should be 10-20cm H2O (ideally 12-15) measured by PEP manometer (in circuit) for mid-part of expiration.

----
## Physio Routine for children

![Physio Routine](Routine.jpg)

- Treatments usually consistent of a series of ‘cycles’ – One cycle might typically include say 8-10 breaths through device (PEP & Acapella & Flutter ) as described above, followed by fewer but more forceful huffs (often not through the device- although some will huff through their PEP) and coughing as needed. The cycles are repeated until the chest feels clear. 

- Typical sessions should last no longer than 20 minutes.

- There needs to be a threshold for effort for an active blow (so that it doesn’t just respond to normal passive expiration) 

- It is important that we don’t incentivise more effort but do motivate for a longer blow, eg. acceleration could increase the longer the blow but definitely not accelerate with increased effort beyond the threshold trigger point.

----
## Useful videos on Patient physio and technique

- [Which is the best Airway Clearance method for Cystic Fibrosis?](https://www.youtube.com/watch?v=Wn5o5AgD9m0)
- [Cystic fibrosis breathing techniques – acapella device](https://www.youtube.com/watch?v=DJFp6A_p2R8)
- [Cystic fibrosis breathing techniques – positive expiratory pressure (PEP) mask](https://www.youtube.com/watch?v=C1SLdjvNg9U)

----

