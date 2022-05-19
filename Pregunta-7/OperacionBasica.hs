suma :: Int -> Int -> Int
suma a b = a + b
resta :: Int -> Int -> Int
resta a b = a - b
multiplicacion :: Int -> Int -> Int
multiplicacion a b = a * b
division :: Int -> Int -> Int
division a b = div a b

main = do
  putStrLn "Ingrese numero 1: "
  x <- getLine
  putStrLn "Ingrese numero 2: "
  y <- getLine
  putStrLn "=== ELIJA UNA DE LAS OPERACIONES ==="
  putStrLn "1.- Suma"
  putStrLn "2.- Resta"
  putStrLn "3.- Multiplicacion"
  putStrLn "4.- Division"
  ope <- getLine
  case ope of "1" -> putStrLn ("La suma es: " ++ show (suma (read x) (read y)))
              "2" -> putStrLn ("La resta es: " ++ show (resta (read x) (read y)))
              "3" -> putStrLn ("La multiplicacion es: " ++ show (multiplicacion (read x) (read y)))
              "4" -> if y == "0"
                        then putStrLn "No se puede dividir entre 0!!!!"
                        else putStrLn ("La division es: " ++ show (division (read x) (read y)))





  