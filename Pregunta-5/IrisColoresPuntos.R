#Selccionamos una columna de la tabla iris
#bg le damos un color a los puntos
#col le damos color a lobs bordes
#iri[1:4] escogemos las 4 columnas
plot(iris[1:4], pch=1, col=c("red","green3","blue")[unclass(iris$Species)])