fn main() {}

#[allow(dead_code)]
fn somador(vetor: &mut [i32]) -> i32 {
    let mut soma_vetor = 0;

    for elemento in vetor {
        soma_vetor += *elemento
    }

    soma_vetor
}

#[cfg(test)]
mod tests {
    // Note this useful idiom: importing names from outer (for mod tests) scope.
    use super::*;

    #[test]
    fn test_somar_vetor() {
        // Arrange
        let esperado = 9;
        let mut vetor_para_somar: [i32; 3] = [2, 3, 4];

        // Act
        let soma_vetor = somador(&mut vetor_para_somar);

        // Assert
        assert_eq!(esperado, soma_vetor);
    }
}
