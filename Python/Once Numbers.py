#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Fri Jan 24 19:37:20 2020

@author: omid
"""
counter = 0

number = int(input("Enter number: "))
for i in range(1, number + 1, 1):
    counter = 0
    for j in range(1, i, 1): 
        if ((i % j) == 0):
            counter += 1;
         
    if (counter == 1):
        result = i
        print(str(result));
