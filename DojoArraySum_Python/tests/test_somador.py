from somador import Somador

import unittest


class SomadorTests(unittest.TestCase):

    def test_soma_elementos_returns_soma_elementos(self):
        # Arrange
        esperado = 9
        vetorParaSomar = [2, 3, 4]
        somador = Somador()

        # Act
        result = somador.somar_vetor(vetorParaSomar)

        # Assert
        self.assertEqual(esperado, result)

if __name__ == '__main__':
    unittest.main()
