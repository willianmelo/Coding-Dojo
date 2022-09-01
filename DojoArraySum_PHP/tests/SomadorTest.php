<?php

namespace App;

use PHPUnit\Framework\TestCase;
use App\Somador;

class SomadorTest extends TestCase
{
    public function testSomadorRetornaValorElementosSomados(): void
    {
        // Arrange
        $somador = new Somador();
        $esperado = 9;
        $vetorParaSomar = [2, 3, 4];

        // Act
        $result = $somador->somar($vetorParaSomar);

        // Assert
        $this->assertEquals($esperado, $result);
    }
}
