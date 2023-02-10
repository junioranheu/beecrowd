// https://www.beecrowd.com.br/judge/pt/problems/view/1047
string[] tempos = Console.ReadLine().Split(' ');

int horaInicio = int.Parse(tempos[0]);
int minutoInicio = int.Parse(tempos[1]);
int horaFim = int.Parse(tempos[2]);
int minutoFim = int.Parse(tempos[3]);

if ((horaInicio == horaFim) && (minutoInicio == minutoFim))
{
    Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
}
else
{
    int diferencaHoras = 0;

    if (horaInicio == horaFim)
    {
        diferencaHoras = DefinirHorasSeHoraInicioIgualHoraFim(horaInicio, horaFim, minutoInicio, minutoFim);
    }
    else if (horaInicio > horaFim)
    {
        diferencaHoras = DefinirHorasSeHoraInicioMaiorHoraFim(horaInicio, horaFim, minutoInicio, minutoFim);
    }
    else if (horaInicio < horaFim)
    {
        diferencaHoras = DefinirHorasSeHoraInicioMenorHoraFim(horaInicio, horaFim, minutoInicio, minutoFim);
    }

    diferencaHoras = CorrirHorasSeMinutoInicioMenorQueMinutoFim(diferencaHoras, minutoInicio, minutoFim);

    Console.WriteLine($"O JOGO DUROU {diferencaHoras} HORA(S) E {DefinirMinutos(minutoInicio, minutoFim)} MINUTO(S)");
}

static int DefinirHorasSeHoraInicioIgualHoraFim(int horaInicio, int horaFim, int minutoInicio, int minutoFim)
{
    if ((horaInicio >= horaFim) && (minutoInicio >= minutoFim))
    {
        return 23;
    }

    return 0;
}

static int DefinirHorasSeHoraInicioMaiorHoraFim(int horaInicio, int horaFim, int minutoInicio, int minutoFim)
{
    int ateMeiaNoite = 24 - horaInicio;
    int resultadoFinal = ateMeiaNoite + horaFim;

    if (minutoInicio != minutoFim)
    {
        resultadoFinal += -1;
    }

    return resultadoFinal;
}

static int DefinirHorasSeHoraInicioMenorHoraFim(int horaInicio, int horaFim, int minutoInicio, int minutoFim)
{
    int resultadoFinal = (horaInicio - horaFim) * -1;

    if (minutoInicio > minutoFim)
    {
        return resultadoFinal - 1;
    }

    return resultadoFinal;
}

static int CorrirHorasSeMinutoInicioMenorQueMinutoFim(int diferencaHoras, int minutoInicio, int minutoFim)
{
    if (minutoInicio < minutoFim)
    {
        return diferencaHoras <= 1 ? 0 : diferencaHoras;
    }

    return diferencaHoras;
}

static int DefinirMinutos(int minutoInicio, int minutoFim)
{
    int diferenca = minutoInicio - minutoFim;

    if (diferenca == 0)
    {
        return 0;
    }
    else if (diferenca < 0)
    {
        if (minutoInicio >= minutoFim)
        {
            return 60 - (diferenca * -1);

        }
        else
        {
            return diferenca * -1;
        }
    }
    else
    {
        return 60 - diferenca;
    }
}