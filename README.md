# lab-test-sample-2017-18
sample lab test 2017-18

1.
fork this repo, and then clone from your fork to the local machine

2.
Create some post-constructor unit tests

    - units is 0
    - capacity is 100
    - maxDelivery is 20
    - nearlyFullLoadPercdentage is .75
    - isNearlyFull() method returns false

3.
Create some post-action unit tests

    - test that after 1 delivery of 10, the delivery method returns false and the number of units is 10
    - test that after 1 deliveries of 25, the delivery method returns false and number of units is still 0
    - test that after 4 deliveries of 20, the isNearlyFull() method returns true and number of units is 80

4.
You have been given a Scene in the Unity project

    Add View-Controller-Manager scripts to allow the scene to change the model
    (i.e. when user types in a number and clicks the button, the delivery is attempted,
    and the status on screen updated to refect any changes to the model values)

    Note - as long as you separate View from Model from Controller (so at least 3 scripts in your system),
    feel free to implement how you wish
    (i.e.  you don't have to follow the sample MVC-mediating controller achitecture

    BUT - you must NOT make any changes to the provided Model class ....

4.
commit your changes to your repo
and make a pull request to my original repo