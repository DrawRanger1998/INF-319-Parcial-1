# -*- coding: utf-8 -*-
"""
Created on Fri May 13 23:29:50 2022

@author: Orlando
"""


from pyswip import Prolog

prolog = Prolog()
prolog.consult("RelacionesProlog.pl")

"""
% X es padre de Y
padre(roberto, andres).
padre(jaime, felipe).
padre(juan,roberto).
padre(juan,jaime).
% X es hermano de Y
hermano(roberto,jaime).

%Relacion ABUELO
% X es abuelo de Y
abuelo(X,Y):-padre(X,Z),padre(Z,Y).

Relacion NIETO
% X es nieto de Y
nieto(X,Y):-padre(Y,Z),padre(Z,X).

%RELACION PRIMO
% X es primo de Y
primo(X,Y):-(hermano(M,L);hermano(L,M)),padre(M,X),padre(L,Y).


"""

for elemento in prolog.query("abuelo(X,Y)"):
    print(elemento["X"],"es abuelo de",elemento["Y"])
for elemento in prolog.query("nieto(X,Y)"):
    print(elemento["X"],"es nieto de",elemento["Y"])
for elemento in prolog.query("primo(X,Y)"):
    print(elemento["X"],"es primo de", elemento["Y"])    
