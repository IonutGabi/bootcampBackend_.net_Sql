# Explicación del modelado

Empezando este apartado fui creado las tablas que necesitaba para este caso, que son: **Courses, Authors, Lessons, Categories and SubCategories**.

Luego he creado todos los campos necesarios en cada una de las tablas.

El siguiente paso fue crear las relaciones, para la primera relación que es la de **Courses** con **Authors** hice una tabla intermedia llamada **CoursesAuthors** ya que es una relación de M:N

La siguiente relación que hice fue la de la tabla **Categories** con la tabla **SubCategories** que es una relación de 1:M, por lo que metí en la tabla **Categories** un campo llamado **IdSubCategory** para relacionarlo con la tabla correspondiente.

La cuarta relación, es con la tabla **Courses** y la tabla **Lessons** es de 1:M por lo que seguí el mismo procedimiento que en el anterior caso.

La penúltima relación, tabla **Authors** y **Lessons** es de 1:M, el mismo procedimiento que antes.

Y por último, la última relación es igual que las anteriores, Es la tabla **SubCategories** y la tabla **Lessons**, es de 1:M y seguí los mismos pasos como en los anteriores.
