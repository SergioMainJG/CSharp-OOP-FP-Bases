# Programación Funcional

## Programación Imperativa vs Programación Declarativa

La __programción imperativa__ se basa en la filosofia: "Como hacer algo ¿Cómo hacer algo?". Basicamente como se ha hecho en todo el libro

La __programación declarativa__ se basa en la filosofia: "Que hacer ¿Qué hago?"


## Funciones de primera clase

Es una función que puede guardarse como una variable para poder guardarla y manipularla a su conveniencia, incluso podiendola pasar a otras funciones

```code
void Hi()
{
    Console.WriteLine("Hola Mundo");
}

var hello = Hi;

hello();
```

Al poder guardar funciones como variables, tenemos mayor flexibilidad a la hora de programa por el hecho de guardar funcionamientos como tal.

## Funciones de orden superior

Son funciones que reciben funciones de primera clase como parametro, pero también son funciones que pueden retornar otra función

## Funciones puras


La función pura es una regla importante en la FP, lo cuál es:

- Una función que siempre produce los mismos resultados dados siempre los mismos datos de entrada.
- No tiene efectos o cambios con elementos externos a ella.

Al reemplazar funciones por otras sabiendo que no va alterar lugares inadecuados del software se le conoce como __Transparencia referencial__.

## Funciones anonimas/ Expresiones lambda

Función que no cuenta con un nombre y puede ser guardada como variable, arrow Function y callbacks en JS/TS.

## Recursividad

Es un patrón en el cuál se cumple lo siguiente:
1. Una función se llama así msima
2. Se debe cumplir cierta condición para que se llame así misma.

## Closures ( Clausuras )

Una clausura es cuando una función tiene variables para mantenter sus variables, siendo que también pueden retornar una función como resultado.
Es útil porque se puede compartir información sin depender de variables externas a la función.

## Currificación

Es la declaración de una función que no recibe nada, pero retorna 1 función que retorna otra función con las siguientes parametros:
1. El primer retorno regresa una función con un valor inicial que se plantea conservar en la última función
2. La segunda función es la variante que ya tiene un valor inicial pero recibe diferentes valores de cierto tipo para regesar diferentes cosas