# Explicación del modelado

Primero empecé creado la tabla **Courses** con los campos **ID** (clave primaria), **Title** y **Description**.

Luego la segunda tabla que he creado ha sido **Authors** con los campos **Name** y **Description**

La penúltima tabla que he creado ha sido Lessons, le he puesto lessons, (porque así engloba tanto los articulos como los vídeos y es mucho más entendible). Con los campos **ID, Title UrlVideo UrlArticle**.

Y por útlimo, he creado la tabla **Categories** que contiene los campos **ID** y **Name**.

El siguiente paso, ha sido crear las relaciones. La primera relación que he creado ha sido entre **Courses** y **Authors**, como es una relación de M:N, he tenido que crear la tabla intermedia **CoursesAuthors** que contiene los campos **IdCourse** y **IdAuthor** y asi los pueda relacionar.

La segunda relación, ha sido la de **Courses** con **Lessons**, está relación es de 1:M porque un curso puede tener muchas lecciones (pero para está parte del laboratorio una lección solamente pertenece a un solo curso), he añadido en la tabla **Lessons** el campo **IdCourse** para poder relacionarlo. Como bien dice el enunciado de que no se van a compartir lecciones entre cursos.

Otra relación, es la de **Authors** con **Lessons** que es de 1:M (Porque en el enunciado se ha restringido a un solo autor), ya que un autor puede dar varias lecciones pero una lección solo es de un autor, he tenido que añadir en la tabla Lecciones el campo **IdAuthor** para poder relacionarlo

Y la última relación que ha sido creada, fue la de **Categories** con **Lessons**, también es de 1:M (ya que como bien dice el enunciado, una lección solo pertenece a una categoria. Mientras que una categoria puede tener muchas lecciones), y como en ha pasado anteriormete he creado el campo **IdCategories** en la tabla **Lessons** para poder relacionarlo.
