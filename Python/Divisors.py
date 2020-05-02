#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Fri Jan 24 23:20:15 2020

@author: omid
"""

number = int(input("Enter number: "))
for i in range(1, number + 1, 1):
    if ((number % i) == 0):
        print(str(i))