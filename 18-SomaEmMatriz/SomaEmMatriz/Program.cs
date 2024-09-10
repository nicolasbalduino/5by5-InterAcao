int[,] mat = {  { 3, 2, 1, 5, 6 }, 
                { 4, 5, 6, 8, 10 }, 
                { 9, 8, 10, 8, 6 }, 
                { 4, 5, 3, 5, 3 }, 
                { 9, 8, 6, 2, 1 } };


string SomaValoresLinhas(int[,] mat)
{
    int somaDaLinha = 0;
    string somaDasLinhas = "";

    for (int linha = 0; linha < mat.GetLength(0); linha++)
    {
        somaDaLinha = 0;

        for (int coluna = 0; coluna < (mat.GetLength(1)); coluna++)
            somaDaLinha += mat[linha, coluna];

        somaDasLinhas += "[" + somaDaLinha.ToString() + "] ";
    }

    return somaDasLinhas;
}

string SomaValoresColunas(int[,] mat)
{
    int somaDaColuna = 0;
    string somaDasColunas = "";

    for (int coluna = 0; coluna < mat.GetLength(0); coluna++)
    {
        somaDaColuna = 0;

        for (int linha = 0; linha < (mat.GetLength(1)); linha++)
            somaDaColuna += mat[linha, coluna];

        somaDasColunas += "[" + somaDaColuna.ToString() + "] ";
    }

    return somaDasColunas;
}

string SomaValoresDiagonalPrincipal(int[,] mat)
{
    int somaDaDiagonal = 0;

    for (int diagonal = 0; diagonal < mat.GetLength(0); diagonal++)
        somaDaDiagonal += mat[diagonal, diagonal];

    return somaDaDiagonal.ToString();
}

string SomaValoresDiagonalSecundaria(int[,] mat)
{
    int somaDaDiagonal = 0;

    for (int diagonal = 0; diagonal < mat.GetLength(0); diagonal++)
        somaDaDiagonal += mat[diagonal, ((mat.GetLength(0) - 1)- diagonal)];

    return somaDaDiagonal.ToString();
}



Console.WriteLine("Soma Linhas = " + SomaValoresLinhas(mat));
Console.WriteLine("\nSoma colunas = " + SomaValoresColunas(mat));
Console.WriteLine("\nSoma da diagonal principal = " + SomaValoresDiagonalPrincipal(mat));
Console.WriteLine("\nSoma da diagonal secundaria = " + SomaValoresDiagonalSecundaria(mat));