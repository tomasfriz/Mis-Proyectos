<?php

$productos = (new Productos())->obtener_productos();
$categorias = (new Categorias)->obtener_categorias();

$buscador = isset($_POST['buscador']) ? $_POST['buscador'] : false;
$categoria = isset($_GET['categoria']) ? $_GET['categoria'] : false;
$categoria_id = isset($_GET['id']) ? $_GET['id'] : false;
$marca_id = isset($_GET['marca_id']) ? $_GET['marca_id'] : false;
$orden_precio = isset($_GET['orden_precio']) ? $_GET['orden_precio'] : false;
$orden_alfabetico = isset($_GET['orden_alfabetico']) ? $_GET['orden_alfabetico'] : false;

$marcas = (new Marcas)->marca_x_categorias($categoria_id);

// echo "<pre>";
// print_r($marcas);
// echo "</pre>";

if ($marca_id && $categoria_id) {
    $productos = (new Productos)->filtrar($marca_id, $categoria_id);
} elseif ($buscador) {
    $productos = (new Productos)->buscador($buscador);
} elseif ($orden_precio && $categoria_id) {
    echo "hola";
    $productos = (new Productos)->orden($orden_precio, "precio", $categoria_id, $_GET["seccion"]);
} elseif ($orden_alfabetico && $categoria_id) {
    $productos = (new Productos)->orden($orden_alfabetico, "nombre", $categoria_id, $_GET["seccion"]);
} elseif ($orden_precio) {
    $productos = (new Productos)->orden($orden_precio, "precio", $categoria_id, $_GET["seccion"]);
} elseif ($orden_alfabetico) {
    $productos = (new Productos)->orden($orden_alfabetico, "nombre", $categoria_id, $_GET["seccion"]);
} elseif ($categoria) {
    $productos = (new Productos)->filtrar_categoria($categoria_id);
}


?>

<h1 class="text-center col-12 mt-5 mb-5">Productos</h1>
<div class="d-flex justify-content-around">
    <div id="productos" class="d-flex flex-wrap justify-content-center align-items-baseline">
        <p class="container-fluid me-5 ms-5 fs-4 col-10"> <?= $categoria == false ?  "Todos los productos" : $categoria ?></p>
        <?PHP if (count($productos)) { ?>
            <?php foreach ($productos as $producto) {
            ?>

                <div class="d-flex flex-column align-items-center justify-conten-evenly col-xxl-4 col-md-6  col-sm-8">
                    <img src="recursos/imagenes/<?= $producto->getimagen_small(); ?>" alt="<?= $producto->getNombre() ?>">
                    <div class="d-flex flex-column align-items-center justify-conten-end w-100">
                        <h2><?= $producto->recortar_texto(4, $producto->getNombre()); ?></h2>
                        <p><?= $producto->getCategoria(); ?></p>
                        <p><?= $producto->recortar_texto(2, $producto->getDescripcion()); ?></p>
                        <p class="text-start fs-5">$<?= $producto->formatear_precio($producto->getPrecio()) ?></p>
                        <a class="text-center mt-2" href="index.php?seccion=producto&id=<?= $producto->getId() ?>">Ver más</a>
                    </div>
                </div>
            <?php }; ?>
        <?php } else { ?>
            <div id="no_encontrado" class="col-12">
                <h2 class="text-center">No se encontraron productos.</h2>
            </div>
        <?php }; ?>
    </div>
    <div class="filtros col-3">
        <form class="mb-1 mt-5 d-flex flex-column" action="index.php?seccion=todos_productos&" method="post">
            <input class="form-control mb-2" placeholder="Buscador" type="search" name="buscador" id="buscador">
            <button class="btn" type="submit">Buscar</button>
        </form>
        <ul>
            <li>
                <a href=<a href="index.php?seccion=<?= $_GET["seccion"] ?><?= $categoria ? "&categoria=" . $categoria . "&id=" . $categoria_id : "" ?>">Ordenar por</a>
                <ul>
                    <li><a href="index.php?seccion=<?= $_GET["seccion"] ?><?= $categoria ? "&categoria=" . $categoria . "&id=" . $categoria_id : "" ?>&orden_precio=ASC">Menor a mayor</a></li>
                    <li><a href="index.php?seccion=<?= $_GET["seccion"] ?><?= $categoria ? "&categoria=" . $categoria . "&id=" . $categoria_id : "" ?>&orden_precio=DESC">Mayor a menor</a></li>
                    <li><a href="index.php?seccion=<?= $_GET["seccion"] ?><?= $categoria ? "&categoria=" . $categoria . "&id=" . $categoria_id : "" ?>&orden_alfabetico=ASC">A-Z</a></li>
                    <li><a href="index.php?seccion=<?= $_GET["seccion"] ?><?= $categoria ? "&categoria=" . $categoria . "&id=" . $categoria_id : "" ?>&orden_alfabetico=DESC">Z-A</a></li>
                </ul>
            </li>
            <?php if ($marcas != null) {?>
            <li>
                <a href="index.php?seccion=<?= $_GET["seccion"] ?>">Marca</a>
                <ul>
                    <?php foreach ($marcas as  $value) { ?>

                        <li><a href="index.php?seccion=<?= $_GET["seccion"] ?>&categoria=<?= $categoria ?>&id=<?= $categoria_id ?>&marca_id=<?= $value->id_marca ?>"><?= $value->nombre; ?></a></li>
                    <?php }?>
                </ul>
            </li>
            <?php } ?>
            <li>
                <a href="index.php?seccion=todos_productos">Categorias</a>
                <ul>
                    <?php foreach ($categorias as $categoria) { ?>
                        <li><a href=" index.php?seccion=<?= $_GET["seccion"] ?>&categoria=<?= $categoria->getCategoria() ?>&id=<?= $categoria->getId() ?>"><?= $categoria->getCategoria() ?></a></li>
                    <?php }; ?>
                </ul>
            </li>
        </ul>
        <a class="btn btn-danger mb-5 mt-5" href="index.php?seccion=<?= $_GET["seccion"] ?>">Limpiar filtros</a>
    </div>

</div>