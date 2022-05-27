//? Programación orientado a procedimientos es antigua
//?desventajas de POC:
//Unidades de código muy grandes en apliaciones complejas.
//En aplicaciones complejas elcódigo resultaba difícil de descrifrar
//Poco reutilizable, si hacias programas similares, no podías reulizar aquello  que era igual para hacerla
//si hay un fallo en alguna línea de código, es muy probable que el programa caiga
//Aparición frecuente de cógido espagueti
//Difícil de depurar por otros programadores en caso de necesidad o error.

//? Programación orientada a objetos surgió por la necesidad de solventar los problemas que generaba la programación orientada a procedimieintos
//Consiste: Traslada la naturaleza de los objetos de la vida real al código de programación
//La naturaleza de un objeto en la vida real: Los objetos tienen un etado, un comportamiento y propiedades

//? Ejemplo el coche
//        ESTADO: Un coche puede estar parado, circulando, aparcado, etc
//  PROPIEDAEDES: Un coche tiene color, peso, tamaño, etc
//COMPORTAMIENTO: Un coche peude arrancar, frenar, acelerar, girar

//?ventajas de POO:
//Programas divididos en "trozos", "partes", "módulos" o "clases"
//Muy reutilizable. Herencia
//Si existe un fallo en alguna línea de código, el programa continuará con su funcionamiento. Tratamiento de Excepciones
//Encapsulamiento

//! MODIFICADORES DE ACCESO:
//?Public
  //Accesible desde cualquier parte
//?Private
  //Accesible desde la propia clase
//?Protected
  //Accesible desde clase derivada
//?Internal
  //Accesible desde el mismo ensamblado
//?Protected internal
  //Accesible desde el mismo ensamblado o clase derivada de otro ensamblado
//?Private protected
  //Accesible desde la misma clase o clase derivada del mismo ensamblado
//?Por defecto
  //Accesible desde el mismo paquete

//!Clase : Coches, diferentes marcas misma función
  //Modelo donde se redactan las características comunes deun grupo de objetos
  
//!Objeto : Coches, tienen colores, tamaños diferentes. Puede arrancas, frenar.
  //El objeto tiene propiedaes(atributos, características) color, peso, alto, largo y un comportamineto(¿Qué es capaz de hacer?) arrancar, frenar, girar, acelerar.

//!NOMENCLATURA DEL PUNTO
  //? Accediendo a propiedades de objeto desde código (pseudocódigo):
    //Reanult.color = "rojo";
    //Renault.peso = 1500;
    //renault.ancho = 2000;
    //renault.alto = 900;
  //? Accediendo a comportamiento de objeto desde código (pseudocódigo):
    //Renault.arranca();
    //Renault.frena();
    //Renault.gira();
    //Renault.acelera();