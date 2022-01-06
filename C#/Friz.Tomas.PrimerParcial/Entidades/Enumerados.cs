
namespace Entidades
{
    /// <summary>
    /// Enumera los tipos de Software.
    /// </summary>
    public enum Software
    {
        office,
        messenger,
        icq,
        ares
    }
    /// <summary>
    /// Enumera los tipos de Hardware.
    /// </summary>
    public enum Hardware
    {
        RAM, 
        procesador, 
        placaVideo
    }
    /// <summary>
    /// Enumera los tipos de perifericos.
    /// </summary>
    public enum Periferico
    {
        cámara,
        auriculares,
        micrófono
    }
    /// <summary>
    /// Enumera los tipos de juegos.
    /// </summary>
    public enum Juego
    {
        CounterStrike,
        DiabloII,
        MuOnline,
        LineageII,
        WarcraftIII,
        AgeOfEmpiresII
    }
    /// <summary>
    /// Enumera los tipos de diferentes teclados de telefonos.
    /// </summary>
    public enum TipoTecla
    {
        Disco,
        Teclado
    }
    /// <summary>
    /// Enumera los tipos de Marcas.
    /// </summary>
    public enum Marcas
    {
        Panasonic,
        Siemens,
        Elgin,
        Telefonica
    }
    /// <summary>
    /// Enumera los tipos de equipos
    /// </summary>
    public enum TipoEquipo
    {
        Cabina,
        Computadora
    }
    /// <summary>
    /// Enumera los distintos tipos de estados.
    /// </summary>
    public enum Estado
    {
        Disponible,
        En_Uso
    }
    /// <summary>
    /// Enumera los tipos de localidad, integrado con el numero para hacer el calculo del costo.
    /// </summary>
    public enum TipoLocalidad
    {
        Local = 100, 
        LargaDistancia = 250, 
        Internacional = 500
    }
    /// <summary>
    /// Enumera los distintos tipos de duraciones de computadora.
    /// </summary>
    public enum TipoCompu
    {
        Libre, 
        Limitado
    }
}
