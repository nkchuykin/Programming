using System;
using System.IO;

//Используйте паттерн Singletone
//С умом
internal class Logger
{
    static Logger logger = null;
    public StreamWriter sw;
    public Logger()
    {
        throw new NotImplementedException();
    }

    internal static Logger GetLogger()
    {
        throw new NotImplementedException();
    }

    internal void Write(Object task)
    {
        throw new NotImplementedException();

        //Оставьте эту строку
        sw.Flush();
    }
}