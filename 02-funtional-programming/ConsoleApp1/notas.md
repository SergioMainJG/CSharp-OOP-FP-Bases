# Programaci�n Funcional

## Programaci�n Imperativa vs Programaci�n Declarativa

La __programci�n imperativa__ se basa en la filosofia: "Como hacer algo �C�mo hacer algo?". Basicamente como se ha hecho en todo el libro

La __programaci�n declarativa__ se basa en la filosofia: "Que hacer �Qu� hago?"


## Funciones de primera clase

Es una funci�n que puede guardarse como una variable para poder guardarla y manipularla a su conveniencia, incluso podiendola pasar a otras funciones

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

Son funciones que reciben funciones de primera clase como parametro, pero tambi�n son funciones que pueden retornar otra funci�n

## Funciones puras


La funci�n pura es una regla importante en la FP, lo cu�l es:

- Una funci�n que siempre produce los mismos resultados dados siempre los mismos datos de entrada.
- No tiene efectos o cambios con elementos externos a ella.

Al reemplazar funciones por otras sabiendo que no va alterar lugares inadecuados del software se le conoce como __Transparencia referencial__.

## Funciones anonimas/ Expresiones lambda

Funci�n que no cuenta con un nombre y puede ser guardada como variable, arrow Function y callbacks en JS/TS.

## Recursividad

Es un patr�n en el cu�l se cumple lo siguiente:
1. Una funci�n se llama as� msima
2. Se debe cumplir cierta condici�n para que se llame as� misma.

## Closures ( Clausuras )

Una clausura es cuando una funci�n tiene variables para mantenter sus variables, siendo que tambi�n pueden retornar una funci�n como resultado.
Es �til porque se puede compartir informaci�n sin depender de variables externas a la funci�n.

## Currificaci�n

Es la declaraci�n de una funci�n que no recibe nada, pero retorna 1 funci�n que retorna otra funci�n con las siguientes parametros:
1. El primer retorno regresa una funci�n con un valor inicial que se plantea conservar en la �ltima funci�n
2. La segunda funci�n es la variante que ya tiene un valor inicial pero recibe diferentes valores de cierto tipo para regesar diferentes cosas