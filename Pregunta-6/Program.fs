// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.

open System

let suma a b = a + b
let resta a b = a - b
let multiplicacion a b = a * b
let division a b = a / b

[<EntryPoint>]
let main argumentos = 
    printf ("Ingrese numero 1: ")
    let num1 = Convert.ToInt32(Console.ReadLine())
    printf ("Ingrese numero 2: ")
    let num2 = Convert.ToInt32(Console.ReadLine())
    Console.WriteLine(
        "SELECCIONE UNA OPERACION\n1.- Suma\n2.- Resta\n3.- Multiplicacion\n4.- Division"
    )
    let ope = Convert.ToInt32(Console.ReadLine());
    if (ope = 1) then
        printf "El resultado de la suma es: %A" (suma num1 num2)
    elif (ope = 2) then
        printf "El resultado de la resta es: %A" (resta num1 num2)
    elif (ope = 3) then 
        printf "El resultado de la multiplicacion es: %A" (multiplicacion num1 num2)
    elif (ope = 4) then 
        if (num2 = 0) then 
            printfn "Division entre 0 incorrecto!!!!!!!!!!"
        else 
            printf "El resultaado de la division es %A" (division num1 num2)
    let tecla = Console.ReadKey()
    0 // devolver un código de salida entero
