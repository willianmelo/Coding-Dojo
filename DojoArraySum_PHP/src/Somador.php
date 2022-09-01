<?php

namespace App;

class Somador
{
    public function somar(array $vetor = []): int
    {
        $soma = 0;

        foreach ($vetor as $elemento) {
            $soma += $elemento;
        }

        return $soma;
    }
}
