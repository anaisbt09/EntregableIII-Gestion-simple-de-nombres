# Entregable III - Gestión Simple de Nombres

## Funcionalidades

* Agregar un nombre de Team Member
* Eliminar un nombre
* Buscar un nombre
* Mostrar todos los nombres ordenados alfabéticamente
* Permitir al usuario salir de la aplicación.

---

## Uso de List<T>

Para almacenar los nombres de los Team Members se utilizó una lista de tipo `List<string>`.

Se utilizaron los siguientes métodos y propiedades:

* `Add()` para agregar nombres.
* `Remove()` para eliminar nombres.
* `Contains()` para buscar nombres.
* `Sort()` para ordenar los nombres alfabéticamente.
* `Count` para verificar la cantidad de elementos registrados.

---

## Ordenamiento alfabético

Para mostrar los nombres en orden alfabético se utilizó el método `Sort()` de `List<T>`.

Los nombres se copian previamente en una nueva lista para realizar el ordenamiento sin modificar la lista original.

---

## Validaciones

* No permite agregar nombres vacíos.
* Valida que existan Team Members antes de realizar operaciones sobre la lista.
* Verifica si el nombre que se desea eliminar existe en la lista.
* Verifica si el nombre que se desea buscar existe en la lista.
* Permite volver a ingresar los datos cuando existe un error.

---

## Autor

**Anais Milagros Bustamante Torres**
