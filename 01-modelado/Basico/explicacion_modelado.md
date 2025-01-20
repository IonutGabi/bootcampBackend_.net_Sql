# Explicación del modelado

Primero empecé creado la tabla Cursos con los campos id (clave primaria), **Titulo** y **Descripcion**.

Luego la segunda tabla que he creado ha sido Autores con los campos **Nombre** y **Descripcion**

La penúltima tabla que he creado ha sido Lecciones, le he puesto lecciones, (porque así engloba tanto los articulos como los vídeos y es mucho más entendible). Con los campos **ID**, **Titulo** **UrlVideo** **UrlArticulo**.

Y por útlimo, he creado la tabla Categorias que contiene los campos **ID** y **Nombre**.

El siguiente paso, ha sido crear las relaciones. La primera relación que he creado ha sido entre **Cursos** y **Autores**, como es una relación de muchos a muchos, he tenido que crear la tabla intermedia **CursosAutores** que contiene los campos IdCurso y IdAutor y asi los pueda relacionar.

La segunda relación, ha sido la de **Cursos** con **Lecciones**, está relación es de uno a muchos porque un curso puede tener muchas lecciones (pero para está parte del laboratorio una lección solamente pertenece a un solo curso), he añadido en la tabla **Lecciones** el campo **IdCurso** para poder relacionarlo. Como bien dice el enunciado de que no se van a compartir lecciones entre cursos.

Otra relación, es la de **Autores** con **Lecciones** que es de uno a muchos (Porque en el enunciado se ha restringido a un solo autor), ya que un autor puede dar varias lecciones pero una lección solo es de un autor, he tenido que añadir en la tabla Lecciones el campo **IdAutor** para poder relacionarlo

Y la última relación que ha sido creada, fue la de **Categorias** con **Lecciones**, también es de uno a muchos (ya que como bien dice el enunciado, una lección solo pertenece a una categoria. Mientras que una categoria puede tener muchas lecciones), y como en ha pasado anteriormete he creado el campo **IdCategorias** en la tabla **Lecciones** para poder relacionarlo
