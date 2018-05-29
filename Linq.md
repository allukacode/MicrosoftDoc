

Language Integrated Query (LINQ) ofrece una nueva forma de interactuar con datos de todo tipo. De hecho, esto
la nueva función le proporciona herramientas que facilitan la creación de consultas
usando menos código. Las consultas resultantes son a menudo más fáciles de entender que
otras técnicas para obtener información de base de dato.

LINQ permite realizar consultas a cualquier objeto que soporte la interface, IEnumerable o IEnumerable<T>; lo que serían todas las colecciones de datos, incluídos los DataSet, List<T>, Array y muchos más.

Hay dos formas básicas de escribir una consulta LINQ en la colección IEnumerable o fuentes de datos IQueryable.
*Query Syntax or Query Expression Syntax
*Method Syntax or Method extension syntax or Fluent

La sintaxis de consulta es similar a SQL (lenguaje de consulta estructurado) para la base de datos. Se define dentro del código C # o VB.

from <range variable> in <IEnumerable<T> or IQueryable<T> Collection>

<Standard Query Operators> <lambda expression>

<select or groupBy operator> <result formation>

La sintaxis de la consulta LINQ comienza con la palabra clave y finaliza con la palabra clave seleccionada. La siguiente es una consulta de muestra LINQ que devuelve una colección de cadenas que contiene una palabra "Tutoriales".