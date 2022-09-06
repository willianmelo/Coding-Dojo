class Somador(object):

    def somar_vetor(self, vetor):
        soma_vetor = 0

        for elemento in vetor:
            soma_vetor += elemento

        return soma_vetor
