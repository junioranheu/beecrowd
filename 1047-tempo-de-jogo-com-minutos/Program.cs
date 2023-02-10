// https://www.beecrowd.com.br/judge/pt/problems/view/1047
string[] tempos = Console.ReadLine().Split(' ');

int horaInicio = int.Parse(tempos[0]);
int minutoInicio = int.Parse(tempos[1]);
int horaFim = int.Parse(tempos[2]);
int minutoFim = int.Parse(tempos[3]);

int minutoResultado = DefinirMinutos(minutoInicio, minutoFim);

if ((horaInicio == horaFim) && (minutoInicio == minutoFim))
{
    Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
}
else
{
    int diferencaHoras = 0;

    if (horaInicio == horaFim)
    {
        diferencaHoras = 23;
    }
    else if (horaInicio > horaFim)
    {
        diferencaHoras = DefinirHorasSeHoraInicioMaiorHoraFim(horaInicio, horaFim);
    }
    else if (horaInicio < horaFim)
    {
        diferencaHoras = DefinirHorasSeHoraInicioMenorHoraFim(horaInicio, horaFim);
    }

    diferencaHoras = CorrirHorasSeMinutoInicioMenorQueMinutoFim(diferencaHoras, minutoInicio, minutoFim);

    Console.WriteLine($"O JOGO DUROU {diferencaHoras} HORA(S) E {minutoResultado} MINUTO(S)");
}

static int DefinirMinutos(int minutoInicio, int minutoFim)
{
    int diferenca = minutoInicio - minutoFim;
    int minutoResultado = 0;

    if (diferenca == 0)
    {
        minutoResultado = 0;
    }
    else if (diferenca < 0)
    {
        minutoResultado = diferenca * -1;
    }
    else
    {
        minutoResultado = 60 - diferenca;
    }

    return minutoResultado;
}

static int DefinirHorasSeHoraInicioMaiorHoraFim(int horaInicio, int horaFim)
{
    int ateMeiaNoite = 24 - horaInicio;
    return ateMeiaNoite + horaFim;
}

static int DefinirHorasSeHoraInicioMenorHoraFim(int horaInicio, int horaFim)
{
    return (horaInicio - horaFim) * -1;
}

static int CorrirHorasSeMinutoInicioMenorQueMinutoFim(int diferencaHoras, int minutoInicio, int minutoFim)
{
    if (minutoInicio != minutoFim)
    {
        return diferencaHoras <= 1 ? 0 : diferencaHoras;
    }

    return diferencaHoras;
}