using system;
using console;

int[] numerosOrganizados = new int[];
int numeroReceber = 3;
int numeroAux = 0;
int contador = 1;

for (int x = 0; x < numeroReceber; x++)
{
    Console.WriteLine($"Digite {x} nuemros: \n");
    numerosOrganizados[x] = Console.ReadLine();

}

for (int x = 0; x < numeroReceber; x++)
{


    foreach (int numeroComparar in numerosOrganizados)
    {
        do
        {
            if (numeroComparar < numeroReceber)
            {
                numeroAux = numerosOrganizados[contador];
                numerosOrganizados[contador] = numeroComparar;
                numerosOrganizados[contador -1] = numeroAux;
            }

            contador ++;
        } while (contador == numerosOrganizados.count);

    }

}
