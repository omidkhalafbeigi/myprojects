#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Fri Jan 24 23:23:34 2020

@author: omid
"""
list1 = []
list2 = []
element = input("Enter element for list1: ")
while (element != "exit"):
    list1.append(element)
    element = input("Enter element for list1: ")

element = input("Enter element for list2: ")
while (element != "exit"):
    list2.append(element)
    element = input("Enter element for list2: ")

print("List1: ", list1)
print("List2: ", list2)

for i in list1:
    if (i in list2):
        print(i)
    else: continue