% X es padre de Y
padre(roberto, andres).
padre(jaime, felipe).
padre(juan,roberto).
padre(juan,jaime).
% X es hermano de Y
hermano(roberto,jaime).
% X es abuelo de Y
abuelo(X,Y):-padre(X,Z),padre(Z,Y).
% X es nieto de Y
nieto(X,Y):-padre(Y,Z),padre(Z,X).
% X es primo de Y
primo(X,Y):-(hermano(M,L);hermano(L,M)),padre(M,X),padre(L,Y).
