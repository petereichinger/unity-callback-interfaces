# unity-callback-interfaces
A collection of interfaces for use in the Unity 3D engine.


What is this?
=============

Interfaces for the various callbacks the Unity Engine makes to `MonoBehaviour` classes.
The interfaces are called like the callbacks.

What is this good for?
======================

A typo in a callback leads to the function not being called from Unity. An interface prevents that.
Also if a signature should change when an Update occurs the change in the interface might prevent problems.

Different Versions
==================

The support for different versions are handled with different branches in the repository.
Currently there are:

- v56 for Unity 5.6.x
- v2017.2 for Unity 2017.2

Usage
=====

The interfaces are in the file `Assets/Scripts/CallbackInterfaces.cs`.
They are in a separate namespace to prevent collisions and clutter in auto complete.
