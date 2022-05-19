numeros = c('2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A')
simbolos = c('Rombo', 'Corazon', 'Espada', 'Trebol')
simbolos_ampliado = c(rep(simbolos[1], 13), rep(simbolos[2], 13), rep(simbolos[3], 13), rep(simbolos[4], 13))
numeros_ampliado = rep(numeros, 4)
mi_df <- data.frame("NUMERO" = numeros_ampliado, "SIMBOLO" = simbolos_apliado)
mi_df